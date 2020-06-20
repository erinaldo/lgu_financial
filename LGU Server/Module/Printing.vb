Imports System.IO

Module Printing
    Dim PicBox As PictureBox = New PictureBox
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
    Public Function PrintSetupHeader() As String
        PrintSetupHeader += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "
        PrintSetupHeader += "<p align='right'><strong>" & UCase(globaloffice) & "</strong></br>"

        Return PrintSetupHeader
    End Function



    Public Function PrintSetupHeaderGeneral()
        PrintSetupHeaderGeneral = ""
        PrintSetupHeaderGeneral += "<p align='right' ><strong>" & UCase(compname) & "</strong></br>" _
                            + compadd & "<br/> " _
                            + compnumber & "<br/> "

        Return PrintSetupHeaderGeneral
    End Function

    Public Function PrintSetupHeaderGL(ByVal companyid As String, ByVal center As Boolean)
        PrintSetupHeaderGL = ""
        com.CommandText = "select * from tblcompanysettings where companycode='" & companyid & "'" : rst = com.ExecuteReader
        While rst.Read
            PrintSetupHeaderGL += "<p align='" & If(center = True, "center", "right") & "' ><strong>" & UCase(rst("companyname").ToString) & "</strong></br>" _
                    + rst("compadd").ToString & "<br/> " _
                    + rst("telephone").ToString & "<br/> "
        End While
        rst.Close()


        Return PrintSetupHeaderGL
    End Function

    Public Sub PrintViaInternetExplorer(ByVal location As String, ByVal form As Windows.Forms.Form)
        Try
            System.Diagnostics.Process.Start(location)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub PrintDatagridview(ByVal ReportTitle As String, ByVal TableTitle As String, ByVal ReportDescription As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As Form)
        If gv.RowCount = 0 Then
            MessageBox.Show("No data report to print!", _
                       "Error Print", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'CreateHTMLReportTemplate("StandardReportsServer.html")

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
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[title]", UCase(ReportTitle)), False)

        Dim ReportDetails As String = "<p align='left'> " & If(ReportDescription = "", "&nbsp;", ReportDescription) & " <span style='float:right'>Date Report: " & CDate(Now).ToString("MMMM dd, yyyy") & "</span></p>"
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report details]", ReportDetails), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report table]", SetupTheGridviewPrinter(TableTitle, gv)), False)


        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Function SetupTheGridviewPrinter(ByVal TableTitle As String, ByVal gv As DevExpress.XtraGrid.Views.Grid.GridView) As String
        On Error Resume Next
        Dim TableHeaderStart As String = "" : Dim TableHeaderEnd As String = "" : Dim ColumnName As String = "" : Dim rows As String = "" : Dim rowRowTableData As String = "" : Dim RowFooter As String = ""
        Dim width As Double = 0
        For I = 0 To gv.Columns.Count - 1
            If gv.Columns(I).VisibleIndex >= 0 Then
                width += gv.Columns(I).Width
            End If
        Next


        TableHeaderStart = "<table border='1' width='100%' style='margin:3px 0' cellpadding='4' cellspacing='0' style='border-collapse:collapse;'> " _
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

                End If

                Dim CellData As String = strvalue.Replace("True", "YES").Replace("False", "-").Replace(Chr(13), "<br/>").Replace(vbCrLf, "<br/>").Replace(vbCr, "<br/>").Replace(vbLf, "<br/>")

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

        SetupTheGridviewPrinter = TableHeaderStart + ColumnName + TableHeaderEnd + rows + SummaryRow + "</table>"
        Return SetupTheGridviewPrinter
    End Function

    Public Function getWhiteSpaces(ByVal CellData As String) As String
        Dim cnt As Integer = 0 : Dim spaces As String = ""
        For Each q In CellData
            If q = " " Then
                cnt += 1
            ElseIf q <> " " And cnt > 5 Then
                For x = 0 To cnt - 1
                    spaces += " "
                Next
                Exit For
            End If
        Next
        Return spaces
    End Function

    Public Function SplitLongString(ByVal CellData As String, ByVal spaces As String)
        Dim newCellData As String = ""
        If CellData.Length > 120 Then
            Dim cn As Integer = 0 : Dim word As String = ""
            For Each q In CellData
                word += q
                If cn > 120 Then
                    If q = " " Then
                        Exit For
                    End If
                End If
                cn += 1
            Next
            newCellData = word
            If CellData.Replace(word, "").Length > 0 Then
                newCellData += "<br/>" & spaces & CellData.Replace(word, "")
            End If
        Else
            newCellData = CellData
        End If
        Return newCellData
    End Function

    Public Sub PrintLXReceipt(ByVal location As String, ByVal form As Windows.Forms.Form)
        Dim printProcess As New Diagnostics.ProcessStartInfo()
        printProcess.FileName = location
        Try
            Process.Start(printProcess)
            'form.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MessageBox.Show("File not found!", _
                          "Error Reprint Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module