Imports System.Drawing.Printing
Imports System.IO

Module Company
    Public compinitialcode As String
    Public compname As String
    Public compadd As String
    Public compnumber As String
    Public compemail As String
    Public compwebsite As String
    Public complogo As Image = Nothing

    Public complogimg As Image = Nothing
    Public compapproversign As Image = Nothing
    Public complogwidth
    Public complogheight
    Public GlobalOrganizationLogoURL As String

    Public GlobalMayorID As String
    Public GlobalMayorName As String
    Public GlobalMayorPosition As String

    Public GlobalViceMayorID As String
    Public GlobalViceMayorName As String
    Public GlobalViceMayorPosition As String

    Public GlobalAccountantID As String
    Public GlobalAccountantName As String
    Public GlobalAccountantPosition As String

    Public GlobalTreasurerID As String
    Public GlobalTreasurerName As String
    Public GlobalTreasurerPosition As String

    Public GlobalBudgetID As String
    Public GlobalBudgetName As String
    Public GlobalBudgetPosition As String

    Public Sub loadcompsettings()
        complogo = Nothing
        compapproversign = Nothing
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing

        Dim imgBytes2 As Byte() = Nothing
        Dim stream2 As MemoryStream = Nothing
        Dim img2 As Image = Nothing

        com.CommandText = "select *, " _
            + " (select fullname from tblaccounts where accountid=a.mayorname) as mayor, " _
            + " (select fullname from tblaccounts where accountid=a.vicemayorname) as vicemayor, " _
            + " (select fullname from tblaccounts where accountid=a.accountantname) as accountant, " _
            + " (select fullname from tblaccounts where accountid=a.treasurermame) as treasurer, " _
            + " (select fullname from tblaccounts where accountid=a.budgetname) as budget " _
            + " from tblcompanysettings as a"
        rst = com.ExecuteReader
        While rst.Read
            GlobalCompanyID = rst("companycode").ToString
            compinitialcode = rst("initialcode").ToString
            compname = rst("companyname").ToString
            compadd = rst("compadd").ToString
            compnumber = rst("telephone").ToString
            compemail = rst("email").ToString
            compwebsite = rst("website").ToString
           
            GlobalOrganizationLogoURL = rst("logourl").ToString
            If rst("logo").ToString <> "" Then
                imgBytes = CType(rst("logo"), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                complogo = img
            End If

            GlobalMayorID = rst("mayorname").ToString
            GlobalMayorName = rst("mayor").ToString
            GlobalMayorPosition = rst("mayorposition").ToString

            GlobalViceMayorID = rst("vicemayorname").ToString
            GlobalViceMayorName = rst("vicemayor").ToString
            GlobalViceMayorPosition = rst("vicemayorposition").ToString

            GlobalAccountantID = rst("accountantname").ToString
            GlobalAccountantName = rst("accountant").ToString
            GlobalAccountantPosition = rst("accountantposition").ToString

            GlobalTreasurerID = rst("treasurermame").ToString
            GlobalTreasurerName = rst("treasurer").ToString
            GlobalTreasurerPosition = rst("treasurerposition").ToString

            GlobalBudgetID = rst("budgetname").ToString
            GlobalBudgetName = rst("budget").ToString
            GlobalBudgetPosition = rst("budgetposition").ToString
        End While
        rst.Close()
        GlobalCopyrightName = GlobalSystemName & " © Winter Bugahod of " & StrConv(compname, VbStrConv.ProperCase)
    End Sub
    
End Module
