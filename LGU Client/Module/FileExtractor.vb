Imports System.IO
Imports Shell32
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors

Module FileExtractor
    Public Sub VoucherExporter(ByVal batch As Boolean, ByVal query As String, ByVal Location As String, ByVal progressControl As ProgressBarControl, ByVal form As Form)
        Dim totalVoucher As Integer = countqry("tbldisbursementvoucher", query)

        If Not progressControl Is Nothing Then
            progressControl.Properties.Step = 1
            progressControl.Properties.PercentView = True
            progressControl.Properties.Maximum = totalVoucher - 1
            progressControl.Properties.Minimum = 0
            progressControl.Position = 0
        End If


        da = Nothing : Dim dst = New DataSet : dst.Clear()
        da = New MySqlDataAdapter("select voucherid, pid, voucherno,yearcode, fundcode, date_format(voucherdate, '%M') as voucherMonth, (select description from tblfund where code=tbldisbursementvoucher.fundcode) as fundname from tbldisbursementvoucher where " & query, conn)
        da.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                Dim pid As String = .Rows(cnt)("pid").ToString()
                Dim voucherDIR As String = ""

                If batch Then
                    voucherDIR = Location & "\" & .Rows(cnt)("yearcode").ToString() & "\" & .Rows(cnt)("voucherMonth").ToString() & "\" & .Rows(cnt)("fundname").ToString() & "\" & .Rows(cnt)("voucherno").ToString()
                Else
                    voucherDIR = Location & "\" & .Rows(cnt)("voucherno").ToString()
                End If

                If Not IO.Directory.Exists(voucherDIR) Then
                    IO.Directory.CreateDirectory(voucherDIR)
                End If

                Dim VoucherPDS As String = voucherDIR & "\DV " & .Rows(cnt)("voucherno").ToString() & ".pdf"
                If File.Exists(VoucherPDS) = True Then
                    File.Delete(VoucherPDS)
                End If

                Dim voucherLocation As String = PrintDisbursementVoucher(.Rows(cnt)("voucherid").ToString(), False, form)
                SavePDFCopy(voucherLocation, VoucherPDS)

                If countqry("tblfund", "code='" & .Rows(cnt)("fundcode").ToString() & "' and template='FURS'") > 0 Then
                    Dim FursPDF As String = voucherDIR & "\FURS " & .Rows(cnt)("voucherno").ToString() & ".pdf"
                    If File.Exists(FursPDF) = True Then
                        File.Delete(FursPDF)
                    End If

                    Dim FursLocation As String = PrintFURS(pid, False, form)
                    SavePDFCopy(FursLocation, FursPDF)

                ElseIf countqry("tblfund", "code='" & .Rows(cnt)("fundcode").ToString() & "' and template='CAFOA'") > 0 Then
                    Dim CafoaPDF As String = voucherDIR & "\CAFOA " & .Rows(cnt)("voucherno").ToString() & ".pdf"
                    If File.Exists(CafoaPDF) = True Then
                        File.Delete(CafoaPDF)
                    End If

                    Dim CafoaLocation As String = PrintCAFOA(pid, False, form)
                    SavePDFCopy(CafoaLocation, CafoaPDF)

                End If

                If countqry("" & sqlfiledir & ".tblattachmentlogs", "refnumber='" & pid & "' and trntype='requisition'") > 0 Then
                    Dim directoryFolder As String = voucherDIR & "\Attachment"
                    If Not IO.Directory.Exists(directoryFolder) Then
                        IO.Directory.CreateDirectory(directoryFolder)
                    End If

                    Dim list As New ArrayList
                    com.CommandText = "select * from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & pid & "' and trntype='requisition'" : rst = com.ExecuteReader
                    While rst.Read
                        list.Add(rst("id").ToString)
                    End While
                    rst.Close()
                    ExtractFiles(list.ToArray, directoryFolder)
                End If

                If Not progressControl Is Nothing Then
                    progressControl.PerformStep()
                    progressControl.Update()
                End If


            End With
        Next
        If Not progressControl Is Nothing Then
            progressControl.Position = 0
        End If

        MessageBox.Show("Voucher Successfully Exported!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Module
