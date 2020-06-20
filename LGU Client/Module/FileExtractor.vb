Imports System.IO
Imports Shell32
Imports MySql.Data.MySqlClient

Module FileExtractor
    'Public Function SendAttachment(ByVal refno As String, ByVal trntype As String, ByVal fileList() As String) As Boolean
    '    Dim FileSize As UInt32
    '    Dim rawData() As Byte
    '    Dim fs As FileStream

    '    'Try
    '    For Each strfile As String In fileList
    '        If Not strfile = "" Then
    '            com = Nothing : rawData = Nothing : FileSize = Nothing
    '            fs = New FileStream(strfile, FileMode.Open, FileAccess.Read)
    '            FileSize = fs.Length

    '            rawData = New Byte(FileSize) {}
    '            fs.Read(rawData, 0, FileSize)
    '            fs.Close()
    '            com = New MySqlCommand : com.Connection = conn
    '            com.CommandText = "DELETE FROM "  & sqlfiledir & ".tblattachmentlogs where refnumber='" & refno & "' and filename='" & rchar(Path.GetFileName(strfile)) & "';" : com.ExecuteNonQuery()
    '            com.CommandText = "INSERT INTO "  & sqlfiledir & ".tblattachmentlogs (refnumber,trntype, filename,extension,attachment,filesize,datesaved) " _
    '                + " VALUES('" & refno & "','" & trntype & "','" & rchar(Path.GetFileName(strfile)) & "','" & Path.GetExtension(strfile) & "',?File,?FileSize,current_timestamp)"
    '            com.Parameters.Add("?File", rawData)
    '            com.Parameters.Add("?FileSize", FileSize)
    '            com.ExecuteNonQuery()
    '        End If
    '    Next
    '    'Catch ex As Exception
    '    '    MessageBox.Show("Connection error during uploading attachment. click ok to retry upload.", "Error Uploading", _
    '    '        MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    '    Return False
    '    'End Try
    '    Return True
    'End Function
    'Public Function ExtractBlobFiles(ByVal refno As String)
    '    Dim extract_location As String = System.IO.Path.GetTempPath() & "CoffeecupFiles\"
    '    Dim myData As MySqlDataReader
    '    Dim rawData() As Byte
    '    Dim FileSize As UInt32
    '    Dim fs As FileStream
    '    Try
    '        While MainForm.BackgroundWorker1.IsBusy()
    '            Windows.Forms.Application.DoEvents()
    '        End While
    '        If (System.IO.Directory.Exists(extract_location)) Then
    '            My.Computer.FileSystem.DeleteDirectory(extract_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
    '        End If
    '        If (Not System.IO.Directory.Exists(extract_location)) Then
    '            System.IO.Directory.CreateDirectory(extract_location)
    '        End If

    '        For Each word In refno.Split(New Char() {","c})
    '            If word <> "" Then
    '                com.CommandText = "SELECT * FROM "  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & word & "'"
    '                myData = com.ExecuteReader
    '                While myData.Read
    '                    FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
    '                    rawData = New Byte(FileSize) {}
    '                    myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)
    '                    fs = New FileStream(extract_location & myData("filename").ToString, FileMode.OpenOrCreate, FileAccess.Write)
    '                    fs.Write(rawData, 0, FileSize)
    '                    fs.Close()
    '                End While
    '                myData.Close()
    '            End If
    '        Next
    '        Process.Start("explorer.exe", extract_location)

    '    Catch ex As Exception
    '        myData.Close()
    '        MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    Return True
    'End Function

    'Public Function ExtractSingleBlobFiles(ByVal refno As String, ByVal trntype As String) As Boolean
    '    Dim saveFileDialog1 As New SaveFileDialog()

    '    Dim myData As MySqlDataReader
    '    Dim rawData() As Byte
    '    Dim FileSize As UInt32
    '    Dim fs As FileStream
    '    Try
    '        While MainForm.BackgroundWorker1.IsBusy()
    '            Windows.Forms.Application.DoEvents()
    '        End While
    '        If qrysingledata("extension", "extension", ""  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & refno & "' and trntype='" & trntype & "'") <> "" Then
    '            saveFileDialog1.Filter = qrysingledata("extension", "extension", ""  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & refno & "' and trntype='" & trntype & "'") & "|*" & qrysingledata("extension", "extension", ""  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & refno & "' and trntype='" & trntype & "'")
    '            saveFileDialog1.FileName = UCase(qrysingledata("filename", "filename", ""  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & refno & "' and trntype='" & trntype & "'"))
    '            saveFileDialog1.FilterIndex = 2
    '            saveFileDialog1.RestoreDirectory = True

    '            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
    '                If System.IO.File.Exists(saveFileDialog1.FileName) = True Then
    '                    System.IO.File.Delete(saveFileDialog1.FileName)
    '                End If
    '                com.CommandText = "SELECT * FROM "  & sqlfiledir & ".tblattachmentlogs where refnumber = '" & refno & "' and trntype='" & trntype & "'"
    '                myData = com.ExecuteReader
    '                While myData.Read
    '                    FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
    '                    rawData = New Byte(FileSize) {}
    '                    myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)
    '                    fs = New FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write)
    '                    fs.Write(rawData, 0, FileSize)
    '                    fs.Close()
    '                End While
    '                myData.Close()
    '                MessageBox.Show("File successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                Return True
    '            End If
    '        Else
    '            MessageBox.Show("File not available yet. please wait your approved request to be generated by procurement", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        myData.Close()
    '        MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try


    '    Return True
    'End Function
End Module
