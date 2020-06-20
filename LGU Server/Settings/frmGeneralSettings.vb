Imports DevExpress.XtraEditors
Imports System.Xml
Imports MySql.Data.MySqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmGeneralSettings
    Public grid As DevExpress.XtraGrid.Views.Grid.GridView
   
    Private Sub frmGeneralSettingsvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadAdvanceSettings()
        LoadSequenceSettings()
        LoadDefaultSettings()
        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdSaveSettings.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdSaveSettings.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub txtFileMB_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileMB.EditValueChanged
        txtFileKB.Text = Val(CC(txtFileMB.Text)) * 1024
    End Sub

    Public Sub LoadAdvanceSettings()
        com.CommandText = "SELECT * FROM information_schema.`COLUMNS` where table_schema='" & sqldatabase & "' and table_name='tblgeneralsettings' and data_type like '%tinyint%' order by column_comment asc ;" : rst = com.ExecuteReader
        While rst.Read
            list_settings.Items.Add(rst("column_name").ToString, False)
            list_settings.Items.Item(rst("column_name").ToString).Description = If(rst("column_comment").ToString = "", rst("column_name").ToString, rst("column_comment").ToString)
            list_settings.Items.Item(rst("column_name").ToString).Value = rst("column_name").ToString
        End While
        rst.Close()

        com.CommandText = "select * from tblgeneralsettings" : rst = com.ExecuteReader
        While rst.Read
            txtWebserverAddress.Text = rst("downloaddefaultlocation").ToString
            txtFileMB.Text = (Val(CC(rst("allowableattachsize").ToString)) / 1024) / 1024
            For I = 0 To list_settings.ItemCount - 1
                list_settings.Items.Item(list_settings.Items.Item(I).Value).CheckState = If(CBool(rst(list_settings.Items.Item(I).Value)) = True, CheckState.Checked, CheckState.Unchecked)
            Next
        End While
        rst.Close()
    End Sub

    Public Sub LoadSequenceSettings()
        com.CommandText = "DROP TEMPORARY TABLE if EXISTS tmpGeneralSequence" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE tmpGeneralSequence (  `ColumnName` VARCHAR(500) NOT NULL,  `Description` VARCHAR(500) NOT NULL,  `ValueData` TEXT)ENGINE = InnoDB;" : com.ExecuteNonQuery()
        Dim Details As String = ""
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblgeneralsettings", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "SELECT * FROM information_schema.`COLUMNS` where table_schema='" & sqldatabase & "' and table_name='tblgeneralsettings' and (column_name like '%sequence%' or column_name like '%referenceno%' or column_name like '%series%' ) order by column_comment asc;" : rst = com.ExecuteReader
                While rst.Read
                    Details += "('" & rst("column_name").ToString & "','" & If(rst("column_comment").ToString = "", rst("column_name").ToString, rst("column_comment").ToString) & "','" & rchar(.Rows(cnt)(rst("column_name").ToString).ToString()) & "'),"
                End While
                rst.Close()
            End With
        Next
        If Details.Length > 0 Then
            Details = Details.Remove(Details.Length - 1, 1)
            com.CommandText = "INSERT INTO tmpGeneralSequence (ColumnName,Description,ValueData) VALUES " & Details : com.ExecuteNonQuery()
        End If

        LoadXgridNoPaint("Select * from tmpGeneralSequence order by description asc", "tmpGeneralSequence", Em, Gridview1, Me)
        XgridHideColumn({"ColumnName"}, Gridview1)
        'XgridColWidth({"Description"}, Gridview1, 250)
        Gridview1.Columns("Description").OptionsColumn.AllowEdit = False
        Gridview1.Columns("Description").OptionsColumn.AllowFocus = False

        Gridview1.Columns("Description").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Gridview1.Columns("Description").ColumnEdit = MemoEdit
        XgridColAlign({"ValueData"}, Gridview1, DevExpress.Utils.HorzAlignment.Center)
        'Gridview1.Columns("ValueData").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        'Gridview1.Columns("ValueData").ColumnEdit = MemoEdit
        Gridview1.BestFitColumns()

        For Each col In Gridview1.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next

    End Sub

    Public Sub LoadDefaultSettings()
        com.CommandText = "DROP TEMPORARY TABLE if EXISTS tmpGeneralDefault" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE tmpGeneralDefault (  `ColumnName` VARCHAR(500) NOT NULL,  `Description` VARCHAR(500) NOT NULL,  `ValueData` TEXT)ENGINE = InnoDB;" : com.ExecuteNonQuery()
        Dim Details As String = ""
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tblgeneralsettings", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                com.CommandText = "SELECT * FROM information_schema.`COLUMNS` where table_schema='" & sqldatabase & "' and table_name='tblgeneralsettings' and (column_name like '%default%' or column_name like '%caption%' or column_name like '%custom%' or column_name like '%title%' or column_name like '%template%') and column_name not like '%sequence%' and column_type not like '%tinyint%' order by column_comment asc;" : rst = com.ExecuteReader
                While rst.Read
                    Details += "('" & rst("column_name").ToString & "','" & If(rst("column_comment").ToString = "", rst("column_name").ToString, rst("column_comment").ToString) & "','" & rchar(.Rows(cnt)(rst("column_name").ToString).ToString()) & "'),"
                End While
                rst.Close()
            End With
        Next
        If Details.Length > 0 Then
            Details = Details.Remove(Details.Length - 1, 1)
            com.CommandText = "INSERT INTO tmpGeneralDefault (ColumnName,Description,ValueData) VALUES " & Details : com.ExecuteNonQuery()
        End If

        LoadXgridNoPaint("Select * from tmpGeneralDefault order by description asc", "tmpGeneralDefault", GridControl1, GridView2, Me)
        XgridHideColumn({"ColumnName"}, GridView2)

        GridView2.Columns("Description").OptionsColumn.AllowEdit = False
        GridView2.Columns("Description").OptionsColumn.AllowFocus = False

        GridView2.Columns("Description").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        GridView2.Columns("Description").ColumnEdit = MemoEdit
        XgridColAlign({"ValueData"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
        GridView2.BestFitColumns()
        'Gridview2.Columns("ValueData").AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        'Gridview2.Columns("ValueData").ColumnEdit = MemoEdit

        For Each col In GridView2.Columns
            col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSaveSettings.ItemClick
        If XtraTabControl1.SelectedTabPage Is tabGeneral Then
            If XtraMessageBox.Show("This action is required an administrative permission! are you wish to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set downloaddefaultlocation='" & rchar(txtWebserverAddress.Text) & "', allowableattachsize='" & Val(txtFileKB.EditValue) * 1024 & "'" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Your settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf XtraTabControl1.SelectedTabPage Is tabAdvance Then
            Dim Details As String = ""
            For n = 0 To list_settings.ItemCount - 1
                Details += list_settings.Items.Item(n).Value.ToString & "=" & If(list_settings.Items.Item(n).CheckState = CheckState.Checked, "1", "0") & ","
            Next
            If XtraMessageBox.Show("This action is required an administrative permission! are you wish to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set " & Details.Remove(Details.Length - 1, 1) : com.ExecuteNonQuery()
                XtraMessageBox.Show("Your settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf XtraTabControl1.SelectedTabPage Is tabTransactionSequence Then
            Dim Details As String = ""
            For I = 0 To Gridview1.RowCount - 1
                Details += Gridview1.GetRowCellValue(I, "ColumnName").ToString() & "='" & rchar(Gridview1.GetRowCellValue(I, "ValueData").ToString()) & "',"
            Next
            If XtraMessageBox.Show("This action is required an administrative permission! are you wish to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set " & Details.Remove(Details.Length - 1, 1) : com.ExecuteNonQuery()
                XtraMessageBox.Show("Your settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf XtraTabControl1.SelectedTabPage Is tabDefaultSettings Then
            Dim Details As String = ""
            For I = 0 To GridView2.RowCount - 1
                Details += GridView2.GetRowCellValue(I, "ColumnName").ToString() & "='" & rchar(GridView2.GetRowCellValue(I, "ValueData").ToString()) & "',"
            Next
            If XtraMessageBox.Show("This action is required an administrative permission! are you wish to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "UPDATE tblgeneralsettings set " & Details.Remove(Details.Length - 1, 1) : com.ExecuteNonQuery()
                XtraMessageBox.Show("Your settings Successfully Saved!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub
End Class