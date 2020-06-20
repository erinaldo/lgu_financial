Imports System.Security.Cryptography
Imports System
Module SystemSecurity

#Region "Encryptor / Decryptor"
    Const sKey As String = "kira"

    Public Function EncryptTripleDES(ByVal sIn As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function DecryptTripleDES(ByVal sOut As String) As String
        Try
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(sKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch errMS As Exception

        End Try
    End Function


    Public Function EncryptCoffeecup(ByVal sIn As String, ByVal myKey As String) As String
        Dim DES As New TripleDESCryptoServiceProvider()
        Dim hashMD5 As New MD5CryptoServiceProvider()

        ' Compute the MD5 hash.
        DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(myKey))
        ' Set the cipher mode.
        DES.Mode = CipherMode.ECB
        ' Create the encryptor.
        Dim DESEncrypt As ICryptoTransform = DES.CreateEncryptor()
        ' Get a byte array of the string.
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(sIn)
        ' Transform and return the string.
        Return Convert.ToBase64String(DESEncrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function Decryptoffeecup(ByVal sOut As String, ByVal myKey As String) As String
        Try
            Dim DES As New TripleDESCryptoServiceProvider()
            Dim hashMD5 As New MD5CryptoServiceProvider()

            ' Compute the MD5 hash.
            DES.Key = hashMD5.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(myKey))
            ' Set the cipher mode.
            DES.Mode = CipherMode.ECB
            ' Create the decryptor.
            Dim DESDecrypt As ICryptoTransform = DES.CreateDecryptor()
            Dim Buffer As Byte() = Convert.FromBase64String(sOut)
            ' Transform and return the string.
            Return System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypt.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch errMS As Exception

        End Try
    End Function


#End Region

End Module
