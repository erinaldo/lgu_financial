Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmCollectionItem
    Private Sub frmCollectionItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        filter()
        LoadAccountTitle()
        PermissionAccess({cmdSave}, globalAllowAdd)
        PermissionAccess({cmdEdit}, globalAllowEdit)
        PermissionAccess({cmdDelete}, globalAllowDelete)
    End Sub

    Public Sub LoadAccountTitle()
        LoadXgridLookupSearch("SELECT itemcode,itemname as 'Account Title'  from tblglitem where sl=1", "tblglitem", txtAccountTitle, gridFund, Me)
        gridFund.Columns("itemcode").Visible = False
    End Sub

    Public Sub filter()
        LoadXgrid("Select trncode, trnname as 'Description', (select itemname from tblglitem where itemcode=a.glitemcode) as 'Account Title', amount as 'Default Amount' from tblcollectionitem as a order by trnname asc", "tblcollectionitem", Em, GridView1, Me)
        XgridColAlign({"trncode"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Default Amount"}, GridView1)
        GridView1.BestFitColumns()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter collection name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        ElseIf txtAccountTitle.Text = "" Then
            XtraMessageBox.Show("Please select account title name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAccountTitle.Focus()
            Exit Sub
        End If
        If mode.Text = "edit" Then
            com.CommandText = "update tblcollectionitem set trnname='" & rchar(txtDescription.Text) & "',glitemcode='" & txtAccountTitle.EditValue & "', amount='" & Val(CC(txtAmount.Text)) & "' where trncode='" & code.Text & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "insert into tblcollectionitem set  trnname='" & rchar(txtDescription.Text) & "',glitemcode='" & txtAccountTitle.EditValue & "', amount='" & Val(CC(txtAmount.Text)) & "'" : com.ExecuteNonQuery()
        End If
        code.Text = "" : mode.Text = "" : txtDescription.Text = "" : txtAmount.Text = "0" : txtDescription.Focus() : filter() : code.Enabled = True
        XtraMessageBox.Show("collection item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        com.CommandText = "select * from tblcollectionitem where trncode='" & code.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtDescription.Text = rst("trnname").ToString
            txtAccountTitle.EditValue = rst("glitemcode").ToString
            txtAmount.Text = rst("amount").ToString
        End While
        rst.Close()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        mode.Text = "" : code.Enabled = False
        code.Text = GridView1.GetFocusedRowCellValue("trncode").ToString
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
                com.CommandText = "update tblcollectionitem set deleted=1, datedeleted=current_timestamp, deletedby='" & globaluserid & "' where trncode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "trncode") & "' " : com.ExecuteNonQuery()
            Next
            filter()
        End If
    End Sub


 


End Class