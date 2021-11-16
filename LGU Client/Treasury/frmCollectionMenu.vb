Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Net
Imports DevExpress.XtraEditors

Public Class frmCollectionMenu
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCollectionMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmAssignAccountable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        txtCollectionDate.Properties.MinValue = CDate(GetServerDate().AddDays(-15))
        txtCollectionDate.Properties.MaxValue = CDate(GetServerDate())
        txtCollectionDate.EditValue = CDate(GetServerDate())
        ViewFormList()
        LoadToComboBoxDB("select id,concat(yeartrn,' - ',(select description from tblfund where code=a.fundcode)) as activedfund from tblfundperiod as a where closed='0' " & If(LCase(globalusername) = "root", "", " and fundcode in (select fundcode from tblfundfilter where filtered_id='" & globalAuthcode & "' and filtered_type='client')") & "", "activedfund", "id", txtFundcode)
        SecurityCheck()
    End Sub

    Private Sub txtFuncode_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtFundcode.SelectedValueChanged
        com.CommandText = "select * from tblfundperiod where id='" & DirectCast(txtFundcode.SelectedItem, ComboBoxItem).HiddenValue() & "'" : rst = com.ExecuteReader
        While rst.Read
            periodcode.Text = rst("periodcode").ToString
            fundcode.Text = rst("fundcode").ToString
            yeartrn.Text = rst("yeartrn").ToString
        End While
        rst.Close()
        SecurityCheck()
    End Sub

    Public Function SecurityCheck()
        Dim GetActivedOR As Integer = 0
        If mode.Text = "collection" Then
            GetActivedOR = countqry("tblforminventory", "officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcollection from tbldefaultsettings)")
        ElseIf mode.Text = "cedulaindividual" Then
            GetActivedOR = countqry("tblforminventory", "officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcedulaindividual from tbldefaultsettings)")
        ElseIf mode.Text = "cedulacorporate" Then
            GetActivedOR = countqry("tblforminventory", "officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultcedulacorporate from tbldefaultsettings)")
        ElseIf mode.Text = "property" Then
            GetActivedOR = countqry("tblforminventory", "officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and inused=1 and formcode in (select defaultpropertytax from tbldefaultsettings)")
        End If
        If GetActivedOR > 0 And txtFundcode.Text <> "" Then
            cmdStartCollection.Enabled = True
        Else
            cmdStartCollection.Enabled = False
        End If
        Return True
    End Function

    Public Sub ViewFormList()
        If mode.Text = "collection" Then
            LoadXgrid("Select  id as 'Inventory Code', (select description from tblaccountableform where code=a.formcode) as 'Form', SeriesFrom,SeriesTo,CurrentNo, InUsed  from tblforminventory as a where formcode in (select defaultcollection from tbldefaultsettings) and officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
        ElseIf mode.Text = "cedulaindividual" Then
            LoadXgrid("Select  id as 'Inventory Code', (select description from tblaccountableform where code=a.formcode) as 'Form', SeriesFrom,SeriesTo,CurrentNo, InUsed  from tblforminventory as a where formcode in (select defaultcedulaindividual from tbldefaultsettings) and officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
        ElseIf mode.Text = "cedulacorporate" Then
            LoadXgrid("Select  id as 'Inventory Code', (select description from tblaccountableform where code=a.formcode) as 'Form', SeriesFrom,SeriesTo,CurrentNo, InUsed  from tblforminventory as a where formcode in (select defaultcedulacorporate from tbldefaultsettings) and officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
        ElseIf mode.Text = "property" Then
            LoadXgrid("Select  id as 'Inventory Code', (select description from tblaccountableform where code=a.formcode) as 'Form', SeriesFrom,SeriesTo,CurrentNo, InUsed  from tblforminventory as a where formcode in (select defaultpropertytax from tbldefaultsettings) and officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' order by seriesfrom asc", "tblforminventory", Em, GridView1, Me)
        End If

        XgridColAlign({"Inventory Code", "Form", "SeriesFrom", "SeriesTo", "CurrentNo", "Date Updated", "Date Entry"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        If GridView1.RowCount > 0 Then
            Em.ContextMenuStrip = cms_em
        Else
            Em.ContextMenuStrip = Nothing
        End If
    End Sub

    Private Sub cmdSetActiveForm_Click(sender As Object, e As EventArgs) Handles cmdSetActiveForm.Click
        If XtraMessageBox.Show("Are you sure you want to continue execute? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "collection" Then
                com.CommandText = "UPDATE tblforminventory set inused=0 where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and formcode in (select defaultcollection from tbldefaultsettings)" : com.ExecuteNonQuery()
            ElseIf mode.Text = "cedulaindividual" Then
                com.CommandText = "UPDATE tblforminventory set inused=0 where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and formcode in (select defaultcedulaindividual from tbldefaultsettings)" : com.ExecuteNonQuery()
            ElseIf mode.Text = "cedulacorporate" Then
                com.CommandText = "UPDATE tblforminventory set inused=0 where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and formcode in (select defaultcedulacorporate from tbldefaultsettings)" : com.ExecuteNonQuery()
            ElseIf mode.Text = "property" Then
                com.CommandText = "UPDATE tblforminventory set inused=0 where officeid='" & compOfficeid & "' and accountable='" & globaluserid & "' and formcode in (select defaultpropertytax from tbldefaultsettings)" : com.ExecuteNonQuery()
            End If
            com.CommandText = "UPDATE tblforminventory set inused=1 where id='" & GridView1.GetFocusedRowCellValue("Inventory Code").ToString & "'" : com.ExecuteNonQuery()
            ViewFormList()
            SecurityCheck()
        End If
    End Sub

    Private Sub cmdReturnForm_Click(sender As Object, e As EventArgs) Handles cmdReturnForm.Click
        If XtraMessageBox.Show("Are you sure you want to continue execute? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblforminventory set inused=0, accountable='' where id='" & GridView1.GetFocusedRowCellValue("Inventory Code").ToString & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblformreportlogs set ending='" & GridView1.GetFocusedRowCellValue("CurrentNo").ToString & "',dateending=current_timestamp where invrefcode='" & GridView1.GetFocusedRowCellValue("Inventory Code").ToString & "' and accountable='" & globaluserid & "' and returned=0" : com.ExecuteNonQuery()
            ViewFormList()
            SecurityCheck()
        End If
    End Sub

    Private Sub cmdStartCollection_Click(sender As Object, e As EventArgs) Handles cmdStartCollection.Click
        MainForm.ProceedCollection(True, periodcode.Text, fundcode.Text, fundcode.Text & "-" & UCase(txtFundcode.Text), yeartrn.Text, CDate(txtCollectionDate.EditValue), mode.Text, Me)

    End Sub
End Class