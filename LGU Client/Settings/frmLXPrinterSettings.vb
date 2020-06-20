Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports System.Drawing.Printing

Public Class frmLXPrinterSettings
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmPOSPrinterSettings_Script_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInstalledPrinter()
        LoadSystemFont()
        txtFontName.Text = "Consolas"
        LoadPrinterSettings()
        ckTemporaryDisablePrinting.Checked = globalEnableTemporaryDisablePrinting
    End Sub

    Private Sub LoadSystemFont()
        txtFontName.Items.Clear()
        For Each oFont As FontFamily In FontFamily.Families
            txtFontName.Items.Add(oFont.Name)
        Next
    End Sub

    Private Sub LoadInstalledPrinter()
        Dim i As Integer
        txtPrinterName.Items.Clear()
        Dim pkInstalledPrinters As String
        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            txtPrinterName.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Public Sub LoadPrinterSettings()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            ckEnableLxPrinter.Checked = True
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim Split As String() = br.Split(",")

            txtPrinterName.Text = Split(0)
            txtSPaperWidth.Text = Split(1)
            txtSMarginTop.Text = Split(2)
            txtSMarginLeft.Text = Split(3)

            txtFontName.Text = Split(4)
            txtFontSize.Text = Split(5)
        End If
    End Sub

    Private Sub cmdSaveSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSettings.Click
        If txtPrinterName.Text = "" Then
            MessageBox.Show("Please select printer device!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPrinterName.Focus()
            Exit Sub
        ElseIf txtSPaperWidth.Text = "" Then
            MessageBox.Show("Please enter paper width!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSPaperWidth.Focus()
            Exit Sub
        ElseIf txtSMarginTop.Text = "" Then
            MessageBox.Show("Please enter top margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSMarginTop.Focus()
            Exit Sub

        ElseIf txtSMarginLeft.Text = "" Then
            MessageBox.Show("Please enter left margin!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSMarginLeft.Focus()
            Exit Sub

        ElseIf txtFontName.Text = "" Then
            MessageBox.Show("Please select font name!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFontName.Focus()
            Exit Sub
        ElseIf txtFontSize.Text = "" Then
            MessageBox.Show("Please select font size!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtFontSize.Focus()
            Exit Sub

        End If
        If MessageBox.Show("Are you sure you want to save settings? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            While MainForm.BackgroundWorker1.IsBusy()
                Windows.Forms.Application.DoEvents()
            End While
            Try
                If ckEnableLxPrinter.Checked = True Then
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                    Dim detailsFile As StreamWriter = Nothing
                    detailsFile = New StreamWriter(file_PrinterSettings, True)
                    detailsFile.WriteLine(txtPrinterName.Text & "," & txtSPaperWidth.Text & "," & txtSMarginTop.Text & "," & txtSMarginLeft.Text & "," & txtFontName.Text & "," & txtFontSize.Text)
                    detailsFile.Close()

                    If ckEnableLxPrinter.Checked = True Then
                        LoadLXPrinterSetup()
                    End If
                    globalEnableTemporaryDisablePrinting = ckTemporaryDisablePrinting.CheckState
                Else
                    If System.IO.File.Exists(file_PrinterSettings) = True Then
                        System.IO.File.Delete(file_PrinterSettings)
                    End If
                End If
                LoadPrinterSettings()
                MessageBox.Show("your settings successfully saved!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch errMYSQL As MySqlException
                MessageBox.Show("Message:" & errMYSQL.Message, vbCrLf _
                                & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Catch errMS As Exception
                MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub
      
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim details As String = "" : Dim BalanceSheet As String = ""
        Dim salefilelocation As String = System.IO.Path.GetTempPath

        details = PrintCenterText("LX PRINT TEST") & Environment.NewLine & Environment.NewLine
        details += PrintSpaceLine() & Environment.NewLine
        com.CommandText = "select * from tblaccounts where accountid='" & globaluserid & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintLeftText("Office: " & compOfficename, 0, ContentAlignment.MiddleLeft, 1)
            details += PrintLeftText("Fullname: " & rst("fullname").ToString, 0, ContentAlignment.MiddleLeft, 1)
            details += PrintLeftText("Position: " & rst("designation").ToString, 0, ContentAlignment.MiddleLeft, 1)
            details += PrintLeftText("Email: " & rst("emailaddress").ToString, 0, ContentAlignment.MiddleLeft, 1)
        End While
        rst.Close()
        details += PrintLeftText("System Date: " & Format(CDate(qryDate("dt", "current_timestamp as dt"))), 0, ContentAlignment.MiddleLeft, 1)
        details += PrintSpaceLine() & Environment.NewLine

        details += PrintCenterText("- Print test end -") & Environment.NewLine & Environment.NewLine
        ExecutePrintCommand(details, "DEFAULT")
    End Sub

    Private Sub cmdPrintLayout_Click(sender As Object, e As EventArgs) Handles cmdPrintLayout.Click
        ExecutePrintCommand(File.ReadAllText(Application.StartupPath.ToString & "\Printer\print-layout.txt"), "DEFAULT")
    End Sub

    Private Sub ckEnableLxPrinter_CheckedChanged(sender As Object, e As EventArgs) Handles ckEnableLxPrinter.CheckedChanged
        If ckEnableLxPrinter.Checked = True Then
            EnableControl(True)
        Else
            EnableControl(False)
        End If
    End Sub

    Public Function EnableControl(ByVal enable As Boolean)
        txtPrinterName.Enabled = enable
        txtSPaperWidth.Enabled = enable
        txtSMarginTop.Enabled = enable
        txtSMarginLeft.Enabled = enable

        txtFontName.Enabled = enable
        txtFontSize.Enabled = enable
        Return True
    End Function
End Class