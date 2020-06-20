Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Grid

Module reports
    Public openform As DevExpress.XtraEditors.XtraForm

    Public Function LoadReportSettings(ByVal rpt As XtraReport, ByVal form As String)
        If countqry("tblreportsetting", "formname='" & form & "'") = 0 Then
            com.CommandText = "insert into tblreportsetting set formname = '" & form & "'" : com.ExecuteNonQuery()
        End If
        com.CommandText = "select * from tblreportsetting where formname='" & form & "'" : rst = com.ExecuteReader
        While rst.Read
            rpt.Landscape = rst("landscape")
            If rst("paperkind").ToString = "Legal" Then
                rpt.PaperKind = PaperKind.Legal
            ElseIf rst("paperkind").ToString = "Short" Then
                rpt.PaperKind = PaperKind.Letter
            ElseIf rst("paperkind").ToString = "Wide For Export" Then
                rpt.PaperKind = PaperKind.A2
            Else
                rpt.PaperKind = PaperKind.Letter
            End If
        End While
        rst.Close()
    End Function
 
    Public Function CopyGridControl(ByVal grid As GridControl) As WinControlContainer
        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 0)
        winContainer.Size = New Size(0, 0)
        ' Set the grid as a wrapped object.
        'grid.MainView.PaintStyleName = "Web"
        grid.MainView.OptionsPrint.ShowPrintExportProgress = True
        winContainer.WinControl = grid
        Return winContainer
    End Function
    Public Function CopyChartControl(ByVal chart As ChartControl) As WinControlContainer

        ' Create a WinControlContainer object.
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 0)
        winContainer.Size = New Size(200, 100)

        ' Set the grid as a wrapped object.
        winContainer.WinControl = chart
        Return winContainer
    End Function
    Public Function CopyGridControl1(ByVal grid As GridControl) As WinControlContainer

        ' Create a WinControlContainer object.CopyGridControl
        Dim winContainer As New WinControlContainer()

        ' Set its location and size.
        winContainer.Location = New Point(0, 30)
        winContainer.Size = New Size(700, 100)

        ' Set the grid as a wrapped object.
        grid.MainView.OptionsPrint.ShowPrintExportProgress = True
        winContainer.WinControl = grid
        Return winContainer
    End Function

    Public Sub DxChartPreviewReport(ByVal fullquery As String, ByVal table As String, ByVal argumentdata As String, ByVal argumentvalue As String, ByVal charttitle As String, ByVal chart As ChartControl, ByVal vtype As ViewType, ByVal hidelegend As Boolean)
        'Dim pieChart As New ChartControl()

        ' Create a pie series.
        chart.Series.Clear()
        Dim series1 As New Series(charttitle, vtype)
        msda = Nothing : Dim dst = New DataSet : dst.Clear()
        msda = New MySqlDataAdapter(fullquery, conn)
        msda.SelectCommand.CommandTimeout = 6000000
        msda.Fill(dst, table)

        chart.DataSource = dst.Tables(table)
        ' Add the series to the chart.
        chart.Series.Add(series1)

        ' Adjust the value numeric options of the series.
        series1.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
        series1.PointOptions.ValueNumericOptions.Precision = 0

        series1.ArgumentScaleType = ScaleType.Auto
        series1.ArgumentDataMember = argumentdata
        series1.ShowInLegend = True
        series1.ValueScaleType = ScaleType.Numerical
        series1.ValueDataMembers.AddRange(New String() {argumentvalue})

        series1.LegendPointOptions.PointView = PointView.Argument
        series1.Label.TextPattern = "{A}: {VP:p0}"

        If vtype = ViewType.Pie3D Then
            ' Adjust the view-type-specific options of the series.
            CType(series1.View, Pie3DSeriesView).ExplodedPoints.Clear()
            CType(series1.View, Pie3DSeriesView).Depth = 20
            'CType(series1.View, Pie3DSeriesView).ExplodedPoints.Add(series1.Points(-1))
            CType(series1.View, Pie3DSeriesView).ExplodedDistancePercentage = 100
            '
            ' Detect overlapping of series labels.
             
            CType(chart.Diagram, SimpleDiagram3D).RotationType = RotationType.UseAngles
            CType(chart.Diagram, SimpleDiagram3D).RotationAngleX = -60
            CType(series1.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default
        End If
        'CType(series1.Label, PieSeriesLabel).Position = PieSeriesLabelPosition.TwoColumns


        ' Add a title to the chart and hide the legend.
        chart.Titles.Clear()
        Dim chartTitle1 As New ChartTitle()
        chartTitle1.Text = charttitle
        chart.Titles.Add(chartTitle1)
        chart.Legend.Visible = True
        ' Hide the legend (if necessary).
        chart.Legend.Visibility = hidelegend
    End Sub

    Public Sub TitleOrient(ByVal txtbox As DevExpress.XtraReports.UI.XRLabel, ByVal orient As String)
        If orient = "True" Then
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Else
            txtbox.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        End If
    End Sub

    Public Function getReportTemplateID()
        Dim strng = ""
        Try
            If CInt(countrecord("tblreporttemplate")) = 0 Then
                strng = "RPT100001"
            Else
                com.CommandText = "select rptid from tblreporttemplate order by right(rptid,6) desc limit 1" : rst = com.ExecuteReader()
                Dim removechar As Char() = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-".ToCharArray()
                Dim sb As New System.Text.StringBuilder
                While rst.Read
                    Dim str As String = rst("rptid").ToString
                    For Each ch As Char In str
                        If Array.IndexOf(removechar, ch) = -1 Then
                            sb.Append(ch)
                        End If
                    Next
                End While
                rst.Close()
                strng = "RPT" & Val(sb.ToString) + 1
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
        Return strng.ToString
    End Function

    Public Function PrintGeneralReportWithDate(ByVal reportAsof As Boolean, ByVal datefrom As Date, ByVal dateto As Date, ByVal TableTitle As String, ByVal gv As GridView, ByVal form As XtraForm)
        Dim reportDescription As String = ""
        If reportAsof = True Then
            reportDescription = "Report period covered as of " & dateto.ToString("MMMM dd, yyyy")
        Else
            reportDescription = "Report period covered from " & datefrom.ToString("MMMM dd, yyyy") & " to " & dateto.ToString("MMMM dd, yyyy")
        End If

        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(TableTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(reportDescription = "", "&nbsp;", reportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)

        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        Return True
    End Function

    Public Function PrintGeneralReport(ByVal TableTitle As String, ByVal reportDescription As String, ByVal gv As GridView, ByVal form As XtraForm)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        CreateHTMLReportTemplate("StandardReportsServer.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsServer.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/img/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(TableTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(reportDescription = "", "&nbsp;", reportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        Return True
    End Function

    Public Function ExportGridToExcel(ByVal filename As String, ByVal gv As GridView)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Microsoft Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveFileDialog1.FileName = filename & ".xlsx"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            gv.ExportToXlsx(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return True
    End Function

    Public Function ExportGridToHtml(ByVal filename As String, ByVal gv As GridView)
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Microsoft Excel (*.html)|*.html|All files (*.*)|*.*"
        saveFileDialog1.FileName = filename & ".html"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
                System.IO.File.Delete(saveFileDialog1.FileName)
            End If
            gv.ExportToHtml(saveFileDialog1.FileName)
            XtraMessageBox.Show("Export done successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Return True
    End Function

    Public Function ExportToExcelDirectory(ByVal filename As String, ByVal gv As GridView)
        If System.IO.File.Exists(filename) = True Then
            System.IO.File.Delete(filename)
        End If
        gv.ExportToXlsx(filename)
        Return True
    End Function

End Module
