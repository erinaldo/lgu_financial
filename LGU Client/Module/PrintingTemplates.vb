Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module PrintingTemplates
    Public Function PrintCollectionReceipt(ByVal ornumber As String, ByVal cifid As String, ByVal fundcode As String, ByVal invrefcode As String, ByVal reprint As Boolean) As Boolean
        Dim details As String = ""

        Dim LXMarginTop As Integer = 0 : Dim LXMarginLeft As Integer = 0
        Dim code As String = qrysingledata("defaultcollection", "defaultcollection", "tbldefaultsettings")

        com.CommandText = "select * from tblaccountableform where code='" & code & "'" : rst = com.ExecuteReader
        While rst.Read
            LXMarginTop = CInt(rst("prnMarginTop").ToString)
            LXMarginLeft = CInt(rst("prnMarginLeft").ToString)
        End While
        rst.Close()

        details += PrintGetSpace(LXMarginLeft) + PrintSpaceLine(LXMarginTop)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalOrganizationName & "|22|center"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({CDate(Now).ToString("MMM dd, yyyy") & "|0|left", ornumber & "|33|center"}, 6)

        Dim collectionarea As Integer = 15
        com.CommandText = "select *,(select description from tbldatapicked where id=a.agencycode) as agency from tbltaxpayerprofile as a where cifid='" & cifid & "'" : rst = com.ExecuteReader
        While rst.Read
            details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({rst("agency").ToString & "|0|left", fundcode & "|37|center"}, 2)
            details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({rst("fullname").ToString & "|0|left"}, 2)
        End While
        rst.Close()
        details += PrintGetSpace(LXMarginLeft) + PrintSpaceLine(3)

        If reprint = True Then
            com.CommandText = "select * from tbltransactionentries where ornumber='" & ornumber & "' and cifid='" & cifid & "' and fundcode='" & fundcode & "' and invrefcode='" & invrefcode & "' and credit>0" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tmpcollection" : rst = com.ExecuteReader
        End If
        While rst.Read
            details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({rst("trnname").ToString & "|0|left", FormatNumber(Val(If(reprint = True, rst("credit").ToString, rst("amount").ToString)), 2) & "|42|right"}, 1)
            If rst("explaination").ToString <> "" Then
                Dim description As String = "" : Dim fline As Boolean = True
                For Each word In rst("explaination").ToString.Split(New Char() {vbCrLf})
                    If fline = True Then
                        description += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({"  - " & word.Replace(vbCr, "").Replace(vbCrLf, "") & "|0|left"}, 1)
                        fline = False
                    Else
                        description += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({"  - " & word.Replace(vbCr, "").Replace(vbCrLf, "") & "|0|left"}, 1)
                    End If
                    collectionarea = collectionarea - 1
                Next
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({description & "|0|left"}, 0)
            End If
            collectionarea = collectionarea - 1
        End While
        rst.Close()

        details += PrintGetSpace(LXMarginLeft) + PrintSpaceLine(collectionarea)
        If reprint = True Then
            com.CommandText = "select * from tblcollectionlist where ornumber='" & ornumber & "' and cifid='" & cifid & "' and fundcode='" & fundcode & "'" : rst = com.ExecuteReader
        Else
            com.CommandText = "select * from tmpcollectionlist" : rst = com.ExecuteReader
        End If
        While rst.Read
            Dim paymentmode As String = ""
            If CBool(rst("cash")) = True Then
                paymentmode = "cash"
            ElseIf CBool(rst("check")) = True Then
                paymentmode = "check"
            ElseIf CBool(rst("moneyorder")) = True Then
                paymentmode = "moneyorder"
            End If
            details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({FormatNumber(Val(rst("total").ToString), 2) & "|42|right"}, 1)
            details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({ConvertCurrencyToEnglish(Val(rst("total").ToString)) & "|0|left"}, 3)
            If LCase(paymentmode) = "cash" Then
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({" X - " & UCase(paymentmode) & "|0|left"}, 3)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerName & "|32|center"}, 5)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerPosition & "|32|center"}, 1)
            ElseIf LCase(paymentmode) = "check" Then
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({" X - " & UCase(paymentmode) & "|0|left"}, 4)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({rst("checkbank").ToString & "|16|left", rst("checknumber").ToString & "|24|left", rst("checkdate").ToString & "|39|left"}, 1)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerName & "|32|center"}, 4)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerPosition & "|32|center"}, 1)
            Else
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({" X - Money Order|0|left", rst("checkbank").ToString & "|19|center", rst("checknumber").ToString & "|31|center", rst("checkdate").ToString & "|40|center"}, 5)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerName & "|32|center"}, 3)
                details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerPosition & "|32|center"}, 1)
            End If
        End While
        rst.Close()

        ExecutePrintCommand(details, "FORM51")
        Return True
    End Function

    Public Function PrintCedulaReceiptIndividual(ByVal communitytaxno As String, ByVal cifid As String, ByVal fundcode As String, ByVal reprint As Boolean) As Boolean
        Dim details As String = ""
        Dim tin As String = "" : Dim fullname As String = "" : Dim address As String = "" : Dim gender As String = "" : Dim citizenship As String = "" : Dim icrno As String = "" : Dim birthdate As String = "" : Dim birthplace As String = "" : Dim civilstatus As String = "" : Dim height As String = "" : Dim weight As String = "" : Dim profession As String = ""
        Dim yeartrn As String = "" : Dim dateissued As String = "" : Dim basic As Double = 0 : Dim additional As Double = 0 : Dim inputbusiness As Double = 0 : Dim totalbusiness As Double = 0 : Dim inputsalaries As Double = 0 : Dim totalsalaries As Double = 0 : Dim inputproperty As Double = 0 : Dim totalproperty As Double = 0 : Dim subtotal As Double = 0 : Dim totalinterest As Double = 0 : Dim amountpaid As Double = 0


        msda = New MySqlDataAdapter("select *,(select description from tbldatapicked where id=a.birthplace) as str_birthplace, " _
                                    + " (select description from tbldatapicked where id=a.profession) as str_profession, " _
                                    + " (select description from tbldatapicked where id=a.citizenship) as str_citizenship " _
                                    + " from tbltaxpayerprofile as a where cifid='" & cifid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                fullname = .Rows(cnt)("fullname").ToString()
                tin = .Rows(cnt)("tin").ToString()
                gender = .Rows(cnt)("gender").ToString()
                address = .Rows(cnt)("address").ToString()
                civilstatus = .Rows(cnt)("civilstatus").ToString()
                citizenship = .Rows(cnt)("str_citizenship").ToString()
                icrno = .Rows(cnt)("icrno").ToString()
                birthdate = If(.Rows(cnt)("birthdate").ToString = "", "", CDate(.Rows(cnt)("birthdate").ToString))
                birthplace = .Rows(cnt)("str_birthplace").ToString()
                height = .Rows(cnt)("height").ToString()
                weight = .Rows(cnt)("weight").ToString()
                profession = .Rows(cnt)("str_profession").ToString()
            End With
        Next

        If reprint = True Then
            msda = New MySqlDataAdapter("select *,right(yeartrn,2) as str_year from tblcommunitytax where communitytaxno='" & communitytaxno & "' and cifid='" & cifid & "' and fundcode='" & fundcode & "'", conn)
        Else
            msda = New MySqlDataAdapter("select *,right(yeartrn,2) as str_year from tmpcommunitytax", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                yeartrn = .Rows(cnt)("str_year").ToString()
                dateissued = .Rows(cnt)("postingdate").ToString()
                basic = Val(.Rows(cnt)("basiccomunitytax").ToString())
                additional = Val(.Rows(cnt)("additionalcomunitytax").ToString())
                inputbusiness = Val(.Rows(cnt)("inputbusiness").ToString())
                totalbusiness = Val(.Rows(cnt)("totalbusiness").ToString())
                inputsalaries = Val(.Rows(cnt)("inputsalary").ToString())
                totalsalaries = Val(.Rows(cnt)("totalsalary").ToString())
                inputproperty = Val(.Rows(cnt)("inputrealproperty").ToString())
                totalproperty = Val(.Rows(cnt)("totalrealproperty").ToString())
                subtotal = Val(.Rows(cnt)("subtotal").ToString())
                totalinterest = Val(.Rows(cnt)("interest").ToString())
                amountpaid = Val(.Rows(cnt)("amountpaid").ToString())
            End With
        Next
        Dim LXMarginTop As Integer = 0 : Dim LXMarginLeft As Integer = 0
        Dim code As String = qrysingledata("defaultcedulaindividual", "defaultcedulaindividual", "tbldefaultsettings")

        com.CommandText = "select * from tblaccountableform where code='" & code & "'" : rst = com.ExecuteReader
        While rst.Read
            LXMarginTop = CInt(rst("prnMarginTop").ToString)
            LXMarginLeft = CInt(rst("prnMarginLeft").ToString)
        End While
        rst.Close()

        details += PrintSpaceLine(LXMarginTop)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({communitytaxno & "|61|center"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({yeartrn & "|2|left", GlobalOrganizationName & "|6|left", dateissued & "|35|center"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({fullname & "|11|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({address & "|6|left", tin & "|45|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(gender = "M", "MALE", "FEMALE") & "|47|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({citizenship & "|0|left", icrno & "|5|left", birthplace & "|32|left", height & "|60|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({UCase(civilstatus) & "|3|left", birthdate & "|47|left", weight & "|60|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({profession & "|0|left"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(basic > 0, FormatNumber(basic, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(additional > 0, FormatNumber(additional, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(inputbusiness > 0, FormatNumber(inputbusiness, 2), "") & "|55|right", If(totalbusiness > 0, FormatNumber(totalbusiness, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(inputsalaries > 0, FormatNumber(inputsalaries, 2), "") & "|55|right", If(totalsalaries > 0, FormatNumber(totalsalaries, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(inputproperty > 0, FormatNumber(inputproperty, 2), "") & "|55|right", If(totalproperty > 0, FormatNumber(totalproperty, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(subtotal > 0, FormatNumber(subtotal, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(totalinterest > 0, FormatNumber(totalinterest, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerName & "|29|center", If(amountpaid > 0, FormatNumber(amountpaid, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerPosition & "|29|center"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({ConvertCurrencyToEnglish(amountpaid) & "|59|center"}, 1)
        ExecutePrintCommand(details, "CEDULA_INDIVIDUAL")
        Return True
    End Function

    Public Function PrintCedulaReceiptCorporation(ByVal communitytaxno As String, ByVal companyid As String, ByVal fundcode As String, ByVal reprint As Boolean) As Boolean
        Dim details As String = ""
        Dim companyname As String = "" : Dim address As String = "" : Dim dateregincorporation As String = "" : Dim placeincorporation As String = "" : Dim kindoforganization As String = "" : Dim businessnature As String = "" : Dim tin As String = ""
        Dim yeartrn As String = "" : Dim dateissued As String = "" : Dim basic As Double = 0 : Dim additional As Double = 0 : Dim inputproperty As Double = 0 : Dim totalproperty As Double = 0 : Dim inputgrossreceipts As Double = 0 : Dim totalgrossreceipts As Double = 0 : Dim subtotal As Double = 0 : Dim totalinterest As Double = 0 : Dim amountpaid As Double = 0


        msda = New MySqlDataAdapter("select *,  " _
                                    + " (select description from tbldatapicked where id=a.placeincorporation) as str_placeincorporation, " _
                                    + " (select description from tbldatapicked where id=a.businessnature) as str_businessnature " _
                                    + " from tblbusiness as a where id='" & companyid & "'", conn)
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                companyname = .Rows(cnt)("companyname").ToString()
                tin = .Rows(cnt)("tin").ToString()
                address = .Rows(cnt)("address").ToString()
                dateregincorporation = If(.Rows(cnt)("dateregincorporation").ToString = "", "", CDate(.Rows(cnt)("dateregincorporation").ToString))
                placeincorporation = .Rows(cnt)("str_placeincorporation").ToString()
                kindoforganization = UCase(.Rows(cnt)("kindoforganization").ToString())
                businessnature = .Rows(cnt)("str_businessnature").ToString()
            End With
        Next

        If reprint = True Then
            msda = New MySqlDataAdapter("select * from tblcommunitytaxcorp where communitytaxno='" & communitytaxno & "' and companyid='" & companyid & "' and fundcode='" & fundcode & "'", conn)
        Else
            msda = New MySqlDataAdapter("select * from tmpcommunitytaxcorp", conn)
        End If
        msda.Fill(dst, 0)
        For cnt = 0 To dst.Tables(0).Rows.Count - 1
            With (dst.Tables(0))
                yeartrn = .Rows(cnt)("yeartrn").ToString()
                dateissued = .Rows(cnt)("postingdate").ToString()
                basic = Val(.Rows(cnt)("basiccomunitytax").ToString())
                additional = Val(.Rows(cnt)("additionalcomunitytax").ToString())
                inputproperty = Val(.Rows(cnt)("inputrealproperty").ToString())
                totalproperty = Val(.Rows(cnt)("totalrealproperty").ToString())

                inputgrossreceipts = Val(.Rows(cnt)("inputgrossreceipts").ToString())
                totalgrossreceipts = Val(.Rows(cnt)("totalgrossreceipts").ToString())

                subtotal = Val(.Rows(cnt)("subtotal").ToString())
                totalinterest = Val(.Rows(cnt)("interest").ToString())
                amountpaid = Val(.Rows(cnt)("amountpaid").ToString())
            End With
        Next
        Dim LXMarginTop As Integer = 0 : Dim LXMarginLeft As Integer = 0
        Dim code As String = qrysingledata("defaultcedulacorporate", "defaultcedulacorporate", "tbldefaultsettings")

        com.CommandText = "select * from tblaccountableform where code='" & code & "'" : rst = com.ExecuteReader
        While rst.Read
            LXMarginTop = CInt(rst("prnMarginTop").ToString)
            LXMarginLeft = CInt(rst("prnMarginLeft").ToString)
        End While
        rst.Close()

        details += PrintSpaceLine(LXMarginTop)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({communitytaxno & "|61|center"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({yeartrn & "|0|left", GlobalOrganizationName & "|6|left", dateissued & "|35|center"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({companyname & "|0|left", tin & "|45|left"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({address & "|0|left"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({kindoforganization & "|0|left", placeincorporation & "|35|left", dateregincorporation & "|64|center"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({businessnature & "|0|left"}, 1)

        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(basic > 0, FormatNumber(basic, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(additional > 0, FormatNumber(additional, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(inputgrossreceipts > 0, FormatNumber(inputgrossreceipts, 2), "") & "|55|right", If(totalgrossreceipts > 0, FormatNumber(totalgrossreceipts, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(inputproperty > 0, FormatNumber(inputproperty, 2), "") & "|55|right", If(totalproperty > 0, FormatNumber(totalproperty, 2), "") & "|69|right"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(subtotal > 0, FormatNumber(subtotal, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({If(totalinterest > 0, FormatNumber(totalinterest, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerName & "|24|center", If(amountpaid > 0, FormatNumber(amountpaid, 2), "") & "|69|right"}, 2)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({GlobalTreasurerPosition & "|24|center"}, 1)
        details += PrintGetSpace(LXMarginLeft) + PrintLineByGroup({ConvertCurrencyToEnglish(amountpaid) & "|69|right"}, 1)
        ExecutePrintCommand(details, "CEDULA_CORPORATION")
        Return True
    End Function
End Module
