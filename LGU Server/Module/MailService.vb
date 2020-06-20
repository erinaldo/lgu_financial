Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraBars.Alerter

Module MailService
    Public Function FormattingEmailBody(ByVal value As String) As String
        value = value.Replace(vbCrLf, "<br/>")
        value = value.Replace(vbCr, "")
        value = value.Replace("Ñ", "&Ntilde;")
        value = value.Replace("ñ", "&ntilde;")
        value = value.Replace("  -  ", "&nbsp; &nbsp; - &nbsp; &nbsp;")
        Return value
    End Function

    Public Function getEmailAccount(ByVal userid As String) As String
        getEmailAccount = qrysingledata("emailaddress", "emailaddress", "where accountid='" & userid & "'", "tblaccounts")
        Return getEmailAccount
    End Function

    Public Function getOfficeEmail(ByVal officeid As String) As String
        getOfficeEmail = qrysingledata("officeemail", "officeemail", "where officeid='" & officeid & "'", "tblcompoffice")
        Return getOfficeEmail
    End Function

    Public Sub InsertEmailNotification(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String, ByVal CommandQuery As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(FormattingEmailBody(emailbody + "<br/><br/><b>" + globalfullname + "</b><br/>" + globaldesignation + "<br/>" + globalEmailaddress + "<br/><br/>" _
                                + "<em color=""grey"">*This is a coffeecup system generated email and use for notification only. To view full transaction, please login on coffeecup system. thank you*</em>")) & "'" : com.ExecuteNonQuery()
        End If
        If CommandQuery <> "" Then
            com.CommandText = CommandQuery : com.ExecuteNonQuery()
        End If
    End Sub

    Public Sub InsertHTMLEmailNotification(ByVal trntype As String, ByVal receiver As String, ByVal subject As String, emailbody As String, ByVal CommandQuery As String)
        If receiver.Length > 5 Then
            com.CommandText = "insert into tblemailnotification set trntype='" & trntype & "',receiver='" & receiver & "', subject='" & Trim(rchar(subject)) & "', emailbody='" & EncryptTripleDES(emailbody) & "'" : com.ExecuteNonQuery()
        End If
        If CommandQuery <> "" Then
            com.CommandText = CommandQuery : com.ExecuteNonQuery()
        End If
    End Sub

End Module
