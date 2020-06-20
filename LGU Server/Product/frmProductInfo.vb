﻿Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmProductInfo

    Private Sub frmProductInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmProductInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        SetIcon(Me)
        LoadToComboBox("unitname", "tblproductunit", txtUnit, True)
        LoadCategory()
        If mode.Text = "edit" Then
            productid.Text = code.Text
            showInfo()
        Else
            productid.Text = "SYSTEM GENERATED"
        End If
    End Sub

    Public Sub LoadCategory()
        LoadXgridLookupSearch("SELECT code, Description as 'Select', CASE WHEN noninventory = 1 THEN 0 WHEN consumable = 1 then 1 when ppe = 1 then 2 else -1 END as InventoryType from tblproductcategory", "tblproductcategory", txtCategory, gridcategory, Me)
        XgridHideColumn({"InventoryType"}, gridcategory)
        gridcategory.Columns("code").Visible = False
    End Sub
    Private Sub txtCategory_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCategory.EditValueChanged
        On Error Resume Next
        categorycode.Text = txtCategory.Properties.View.GetFocusedRowCellValue("code").ToString()
        ckpooption.SelectedIndex = CInt(txtCategory.Properties.View.GetFocusedRowCellValue("InventoryType").ToString())
        LoadClassification()
        txtClassification.Focus()
    End Sub

    Public Sub LoadClassification()
        If cmdCategory.Text = "" Then Exit Sub
        LoadXgridLookupSearch("SELECT code, Description as 'Select' from tblproductclass where categorycode='" & categorycode.Text & "'", "tblproductcategory", txtClassification, gridClass, Me)
        gridClass.Columns("code").Visible = False
    End Sub
    Private Sub txtClassification_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClassification.EditValueChanged
        On Error Resume Next
        classcode.Text = txtClassification.Properties.View.GetFocusedRowCellValue("code").ToString()
    End Sub

    Private Sub cmdSaveButton_Click(sender As Object, e As EventArgs) Handles cmdSaveButton.Click
        If countqry("tblproductclass", "code='" & code.Text & "'") > 0 And mode.Text <> "edit" Then
            XtraMessageBox.Show("Code already exists!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            code.Focus()
            Exit Sub

        ElseIf txtUnit.Text = "" Then
            XtraMessageBox.Show("Please select unit measurement!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUnit.Focus()
            Exit Sub

        ElseIf txtCategory.Text = "" Then
            XtraMessageBox.Show("Please select category!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCategory.Focus()
            Exit Sub

        ElseIf txtClassification.Text = "" Then
            XtraMessageBox.Show("Please select product classification!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClassification.Focus()
            Exit Sub

        ElseIf txtDescription.Text = "" Then
            XtraMessageBox.Show("Please enter product name!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtDescription.Focus()
            Exit Sub
        End If
        If XtraMessageBox.Show("Are you sure you want to continue? " & todelete, GlobalSystemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If mode.Text = "edit" Then
                com.CommandText = "update tblproducts set productname='" & rchar(txtDescription.Text) & "',categoryid='" & categorycode.Text & "',categoryname='" & rchar(txtCategory.Text) & "', classcode='" & classcode.Text & "', classificationname='" & rchar(txtClassification.Text) & "',unit='" & txtUnit.Text & "' " & If(ckpooption.SelectedIndex = 0, ",noninventory=1", ",noninventory=0") & If(ckpooption.SelectedIndex = 1, ",consumable=1", ",consumable=0") & If(ckpooption.SelectedIndex = 2, ",ppe=1", ",ppe=0") & " where productid='" & code.Text & "'" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                com.CommandText = "insert into tblproducts set productname='" & rchar(txtDescription.Text) & "',categoryid='" & categorycode.Text & "',categoryname='" & rchar(txtCategory.Text) & "', classcode='" & classcode.Text & "', classificationname='" & rchar(txtClassification.Text) & "',unit='" & txtUnit.Text & "' " & If(ckpooption.SelectedIndex = 0, ",noninventory=1", ",noninventory=0") & If(ckpooption.SelectedIndex = 1, ",consumable=1", ",consumable=0") & If(ckpooption.SelectedIndex = 2, ",ppe=1", ",ppe=0") & "" : com.ExecuteNonQuery()
                code.Text = "" : mode.Text = "" : txtDescription.Text = "" : txtDescription.Focus() : productid.Text = "SYSTEM GENERATED"
                XtraMessageBox.Show("Item successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If frmProductManagement.Visible = True Then
                frmProductManagement.LoadReport()
            End If
        End If
    End Sub

    Public Sub showInfo()
        If code.Text = "" Then Exit Sub
        dst = Nothing : dst = New DataSet
        msda = New MySqlDataAdapter("select *, CASE WHEN noninventory = 1 THEN 0 WHEN consumable = 1 then 1 when ppe = 1 then 2 else -1 END as InventoryType from tblproducts where productid='" & code.Text & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                txtDescription.Text = .Rows(cnt)("productname").ToString
                txtUnit.Text = .Rows(cnt)("unit").ToString
                categorycode.Text = .Rows(cnt)("categoryid").ToString
                txtCategory.EditValue = .Rows(cnt)("categoryid").ToString
                classcode.Text = .Rows(cnt)("classcode").ToString
                txtClassification.EditValue = .Rows(cnt)("classcode").ToString
                ckpooption.SelectedIndex = CInt(.Rows(cnt)("InventoryType").ToString)
            End With
        Next
    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar() = Chr(13) Then
            cmdSaveButton.PerformClick()
        End If
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        frmProductMeasurement.ShowDialog(Me)
        LoadToComboBox("unitname", "tblproductunit", txtUnit, True)
    End Sub

    Private Sub cmdCategory_Click(sender As Object, e As EventArgs) Handles cmdCategory.Click
        frmProductCategory.ShowDialog(Me)
        LoadCategory()
    End Sub

    Private Sub cmdClassification_Click(sender As Object, e As EventArgs) Handles cmdClassification.Click
        frmProductClass.categorycode.Text = categorycode.Text
        frmProductClass.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class