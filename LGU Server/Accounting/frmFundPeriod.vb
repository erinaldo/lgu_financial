Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmFundPeriod
    Private Sub frmFundPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        LoadFund()
        filter()
        PermissionAccess({cmdClose}, globalAdminAccess)
        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub

    Public Sub createperiod()
        If mode.Text = "edit" Then Exit Sub
        code.Text = fundcode.Text & "-" & txtYear.Text
    End Sub

    Private Sub txtYear_EditValueChanged(sender As Object, e As EventArgs) Handles txtYear.EditValueChanged
        createperiod()
    End Sub
    Public Sub LoadFund()
        LoadXgridLookupSearch("SELECT code,Description from tblfund", "tblfund", txtFund, gridFund, Me)
        gridFund.Columns("code").Visible = False
    End Sub
    Private Sub txtFund_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFund.EditValueChanged
        On Error Resume Next
        fundcode.Text = txtFund.Properties.View.GetFocusedRowCellValue("code").ToString()
        createperiod()
    End Sub

    Public Sub filter()
        LoadXgrid("Select id, periodcode as 'Period Code', (select description from tblfund where code=a.fundcode) as 'Fund', yeartrn as 'Year', jevseries as 'JEV Series', prseries as 'PR Series', poseries as 'PO Series', dvseries as 'DV Series', Closed from tblfundperiod as a order by id asc", "tblfundperiod", Em, GridView1, Me)
        XgridHideColumn({"id"}, GridView1)
        XgridColAlign({"Period Code", "Year", "JEV Series", "PR Series", "PO Series", "DV Series"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If countqry("tblfundperiod", "fundcode='" & fundcode.Text & "' and yeartrn='" & txtYear.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Fund period is already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFund.Focus()
            Exit Sub
        ElseIf txtYear.Text = "" Then
            XtraMessageBox.Show("Please enter transaction year!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtYear.Focus()
            Exit Sub
        ElseIf txtJev.Text = "" Then
            XtraMessageBox.Show("Please enter jev series no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtJev.Focus()
            Exit Sub
        ElseIf txtPR.Text = "" Then
            XtraMessageBox.Show("Please enter pr series no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPR.Focus()
            Exit Sub
        ElseIf txtPO.Text = "" Then
            XtraMessageBox.Show("Please enter po series no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPO.Focus()
            Exit Sub
        ElseIf txtDV.Text = "" Then
            XtraMessageBox.Show("Please enter dv series no!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDV.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblfundperiod set periodcode='" & code.Text & "', fundcode='" & fundcode.Text & "',yeartrn='" & txtYear.Text & "',jevseries='" & txtJev.Text & "',dvseries='" & txtDV.Text & "',prseries='" & txtPR.Text & "', poseries='" & txtPO.Text & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblfundperiod set periodcode='" & code.Text & "', fundcode='" & fundcode.Text & "',yeartrn='" & txtYear.Text & "',jevseries='" & txtJev.Text & "',dvseries='" & txtDV.Text & "',prseries='" & txtPR.Text & "', poseries='" & txtPO.Text & "'" : com.ExecuteNonQuery()
        End If
        id.Text = "" : mode.Text = "" : code.Text = "" : fundcode.Text = "" : txtFund.EditValue = Nothing : txtYear.Text = "" : txtJev.Text = "" : txtPR.Text = "" : txtPO.Text = "" : txtDV.Text = "" : txtFund.Focus() : filter()
        XtraMessageBox.Show("fund period successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub showInfo()
        If id.Text = "" Then Exit Sub
        com.CommandText = "select * from tblfundperiod where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            code.Text = rst("periodcode").ToString
            txtFund.EditValue = rst("fundcode").ToString
            fundcode.Text = rst("fundcode").ToString
            txtYear.Text = rst("yeartrn").ToString
            txtJev.Text = rst("jevseries").ToString
            txtPR.Text = rst("prseries").ToString
            txtPO.Text = rst("poseries").ToString
            txtDV.Text = rst("dvseries").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "" : id.Enabled = False
        id.Text = GridView1.GetFocusedRowCellValue("id").ToString
        mode.Text = "edit"
        showInfo()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        filter()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "delete from tblfundperiod where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub

    Private Sub CloseTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        If XtraMessageBox.Show("Are you sure you want to permanently closed selected item? ", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tblfundperiod set closed=1 where id='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "id") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub
End Class