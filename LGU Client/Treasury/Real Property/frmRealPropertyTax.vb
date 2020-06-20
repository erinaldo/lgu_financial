Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmRealPropertyTax

    Delegate Sub Execute_Delegate()
    Private Sub Execute_ThreadSafe()
        If Me.InvokeRequired Then
            Dim MyDelegate As New Execute_Delegate(AddressOf Execute_ThreadSafe)
            Me.Invoke(MyDelegate)
        Else
            loadTaxDueDeclaration()
        End If
    End Sub


    Private Sub frmRealPropertyTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
    End Sub

    Private Sub txtFullname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullname.KeyPress
        If e.KeyChar = Chr(13) Then
            If RemoveWhiteSpaces(txtFullname.Text, False) = "" Or RemoveWhiteSpaces(txtFullname.Text, False) = "%" Then Exit Sub
            If countqry("tbltaxpayerprofile", "fullname = '" & RemoveWhiteSpaces(txtFullname.Text, False) & "' and cifid in (select cifid from tbltaxdeclaration where paid=0)") = 0 Then
                If countqry("tbltaxpayerprofile", "fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' and cifid in (select cifid from tbltaxdeclaration where paid=0)") = 0 Then
                    XtraMessageBox.Show("No match found on real property records!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    DXLoadToComboBoxQuery("fullname", "SELECT fullname FROM tbltaxpayerprofile  where fullname like '%" & RemoveWhiteSpaces(txtFullname.Text, False) & "%' order by fullname asc;", txtFullname)
                End If
                txtPropertyNo.Enabled = False
                txtFullname.ShowPopup()
                Exit Sub
            Else
                LoadCustomerInfo(RemoveWhiteSpaces(txtFullname.Text, False), False)
            End If
        End If
    End Sub

    Public Sub LoadCustomerInfo(ByVal parameter As String, ByVal querybyid As Boolean)
        dst = Nothing : dst = New DataSet
        If querybyid = True Then
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where cifid='" & parameter & "' and cifid", conn)
        Else
            msda = New MySqlDataAdapter("select * from tbltaxpayerprofile where fullname='" & parameter & "'", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                taxpayerid.Text = .Rows(cnt)("cifid").ToString()
                txtPropertyNo.Enabled = True
                txtPropertyNo.Focus()
            End With
        Next
        LoadProperty()
    End Sub

    Public Sub LoadProperty()
        If taxpayerid.Text = "" Then Exit Sub
        LoadXgridLookupSearch("SELECT id, certificateno as 'Property No',ifnull((select sum(totaltaxdue) from tbltaxdeclaration where propertyno=a.certificateno),0) as 'Balance Due' from tblrealproperty as a where cifid='" & taxpayerid.Text & "' and cifid in (select cifid from tbltaxdeclaration where paid=0)", "tblrealproperty", txtPropertyNo, gridProperty)
        gridProperty.Columns("id").Visible = False
        XgridColCurrency({"Balance Due"}, gridProperty)
        txtPropertyNo.ShowPopup()
    End Sub

    Private Sub txtPropertyNo_EditValueChanged(sender As Object, e As EventArgs) Handles txtPropertyNo.EditValueChanged
        loadPropertyInfo()
    End Sub

    Public Sub loadPropertyInfo()
        msda = New MySqlDataAdapter("select * from tblrealproperty where id='" & txtPropertyNo.EditValue & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtLotAddress.Text = .Rows(cnt)("lotaddress").ToString()
                txtTotalarea.Text = FormatNumber(Val(.Rows(cnt)("totalarea").ToString()), 2)
                txtLotBlockNo.Text = .Rows(cnt)("lotblockno").ToString()
            End With
        Next
        loadTaxDueDeclaration()
    End Sub

    Public Sub loadTaxDueDeclaration()
        dgv.Rows.Clear() : dgv.Columns.Clear()
        PopulateGridViewControls("Select", 20, "CHECKBOX", dgv, True, False)
        PopulateGridViewControls("Declaration No.", 70, "", dgv, True, True)
        PopulateGridViewControls("Fund", 70, "", dgv, True, True)
        PopulateGridViewControls("Land", 50, "", dgv, True, True)
        PopulateGridViewControls("Improvement", 50, "", dgv, True, True)
        PopulateGridViewControls("Assessed Value", 30, "", dgv, True, True)
        PopulateGridViewControls("Tax Due", 40, "", dgv, True, True) 'Amount + basic/sef if checked
        PopulateGridViewControls("Installment", 20, "", dgv, True, False)  ' show if installment then hide fullpayment
        PopulateGridViewControls("Balance", 20, "", dgv, True, True)  ' show if installment then hide fullpayment
        PopulateGridViewControls("Full Payment", 20, "", dgv, True, True) ' show if full payment then hide installment
        PopulateGridViewControls("Penalty", 30, "", dgv, True, False)
        PopulateGridViewControls("Total", 10, "", dgv, True, True)
        PopulateGridViewControls("id", 0, "", dgv, False, True)

      
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select * from tbltaxdeclaration where propertyno='" & txtPropertyNo.Text & "' and paid=0", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                If ckBasic.Checked = True Then
                    dgv.Rows.Add(True, .Rows(cnt)("taxdeclarationno").ToString(), _
                                            "BASIC", _
                                             Val(.Rows(cnt)("assessedvalue").ToString()), _
                                             Val(.Rows(cnt)("improvement").ToString()), _
                                             Val(.Rows(cnt)("totalassessedvalue").ToString()), _
                                             Val(.Rows(cnt)("basictax").ToString()), _
                                             Val(0), _
                                             Val(.Rows(cnt)("basictax").ToString()), _
                                             Val(.Rows(cnt)("basictax").ToString()), _
                                             Val(.Rows(cnt)("basicpenalty").ToString()), _
                                             Val(.Rows(cnt)("totalbasic").ToString()), _
                                             .Rows(cnt)("id").ToString())
                End If
                If ckSef.Checked = True Then
                    dgv.Rows.Add(True, .Rows(cnt)("taxdeclarationno").ToString(), _
                                            "SEF", _
                                             Val(.Rows(cnt)("assessedvalue").ToString()), _
                                             Val(.Rows(cnt)("improvement").ToString()), _
                                             Val(.Rows(cnt)("totalassessedvalue").ToString()), _
                                             Val(.Rows(cnt)("seftax").ToString()), _
                                             Val(0), _
                                             Val(.Rows(cnt)("seftax").ToString()), _
                                             Val(.Rows(cnt)("seftax").ToString()), _
                                             Val(.Rows(cnt)("sefpenalty").ToString()), _
                                             Val(.Rows(cnt)("totalsef").ToString()), _
                                             .Rows(cnt)("id").ToString())
                End If
            End With
        Next
        If radPaymentType.EditValue = "full" Then
            GridHideColumn(dgv, {"Installment", "Balance"})
        Else
            GridHideColumn(dgv, {"Full Payment"})
        End If
        TaxCalculator()
        GridCurrencyColumn(dgv, {"Land", "Improvement", "Assessed Value", "Tax Due", "Installment", "Balance", "Full Payment", "Penalty", "Total"})
        GridColumnWidth(dgv, {"Declaration No.", "Land", "Improvement", "Assessed Value", "Tax Due", "Installment", "Balance", "Full Payment", "Penalty", "Total"}, 100)
        GridColumnAlignment(dgv, {"Declaration No.", "Fund"}, DataGridViewContentAlignment.MiddleCenter)
        GridColumAutoWidth(dgv, {"Select", "Tax Declaration No"})
    End Sub

    Private Sub dgv_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellEndEdit
        TaxCalculator()
    End Sub

    Private Sub dgv_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles dgv.CellStateChanged
        TaxCalculator()
    End Sub

    Private Sub dgv_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgv.EditingControlShowing
        Try
            If dgv.CurrentCell.ColumnIndex = 6 Then
                Dim combo As Windows.Forms.ComboBox = CType(e.Control, Windows.Forms.ComboBox)
                If (combo IsNot Nothing) Then
                    RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Tax_SelectionChangeCommitted)
                    AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf Tax_SelectionChangeCommitted)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Sub Tax_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim combo As Windows.Forms.CheckBox = CType(sender, Windows.Forms.CheckBox)

    End Sub

    Private Sub dgv_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv.CellMouseDown
        On Error Resume Next
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Me.dgv.CurrentCell = Me.dgv.Rows(e.RowIndex).Cells(e.ColumnIndex)
        End If
    End Sub

    Private Sub ckBasic_CheckedChanged(sender As Object, e As EventArgs) Handles ckBasic.CheckedChanged
        loadTaxDueDeclaration()
    End Sub

    Private Sub ckSef_CheckedChanged(sender As Object, e As EventArgs) Handles ckSef.CheckedChanged
        loadTaxDueDeclaration()
    End Sub

    Private Sub txtGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles radPaymentType.SelectedIndexChanged
        loadTaxDueDeclaration()
    End Sub

    Private Sub CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv.CellValueChanged
        Dim gv As DataGridView = DirectCast(sender, DataGridView)
        If DirectCast(dgv.Rows(e.RowIndex).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
            Dim TaxDue As Double = Val(CC(gv("Tax Due", e.RowIndex).Value))
            Dim PenaltyDue As Double = Val(CC(gv("Penalty", e.RowIndex).Value))
            If radPaymentType.EditValue = "full" Then
                If e.ColumnIndex = 10 Then ' penalty
                    gv("Total", e.RowIndex).Value = TaxDue + PenaltyDue
                    gv("Balance", e.RowIndex).Value = 0
                End If
            Else
                Dim Installment As Double = Val(CC(gv("Installment", e.RowIndex).Value))
                If e.ColumnIndex = 7 Or e.ColumnIndex = 10 Then ' penalty
                    gv("Balance", e.RowIndex).Value = TaxDue - Installment
                    gv("Total", e.RowIndex).Value = (TaxDue - Installment) + PenaltyDue
                End If
            End If
        End If
     



        'If e.ColumnIndex = 6 Then ' tax rate selected
        '    Dim vat As Double = 0
        '    vat = (originalamount * (taxrate / 100))
        '    gv("Tax", e.RowIndex).Value = vat
        '    gv("Total", e.RowIndex).Value = originalamount - vat
        '    gv("Payment", e.RowIndex).Value = originalamount - vat
        '    gv("New Balance", e.RowIndex).Value = 0
        'End If

        'If e.ColumnIndex = 9 Then ' enter payment amount
        'Dim originalamount As Double = If(gv("Current Balance", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Current Balance", e.RowIndex).Value)))
        'Dim taxrate As Double = If(gv("taxrate", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("taxrate", e.RowIndex).Value)))

        '    Dim Total As Double = If(gv("Total", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Total", e.RowIndex).Value)))
        '    Dim Tenderamount As Double = If(gv("Payment", e.RowIndex).Value.ToString = "", 0, Val(CC(gv("Payment", e.RowIndex).Value)))
        '    gv("New Balance", e.RowIndex).Value = Total - Tenderamount
        'End If
        TaxCalculator()
    End Sub

    Public Sub TaxCalculator()
        Dim SelectedAmount As Double
        For I = 0 To dgv.RowCount - 1
            If DirectCast(dgv.Rows(I).Cells("Select"), DataGridViewCheckBoxCell).Value = 1 Then
                SelectedAmount += Val(CC(dgv.Item("Total", I).Value))
            End If
        Next
        txtAmountInWords.Text = ConvertCurrencyToEnglish(SelectedAmount)
        txtTotalOnScreen.Text = FormatNumber(SelectedAmount, 2)
    End Sub
    Private Sub dgv_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dgv.DataError

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        TaxCalculator()
    End Sub

    Private Sub txtCheckAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtCheckAmount.EditValueChanged
        txtTotalCheck.Text = txtCheckAmount.EditValue
    End Sub

    Private Sub txtPmoAmount_EditValueChanged(sender As Object, e As EventArgs) Handles txtPmoAmount.EditValueChanged
        txtTotalPMO.Text = txtPmoAmount.EditValue
    End Sub

    Private Sub txtTotalCash_EditValueChanged(sender As Object, e As EventArgs) Handles txtTotalCash.EditValueChanged, txtTotalCheck.EditValueChanged, txtTotalPMO.EditValueChanged
        txtTotalPaymentDue.Text = Val(txtTotalCash.EditValue) + Val(txtTotalCheck.EditValue) + Val(txtTotalPMO.EditValue)
    End Sub


End Class