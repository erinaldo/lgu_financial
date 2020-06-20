Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient

Public Class frmResetDatabase

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmResetDatabase_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        CheckedListBox1.Items.Clear()
        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("show tables in " & sqldatabase, conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblappearance" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblcompanysettings" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblcountries" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tbldatabaseupdatelogs" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblgeneralsettings" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblglobalproductssequence" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblpayrolldeductionrange" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblsalesbatchsequence" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblemailreportnotification" And
                   .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString() <> "tblsalescardtype" Then
                    CheckedListBox1.Items.Add(sqldatabase & "." & .Rows(cnt)("Tables_in_" & sqldatabase & "").ToString())
                End If
            End With
        Next
        msda = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("show tables in " & sqlfiledir, conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
               CheckedListBox1.Items.Add(sqlfiledir & "." & .Rows(cnt)("Tables_in_" & sqlfiledir & "").ToString()) 
            End With
        Next
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Checked)
            Next
        Else
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Unchecked)
            Next
        End If
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If XtraMessageBox.Show("WARNING: You are about to delete all containing data on checked items above! " & Environment.NewLine & Environment.NewLine & "NOTE: If you continue this action, there will be no undo function to retrive all deleted data." & Environment.NewLine & Environment.NewLine & "Are you sure you want to continue?  " & todelete, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = vbYes Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(I) = True And CheckedListBox1.Items(I).ToString.Contains("tbl") = True Then
                    com.CommandText = "DELETE FROM " & CheckedListBox1.Items(I).ToString : com.ExecuteNonQuery()
                End If
            Next

            For I = 0 To CheckedListBox1.Items.Count - 1
                If CheckedListBox1.GetItemChecked(I) = True And CheckedListBox1.Items(I).ToString.Contains("tbl") = True Then
                    com.CommandText = "ALTER TABLE " & CheckedListBox1.Items(I).ToString & " AUTO_INCREMENT = 1;" : com.ExecuteNonQuery()
                End If
            Next

            com.CommandText = "ALTER TABLE `tblaccounts` AUTO_INCREMENT = 100;" : com.ExecuteNonQuery()
            XtraMessageBox.Show("Database successfully resetted!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class