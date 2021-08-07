Imports DevExpress.XtraEditors

Module Templates
    Dim PicBox As PictureBox = New PictureBox

    Public Function PrintSetupHeaderGL(ByVal center As Boolean)
        PrintSetupHeaderGL = ""
        com.CommandText = "select * from tblcompanysettings" : rst = com.ExecuteReader
        While rst.Read
            PrintSetupHeaderGL += "<p align='" & If(center = True, "center", "right") & "' ><strong>" & UCase(rst("companyname").ToString) & "</strong></br>" _
                    + rst("compadd").ToString & "<br/> " _
                    + rst("telephone").ToString & "<br/> "
        End While
        rst.Close()


        Return PrintSetupHeaderGL
    End Function

    Public Function PrintDisbursementVoucher(ByVal voucherid As String, ByVal print As Boolean, ByVal form As Form) As String
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-24_DV.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-24_DV_" & voucherid & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim pid As String = "" : Dim supplierid As String = "" : Dim officeid As String = "" : Dim sb As Boolean = False : Dim requesttype As String = "" : Dim voucherdate As Date = Nothing
        com.CommandText = "select *,date_format(datetrn,'%M %d, %Y') as trndate, " _
            + " (select sb from tblcompoffice where officeid=a.officeid) as sb,  " _
            + " (select requesttype from tblrequisition where pid=a.pid) as requesttype, " _
            + " (select centercode from tblcompoffice where officeid=a.officeid) as centercode  " _
            + " from tbldisbursementvoucher as a where voucherid='" & voucherid & "'" : rst = com.ExecuteReader
        While rst.Read
            voucherdate = CDate(rst("voucherdate").ToString)
            pid = rst("pid").ToString : supplierid = rst("supplierid").ToString : officeid = rst("officeid").ToString : sb = CBool(rst("sb").ToString) : requesttype = rst("requesttype").ToString
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherno]", rst("voucherno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucherdate]", rst("voucherdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkno]", rst("checkno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[bankname]", rst("checkbank").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[checkdate]", rst("checkdate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[responsibilty]", rst("centercode").ToString), False)
        End While
        rst.Close()

        Dim officerid As String = "" : Dim officername As String = ""
        com.CommandText = "SELECT *,(select fullname from  tblaccounts where accountid=a.officerid) as officehead FROM `tblcompofficerlog` as a where officeid='" & officeid & "' and '" & ConvertDate(voucherdate) & "' between datefrom and if(current,current_date,dateto)" : rst = com.ExecuteReader
        While rst.Read
            officerid = rst("officerid").ToString
            officername = rst("officehead").ToString
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[officehead]", If(officername = "", "_____________________________", UCase(officername))), False)
        DigitalReportSigniture(SaveLocation, officerid, "officehead")


        'supplier
        com.CommandText = "select * from tblsupplier where supplierid='" & supplierid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[suppliername]", rst("suppliername").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[tin]", rst("tin").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supplieraddress]", rst("completeaddress").ToString), False)
        End While
        rst.Close()

        'Voucher Item
        TableRow = "" : Dim itemRow As String = "" : Dim cnt As Integer = 0
        com.CommandText = "select purpose from tblrequisition where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            If cnt = 0 Then
                TableRow += "<tr> " _
                         + " <td colspan='3' style='padding:7px;'>" & rst("purpose").ToString & "</td> " _
                         + " <td  align='right' style='padding:7px;' rowspan='[total_row_span]'>[total]</td> " _
                   + " </tr> " & Chr(13)
            Else
                TableRow += "<tr> " _
                        + " <td colspan='3' style='padding:7px;'>" & rst("purpose").ToString & "</td> " _
                  + " </tr> " & Chr(13)
            End If
            cnt += 1
        End While
        rst.Close()


        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[voucher_item]", ""), False)
        End If

        'For I = 0 To 5 - cnt
        '    TableRow += "<tr> " _
        '                 + " <td colspan='3' style='padding:7px;'>&nbsp;</td> " _
        '                 + " <td  align='right' style='padding:7px;'>&nbsp;</td> " _
        '           + " </tr> " & Chr(13)
        'Next
        Dim total As Double = 0
        com.CommandText = "select ifnull(sum(credit),0) as total from tbljournalentryvoucher as a inner join tbljournalentryitem as b on a.jevno=b.jevno where a.dvid='" & voucherid & "' and itemcode in (select itemcode from tblglcashitem)" : rst = com.ExecuteReader
        While rst.Read
            total = rst("total").ToString
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total_row_span]", cnt), False)

        Dim AcctRow = ""
        com.CommandText = "select b.*, (select itemname from tblglitem where itemcode=b.itemcode) as itemname from tbljournalentryvoucher as a inner join tbljournalentryitem as b on a.jevno=b.jevno where a.dvid='" & voucherid & "'" : rst = com.ExecuteReader
        While rst.Read
            AcctRow += " <tr> " _
                           + " <td>" & rst("itemname").ToString & "</td> " _
                           + " <td align='center'>" & rst("itemcode").ToString & "</td> " _
                           + " <td align='right'>" & If(Val(rst("debit").ToString) > 0, FormatNumber(rst("debit").ToString, 2), "") & "</td> " _
                           + " <td align='right'>" & If(Val(rst("credit").ToString) > 0, FormatNumber(rst("credit").ToString, 2), "") & "</td> " _
                        + "</tr> " & Chr(13)
        End While
        rst.Close()

        If AcctRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", AcctRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", ""), False)
        End If

        Dim documents As String = ""
        com.CommandText = "select * from (select description,if(required,'YES','OPTIONAL') as required, " _
                        + " (select if(count(*)>0,concat(cast(count(*) as CHAR), ' File(s)'),'None') from lgufiledir.tblattachmentlogs where refnumber='" & pid & "' and trntype='requisition' and docname=a.doccode) as files " _
                        + " from tblapprovingattachment As a inner join tbldocumenttype As b On a.doccode=b.code where trncode='" & requesttype & "') as x order by description asc" : rst = com.ExecuteReader
        While rst.Read
            documents += "<tr><td>" & rst("description").ToString & "</td> " _
                      + "<td align='center'>" & rst("required").ToString & "</td> " _
                      + "<td align='center'>" & rst("files").ToString & "</td></tr> "
        End While
        rst.Close()

        If documents.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supporting_documents]", documents), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[supporting_documents]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting]", UCase(GlobalAccountantName)), False)
        DigitalReportSigniture(SaveLocation, GlobalAccountantID, "accounting")

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[treasurer]", UCase(GlobalTreasurerName)), False)
        DigitalReportSigniture(SaveLocation, GlobalTreasurerID, "treasurer")


        If sb Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalViceMayorName)), False)
            DigitalReportSigniture(SaveLocation, GlobalViceMayorID, "mayor")
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalMayorName)), False)
            DigitalReportSigniture(SaveLocation, GlobalMayorID, "mayor")
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(GlobalAccountantName)), False)
        DigitalReportSigniture(SaveLocation, GlobalAccountantID, "prepared")

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "© LGU Financial " & CDate(Now).ToString("yyyy") & " - Disbursement System v" & fversion & " (Printed On " & CDate(Now).ToString("MMMM dd, yyyy") & ") "), False)

        If print Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If

        Return SaveLocation
    End Function

    Public Function PrintCAFOA(ByVal pid As String, ByVal print As Boolean, ByVal form As Form) As String
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-28_CAFOA.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-28_CAFOA_" & pid & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim officeid As String = "" : Dim periodcode As String = "" : Dim sb As Boolean = False : Dim postingdate As Date = Nothing
        com.CommandText = "select *, date_format(postingdate,'%M %d, %Y') as daterequest, " _
            + " date_format(postingdate,'%m') as month_request, " _
            + " (select sb from tblcompoffice where officeid=a.officeid) as sb,  " _
            + " (select fullname from tblaccounts where accountid=a.requestedby) as payee,  " _
            + " ifnull((select sum(amount) from tblrequisitionfund where pid=a.pid),0) as total " _
            + " from tblrequisition as a where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            postingdate = CDate(rst("postingdate").ToString)
            periodcode = rst("periodcode").ToString : officeid = rst("officeid").ToString : sb = CBool(rst("sb").ToString)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[remarks]", rst("purpose").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[obligation_no]", rst("requestno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[payee]", rst("payee").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_requestor]", rst("daterequest").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total_amount]", FormatNumber(rst("total").ToString, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[approved_amount]", FormatNumber(rst("total").ToString, 2)), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total_in_words]", ConvertCurrencyToEnglish(rst("total").ToString)), False)
        End While
        rst.Close()

        Dim requestorid As String = "" : Dim officername As String = ""
        com.CommandText = "SELECT *,(select fullname from  tblaccounts where accountid=a.officerid) as officehead FROM `tblcompofficerlog` as a where officeid='" & officeid & "' and '" & ConvertDate(postingdate) & "' between datefrom and if(current,current_date,dateto)" : rst = com.ExecuteReader
        While rst.Read
            requestorid = rst("officerid").ToString : officername = rst("officehead").ToString
        End While
        rst.Close()
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_requestor]", If(officername = "", "_________________", officername)), False)

        Dim budget As Boolean = False : Dim treasurer As Boolean = False : Dim accountant As Boolean = False
        com.CommandText = "select *,date_format(dateconfirm,'%m/%d/%y %h:%i %p') as date_approved from tblapprovalhistory as a where mainreference='" & pid & "' and status='Approved'" : rst = com.ExecuteReader
        While rst.Read
            If rst("confirmid").ToString = GlobalBudgetID Then
                budget = True
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_budget]", rst("confirmby").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_budget]", rst("date_approved").ToString), False)
            End If

            If rst("confirmid").ToString = GlobalTreasurerID Then
                treasurer = True
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_treasurer]", rst("confirmby").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_treasurer]", rst("date_approved").ToString), False)
            End If

            If rst("confirmid").ToString = GlobalAccountantID Then
                accountant = True
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_accountant]", rst("confirmby").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_accountant]", rst("date_approved").ToString), False)
            End If
        End While
        rst.Close()

        DigitalReportSigniture(SaveLocation, requestorid, "requestor")


        If budget = True Then
            DigitalReportSigniture(SaveLocation, GlobalBudgetID, "budget")
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_budget]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_budget]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_budget]", "hidden"), False)
        End If

        If treasurer = True Then
            DigitalReportSigniture(SaveLocation, GlobalTreasurerID, "treasurer")
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_treasurer]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_treasurer]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_treasurer]", "hidden"), False)
        End If

        If accountant = True Then
            DigitalReportSigniture(SaveLocation, GlobalAccountantID, "accountant")
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_accountant]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_accountant]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_accountant]", "hidden"), False)
        End If

        Dim ItemRow = "" : Dim acctint As Integer = 0
        com.CommandText = "select *, SUBSTRING_INDEX(periodcode,'-',1) as fund, (select centercode from tblcompoffice where officeid=a.officeid) as centercode, " _
                + " (select shortname from tblcompoffice where officeid=a.officeid) as office, " _
                + " (select expenditurecode from tblexpendituretagging where glitemcode=a.itemcode) as expenditure from tblrequisitionfund as a where pid='" & pid & "' " : rst = com.ExecuteReader
        While rst.Read
            ItemRow += " <tr> " _
                           + " <td align='center' style='font-size: 12px; white-space: nowrap;'>" & rst("centercode").ToString & "-" & rst("office").ToString & "</td> " _
                           + " <td style='font-size: 12px'>" & rst("fund").ToString & " (" & rst("expenditure").ToString & ")" & "</td> " _
                           + " <td align='center' style='font-size: 12px; white-space: nowrap;'>" & rst("itemcode").ToString & "</td> " _
                           + " <td align='right' style='font-size: 12px; white-space: nowrap;'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + "</tr> " & Chr(13)
            acctint += 1
        End While
        rst.Close()

        For I = 0 To 4 - acctint
            ItemRow += " <tr> " _
                           + " <td align='center' style='font-size: 0.6vw; white-space: nowrap;'>&nbsp;</td> " _
                           + " <td style='font-size: 0.6vw;'>&nbsp;</td> " _
                           + " <td align='center' style='font-size: 0.6vw; white-space: nowrap;'>&nbsp;</td> " _
                           + " <td align='right' style='font-size: 0.6vw; white-space: nowrap;'>&nbsp;</td> " _
                        + "</tr> " & Chr(13)
        Next
        If ItemRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", ItemRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", ""), False)
        End If



        Dim AcctRow = "" : Dim acct As Integer = 0
        com.CommandText = "SELECT b.postingdate, (select itemname from tblglitem where itemcode = a.itemcode) as itemname, a.requestno,a.prevbalance,a.amount,a.newbalance, " _
                                    + " b.paid as cleared FROM `tblrequisitionfund` as a inner join tblrequisition as b on a.pid = b.pid where a.pid='" & pid & "' order by a.itemcode, b.postingdate asc; " : rst = com.ExecuteReader
        While rst.Read
            Dim cleared As Boolean = CBool(rst("cleared"))
            AcctRow += " <tr> " _
                           + " <td class='item_list' align='center'>" & rst("postingdate").ToString & "</td> " _
                           + " <td class='item_list' align='center'>" & rst("itemname").ToString & "</td> " _
                           + " <td class='item_list' align='right'>" & If(cleared, FormatNumber(Val(rst("amount").ToString), 2), "") & "</td> " _
                           + " <td class='item_list' align='right'>" & If(Not cleared, FormatNumber(Val(rst("amount").ToString), 2), "") & "</td> " _
                           + " <td class='item_list' align='right'>" & FormatNumber(Val(rst("newbalance").ToString), 2) & "</td> " _
                        + "</tr> " & Chr(13)
            acct += 1
        End While
        rst.Close()

        'For I = 0 To 4 - acct
        '    AcctRow += " <tr> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                + "</tr> " & Chr(13)
        'Next

        If AcctRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[item_transaction]", AcctRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[item_transaction]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting]", UCase(GlobalAccountantName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[treasurer]", UCase(GlobalTreasurerName)), False)

        If sb Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalViceMayorName)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalMayorName)), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "© LGU Financial " & CDate(Now).ToString("yyyy") & " - Disbursement System v" & fversion & " (Printed On " & CDate(Now).ToString("MMMM dd, yyyy") & ") "), False)
        If print Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If
        Return SaveLocation
    End Function

    Public Function PrintFURS(ByVal pid As String, ByVal print As Boolean, ByVal form As Form) As String
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\A-29_FURS.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\A-29_FURS_" & pid & ".html"

        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", GlobalOrganizationName), False)

        Dim periodcode As String = "" : Dim officeid As String = "" : Dim sb As Boolean = False : Dim purpose As String = "" : Dim postingdate As Date = Nothing
        com.CommandText = "select *, date_format(postingdate,'%M %d, %Y') as daterequest,  date_format(postingdate,'%m') as month_request, " _
                            + " (select officename from tblcompoffice where officeid=a.officeid) as office, " _
                            + " (select sb from tblcompoffice where officeid=a.officeid) as sb,  " _
                            + " (select fullname from tblaccounts where accountid=a.requestedby) as payee,  " _
                            + " ifnull((select sum(amount) from tblrequisitionfund where pid=a.pid),0) as total " _
                            + " from tblrequisition as a where pid='" & pid & "'" : rst = com.ExecuteReader
        While rst.Read
            postingdate = CDate(rst("postingdate").ToString)
            periodcode = rst("periodcode").ToString : officeid = rst("officeid").ToString : sb = CBool(rst("sb").ToString) : purpose = rst("purpose").ToString
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fursno]", rst("requestno").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("office").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_requestor]", rst("daterequest").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date]", rst("daterequest").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fund]", rst("fundcode").ToString), False)
        End While
        rst.Close()

        Dim requestorid As String = "" : Dim officername As String = "" : Dim officerposition As String = ""
        com.CommandText = "SELECT *,(select fullname from  tblaccounts where accountid=a.officerid) as officehead, (select designation from  tblaccounts where accountid=a.officerid) as designation FROM `tblcompofficerlog` as a where officeid='" & officeid & "' and '" & ConvertDate(postingdate) & "' between datefrom and if(current,current_date,dateto)" : rst = com.ExecuteReader
        While rst.Read
            requestorid = rst("officerid").ToString : officername = rst("officehead").ToString : officerposition = rst("designation").ToString
        End While
        rst.Close()

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_requestor]", If(officername = "", "_________________", officername)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position_requestor]", officerposition), False)

        DigitalReportSigniture(SaveLocation, requestorid, "requestor")

        Dim budget As Boolean = False : Dim treasurer As Boolean = False : Dim accountant As Boolean = False
        com.CommandText = "select *,date_format(dateconfirm,'%m/%d/%y %h:%i %p') as date_approved, (select designation from tblaccounts where accountid=a.confirmid) as position from tblapprovalhistory as a where mainreference='" & pid & "' and status='Approved'" : rst = com.ExecuteReader
        While rst.Read
            If rst("confirmid").ToString = GlobalAccountantID Then
                accountant = True
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_accountant]", rst("confirmby").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_accountant]", rst("date_approved").ToString), False)
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position_accountant]", rst("position").ToString), False)
            End If
        End While
        rst.Close()

        If accountant = True Then
            DigitalReportSigniture(SaveLocation, GlobalAccountantID, "accountant")
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[name_accountant]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_accountant]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[position_accountant]", "_________________"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_accountant]", "hidden"), False)
        End If

        Dim itemrow = "" : Dim item As Integer = 0 : Dim total As Double = 0
        Dim totalsourcecount As Integer = countqry("tblrequisitionfund", "pid='" & pid & "' ")
        com.CommandText = "select *, (select itemname from tblglitem where itemcode=a.itemcode) as itemname from tblrequisitionfund as a where pid='" & pid & "' " : rst = com.ExecuteReader
        While rst.Read
            itemrow += " <tr> " _
                           + " <td class='item_list' align='center'>" & rst("itemname").ToString & "</td> " _
                           + If(totalsourcecount > 1, If(item = 0, "  <td class='item_list' rowspan='" & totalsourcecount & "'>" & purpose & "</td>", ""), "<td class='item_list'>" & purpose & "</td>") _
                           + " <td class='item_list' align='center'>" & rst("itemcode").ToString & "</td> " _
                           + " <td class='item_list' align='right'>" & FormatNumber(rst("amount").ToString, 2) & "</td> " _
                        + "</tr> " & Chr(13)
            item += 1
            total += Val(rst("amount").ToString)
        End While
        rst.Close()

        'For I = 0 To 4 - item
        '    itemrow += " <tr> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                + "</tr> " & Chr(13)
        'Next
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[total]", FormatNumber(total, 2)), False)
        If itemrow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[item_row]", itemrow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[item_row]", ""), False)
        End If


        Dim AcctRow = "" : Dim acct As Integer = 0
        com.CommandText = "SELECT b.postingdate,b.purpose,b.requestno,a.prevbalance,a.amount,a.newbalance, " _
                                    + " b.paid as cleared FROM `tblrequisitionfund` as a " _
                                    + " inner join tblrequisition as b on a.pid=b.pid " _
                                    + " where a.officeid='" & officeid & "' and a.periodcode='" & periodcode & "' and itemcode in (select itemcode from tblrequisitionfund where pid='" & pid & "' and cancelled=0)  and b.cancelled=0 order by a.itemcode, b.postingdate asc; " : rst = com.ExecuteReader
        While rst.Read
            Dim cleared As Boolean = CBool(rst("cleared"))
            AcctRow += " <tr> " _
                           + " <td class='item_list' align='center'>" & rst("postingdate").ToString & "</td> " _
                           + " <td class='item_list'>" & rst("purpose").ToString & "</td> " _
                           + " <td class='item_list' align='center'>" & rst("requestno").ToString & "</td> " _
                           + " <td class='item_list' align='right'>" & FormatNumber(Val(rst("prevbalance").ToString), 2) & "</td> " _
                           + " <td class='item_list' align='right'>" & FormatNumber(Val(rst("amount").ToString), 2) & "</td> " _
                           + " <td class='item_list' align='right'>" & If(cleared, FormatNumber(Val(rst("amount").ToString), 2), "") & "</td> " _
                           + " <td class='item_list' align='right'>" & FormatNumber(Val(rst("newbalance").ToString), 2) & "</td> " _
                           + " <td class='item_list' align='right'>" & If(cleared, "0.00", FormatNumber(Val(rst("amount").ToString), 2)) & "</td> " _
                        + "</tr> " & Chr(13)
            acct += 1
        End While
        rst.Close()

        'For I = 0 To 2 - acct
        '    AcctRow += " <tr> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                   + " <td class='item_list'>&nbsp;</td> " _
        '                + "</tr> " & Chr(13)
        'Next

        If AcctRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", AcctRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting_row]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[accounting]", UCase(GlobalAccountantName)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[treasurer]", UCase(GlobalTreasurerName)), False)

        If sb Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalViceMayorName)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor]", UCase(GlobalMayorName)), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "© LGU Financial " & CDate(Now).ToString("yyyy") & " - Disbursement System v" & fversion & " (Printed On " & CDate(Now).ToString("MMMM dd, yyyy") & ") "), False)

        If print Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If

        Return SaveLocation
    End Function

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
        com.CommandText = "Select *,date_format(postingdate,'%M %d, %Y') as trndate from tbljournalentryvoucher where jevno='" & jevno & "'" : rst = com.ExecuteReader
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

        'For I = 0 To 7 - cnt
        '    TableRow += "<tr> " _
        '                 + " <td>&nbsp;</td> " _
        '                 + " <td>&nbsp;</td> " _
        '                 + " <td>&nbsp;</td> " _
        '                 + " <td>&nbsp;</td> " _
        '                 + " <td>&nbsp;</td> " _
        '           + " </tr> " & Chr(13)
        'Next
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

    Public Sub DigitalReportSigniture(ByVal SaveLocation As String, ByVal userid As String, ByVal code_command As String)
        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing\Signature") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing\Signature")
        End If

        Dim pic As New PictureEdit
        Dim sig As Image = getAccountSignature(userid)
        If Not sig Is Nothing Then
            pic.Image = getAccountSignature(userid)
            pic.Image.Save(Application.StartupPath.ToString & "\Printing\Signature\" & userid & ".png")
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[sig_" & code_command & "]", Application.StartupPath.ToString & "\Printing\Signature\" & userid & ".png"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_" & code_command & "]", ""), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_" & code_command & "]", "hidden"), False)
        End If
    End Sub

    Public Sub PrintEmployee201(ByVal employeeid As String, ByVal fullname As String, ByVal form As Form)
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HR-201.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HR\201-" & fullname & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If
        If Not IO.Directory.Exists(Application.StartupPath.ToString & "\Transaction\HR\image") Then
            IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Transaction\HR\image")
        End If


        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\seal.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left; width: 110px; position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/seal.png'>"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(False)), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report header]", PrintSetupHeaderGL(True)), False)
        End If

        PicBox.Image = Nothing
        com.CommandText = "select *, " _
                        + " date_format(birthdate,'%M %d, %Y') as 'Birth Date', " _
                        + " (select description from tbldatapicked where id=a.birthplace) as 'str_birthplace', " _
                        + " (select description from tbldatapicked where id=a.religion) as 'str_religion', " _
                        + " (select description from tbldatapicked where id=a.nationality) as 'str_nationality', " _
                        + " (select officename from tblcompoffice where officeid=a.officeid) as 'AssignedOffice', " _
                        + " (select description from tbldatapicked where id=a.designation) as str_designation, " _
                        + " (select description from tbldatapicked where id=a.employeetype) as str_employeetype, " _
                        + " (select description from tbldatapicked where id=a.positionlevel) as str_positionlevel, " _
                        + " (select description from tbldatapicked where id=a.baseratepay) as str_baseratepay, " _
                        + " (select description from tbldatapicked where id=a.basicrate) as str_basicrate, " _
                        + " date_format(datehired,'%M %d, %Y') as 'DateHired', " _
                        + " date_format(dateregular,'%M %d, %Y') as 'DateRegular', " _
                        + " date_format(dateresigned,'%M %d, %Y') as 'date_resigned', " _
                        + " date_format(dateretired,'%M %d, %Y') as 'date_retired', " _
                        + " (select img from tblemployeepic where employeeid=a.id) as img  " _
                        + " from tblemployees as a " _
                        + " where id='" & employeeid & "'" : rst = com.ExecuteReader
        While rst.Read
            ConvertDatabaseImage("img", PicBox)
            If System.IO.File.Exists(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg") = True Then
                System.IO.File.Delete(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
            End If
            If Not PicBox.Image Is Nothing Then
                PicBox.Image.Save(Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Else
                If LCase(rst("gender").ToString) = "male" Then
                    IO.File.Copy(Application.StartupPath.ToString & "\Image\no-picture-male.jpg", Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
                Else
                    IO.File.Copy(Application.StartupPath.ToString & "\Image\no-picture-female.jpg", Application.StartupPath.ToString & "\Transaction\HR\image\" & employeeid & ".jpg")
                End If
            End If


            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[id]", rst("id").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[fullname]", rst("fullname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nickname]", If(rst("nickname").ToString = "", "", "<br/>""" & LCase(rst("nickname").ToString) & """")), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[employeeid]", rst("employeeid").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birthdate]", If(rst("birthdate").ToString = "", "", CDate(rst("birthdate").ToString).ToString("MMMM dd, yyyy"))), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birthplace]", rst("str_birthplace").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[gender]", rst("gender").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[civilstatus]", rst("civilstatus").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[spouse]", rst("spousename").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[height]", rst("height").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[weight]", rst("weight").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[nationality]", rst("str_nationality").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[religion]", rst("str_religion").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[employementstatus]", rst("EmployeeType").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[datehired]", rst("DateHired").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[dateregular]", rst("DateRegular").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[office]", rst("AssignedOffice").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[designation]", rst("str_designation").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[employeetype]", rst("str_employeetype").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[positionlevel]", rst("str_positionlevel").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[baseratepay]", rst("str_baseratepay").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[basicrate]", rst("str_basicrate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[actived]", If(CBool(rst("resigned").ToString) = True, "RESIGNED", "ACTIVED")), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_purok]", rst("per_add_purok").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_barangay]", rst("per_add_brgy").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_province]", rst("per_add_prov").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cur_municipality]", rst("per_add_city").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_purok]", rst("cur_add_purok").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_barangay]", rst("cur_add_brgy").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_province]", rst("cur_add_prov").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[per_municipality]", rst("cur_add_city").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incasecontactperson]", rst("inc_cont_person").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incasecontactnumber]", rst("inc_cont_number").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[incaseaddress]", rst("inc_cont_address").ToString), False)

            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[contactnumber]", rst("contactnumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[homenumber]", rst("homenumber").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[emailaddress]", rst("emailaddress").ToString), False)

            If CBool(rst("resigned")) Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[status]", "RESIGNED (" & rst("date_resigned").ToString & ")"), False)
            ElseIf CBool(rst("retired")) Then
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[status]", "RETIRED (" & rst("date_retired").ToString & ")"), False)
            Else
                My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[status]", "ACTIVED"), False)
            End If


        End While
        rst.Close()

        '#CARDS
        If countqry("tblemployeecard", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cards]", ""), False)
        Else
            Dim education As String = ""
            com.CommandText = "select id, (select description from tbldatapicked where id=tblemployeecard.cardtype) as 'CardType', cardnumber,  " _
                  + " date_format(dateexpired,'%Y-%m-%d') as 'DateExpiry',  if(date_format(dateexpired,'%Y-%m-%d') > current_date, 'Expired','Active') as Status, " _
                  + " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblemployeecard.id and trntype='emp_education'),'-') as 'Attachment' " _
                  + " from tblemployeecard where employeeid='" & employeeid & "'" : rst = com.ExecuteReader
            While rst.Read
                education += "<tr align='center'><td Class='details1'>" & rst("CardType").ToString & "</td><td Class='details1'>" & rst("cardnumber").ToString & "</td><td Class='details1'>" & rst("DateExpiry").ToString & "</td><td Class='details1' align='center'>" & rst("Status").ToString & "</td></tr>	"
            End While
            rst.Close()
            education = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='4' Align='center' class='details1'><Strong>Valid ID Cards</Strong></td></tr><tr align='center'><td Class='title1'>Card Type</td><td Class='title1'>Card Number</td><td Class='title1'>Date Expiry</td><td Class='title1'>Status</td></tr>" _
                        + education + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[cards]", education), False)
        End If

        '#EDUCATION
        If countqry("tblemployeeeducation", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[education]", ""), False)
        Else
            Dim education As String = ""
            com.CommandText = "select id, educationtype as 'Degree', " _
                  + " (select description from tbldatapicked where fieldname='schoolname' and id=tblemployeeeducation.schoolid) as 'school', " _
                  + " (select description from tbldatapicked where fieldname='course' and id=tblemployeeeducation.courseid) as 'course', " _
                  + " date_format(datefrom,'%Y') as 'PeriodFrom', date_format(dateto,'%Y') as 'PeriodTo' " _
                  + " from tblemployeeeducation where employeeid='" & employeeid & "' order by schoollevel desc" : rst = com.ExecuteReader
            While rst.Read
                education += "<tr align='center'><td Class='details1'>" & rst("Degree").ToString & "</td><td Class='details1'>" & rst("school").ToString & "</td><td Class='details1'>" & rst("course").ToString & "</td><td Class='details1' align='center'>" & If(rst("PeriodFrom").ToString = rst("PeriodTo").ToString, rst("PeriodFrom").ToString, rst("PeriodFrom").ToString & "-" & rst("PeriodTo").ToString) & "</td></tr>	"
            End While
            rst.Close()
            education = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='4' Align='center' class='details1'><Strong>Educational Background</Strong></td></tr><tr align='center'><td Class='title1'>Degree</td><td Class='title1'>School</td><td Class='title1'>Course</td><td Class='title1'>Period</td></tr>" _
                        + education + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[education]", education), False)
        End If

        ''#WORK HISTORY
        'If countqry("tblemployeeservice", "employeeid='" & employeeid & "'") = 0 Then
        '    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[servicerecord]", ""), False)
        'Else
        '    Dim workhistory As String = ""
        '    com.CommandText = "select id,date_format(datefrom,'%m/%d/%Y') as 'DateFrom', date_format(dateto,'%m/%d/%Y') as 'DateTo', " _
        '          + " (select description from tbldatapicked where id=a.desigid) as Designation, " _
        '          + " (select description from tbldatapicked where id=a.statusid) as Status, " _
        '          + " salaryrate, " _
        '          + " (select description from tbldatapicked where id=a.baserate) as 'BaseRate',  " _
        '          + " (select description from tbldatapicked where id=a.companyid) as 'OfficeStation', " _
        '          + " (select description from tbldatapicked where id=a.branchid) as 'Branch', " _
        '          + " (select description from tbldatapicked where id=a.sep_causeid) as 'SeparationCause' " _
        '          + " from tblemployeeservice as a where employeeid='" & employeeid & "' order by datefrom desc" : rst = com.ExecuteReader

        '    While rst.Read
        '        workhistory += "<tr align='center'> " _
        '                      + " <td Class='details1'>" & If(rst("DateFrom").ToString = rst("DateTo").ToString, rst("DateFrom").ToString, rst("DateFrom").ToString & " - " & rst("DateTo").ToString) & "</td> " _
        '                      + " <td Class='details1'>" & rst("Designation").ToString & "</td> " _
        '                      + " <td Class='details1'>" & rst("Status").ToString & "</td> " _
        '                      + " <td Class='details1'>" & FormatNumber(Val(rst("salaryrate").ToString), 2) & "/" & rst("BaseRate").ToString & " </td> " _
        '                      + " <td Class='details1'>" & rst("OfficeStation").ToString & "</td> " _
        '                      + " <td Class='details1'>" & rst("Branch").ToString & "</td> " _
        '                      + " <td Class='details1'>" & rst("SeparationCause").ToString & "</td> " _
        '                    + "</tr> "
        '    End While
        '    rst.Close()
        '    workhistory = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='7' Align='center' class='details1'><Strong>Service Record</Strong></td></tr>" _
        '        + " <tr align='center'> " _
        '                + " <td Class='title1'>Period</td> " _
        '                + " <td Class='title1'>Designation</td> " _
        '                + " <td Class='title1'>Status</td> " _
        '                + " <td Class='title1'>Salary Rate</td> " _
        '                + " <td Class='title1'>Office Station</td> " _
        '                + " <td Class='title1'>Branch</td> " _
        '                + " <td Class='title1'>Cause</td> " _
        '         + "</tr>" _
        '         + workhistory + "</table>"
        '    My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[servicerecord]", workhistory), False)
        'End If

        '#CERTIFICATION
        If countqry("tblemployeecertification", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[certification]", ""), False)
        Else
            Dim certification As String = ""
            com.CommandText = "select id,(select description from tbldatapicked where id=tblemployeecertification.certissuedfrom) as 'IssuedFrom', " _
                  + " (select description from tbldatapicked where id=tblemployeecertification.certid) as 'TypeCertificate', certno as 'CertificateNo', " _
                  + " date_format(certdate,'%Y-%m-%d') as 'CertificateDate' " _
                  + " from tblemployeecertification where employeeid='" & employeeid & "' order by certdate desc" : rst = com.ExecuteReader
            While rst.Read
                certification += "<tr align='center'><td Class='details1'>" & rst("IssuedFrom").ToString & "</td>" _
                              + " <td Class='details1'>" & rst("TypeCertificate").ToString & "</td> " _
                              + " <td Class='details1'>" & rst("CertificateNo").ToString & "</td> " _
                              + " <td Class='details1'>" & rst("CertificateDate").ToString & "</td></tr> "
            End While
            rst.Close()
            certification = "<hr class='break'/><table Border='0' width='100%' Cellpadding='4' Cellspacing='0' style='Border-Collapse:Collapse;'><tr><td Colspan='4' Align='center' class='details1'><Strong>Certification</Strong></td></tr>" _
                + " <tr align='center'><td Class='title1'>Issued From</td><td Class='title1'>Type of Certification</td><td Class='title1'>Certificate No.</td><td Class='title1'>Date</td></tr>" _
                        + certification + "</table>"
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[certification]", certification), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared by]", UCase(globalfullname)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[prepared position]", StrConv(globalposition, vbProperCase)), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "This report and the information contained herein are true and generated electronically.<br/> " _
                                                                                                                   + "© " & My.Application.Info.AssemblyName & " " & CDate(Now).ToString("yyyy") & " - Employee 201 file (Printed on " & CDate(Now).ToString("MMMM dd, yyyy") & " by " & StrConv(globalfullname, VbStrConv.ProperCase) & ")"), False)

        ' Me.WindowState = FormWindowState.Minimized
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub

    Public Sub PrintEmployeeServiceRecord(ByVal employeeid As String, ByVal fullname As String, ByVal form As Form)
        'CreateHTMLReportTemplate("ResidentProfile.html")
        Dim TableHead As String = "" : Dim TableRow As String = "" : Dim TableFooter As String = "" : Dim TableTransaction As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\HR-SR.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Transaction\HR\SR-" & fullname & ".html"
        If System.IO.File.Exists(SaveLocation) = True Then
            System.IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        If System.IO.File.Exists(Application.StartupPath.ToString & "\Logo\seal.png") = True Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", "<img style='float:left; width: 110px; position: absolute;' src='" & Application.StartupPath.ToString.Replace("\", "/") & "/Logo/seal.png'>"), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[logo]", ""), False)
        End If

        PicBox.Image = Nothing
        com.CommandText = "select *, " _
                        + " date_format(birthdate,'%M %d, %Y') as 'BirthDate', date_format(current_date,'%M %d, %Y') as 'current_date', " _
                        + " concat(nullif(cur_add_purok,''), nullif(concat(', ', cur_add_brgy),''),nullif(concat(', ', cur_add_city),''),nullif(concat(', ', cur_add_prov),'')) as 'CurrentAddress' " _
                        + " from tblemployees as a where id='" & employeeid & "'" : rst = com.ExecuteReader
        While rst.Read
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[lastname]", rst("lastname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[firstname]", rst("firstname").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[middlename]", rst("middlename").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[birthdate]", rst("BirthDate").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", rst("CurrentAddress").ToString), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[date_today]", rst("current_date").ToString), False)
        End While
        rst.Close()
        Dim workhistory As String = ""
        If countqry("tblemployeeservice", "employeeid='" & employeeid & "'") = 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[servicerecord]", ""), False)
        Else
            com.CommandText = "select *, id,date_format(datefrom,'%m/%d/%Y') as 'DateFrom', " _
                  + " date_format(dateto,'%m/%d/%Y') as 'DateTo', " _
                  + " date_format(sep_date,'%m/%d/%Y') as 'sepdate', " _
                  + " (select description from tbldatapicked where id=a.desigid) as Designation, " _
                  + " (select description from tbldatapicked where id=a.statusid) as Status, " _
                  + " salaryrate, " _
                  + " (select description from tbldatapicked where id=a.baserate) as 'BaseRate',  " _
                  + " (select description from tbldatapicked where id=a.companyid) as 'OfficeStation', " _
                  + " (select description from tbldatapicked where id=a.branchid) as 'Branch', " _
                  + " (select description from tbldatapicked where id=a.sep_causeid) as 'SeparationCause' " _
                  + " from tblemployeeservice as a where employeeid='" & employeeid & "' order by datefrom desc" : rst = com.ExecuteReader

            While rst.Read
                workhistory += "<tr> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("DateFrom").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("DateTo").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("Designation").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("Status").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & FormatNumber(Val(rst("salaryrate").ToString), 2) & "/" & rst("BaseRate").ToString & " </td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("OfficeStation").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("Branch").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("lv_abs_wpay").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("sepdate").ToString & "</td> " _
                              + " <td align='center' style='padding: 5px;'>" & rst("SeparationCause").ToString & "</td> " _
                            + "</tr> "
            End While
            rst.Close()
        End If
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[servicerecord]", workhistory), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor_name]", GlobalMayorName), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[mayor_position]", GlobalMayorPosition), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hr_name]", GlobalHrmdName), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hr_position]", GlobalHrmdPosition), False)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[watermark]", "This report and the information contained herein are true and generated electronically.<br/> " _
                                                                                                                   + "© " & My.Application.Info.AssemblyName & " " & CDate(Now).ToString("yyyy") & " - Employee Service Record (Printed on " & CDate(Now).ToString("MMMM dd, yyyy") & " by " & StrConv(globalfullname, VbStrConv.ProperCase) & ")"), False)
        PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
    End Sub
End Module
