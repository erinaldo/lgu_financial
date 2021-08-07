Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.IO
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Office.Crypto


Public Class frmCompanySettings

#Region "COMPANY SETTINGS"

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCompanySettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        If LCase(globaluser) = "root" Then
            cmdResetDatabase.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdResetDatabase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If globalAllowEdit = True Or LCase(globaluser) = "root" Then
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            cmdSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        LoadAccountInfor()
        ShowCompanyInfo()
    End Sub

    Public Sub LoadAccountInfor()
        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtMayorName, gridMayorName, Me)
        XgridHideColumn({"accountid"}, gridMayorName)

        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtViceMayorName, gridViceMayor, Me)
        XgridHideColumn({"accountid"}, gridViceMayor)

        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtAccountantName, gridAccountantName, Me)
        XgridHideColumn({"accountid"}, gridAccountantName)

        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtTreasurerName, gridTreasurerName, Me)
        XgridHideColumn({"accountid"}, gridTreasurerName)

        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtBudgetName, gridBudgetName, Me)
        XgridHideColumn({"accountid"}, gridBudgetName)

        LoadXgridLookupSearch("select accountid, fullname as 'Select'  from tblaccounts order by fullname asc", "tblaccounts", txtHrmdName, gvHrmdName, Me)
        XgridHideColumn({"accountid"}, gvHrmdName)
    End Sub

    Public Sub ShowCompanyInfo()
        Try
            'ClearFields()
            Dim imgBytes As Byte() = Nothing
            Dim stream As MemoryStream = Nothing
            Dim img As Image = Nothing

            Dim imgBytes2 As Byte() = Nothing
            Dim stream2 As MemoryStream = Nothing
            Dim img2 As Image = Nothing

            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select * from tblcompanysettings", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    companyid.Text = .Rows(cnt)("companycode").ToString()
                    txtinitialcode.Text = .Rows(cnt)("initialcode").ToString()
                    txtcomp.Text = .Rows(cnt)("companyname").ToString()
                    txtadd.Text = .Rows(cnt)("compadd").ToString()
                    txttell.Text = .Rows(cnt)("telephone").ToString()
                    txtemail.Text = .Rows(cnt)("email").ToString()
                    txtweb.Text = .Rows(cnt)("website").ToString()

                    txtLogoWidth.Text = .Rows(cnt)("logowidth")
                    If .Rows(cnt)("logo").ToString() <> "" Then
                        imgBytes = CType(.Rows(cnt)("logo"), Byte())
                        stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                        img = Image.FromStream(stream)
                        piclogo.Image = img
                    End If
                    txtLogoUrl.Text = .Rows(cnt)("logourl").ToString

                    txtMayorName.EditValue = .Rows(cnt)("mayorname").ToString
                    txtMayorPosition.Text = .Rows(cnt)("mayorposition").ToString

                    txtViceMayorName.EditValue = .Rows(cnt)("vicemayorname").ToString
                    txtViceMayorPosition.Text = .Rows(cnt)("vicemayorposition").ToString

                    txtAccountantName.EditValue = .Rows(cnt)("accountantname").ToString
                    txtAccountantPosition.Text = .Rows(cnt)("accountantposition").ToString

                    txtTreasurerName.EditValue = .Rows(cnt)("treasurermame").ToString
                    txtTreasurerPosition.Text = .Rows(cnt)("treasurerposition").ToString

                    txtBudgetName.EditValue = .Rows(cnt)("budgetname").ToString
                    txtBudgetPosition.Text = .Rows(cnt)("budgetposition").ToString

                    txtHrmdName.EditValue = .Rows(cnt)("hrmdname").ToString
                    txtHrmdPosition.Text = .Rows(cnt)("hrmdposition").ToString
                End With
            Next
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub piclogo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles piclogo.Validating
        ResizeImage(piclogo, Val(txtLogoWidth.Text), Me)
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

#End Region

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If txtLogoWidth.Text = "" Then
            XtraMessageBox.Show("Please enter logo width!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLogoWidth.Focus()
            Exit Sub
        End If

        ResizeImage(piclogo, Val(txtLogoWidth.Text), Me)
        Try
            If countqry("tblcompanysettings", "companycode='" & companyid.Text & "'") = 0 Then
                com.CommandText = "insert into tblcompanysettings set companycode='" & companyid.Text & "', initialcode='" & txtinitialcode.Text & "', companyname='" & txtcomp.Text & "', compadd='" & txtadd.Text & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logowidth='" & Val(txtLogoWidth.Text) & "',logourl='" & txtLogoUrl.Text & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblcompanysettings set initialcode='" & txtinitialcode.Text & "', companyname='" & txtcomp.Text & "', compadd='" & txtadd.Text & "', telephone='" & txttell.Text & "', email='" & txtemail.Text & "', website='" & txtweb.Text & "',logowidth='" & Val(txtLogoWidth.Text) & "',logourl='" & txtLogoUrl.Text & "'" : com.ExecuteNonQuery()
            End If
            UpdateImage("companycode='" & companyid.Text & "' and companycode='" & companyid.Text & "'", "logo", "tblcompanysettings", piclogo, Me)


            If System.IO.File.Exists(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png")
            End If
            If Not piclogo.Image Is Nothing Then
                piclogo.Image.Save(Application.StartupPath.ToString & "\img\" & companyid.Text & ".png", System.Drawing.Imaging.ImageFormat.Png)
            End If

            XtraMessageBox.Show("Setting Successfully Updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadcompsettings()

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch errMS As Exception
            XtraMessageBox.Show("Form:" & Me.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        cmdSave.PerformClick()
    End Sub

    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdResetDatabase.ItemClick
        frmResetDatabase.ShowDialog(Me)
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles cmdSaveSignatories.Click
        com.CommandText = "update tblcompanysettings set mayorname='" & rchar(txtMayorName.EditValue) & "', mayorposition='" & rchar(txtMayorPosition.Text) & "', vicemayorname='" & rchar(txtViceMayorName.EditValue) & "', vicemayorposition='" & rchar(txtViceMayorPosition.Text) & "', accountantname='" & rchar(txtAccountantName.EditValue) & "', accountantposition='" & rchar(txtAccountantPosition.Text) & "', treasurermame='" & rchar(txtTreasurerName.EditValue) & "', treasurerposition='" & rchar(txtTreasurerPosition.Text) & "', budgetname='" & rchar(txtBudgetName.EditValue) & "', budgetposition='" & rchar(txtBudgetPosition.Text) & "', hrmdname='" & rchar(txtHrmdName.EditValue) & "', hrmdposition='" & rchar(txtHrmdPosition.Text) & "'" : com.ExecuteNonQuery()
        loadcompsettings()
        XtraMessageBox.Show("Setting Successfully Updated", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class