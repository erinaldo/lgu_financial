Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmQuantitySelect
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmQuantitySelect_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmQuantitySelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If mode.Text = "edit" Then
            ShowItemInfo()
        Else
            txtQuantity.Text = "1"
        End If
        txtQuantity.Focus()
    End Sub

    Public Sub ShowItemInfo()
        com.CommandText = "select * from tblrequisitionitem where id='" & id.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            productid.Text = rst("itemcode").ToString
            txtproduct.Text = rst("itemname").ToString
            catid.Text = rst("catid").ToString
            txtUnit.Text = rst("unit").ToString
            txtRemarks.Text = rst("remarks").ToString
            txtUnitPrice.EditValue = rst("unitcost").ToString
        End While
        rst.Close()
    End Sub

    Private Sub txtquan_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQuantity.GotFocus
        txtQuantity.SelectionStart = 0
        txtQuantity.SelectionLength = Len(txtQuantity.Text)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If Val(CC(txtQuantity.Text)) <= 0 Then
            XtraMessageBox.Show("Quantity missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtQuantity.Focus()
            Exit Sub

        ElseIf txtUnitPrice.Text = "" Then
            XtraMessageBox.Show("Unit Cost missing entry!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnitPrice.Focus()
            Exit Sub
        End If

        If mode.Text = "edit" Then
            com.CommandText = "update tblrequisitionitem set pid='" & frmRequisitionInfo.pid.Text & "', " _
                                    + " requestno='" & frmRequisitionInfo.requestno.Text & "', " _
                                    + " requesttype='" & frmRequisitionInfo.requesttype.Text & "', " _
                                    + " fundcode='" & frmRequisitionInfo.fundcode.Text & "', " _
                                    + " periodcode='" & frmRequisitionInfo.periodcode.Text & "', " _
                                    + " yeartrn='" & frmRequisitionInfo.yearcode.Text & "', " _
                                    + " officeid='" & frmRequisitionInfo.officeid.Text & "', " _
                                    + " postingdate=current_date, " _
                                    + " itemcode='" & productid.Text & "', " _
                                    + " itemname='" & txtproduct.Text & "', " _
                                    + " catid='" & catid.Text & "', " _
                                    + " quantity='" & txtQuantity.EditValue & "', " _
                                    + " unit='" & txtUnit.Text & "', " _
                                    + " unitcost='" & txtUnitPrice.EditValue & "', " _
                                    + " totalcost='" & txtTotalCost.EditValue & "', " _
                                    + " remarks='" & rchar(txtRemarks.Text) & "' where id='" & id.Text & "'" : com.ExecuteNonQuery()
            If frmRequisitionInfo.Visible = True Then
                'frmRequisitionInfo.LoadItem()
            End If
            Me.Close()
            XtraMessageBox.Show("Item successfully updated!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            com.CommandText = "insert into tblrequisitionitem set pid='" & frmRequisitionInfo.pid.Text & "', " _
                                    + " requestno='" & frmRequisitionInfo.requestno.Text & "', " _
                                    + " requesttype='" & frmRequisitionInfo.requesttype.Text & "', " _
                                    + " fundcode='" & frmRequisitionInfo.fundcode.Text & "', " _
                                    + " periodcode='" & frmRequisitionInfo.periodcode.Text & "', " _
                                    + " yeartrn='" & frmRequisitionInfo.yearcode.Text & "', " _
                                    + " officeid='" & frmRequisitionInfo.officeid.Text & "', " _
                                    + " postingdate=current_date, " _
                                    + " itemcode='" & productid.Text & "', " _
                                    + " itemname='" & txtproduct.Text & "', " _
                                    + " catid='" & catid.Text & "', " _
                                    + " quantity='" & txtQuantity.EditValue & "', " _
                                    + " unit='" & txtUnit.Text & "', " _
                                    + " unitcost='" & Val(CC(txtUnitPrice.EditValue)) & "', " _
                                    + " totalcost='" & Val(CC(txtTotalCost.EditValue)) & "', " _
                                    + " remarks='" & rchar(txtRemarks.Text) & "',trnby='" & globaluserid & "', datetrn=current_timestamp" : com.ExecuteNonQuery()
            txtQuantity.Focus()
            frmSelectRequestItem.txtfilter.SelectAll()
            frmSelectRequestItem.txtfilter.Focus()
            If frmRequisitionInfo.Visible = True Then
                'frmRequisitionInfo.LoadItem()
            End If
            Me.Close()
        End If
    End Sub

    Public Sub calctotal()
        Dim quan : Dim stm : Dim ttl
        quan = CC(txtQuantity.Text)
        stm = CC(txtUnitPrice.Text)
        ttl = Val(quan) * Val(stm)

        txtTotalCost.Text = ttl
    End Sub

    Private Sub txtquan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.EditValueChanged
        calctotal()
    End Sub

    Private Sub txtsti_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnitPrice.EditValueChanged
        calctotal()
    End Sub
     
    Private Sub txtTotalCost_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalCost.EditValueChanged
        If txtTotalCost.EditValue > 0 Then
            Me.AcceptButton = cmdaction
        Else
            Me.AcceptButton = Nothing
        End If
    End Sub
End Class