Imports DevExpress.XtraGrid.Design
Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Xml

Public Class frmAccountInformation

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequestType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        If globalUserRequiredUpdateInfo = True Then
            Me.StartPosition = FormStartPosition.CenterScreen
        End If

        txtSystemIcon.Items.Clear()
        For Each folder In System.IO.Directory.GetDirectories(Application.StartupPath & "\Icon")
            txtSystemIcon.Items.Add(folder.Replace(Application.StartupPath & "\Icon\", ""))
        Next
        com.CommandText = "select * from tblaccounts where accountid = '" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "'" : rst = com.ExecuteReader
        While rst.Read
            txtName.Text = rst("fullname").ToString
            txtNickname.Text = rst("nickname").ToString
            txtPosition.Text = rst("designation").ToString
            If rst("emailaddress").ToString = "" Then
                'Dim word As String() = globalserverEmailAddress.Split("@")
                'txtEmail.Text = "username@" + word(1)
                'txtEmail.BackColor = Color.Red
                'txtEmail.ForeColor = Color.White
            Else
                txtEmail.Text = rst("emailaddress").ToString
                txtEmail.BackColor = Color.White
                txtEmail.ForeColor = DefaultForeColor
            End If
            txtContactNumber.Text = rst("contactnumber").ToString
            txtSystemIcon.Text = rst("iconfolderclient").ToString
            txtBgColor.Text = rst("bgcolorclient").ToString
            txtFontColor.Text = rst("fontcolorclient").ToString
            ChangeColor(rst("bgcolorclient").ToString)
            ShowImage("profileimg", imgProfile)
        End While
        rst.Close()
        LoadSchemeStyle()
        LoadGridview()
        livePreview()
    End Sub

    Private Sub cmdset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdset.Click
        If txtNickname.Text = "" Then
            MessageBox.Show("Please enter your nickname!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNickname.Focus()
            Exit Sub
        ElseIf txtContactNumber.Text = "" Then
            MessageBox.Show("Please enter your contact number!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtContactNumber.Focus()
            Exit Sub
        ElseIf txtCurrentPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter your current password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCurrentPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please enter you new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtNewPassword.Focus()
            Exit Sub
        ElseIf txtVerifyPassword.Text = "" And ckChangePassword.Checked = True Then
            MessageBox.Show("Please verify your new password!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text And ckChangePassword.Checked = True Then
            MessageBox.Show("Your password did not match! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        ElseIf countqry("tblaccounts", "accountid='" & globaluserid & "' and password='" & EncryptTripleDES(UCase(globalusername) + txtCurrentPassword.Text) & "'") = 0 And ckChangePassword.Checked = True Then
            MessageBox.Show("Your current password is invalid! please try again", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtVerifyPassword.Focus()
            Exit Sub
        End If
        If MessageBox.Show("Are you sure you want to update changes? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Windows.Forms.Application.DoEvents()
            End While
            com.CommandText = "update tblaccounts set nickname='" & rchar(txtNickname.Text) & "', designation='" & rchar(txtPosition.Text) & "', emailaddress='" & txtEmail.Text & "', contactnumber='" & txtContactNumber.Text & "', iconfolderclient='" & txtSystemIcon.Text & "',bgcolorclient='" & txtBgColor.Text & "',fontcolorclient='" & txtFontColor.Text & "', requiredupdate=0 where accountid='" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "' " : com.ExecuteNonQuery()

            If ckPicChanged.Checked = True Then
                UpdateImage("accountid='" & globaluserid & "'", "profileimg", "tblaccounts", Imaging.ImageFormat.Png, imgProfile)
            End If

            If ckChangePassword.Checked = True Then
                com.CommandText = "update tblaccounts set password='" & EncryptTripleDES(UCase(globalusername) + txtVerifyPassword.Text) & "', webpassword=DES_ENCRYPT('" & globalusername + txtVerifyPassword.Text & "','kira')  where accountid='" & If(globalAssistantUserId <> "", globalAssistantUserId, globaluserid) & "'" : com.ExecuteNonQuery()
            End If
            If mode.Text = "startup" Then
                MessageBox.Show("Hello " & txtNickname.Text & "! Welcome to new coffeecup system, and your account information successfully updated.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                globalUserRequiredUpdateInfo = False
                MessageBox.Show("your account successfully updated!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            LoadAccountDetails(globaluserid)
            Me.Close()
        End If

    End Sub

    Private Sub imgProfile_EditValueChanged(sender As Object, e As EventArgs) Handles imgProfile.EditValueChanged
        ckPicChanged.Checked = True
    End Sub

    Private Sub imgProfile_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles imgProfile.Validating
        ResizeImage(imgProfile, 450)
    End Sub

    Private Sub ckEnableEmailNotification_CheckedChanged(sender As Object, e As EventArgs) Handles ckChangePassword.CheckedChanged
        If ckChangePassword.Checked = True Then
            txtCurrentPassword.ReadOnly = False
            txtNewPassword.ReadOnly = False
            txtVerifyPassword.ReadOnly = False
        Else
            txtCurrentPassword.ReadOnly = True
            txtNewPassword.ReadOnly = True
            txtVerifyPassword.ReadOnly = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            txtBgColor.Text = ColorDialog1.Color.R.ToString & "," & ColorDialog1.Color.G.ToString & "," & ColorDialog1.Color.B.ToString
            ChangeColor(txtBgColor.Text)
        End If
    End Sub

    Public Sub ChangeColor(ByVal RGBString As String)
        Dim RGB As String() = RGBString.Split(",")
        txtBgColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
        txtBgColor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(Val(RGB(0)), Byte), Integer), CType(CType(Val(RGB(1)), Byte), Integer), CType(CType(Val(RGB(2)), Byte), Integer))
    End Sub

    Private Sub txtBgColor_TextChanged(sender As Object, e As EventArgs) Handles txtSystemIcon.TextChanged, txtBgColor.TextChanged, txtFontColor.TextChanged
        MainForm.LoadSystemAppearance(txtSystemIcon.Text, txtBgColor.Text, txtFontColor.Text)
    End Sub

#Region "GRIDVIEW APPEARANCE"
    Public grid As DevExpress.XtraGrid.Views.Grid.GridView

    Public Sub LoadSchemeStyle()
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        Dim styles As XmlNodeList = doc.SelectNodes("/Styles/*")

        txtschemestyle.Properties.Items.Clear()
        txtschemestyle.Properties.Items.Add("Default")
        For Each scheme In styles
            txtschemestyle.Properties.Items.Add(scheme.Attributes.GetNamedItem("name").Value)
        Next
    End Sub

    Public Sub LoadGridview()
        com.CommandText = "select * from tblgridsettings where userid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            ck_enablle_features.Checked = rst("grid_enableappearance")
            txtfontfamily.Text = rst("grid_fontfamily").ToString
            txtforecolor.Text = rst("grid_forntcolor").ToString
            txtFontSize.Text = rst("grid_fontsize").ToString
            txtschemestyle.Text = rst("grid_schemestyle").ToString
            txtpaintstyle.Text = rst("grid_paintstyle").ToString
            txtGridPadding.Text = rst("grid_padding").ToString
            ck_header_bold.Checked = rst("grid_header_bold")
            ck_main_bold.Checked = rst("grid_main_bold")
            ck_footer_bold.Checked = rst("grid_footer_bold")
            ck_evenrowenable.Checked = rst("grid_evenrowenable")
            ck_ShowHorzLines.Checked = rst("grid_ShowHorzLines")
            ck_ShowVertLines.Checked = rst("grid_ShowVertLines")
            ck_indicatorline.Checked = rst("grid_indicatorline")
            ck_enablefilterappearance.Checked = rst("grid_filterappearance")

        End While
        rst.Close()
        If ck_enablle_features.Checked = False Then
            FilterFeatures()
        End If
    End Sub

    Private Sub cmdAppearanceSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAppearanceSave1.Click
        If countqry("tblgridsettings", "userid='" & globaluserid & "'") = 0 Then
            com.CommandText = "insert into tblgridsettings set userid='" & globaluserid & "', grid_enableappearance=" & ck_enablle_features.CheckState & ", " _
                               + " grid_fontfamily='" & txtfontfamily.Text & "'," _
                               + " grid_forntcolor = '" & txtforecolor.Text & "', " _
                               + " grid_fontsize='" & txtFontSize.Text & "', " _
                               + " grid_schemestyle='" & txtschemestyle.Text & "', " _
                               + " grid_paintstyle='" & txtpaintstyle.Text & "', " _
                               + " grid_padding='" & txtGridPadding.Text & "', " _
                               + " grid_header_bold=" & ck_header_bold.CheckState & ", " _
                               + " grid_main_bold=" & ck_main_bold.CheckState & ", " _
                               + " grid_footer_bold=" & ck_footer_bold.CheckState & ", " _
                               + " grid_evenrowenable=" & ck_evenrowenable.CheckState & ", " _
                               + " grid_ShowHorzLines=" & ck_ShowHorzLines.CheckState & ", " _
                               + " grid_ShowVertLines=" & ck_ShowVertLines.CheckState & ", " _
                               + " grid_indicatorline=" & ck_indicatorline.CheckState & ", " _
                               + " grid_filterappearance=" & ck_enablefilterappearance.CheckState & ";" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblgridsettings set grid_enableappearance=" & ck_enablle_features.CheckState & ", " _
                               + " grid_fontfamily='" & txtfontfamily.Text & "'," _
                               + " grid_forntcolor = '" & txtforecolor.Text & "', " _
                               + " grid_fontsize='" & txtFontSize.Text & "', " _
                               + " grid_schemestyle='" & txtschemestyle.Text & "', " _
                               + " grid_paintstyle='" & txtpaintstyle.Text & "', " _
                               + " grid_padding='" & txtGridPadding.Text & "', " _
                               + " grid_header_bold=" & ck_header_bold.CheckState & ", " _
                               + " grid_main_bold=" & ck_main_bold.CheckState & ", " _
                               + " grid_footer_bold=" & ck_footer_bold.CheckState & ", " _
                               + " grid_evenrowenable=" & ck_evenrowenable.CheckState & ", " _
                               + " grid_ShowHorzLines=" & ck_ShowHorzLines.CheckState & ", " _
                               + " grid_ShowVertLines=" & ck_ShowVertLines.CheckState & ", " _
                               + " grid_indicatorline=" & ck_indicatorline.CheckState & ", " _
                               + " grid_filterappearance=" & ck_enablefilterappearance.CheckState & " where userid='" & globaluserid & "';" : com.ExecuteNonQuery()
        End If
        LoadUserGridAppearance()
        MessageBox.Show("Gridview appearance successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ck_enablle_features_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ck_enablle_features.CheckedChanged
        FilterFeatures()
    End Sub
    Public Sub FilterFeatures()
        If ck_enablle_features.Checked = False Then
            txtfontfamily.Text = "Tahoma"
            txtforecolor.Text = "Black"
            txtFontSize.Text = "8.25"
            txtschemestyle.Text = "Default"
            txtpaintstyle.Text = "Default"

            ck_header_bold.Checked = False
            ck_main_bold.Checked = False
            ck_footer_bold.Checked = False
            ck_evenrowenable.Checked = False
            ck_ShowHorzLines.Checked = False
            ck_ShowVertLines.Checked = False
            ck_indicatorline.Checked = False
            ck_enablefilterappearance.Checked = False

            txtfontfamily.Enabled = False
            txtforecolor.Enabled = False
            txtFontSize.Enabled = False
            txtschemestyle.Enabled = False
            txtpaintstyle.Enabled = False
            ck_header_bold.Enabled = False
            ck_main_bold.Enabled = False
            ck_footer_bold.Enabled = False
            ck_evenrowenable.Enabled = False
            ck_ShowHorzLines.Enabled = False
            ck_ShowVertLines.Enabled = False
            ck_indicatorline.Enabled = False
            ck_enablefilterappearance.Enabled = False

        Else
            txtfontfamily.Enabled = True
            txtforecolor.Enabled = True
            txtFontSize.Enabled = True
            txtschemestyle.Enabled = True
            txtpaintstyle.Enabled = True
            ck_header_bold.Enabled = True
            ck_main_bold.Enabled = True
            ck_footer_bold.Enabled = True
            ck_evenrowenable.Enabled = True
            ck_ShowHorzLines.Enabled = True
            ck_ShowVertLines.Enabled = True
            ck_indicatorline.Enabled = True
            ck_enablefilterappearance.Enabled = True
        End If
    End Sub

    Public Sub livePreview()
        FloatingChangeAppearance(GridView1)
        LoadXgrid(" select * from (SELECT 'Rodrigo Duterte' as President, '1945' as 'Born',concat( TIMESTAMPDIFF(YEAR, '1945-01-01', CURDATE()),' years old') as 'Age', '30 Jun 2016' as 'Took office', 'PDP-Laban' as 'Party'  union all " _
                + " select 'Benigno Aquino III', '1960',concat( TIMESTAMPDIFF(YEAR, '1960-01-01', CURDATE()),' years old'), '30 Jun 2010', 'Liberal' union all " _
                + " select 'Gloria Macapagal Arroyo', '1947',concat( TIMESTAMPDIFF(YEAR, '1947-01-01', CURDATE()),' years old'), '20 Jan 2001', 'Lakas-CMD' union all " _
                + " select 'Joseph Estrada', '1937',concat( TIMESTAMPDIFF(YEAR, '1937-01-01', CURDATE()),' years old'), '30 Jun 1998', 'LAMMP' union all " _
                + " select 'Fidel Ramos', '1928',concat( TIMESTAMPDIFF(YEAR, '1928-01-01', CURDATE()),' years old'), '30 Jun 1992', 'Lakas-NUCD' union all " _
                + " select 'Corazon Aquino', '1933–2009','Lived: 76 years', '25 Feb 1986', 'UNIDO ') as a", "a", Em, GridView1, Me)
        XgridColAlign({"Born", "Age", "Took office", "Party"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

    End Sub

    Private Sub txtfontfamily_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfontfamily.SelectedIndexChanged,
        txtforecolor.EditValueChanged, txtFontSize.EditValueChanged, txtschemestyle.EditValueChanged, txtpaintstyle.EditValueChanged, txtGridPadding.SelectedIndexChanged
        FloatingChangeAppearance(GridView1)

    End Sub

    Private Sub Ck_header_bold_CheckedChanged(sender As Object, e As EventArgs) Handles ck_header_bold.CheckedChanged, ck_enablefilterappearance.CheckedChanged, ck_ShowVertLines.CheckedChanged, ck_ShowHorzLines.CheckedChanged, ck_evenrowenable.CheckedChanged, ck_indicatorline.CheckedChanged, ck_footer_bold.CheckedChanged, ck_main_bold.CheckedChanged
        FloatingChangeAppearance(GridView1)
    End Sub

    Public Function FloatingChangeAppearance(ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim gvScheme As XAppearances = New XAppearances(Application.StartupPath & "\DevExpress.XtraGrid.Appearances.xml")
        xgrid.OptionsSelection.EnableAppearanceFocusedCell = False
        If ck_enablle_features.Checked = True Then
            gvScheme.LoadScheme(txtschemestyle.Text, xgrid)
            xgrid.PaintStyleName = txtpaintstyle.Text
            If ck_indicatorline.Checked = True Then
                xgrid.OptionsView.ShowIndicator = True
            Else
                xgrid.OptionsView.ShowIndicator = False
            End If

            If ck_evenrowenable.Checked = True Then
                xgrid.OptionsView.EnableAppearanceEvenRow = True
                xgrid.OptionsView.EnableAppearanceOddRow = True
            Else
                xgrid.OptionsView.EnableAppearanceEvenRow = False
                xgrid.OptionsView.EnableAppearanceOddRow = False
            End If

            If ck_ShowHorzLines.Checked = True Then
                xgrid.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True
            Else
                xgrid.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False
            End If

            If ck_ShowVertLines.Checked = True Then
                xgrid.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True
            Else
                xgrid.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False
            End If
            If ck_header_bold.Checked = True Then
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.HeaderPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupRow.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If ck_main_bold.Checked = True Then
                xgrid.Appearance.Row.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.Row.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            If ck_footer_bold.Checked = True Then
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Else
                xgrid.Appearance.FooterPanel.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
                xgrid.Appearance.GroupFooter.Font = New System.Drawing.Font(txtfontfamily.Text, txtFontSize.Text, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            End If

            xgrid.Appearance.HeaderPanel.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.Row.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.FooterPanel.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.Appearance.GroupFooter.ForeColor = Color.FromName(txtforecolor.Text)
            xgrid.UserCellPadding = New Padding(txtGridPadding.EditValue)
        Else
            gvScheme.LoadScheme("Default", xgrid)
            xgrid.PaintStyleName = "Default"
        End If
        Return xgrid
    End Function


#End Region

End Class