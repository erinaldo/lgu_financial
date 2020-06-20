Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmPurchaseOrder
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
        LoadSupplier()
        LoadProcurementMode()
        LoadPlaceOfDelivery()
        LoadDateDelivery()
        LoadDeliveryTerm()
        LoadPaymentTerm()

        LoadDefaultDropdown(Me.Name, txtProcurementMode)
        LoadDefaultDropdown(Me.Name, txtPlaceofDelivery)
        LoadDefaultDropdown(Me.Name, txtDateDelivery)
        LoadDefaultDropdown(Me.Name, txtDeliveryTerm)
        LoadDefaultDropdown(Me.Name, txtPaymentTerm)
        If countqry("tblpurchaseorder", "pr_number='" & txtPRNumber.Text & "'") = 0 Then
            txtPONumber.Text = "SYSTEM GENERATED"
        Else
            ShowItemInfo()
        End If
        LoadItems()
    End Sub


    Public Sub LoadSupplier()
        LoadXgridLookupSearch("select supplierid as code,suppliername as 'Select', completeaddress, tin from tblsupplier where deleted=0 order by suppliername asc", "tblsupplier", txtSupplier, gridSupplier)
        gridSupplier.Columns("code").Visible = False
        XgridHideColumn({"code", "completeaddress", "tin"}, gridSupplier)
    End Sub

    Private Sub txtSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplier.EditValueChanged
        On Error Resume Next
        txtAddress.Text = txtSupplier.Properties.View.GetFocusedRowCellValue("completeaddress").ToString()
        txtTIN.Text = txtSupplier.Properties.View.GetFocusedRowCellValue("tin").ToString()
    End Sub

    Public Sub LoadProcurementMode()
        LoadPickedDataTable("procurementmode", txtProcurementMode, gridProcurementMode)
    End Sub

    Public Sub LoadPlaceOfDelivery()
        LoadPickedDataTable("placedelivery", txtPlaceofDelivery, gridPlaceOfDelivery)
    End Sub

    Public Sub LoadDateDelivery()
        LoadPickedDataTable("datedelivery", txtDateDelivery, gridDateDelivery)
    End Sub

    Public Sub LoadDeliveryTerm()
        LoadPickedDataTable("deliveryterm", txtDeliveryTerm, gridDeliveryTerm)
    End Sub

    Public Sub LoadPaymentTerm()
        LoadPickedDataTable("paymentterm", txtPaymentTerm, gridPaymentTerm)
    End Sub


    Public Sub ShowItemInfo()
        com.CommandText = "select *,(select completeaddress from tblsupplier where supplierid=a.supplierid) as address,(select tin from tblsupplier where supplierid=a.supplierid) as tin from tblpurchaseorder as a where pr_number='" & txtPRNumber.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtAddress.Text = rst("address").ToString
            txtTIN.Text = rst("tin").ToString
            txtPONumber.Text = rst("ponumber").ToString
            txtPODate.EditValue = rst("po_date").ToString
            txtSupplier.EditValue = rst("supplierid").ToString
            txtProcurementMode.EditValue = rst("procuremode").ToString
            txtPlaceofDelivery.EditValue = rst("placedelivery").ToString
            txtDateDelivery.EditValue = rst("datedelivery").ToString
            txtDeliveryTerm.EditValue = rst("deliveryterm").ToString
            txtPaymentTerm.EditValue = rst("paymentmode").ToString
            ckNegotiated.Checked = CBool(rst("negotiated"))
            txtResolutionNo.Text = rst("resolutionno").ToString
            txtDateApproved.Text = If(rst("dateapproved").ToString = "", "", CDate(rst("dateapproved").ToString))
            txtAddPrintLine.Text = rst("printline").ToString
        End While
        rst.Close()
    End Sub


    Private Sub cmdaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaction.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            If countqry("tblpurchaseorder", "pr_number='" & txtPRNumber.Text & "'") = 0 Then
                Dim poseries As String = CDate(txtPostingDate.EditValue).ToString("yyyy") & "-" & CDate(txtPostingDate.EditValue).ToString("MM") & "-" & GetSequenceNo(periodcode.Text, "poseries")
                com.CommandText = "insert into tblpurchaseorder set ponumber='" & poseries & "', " _
                                       + " pid='" & pid.Text & "'," _
                                       + " po_date='" & ConvertDate(txtPODate.EditValue) & "', " _
                                       + " pr_number='" & txtPRNumber.Text & "', " _
                                       + " pr_date='" & ConvertDate(txtPostingDate.EditValue) & "', " _
                                       + " supplierid='" & txtSupplier.EditValue & "', " _
                                       + " procuremode='" & txtProcurementMode.EditValue & "', " _
                                       + " placedelivery='" & txtPlaceofDelivery.EditValue & "', " _
                                       + " datedelivery='" & txtDateDelivery.EditValue & "', " _
                                       + " deliveryterm='" & txtDeliveryTerm.EditValue & "', " _
                                       + " paymentmode='" & txtPaymentTerm.EditValue & "', " _
                                       + " printline=" & txtAddPrintLine.Text & ", " _
                                       + " negotiated=" & ckNegotiated.CheckState & ", " _
                                       + " resolutionno='" & txtResolutionNo.Text & "', " _
                                       + If(ckNegotiated.Checked, " dateapproved='" & ConvertDate(txtDateApproved.EditValue) & "', ", " dateapproved=null, ") _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp" : com.ExecuteNonQuery()
                UpdatePOItems(poseries)
                XtraMessageBox.Show("Purchase request successfully save!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                com.CommandText = "update tblpurchaseorder set ponumber='" & txtPONumber.Text & "', " _
                                       + " pid='" & pid.Text & "'," _
                                       + " po_date='" & ConvertDate(txtPODate.EditValue) & "', " _
                                       + " pr_number='" & txtPRNumber.Text & "', " _
                                       + " pr_date='" & ConvertDate(txtPostingDate.EditValue) & "', " _
                                       + " supplierid='" & txtSupplier.EditValue & "', " _
                                       + " procuremode='" & txtProcurementMode.EditValue & "', " _
                                       + " placedelivery='" & txtPlaceofDelivery.EditValue & "', " _
                                       + " datedelivery='" & txtDateDelivery.EditValue & "', " _
                                       + " deliveryterm='" & txtDeliveryTerm.EditValue & "', " _
                                       + " paymentmode='" & txtPaymentTerm.EditValue & "', " _
                                       + " printline=" & txtAddPrintLine.Text & ", " _
                                       + " negotiated=" & ckNegotiated.CheckState & ", " _
                                       + " resolutionno='" & txtResolutionNo.Text & "', " _
                                       + If(ckNegotiated.Checked, " dateapproved='" & ConvertDate(txtDateApproved.EditValue) & "', ", " dateapproved=null, ") _
                                       + " trnby='" & globaluserid & "', " _
                                       + " datetrn=current_timestamp where pr_number='" & txtPRNumber.Text & "'" : com.ExecuteNonQuery()
                UpdatePOItems(txtPONumber.Text)
                XtraMessageBox.Show("Purchase request successfully updated!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            SaveDefaultDropdown(Me.Name, txtProcurementMode)
            SaveDefaultDropdown(Me.Name, txtPlaceofDelivery)
            SaveDefaultDropdown(Me.Name, txtDateDelivery)
            SaveDefaultDropdown(Me.Name, txtDeliveryTerm)
            SaveDefaultDropdown(Me.Name, txtPaymentTerm)
            PrintPurchaseOrder(pid.Text, txtAddPrintLine.Text, Me)
        End If

    End Sub

    Public Sub UpdatePOItems(ByVal ponumber As String)
        com.CommandText = "delete from tblpurchaseorderitem where pid='" & pid.Text & "'" : com.ExecuteNonQuery()
        For I = 0 To GridView1.RowCount - 1
            com.CommandText = "insert into tblpurchaseorderitem set pid='" & pid.Text & "', ponumber='" & ponumber & "',trnid='" & GridView1.GetRowCellValue(I, "id").ToString & "',stockno='" & GridView1.GetRowCellValue(I, "Stock No.").ToString & "', itemcode='" & GridView1.GetRowCellValue(I, "itemcode").ToString & "',itemname='" & rchar(GridView1.GetRowCellValue(I, "Particular Name").ToString) & "', quantity='" & Val(CC(GridView1.GetRowCellValue(I, "Quantity").ToString)) & "',unit='" & GridView1.GetRowCellValue(I, "Unit").ToString & "',unitcost='" & Val(CC(GridView1.GetRowCellValue(I, "Unit Cost").ToString)) & "',totalcost='" & Val(CC(GridView1.GetRowCellValue(I, "Total Cost").ToString)) & "',remarks='" & rchar(GridView1.GetRowCellValue(I, "Remarks").ToString) & "'" : com.ExecuteNonQuery()
        Next
    End Sub

    Public Sub LoadItems()
        LoadXgrid("select a.id,a.itemcode, if(b.stockno is null,'',b.stockno) as 'Stock No.', a.itemname as 'Particular Name', a.Unit,  if(b.Quantity is null,a.Quantity,b.Quantity) as 'Quantity', if(b.unitcost is null,a.unitcost,b.unitcost) as 'Unit Cost', if(b.totalcost is null,a.totalcost,b.totalcost) as 'Total Cost', a.Remarks from tblrequisitionitem as a left join tblpurchaseorderitem as b on a.id = b.trnid where a.pid='" & pid.Text & "'", "tblpurchaseorderitem", Em, GridView1, Me)
        XgridHideColumn({"id", "itemcode"}, GridView1)
        XgridColCurrency({"Unit Cost", "Total Cost"}, GridView1)
        XgridColWidth({"Unit Cost", "Total Cost"}, GridView1, 130)
        XgridColAlign({"Quantity", "Stock No."}, GridView1, HorzAlignment.Center)
        XgridDisableColumn({"Particular Name", "itemcode", "Unit", "Total Cost", "Remarks"}, GridView1)
        XgridGeneralSummaryCurrency({"Total Cost"}, GridView1)
        GridView1.BestFitColumns()
        XgridColWidth({"Remarks"}, GridView1, 300)
        XgridColMemo({"Remarks"}, GridView1)
        For Each col In GridView1.Columns
            col.OptionsColumn.AllowSort = DefaultBoolean.False
        Next
    End Sub

    Private Sub gridview1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles GridView1.RowCellStyle
        Dim View As GridView = sender
        If e.Column.Name = "colQuantity" Or e.Column.Name = "colUnitCost" Or e.Column.Name = "colStockNo." Then
            e.Appearance.BackColor = Color.LemonChiffon
            e.Appearance.BackColor2 = Color.LemonChiffon
            e.Appearance.ForeColor = Color.Black
        End If
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.FieldName = "Quantity" Or e.Column.FieldName = "Unit Cost" Then
            Dim quantity As Double = Val(CC(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("Quantity")).ToString()))
            Dim unitcost As Double = Val(CC(Gridview1.GetRowCellValue(e.RowHandle, Gridview1.Columns("Unit Cost")).ToString()))
            Dim TotalCost As Double = unitcost * quantity
            Gridview1.SetRowCellValue(e.RowHandle, Gridview1.Columns("Total Cost"), TotalCost)
        End If
    End Sub


    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmDataPicked.fieldname.Text = "procurementmode"
        frmDataPicked.Text = "Procurement Mode Table"
        frmDataPicked.ShowDialog(Me)
        LoadProcurementMode()
    End Sub

    Private Sub HyperlinkLabelControl3_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl3.Click
        frmDataPicked.fieldname.Text = "placedelivery"
        frmDataPicked.Text = "Place Delivery Table"
        frmDataPicked.ShowDialog(Me)
        LoadPlaceOfDelivery()
    End Sub

    Private Sub HyperlinkLabelControl4_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl4.Click
        frmDataPicked.fieldname.Text = "datedelivery"
        frmDataPicked.Text = "Date Delivery Table"
        frmDataPicked.ShowDialog(Me)
        LoadDateDelivery()
    End Sub

    Private Sub HyperlinkLabelControl5_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl5.Click
        frmDataPicked.fieldname.Text = "deliveryterm"
        frmDataPicked.Text = "Delivery Term Table"
        frmDataPicked.ShowDialog(Me)
        LoadDeliveryTerm()
    End Sub

    Private Sub HyperlinkLabelControl6_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl6.Click
        frmDataPicked.fieldname.Text = "paymentterm"
        frmDataPicked.Text = "Payment Term Table"
        frmDataPicked.ShowDialog(Me)
        LoadPaymentTerm()
    End Sub

    Private Sub HyperlinkLabelControl2_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl2.Click
        frmSupplierInfo.ShowDialog(Me)
        LoadSupplier()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles ckNegotiated.CheckedChanged
        If ckNegotiated.Checked = True Then
            txtResolutionNo.Enabled = True
            txtDateApproved.Enabled = True
        Else
            txtResolutionNo.Enabled = False
            txtResolutionNo.Text = ""
            txtDateApproved.Enabled = False
            txtDateApproved.Text = ""
        End If
    End Sub

  

End Class