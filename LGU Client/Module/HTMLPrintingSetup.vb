Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Module HTMLPrintingSetup
    Public Sub CreateHTMLReportTemplate(ByVal filename As String)
        Dim saveLocation As String = Application.StartupPath.ToString & "\Templates\" & filename
        com.CommandText = "select * from tblreporthtmltemplate where filename='" & filename & "'" : rst = com.ExecuteReader
        While rst.Read
            If System.IO.File.Exists(saveLocation) = True Then
                System.IO.File.Delete(saveLocation)
            End If
            Dim detailsFile As StreamWriter = Nothing
            detailsFile = New StreamWriter(saveLocation, True)
            detailsFile.WriteLine(rst("htmltemplate").ToString)
            detailsFile.Close()
        End While
        rst.Close()
    End Sub
    Public Function PrintSetupHeader()
        PrintSetupHeader += "<p align='center' ><strong>" & UCase(GlobalOrganizationName) & "</strong></br>" _
                            + GlobalOrganizationAddress & "<br/> " _
                            + GlobalOrganizationContactNumber & "<br/> " _
                            + "<b>" & UCase(compOfficename) & "</b><br/> "
        Return PrintSetupHeader
    End Function
    Public Sub PrintViaInternetExplorer(ByVal location As String, ByVal form As  Form)
        Try
            System.Diagnostics.Process.Start(location)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub DXPrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReports.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReports.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", DXSetupTheGridviewPrinter(TableTitle, gv)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        If compOfficerIncharge = "" Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted by]", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted position]", "(Signature over printedname)"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted by]", UCase(compOfficerIncharge)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted position]", UCase(compOfficerPosition)), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DataGridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReports.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReports.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(globalposition)), False)

        If compOfficerIncharge = "" Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted by]", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted position]", "(Signature over printedname)"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted by]", UCase(compOfficerIncharge)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[noted position]", UCase(compOfficerPosition)), False)
        End If

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintDatagridviewSignatories(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DataGridView, _
                                            ByVal prepare_title As String, ByVal prepare_id As String, _
                                            ByVal checked_title As String, ByVal checked_id As String, _
                                            ByVal approved_title As String, ByVal approved_id As String, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsSignatory.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsSignatory.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)


        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared title]", UCase(prepare_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(GetUserinfo(prepare_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(GetUserinfo(prepare_id, "designation"))), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked title]", UCase(checked_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(GetUserinfo(checked_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(GetUserinfo(checked_id, "designation"))), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved title]", UCase(approved_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(GetUserinfo(approved_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(GetUserinfo(approved_id, "designation"))), False)


        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub DXPrintDatagridviewSignatories(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As GridView, _
                                           ByVal prepare_title As String, ByVal prepare_id As String, _
                                           ByVal checked_title As String, ByVal checked_id As String, _
                                           ByVal approved_title As String, ByVal approved_id As String, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsSignatory.html")

        Dim Template As String = Application.StartupPath.ToString & "\Templates\StandardReportsSignatory.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\REPORTS\" & RemoveSpecialCharacter(form.Text) & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\logo.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left;  position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/logo.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeader()), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", DXSetupTheGridviewPrinter(TableTitle, gv)), False)


        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared title]", UCase(prepare_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(GetUserinfo(prepare_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", UCase(GetUserinfo(prepare_id, "designation"))), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked title]", UCase(checked_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked by]", UCase(GetUserinfo(checked_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checked position]", UCase(GetUserinfo(checked_id, "designation"))), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved title]", UCase(approved_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved by]", UCase(GetUserinfo(approved_id, "fullname"))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved position]", UCase(GetUserinfo(approved_id, "designation"))), False)


        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function GetUserinfo(ByVal userid As String, ByVal column As String) As String
        com.CommandText = "select * from tblaccounts where accountid='" & userid & "'" : rst = com.ExecuteReader()
        While rst.Read
            GetUserinfo = rst(column).ToString
        End While
        rst.Close()
        Return GetUserinfo
    End Function
    Public Function SetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DataGridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        TableHeaderStart = "<table border='1' style='min-width:650px; margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.ColumnCount & "' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        For i = 0 To gv.ColumnCount - 1
            If gv.Columns(i).Visible = True Then
                ColumnName += "<th>" & gv.Columns(i).Name & "</th>"
            End If
        Next
        TableHeaderEnd = " </tr> "
        For i = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = ""
            For x = 0 To gv.ColumnCount - 1
                If gv.Columns(x).Visible = True Then
                    Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                    If gv.Columns(gv.Columns(x).Name).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter Then
                        colalignment = "align='center'"

                        If gv.Item(gv.Columns(x).Name, i).Value() Is Nothing Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = gv.Item(gv.Columns(x).Name, i).Value().ToString
                        End If

                    ElseIf gv.Columns(gv.Columns(x).Name).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight Then
                        colalignment = "align='right'"
                        If gv.Item(gv.Columns(x).Name, i).Value().ToString = "" Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = FormatNumber(gv.Item(gv.Columns(x).Name, i).Value().ToString, 2)
                        End If
                    Else
                        If gv.Item(gv.Columns(x).Name, i).Value() Is Nothing Then
                            strvalue = "&nbsp;"
                        Else
                            strvalue = gv.Item(gv.Columns(x).Name, i).Value().ToString
                        End If
                    End If
                    If gv.Columns(x).Width = 300 Then
                        columnSize = " width='" & gv.Columns(x).Width.ToString & "' "
                    End If

                    rowRowTableData += "<td " & colalignment & columnSize & ">" & strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>") & "</td> "
                End If
            Next
            If gv.Rows(i).DefaultCellStyle.ForeColor = Color.Red Then
                rowColor = "ff0000"
            ElseIf gv.Rows(i).DefaultCellStyle.ForeColor = Color.Blue Then
                rowColor = "001a7a"
            Else
                rowColor = "000000"
            End If
            rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
        Next
        SetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + "</table>"
        Return SetupTheGridviewPrinter
    End Function

    Public Function DXSetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' style='margin:3px 0' cellpadding='4' cellspacing='0'> " _
                                       + " <tr> " _
                                           + " <td colspan='" & gv.Columns.Count & "' height='20' align='center'><b>" & UCase(TableTitle) & "</b></td> " _
                                       + " </tr> " & Chr(13) _
                                       + " <tr> "
        com.CommandText = "DROP temporary table if exists temptableprinting" : com.ExecuteNonQuery()
        com.CommandText = "CREATE temporary TABLE  temptableprinting (  `columnname` varchar(100) NOT NULL, `colindex` double NOT NULL, `colwidth` double NOT NULL default 0) ENGINE=memory;" : com.ExecuteNonQuery()
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                com.CommandText = "insert into temptableprinting set columnname='" & gv.Columns(I).FieldName & "',colindex='" & gv.Columns(I).VisibleIndex & "', colwidth='" & gv.Columns(I).Width & "'" : com.ExecuteNonQuery()
            End If
        Next

        com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
        While rst.Read
            ColumnName += "<th>" & rst("columnname").ToString & "</th>"
        End While
        rst.Close()

        TableHeaderEnd = " </tr> "
        For I = 0 To gv.RowCount - 1
            rowRowTableData = "" : Dim rowColor As String = "000000"
            com.CommandText = "select * from temptableprinting order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                Dim colalignment As String = "" : Dim strvalue As String = "" : Dim columnSize As String = ""
                If gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center Then
                    colalignment = "align='center'"

                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If

                ElseIf gv.Columns(rst("columnname").ToString).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far Then
                    colalignment = "align='right'"
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString = "" Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = FormatNumber(gv.GetRowCellValue(I, rst("columnname").ToString).ToString, 2)
                    End If
                Else
                    If gv.GetRowCellValue(I, rst("columnname").ToString).ToString Is Nothing Then
                        strvalue = "&nbsp;"
                    Else
                        strvalue = gv.GetRowCellValue(I, rst("columnname").ToString).ToString
                    End If
                End If

                If Val(rst("colwidth").ToString) >= 350 Then
                    columnSize = " width='350' "
                ElseIf rst("columnname").ToString = "Date" Then
                    columnSize = " width='100' "

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>").Replace("|", "<br/>").Replace(vbCrLf, "<br/>").Replace(vbCr, "<br/>").Replace(vbLf, "<br/>")

                rowRowTableData += "<td " & colalignment & columnSize & ">" & CellData & "</td> "
            End While
            rst.Close()

            Dim EnableBoldFormat As Boolean = False
            For Each col In gv.Columns

                If col.Name = "colbold" Then

                    EnableBoldFormat = True
                End If
            Next
            If EnableBoldFormat = True Then
                If CBool(gv.GetRowCellValue(I, "bold").ToString) = True Then
                    rows += "<tr style='color:#" & rowColor & "; font-weight:bold'>" + rowRowTableData + "</tr>"
                Else
                    rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
                End If
            Else
                rows += "<tr style='color:#" & rowColor & "'>" + rowRowTableData + "</tr>"
            End If
        Next

        Dim SummaryRow As String = "" : Dim SummaryColumn As String = ""
        If gv.OptionsView.ShowFooter = True Then
            For Each col In gv.Columns
                If col.Visible = True Then
                    SummaryColumn += "<td align='center'>" & col.SummaryText & "</td>"
                End If

            Next

            'For Each col As String In gv.Columns
            '    If col <> "" Then
            '        For I = 0 To gv.Columns.Count - 1

            '        Next
            '    End If
            'Next
        End If
        SummaryRow = "<tr style='font-weight:bold'>" & SummaryColumn & "</tr>"
        DXSetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return DXSetupTheGridviewPrinter
    End Function
End Module
