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

    Public GlobalMayorName As String
    Public GlobalMayorPosition As String
    Public GlobalAccountantName As String
    Public GlobalAccountantPosition As String
    Public GlobalTreasurerName As String
    Public GlobalTreasurerPosition As String

    Public Sub loadcompsettings()
        complogo = Nothing
        compapproversign = Nothing
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing

        Dim imgBytes2 As Byte() = Nothing
        Dim stream2 As MemoryStream = Nothing
        Dim img2 As Image = Nothing

        com.CommandText = "select * from tblcompanysettings"
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

            GlobalMayorName = rst("mayorname").ToString
            GlobalMayorPosition = rst("mayorposition").ToString

            GlobalAccountantName = rst("accountantname").ToString
            GlobalAccountantPosition = rst("accountantposition").ToString

            GlobalTreasurerName = rst("treasurermame").ToString
            GlobalTreasurerPosition = rst("treasurerposition").ToString
        End While
        rst.Close()
        GlobalCopyrightName = GlobalSystemName & " © Winter Bugahod of " & StrConv(compname, VbStrConv.ProperCase)
    End Sub
    
End Module
