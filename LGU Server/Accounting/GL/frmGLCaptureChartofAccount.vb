Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports MySql.Data.MySqlClient
Imports DevExpress.Utils
Imports Excel = Microsoft.Office.Interop.Excel
Imports DevExpress.XtraSplashScreen

Public Class frmGLCaptureChartofAccount
    Public DataBook As Excel.Workbook
    Public DS_ChartOfAccount As Excel.Worksheet
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmGLCaptureChartofAccount_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmGLCaptureChartofAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        com.CommandText = "DROP TABLE IF EXISTS tmpglitem;" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE tmpglitem (  `groupcode` varchar(50) NOT NULL DEFAULT '',  `keycode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(50) NOT NULL DEFAULT '',  `itemname` varchar(500) NOT NULL DEFAULT '',  `parent` varchar(50) NOT NULL DEFAULT '',  `glgroup` tinyint(1) NOT NULL DEFAULT '0',  `gl` tinyint(1) NOT NULL DEFAULT '0',  `sl` tinyint(1) NOT NULL DEFAULT '0',  `bold` tinyint(1) NOT NULL DEFAULT '0',  `summary` tinyint(1) NOT NULL DEFAULT '0',  `unappropriate` tinyint(1) NOT NULL DEFAULT '0',  `treasury` tinyint(1) NOT NULL DEFAULT '0',  `cedula` tinyint(1) NOT NULL DEFAULT '0',  `expenditure` tinyint(1) NOT NULL DEFAULT '0',  `level` int(10) unsigned NOT NULL DEFAULT '0',  `remarks` text,  `latestamount` double NOT NULL DEFAULT '0',  `locked` tinyint(1) NOT NULL DEFAULT '0',  `debitentry` tinyint(1) NOT NULL DEFAULT '0',  PRIMARY KEY (`itemcode`)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=DYNAMIC;" : com.ExecuteNonQuery()
    End Sub

 

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If XtraMessageBox.Show("Are you sure you want to continue?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim errorLine As String = "" : Dim errorColumn As String = "" : Dim errorData As String = ""
            Try
                Dim CompleteQuery As String = ""
                Dim Cell As Excel.Range
                Dim ExcelApp As New Excel.Application
                DataBook = ExcelApp.Workbooks.Open(txtChartofAccounts.Text)
                DS_ChartOfAccount = DataBook.Worksheets("Sheet")
                'START ITEM CAPTURE

                ProgressBarControl1.Visible = True
                ProgressBarControl1.Properties.Step = 1
                ProgressBarControl1.Properties.PercentView = True
                ProgressBarControl1.Properties.Maximum = GetLastItemRow(txtChartofAccounts.Text)
                ProgressBarControl1.Properties.Minimum = 0
                ProgressBarControl1.Position = 0

                Dim arrayItem() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S"}

                com.CommandText = "DELETE FROM tmpglitem" : com.ExecuteNonQuery()
                For R = 2 To GetLastItemRow(txtChartofAccounts.Text)
                    Dim coulumnCount As Integer = 0
                    Dim groupcode As String = "" : Dim keycode As String = "" : Dim itemcode As String = "" : Dim itemname As String = "" : Dim parent As String = "" : Dim glgroup As Boolean : Dim gl As Boolean : Dim sl As Boolean : Dim bold As Boolean : Dim summary As Boolean : Dim unappropriate As Boolean : Dim treasury As Boolean : Dim cedula As Boolean : Dim expenditure As Boolean : Dim level As Integer = 0 : Dim remarks As String = "" : Dim latestamount As Double = 0 : Dim locked As Boolean : Dim debitentry As Boolean
                    'Dim g_group As String = "" : Dim g_code As String = "" : Dim g_desc As String = "" : Dim g_parent As String = "" : Dim g_glgroup As Boolean : Dim g_gl As Boolean : Dim g_sl As Boolean : Dim g_level As Integer : Dim g_debit As Boolean : Dim coulumnCount As Integer = 0
                    errorLine = R
                    For Each valueArr As String In arrayItem
                        For Each Cell In DS_ChartOfAccount.Range(valueArr & R)
                            Dim value_x As String = ""
                            value_x = System.Convert.ToString(Cell.Cells.Value2)
                            errorColumn = coulumnCount
                            errorData = value_x
                            If coulumnCount = 0 Then
                                groupcode = value_x
                            ElseIf coulumnCount = 1 Then
                                keycode = value_x
                            ElseIf coulumnCount = 2 Then
                                itemcode = value_x
                            ElseIf coulumnCount = 3 Then
                                itemname = value_x
                            ElseIf coulumnCount = 4 Then
                                parent = value_x
                            ElseIf coulumnCount = 5 Then
                                glgroup = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 6 Then
                                gl = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 7 Then
                                sl = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 8 Then
                                bold = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 9 Then
                                summary = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 10 Then
                                unappropriate = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 11 Then
                                treasury = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 12 Then
                                cedula = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 13 Then
                                expenditure = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 14 Then
                                level = If(value_x = "", 0, value_x)
                            ElseIf coulumnCount = 15 Then
                                remarks = value_x
                            ElseIf coulumnCount = 16 Then
                                latestamount = If(value_x = "", 0, value_x)
                            ElseIf coulumnCount = 17 Then
                                locked = If(value_x = "", 0, CBool(value_x))
                            ElseIf coulumnCount = 18 Then
                                debitentry = If(value_x = "", 0, CBool(value_x))
                            End If
                            coulumnCount = coulumnCount + 1
                        Next
                    Next
                    'CompleteQuery += "insert into tblglitem set  groupcode='" & groupcode & "',keycode='" & keycode & "', itemcode='" & itemcode & "', itemname='" & rchar(itemname) & "', parent='" & parent & "',glgroup=" & glgroup & ",gl=" & gl & ",sl=" & sl & ",bold=" & bold & ",summary=" & summary & ",unappropriate=" & unappropriate & ", treasury=" & treasury & ",cedula = " & cedula & ", expenditure=" & expenditure & ", level=" & level & ",remarks='" & rchar(remarks) & "',latestamount='" & Val(CC(latestamount)) & "',locked=" & locked & ", debitentry=" & debitentry & ";" & Environment.NewLine
                    com.CommandText = "insert into tmpglitem set  groupcode='" & groupcode & "',keycode='" & keycode & "', itemcode='" & itemcode & "', itemname='" & rchar(itemname) & "', parent='" & parent & "',glgroup=" & glgroup & ",gl=" & gl & ",sl=" & sl & ",bold=" & bold & ",summary=" & summary & ",unappropriate=" & unappropriate & ", treasury=" & treasury & ",cedula = " & cedula & ", expenditure=" & expenditure & ", level=" & level & ",remarks='" & rchar(remarks) & "',latestamount='" & Val(CC(latestamount)) & "',locked=" & locked & ", debitentry=" & debitentry & ";" : com.ExecuteNonQuery()

                    ProgressBarControl1.PerformStep()
                    ProgressBarControl1.Update()
                Next
                'For Each strLineItem As String In CompleteQuery.Split(vbLf)
                '    If strLineItem <> "" Then
                '        com.CommandText = strLineItem : com.ExecuteNonQuery()
                '        ProgressBarControl1.PerformStep()
                '        ProgressBarControl1.Update()
                '    End If
                'Next

                DataBook.Close(False)
                ExcelApp.Quit()
                com.CommandText = "delete from tblglitem;" : com.ExecuteNonQuery()
                com.CommandText = "insert into tblglitem select * from tmpglitem" : com.ExecuteNonQuery()
                XtraMessageBox.Show("Chart of account successfully updated!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBarControl1.Position = 0
                ProgressBarControl1.Visible = False
                Me.Close()
            Catch fileException As Exception
                XtraMessageBox.Show(fileException.Message & " at line " & errorLine & " column " & errorColumn & " value " & errorData, compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub ButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtChartofAccounts.ButtonClick
        Dim objOpenFileDialog As New OpenFileDialog
        With objOpenFileDialog
            .Filter = "Excell files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Open File Dialog"
        End With

        If objOpenFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtChartofAccounts.Text = objOpenFileDialog.FileName
        End If
        objOpenFileDialog.Dispose()
        objOpenFileDialog = Nothing
    End Sub

    Public Function GetLastGroupRow(ByVal location As String) As Long
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        GetLastGroupRow = 0
        With xlApp
            .Visible = False
            xlWb = .Workbooks.Open(location)
            xlsheet = xlWb.Sheets("Sheet")
            With xlsheet
                GetLastGroupRow = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            End With
            xlWb.Close(False)
            xlApp.Quit()
        End With
        Return GetLastGroupRow
    End Function

    Public Function GetLastItemRow(ByVal location As String) As Long
        Dim xlApp As New Excel.Application
        Dim xlWb As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        GetLastItemRow = 0
        With xlApp
            .Visible = False
            xlWb = .Workbooks.Open(location)
            xlsheet = xlWb.Sheets("Sheet")
            With xlsheet
                GetLastItemRow = .Range("A" & .Rows.Count).End(Excel.XlDirection.xlUp).Row
            End With
            xlWb.Close(False)
            xlApp.Quit()
        End With
        Return GetLastItemRow
    End Function
End Class