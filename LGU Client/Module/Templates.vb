Module Templates

    Public Sub PrintPurchaseRequest(ByVal pid As String, ByVal printline As Integer, ByVal form As Form)
        Dim itemrow As String = "" : Dim AccountingRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-30_PR.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-30_PR_" & pid & ".html"
        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)
        com.CommandText = "select a.*,(select officename from tblcompoffice where officeid=a.officeid) as office,(select fullname from tblaccounts where accountid=b.requestedby) as requestedname,(select designation from tblaccounts where accountid=b.requestedby) as position from tblpurchaserequest as a inner join tblrequisition as b on a.pid=b.pid where a.pid='" & pid & "' " : rst = com.ExecuteReader
        While rst.Read

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[officename]", rst("office").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[section]", rst("section").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[purpose]", rst("purpose").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pr_no]", rst("prnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pr_date]", If(rst("pr_date").ToString = "", "", CDate(rst("pr_date").ToString).ToString("MMMM dd, yyyy"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[sai_no]", rst("sai_no").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[sai_date]", If(rst("sai_date").ToString = "", "", CDate(rst("sai_date").ToString).ToString("MMMM dd, yyyy"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[alobs_no]", rst("alobs_no").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[alobs_date]", If(rst("alobs_date").ToString = "", "", CDate(rst("alobs_date").ToString).ToString("MMMM dd, yyyy"))), False)

            'requested Signatories
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestby]", UCase(rst("requestedname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[requestbyposition]", rst("position").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[daterequest]", CDate(rst("pr_date").ToString).ToString("MMMM dd, yyyy")), False)

        End While
        rst.Close()

        'Voucher Item
        itemrow = "" : Dim cnt As Integer = 0
        com.CommandText = "select * from tblrequisitionitem where pid='" & pid & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            cnt += 1
            Dim remarks As String = rst("remarks").ToString
            itemrow += "<tr><td align='center'>" & cnt & "</td>" _
                        + " <td align='center'>" & rst("quantity").ToString & "</td>" _
                        + " <td align='center'>" & rst("unit").ToString & "</td>" _
                        + " <td width='300'><b>" & rst("itemname").ToString & "</b>" & If(remarks.Length = 0, "", "<br/>" & remarks.Replace(vbCrLf, "<br/>")) & "</td>" _
                        + " <td align='right'>" & FormatNumber(Val(rst("unitcost").ToString), 2) & "</td>" _
                        + " <td align='right'>" & FormatNumber(Val(rst("totalcost").ToString), 2) & "</td></tr>" & Chr(13)

        End While
        rst.Close()

        For I = 0 To printline - cnt
            itemrow += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[itemrow]", itemrow), False)

        com.CommandText = "select * from tblaccounts where executiveofficer=1" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayorname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayorposition]", rst("designation").ToString), False)
        End While
        rst.Close()
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintPurchaseOrder(ByVal pid As String, ByVal printline As Integer, ByVal form As Form)
        Dim itemrow As String = "" : Dim AccountingRow As String = "" : Dim picbox As New PictureBox
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-29_PO.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-29_PO_" & pid & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        My.Computer.FileSystem.CopyFile(Template, SaveLocation)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim supplierid As String = ""
        com.CommandText = "select *,(select description from tbldatapicked where id=a.procuremode) as 'procurementmode', " _
                            + " (select description from tbldatapicked where id=a.placedelivery) as 'deliveryplace', " _
                            + " (select description from tbldatapicked where id=a.datedelivery) as 'deliverydate', " _
                            + " (select description from tbldatapicked where id=a.deliveryterm) as 'termdelivery', " _
                            + " (select description from tbldatapicked where id=a.paymentmode) as 'modepayment' from tblpurchaseorder as a where a.pid='" & pid & "' " : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("supplierid").ToString
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[ponumber]", rst("ponumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[po_date]", If(rst("po_date").ToString = "", "", CDate(rst("po_date").ToString).ToString("MMMM dd, yyyy"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pr_no]", rst("pr_number").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[pr_date]", If(rst("pr_date").ToString = "", "", CDate(rst("pr_date").ToString).ToString("MMMM dd, yyyy"))), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[procurementmode]", rst("procurementmode").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[placedelivery]", rst("deliveryplace").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[deliverydate]", rst("deliverydate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[deliveryterm]", rst("termdelivery").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[paymentmode]", rst("modepayment").ToString), False)

            If CBool(rst("negotiated")) Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[visibility]", "visible"), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[resolution_no]", UCase(rst("resolutionno").ToString)), False)
                'My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[secretaryname]", rst("secretaryname").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateapproved]", CDate(rst("dateapproved").ToString).ToString("MMMM dd, yyyy")), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[visibility]", "hidden"), False)
            End If

        End While
        rst.Close()

        com.CommandText = "select * from tblsupplier where supplierid='" & supplierid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", UCase(rst("suppliername").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("completeaddress").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliertin]", rst("tin").ToString), False)
        End While
        rst.Close()

        'Voucher Item
        itemrow = "" : Dim cnt As Integer = 0 : Dim total As Double = 0
        com.CommandText = "select * from tblpurchaseorderitem where pid='" & pid & "' order by id asc" : rst = com.ExecuteReader
        While rst.Read
            cnt += 1
            Dim remarks As String = rst("remarks").ToString
            itemrow += "<tr><td align='center' width='30'>" & cnt & "</td>" _
                        + " <td align='center'>" & rst("stockno").ToString & "</td>" _
                        + " <td align='center'>" & rst("unit").ToString & "</td>" _
                        + " <td width='300'><b>" & rst("itemname").ToString & "</b>" & If(remarks.Length = 0, "", "<br/>" & remarks.Replace(vbCrLf, "<br/>")) & "</td>" _
                        + " <td align='center'>" & rst("quantity").ToString & "</td>" _
                        + " <td align='right'>" & FormatNumber(Val(rst("unitcost").ToString), 2) & "</td>" _
                        + " <td align='right'>" & FormatNumber(Val(rst("totalcost").ToString), 2) & "</td></tr>" & Chr(13)
            total += Val(rst("totalcost").ToString)
        End While
        rst.Close()

        For I = 0 To printline - cnt
            itemrow += "<tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>" & Chr(13)
        Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[itemrow]", itemrow), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[amountinwords]", ConvertCurrencyToEnglish(Val(total))), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalamount]", FormatNumber(total, 2)), False)

        com.CommandText = "select * from tblaccounts where executiveofficer=1" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayorname]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayorposition]", rst("designation").ToString), False)
        End While
        rst.Close()

        com.CommandText = "select * from tblaccounts where financeofficer=1" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[financename]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[financeposition]", rst("designation").ToString), False)
        End While
        rst.Close()

        com.CommandText = "select * from tblaccounts where sangguniansecretary=1" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[secretaryname]", UCase(rst("fullname").ToString)), False)
        End While
        rst.Close()
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintDisbursementVoucher(ByVal vouchercode As String, ByVal form As Form)
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-24_DV.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-24_DV_" & vouchercode & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim supplierid As String = ""
        com.CommandText = "select *,date_format(datetrn,'%M %d, %Y') as trndate,(select companyname from  tblsupplier where supplierid=tblbudgetvoucher.payee) as vendor,(select itemname from tblglitem where itemcode=tblbudgetvoucher.sourcefund) as source from tblbudgetvoucher where code='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            supplierid = rst("payee").ToString
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("controlno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("trndate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cash_advance]", If(rst("typeofpayment").ToString = "ca", "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[reimbursement]", If(rst("typeofpayment").ToString = "reimbursement", "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[others]", If(rst("typeofpayment").ToString = "others", "checked='yes'", "")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[sourceoffund]", rst("source").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[responsibilty]", rst("responsiblecenter").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("officeunit").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[otherdoc]", rst("otherdocs").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[headcommittee]", If(rst("headcommittee").ToString = "", "_______________________________", UCase(rst("headcommittee").ToString))), False)
        End While
        rst.Close()

        'supplier
        com.CommandText = "select * from tblsupplier where supplierid='" & supplierid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("companyname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[tin]", rst("tin").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("compadd").ToString), False)
        End While
        rst.Close()

        'check
        com.CommandText = "select * from tblchecktransaction where vouchercode='" & vouchercode & "' and cancelled=0" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkno]", rst("checkno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[bankname]", rst("checkdetails").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkdate]", rst("checkdate").ToString), False)
        End While
        rst.Close()

        'Voucher Item
        TableRow = "" : Dim total As Double = 0 : Dim cnt As Integer = 0
        com.CommandText = "select Explaination, Amount from tblbudgetvoucheritem where vouchercode='" & vouchercode & "'" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td colspan='3' style='padding:7px;'>" & rst("Explaination").ToString & "</td> " _
                           + " <td  align='right' style='padding:7px;'>" & FormatNumber(rst("Amount").ToString, 2) & "</td> " _
                     + " </tr> " & Chr(13)
            total += Val(rst("Amount").ToString)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 7 - cnt
            TableRow += "<tr> " _
                         + " <td colspan='3' style='padding:7px;'>&nbsp;</td> " _
                         + " <td  align='right' style='padding:7px;'>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "© " & My.Application.Info.AssemblyName & " " & CDate(Now).ToString("yyyy") & " - Budget Management System v" & fversion & " (Printed on " & CDate(Now).ToString("MMMM dd, yyyy") & ") "), False)
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub


    Public Sub PrintJournalVoucher(ByVal jevno As String, ByVal form As Form)
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-23_JEV.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-23_JEV_" & jevno & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim remarks As String = ""
        com.CommandText = "select *,date_format(postingdate,'%M %d, %Y') as trndate from tbljournalentryvoucher where jevno='" & jevno & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[jevno]", jevno), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[postingdate]", rst("trndate").ToString), False)
            remarks = rst("remarks").ToString
        End While
        rst.Close()
         
        'Voucher Item
        TableRow = "" : Dim totaldebit As Double = 0 : Dim totalcredit As Double = 0 : Dim cnt As Integer = 0
        com.CommandText = "select *, (select centercode from tblcompoffice where officeid=tbljournalentryitem.centercode) as office_center from tbljournalentryitem where jevno='" & jevno & "'" : rst = com.ExecuteReader
        While rst.Read
            TableRow += "<tr> " _
                           + " <td align='center' style='padding: 5px;'>" & rst("office_center").ToString & "</td> " _
                           + " <td style='padding: 5px;'>" & If(Val(rst("credit").ToString) > 0, "<div style='padding-left:25px'>" & rst("itemname").ToString & "</div>", rst("itemname").ToString) & "</td> " _
                           + " <td align='center' style='padding: 5px;'>" & rst("itemcode").ToString & "</td> " _
                           + " <td align='right' style='padding: 5px;'>" & If(Val(rst("debit").ToString) = 0, "", FormatNumber(rst("debit").ToString, 2)) & "</td> " _
                           + " <td align='right' style='padding: 5px;'>" & If(Val(rst("credit").ToString) = 0, "", FormatNumber(rst("credit").ToString, 2)) & "</td> " _
                     + " </tr> " & Chr(13)
            totaldebit += Val(rst("debit").ToString)
            totalcredit += Val(rst("credit").ToString)
            cnt += 1
        End While
        rst.Close()

        For I = 0 To 7 - cnt
            TableRow += "<tr> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                         + " <td>&nbsp;</td> " _
                   + " </tr> " & Chr(13)
        Next
        If remarks.Length > 1 Then
            TableRow += "<tr> " _
                        + " <td>&nbsp;</td> " _
                        + " <td>" & remarks & "</td> " _
                        + " <td>&nbsp;</td> " _
                        + " <td>&nbsp;</td> " _
                        + " <td>&nbsp;</td> " _
                  + " </tr> " & Chr(13)
        End If

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[journal_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[journal_item]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totaldebit]", FormatNumber(totaldebit, 2)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalcredit]", FormatNumber(totalcredit, 2)), False)

        com.CommandText = "select * from tblaccounts where accountant=1" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[certified]", UCase(rst("fullname").ToString)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position]", rst("designation").ToString), False)
        End While
        rst.Close()

        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub
End Module
