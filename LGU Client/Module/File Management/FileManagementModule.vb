Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Imports MySql.Data.MySqlClient

Module FileManagementModule
    Private Const BUFFER_SIZE As Long = 4096
    Public GlobalStrAttachment As String = " ifnull((select if(count(*)>0,cast(concat(count(*), ' File(s) Attached') as char),null) from " & sqlfiledir & ".tblattachmentlogs where refnumber = tblrequisitions.pid),'-') as 'Attachment', "

    Public Function ViewAttachmentPackage_All(ByVal refno As Array, ByVal trntype As String)
        Dim Root_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globalusername & "\"
        Dim extract_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globalusername & "\" & CDate(Now).ToString("yyyyMMddhhmmss") & "\"
        Dim myData As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream
        Try
            If (System.IO.Directory.Exists(Root_location)) Then
                My.Computer.FileSystem.DeleteDirectory(Root_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(extract_location)) Then
                System.IO.Directory.CreateDirectory(extract_location)
            End If

            Dim strtrntype As String = ""
            If trntype.Length > 0 Then
                strtrntype = " and trntype='" & trntype & "'"
            End If

            For Each refnumber As String In refno
                Dim filetoView As String = ""
                com.CommandText = "select * from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & refnumber & "'" & strtrntype : rst = com.ExecuteReader
                While rst.Read
                    filetoView = filetoView + rst("databasename").ToString & ","
                End While
                rst.Close()

                For Each word In filetoView.Split(New Char() {","c})
                    If word <> "" Then
                        com.CommandText = "SELECT * FROM " & sqlfiledir & ".`" & word & "` where refnumber = '" & refnumber & "'" & strtrntype
                        myData = com.ExecuteReader
                        While myData.Read
                            FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
                            rawData = New Byte(FileSize) {}

                            myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)

                            fs = New FileStream(extract_location & myData("filename").ToString, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(rawData, 0, FileSize)
                            fs.Close()
                        End While
                        myData.Close()
                    End If
                Next
            Next
            Process.Start("explorer.exe", extract_location)

        Catch ex As Exception
            myData.Close()
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function

    Public Function ViewAttachmentPackage_Individual(ByVal id_selected As Array)
        Dim Root_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globalusername & "\"
        Dim extract_location As String = System.IO.Path.GetTempPath() & "Dockeeper\" & globalusername & "\" & CDate(Now).ToString("yyyyMMddhhmmss") & "\"
        Dim myData As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream
        Try
            If (System.IO.Directory.Exists(Root_location)) Then
                My.Computer.FileSystem.DeleteDirectory(Root_location, FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            If (Not System.IO.Directory.Exists(extract_location)) Then
                System.IO.Directory.CreateDirectory(extract_location)
            End If

            Dim id As String = ""
            If id_selected.Length > 0 Then
                For Each itm In id_selected
                    id += "id='" & itm & "' or "
                Next
                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from " & sqlfiledir & ".tblattachmentlogs where (" & id.Remove(id.Length - 3, 3) & ")", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        com.CommandText = "SELECT * FROM " & sqlfiledir & ".`" & .Rows(cnt)("databasename").ToString() & "` where archievedname = '" & .Rows(cnt)("archievedname").ToString() & "' and filesize = '" & .Rows(cnt)("filesize").ToString() & "' and trntype='" & .Rows(cnt)("trntype").ToString() & "'" : myData = com.ExecuteReader
                        While myData.Read
                            FileSize = myData.GetUInt32(myData.GetOrdinal("filesize"))
                            rawData = New Byte(FileSize) {}

                            myData.GetBytes(myData.GetOrdinal("attachment"), 0, rawData, 0, FileSize)

                            fs = New FileStream(extract_location & myData("filename").ToString, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(rawData, 0, FileSize)
                            fs.Close()
                        End While
                        myData.Close()
                    End With
                Next
                Process.Start("explorer.exe", extract_location)
            End If
        Catch ex As Exception
            myData.Close()
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function

    Public Function GetAttachmentDate() As String
        com.CommandText = "select date_format(current_timestamp,'%Y%m%d') as trackdate" : rst = com.ExecuteReader
        While rst.Read
            GetAttachmentDate = rst("trackdate").ToString
        End While
        rst.Close()
        Return GetAttachmentDate
    End Function

    Public Function AddAttachmentPackage(ByVal refno As String, ByVal trntype As String, ByVal fileLocation As Array) As Boolean
        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            For Each flocation As String In fileLocation
                If System.IO.File.Exists(flocation) = True Then
                    com = Nothing : rawData = Nothing : FileSize = Nothing
                    com = New MySqlCommand : com.Connection = conn
                    If countqry("information_schema.tables", "table_schema='" & sqlfiledir & "' and table_name='tbl" & GetAttachmentDate() & "'") = 0 Then
                        com.CommandText = "CREATE TABLE  `" & sqlfiledir & "`.`tbl" & GetAttachmentDate() & "` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,  `trntype` varchar(45) NOT NULL,  `filename` varchar(500) CHARACTER SET latin1 NOT NULL,  `archievedname` text NOT NULL,  `extension` varchar(45) NOT NULL,  `attachment` longblob,  `filesize` bigint(20) unsigned NOT NULL,  `datesaved` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
                    End If
                    fs = New FileStream(flocation, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length

                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()
                    Dim ArchievedName As String = NewMd5FileName(flocation) & Path.GetExtension(flocation)
                    com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & refno & "' and trntype='" & trntype & "' and databasename='tbl" & GetAttachmentDate() & "' and filename='" & rchar(Path.GetFileName(flocation)) & "'" : com.ExecuteNonQuery()
                    com.CommandText = "delete from " & sqlfiledir & ".`tbl" & GetAttachmentDate() & "` where refnumber='" & refno & "' and trntype='" & trntype & "' and filename='" & rchar(Path.GetFileName(flocation)) & "'" : com.ExecuteNonQuery()

                    com.CommandText = "insert into " & sqlfiledir & ".tblattachmentlogs set refnumber='" & refno & "', trntype='" & trntype & "', databasename='tbl" & GetAttachmentDate() & "',filename='" & rchar(Path.GetFileName(flocation)) & "',archievedname='" & ArchievedName & "', filesize='" & FileSize & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO " & sqlfiledir & ".`tbl" & GetAttachmentDate() & "` (refnumber,trntype,filename,archievedname,extension,attachment,filesize,datesaved) " _
                        + " VALUES('" & refno & "','" & trntype & "','" & rchar(Path.GetFileName(flocation)) & "','" & ArchievedName & "','" & Path.GetExtension(flocation) & "',?File,?FileSize,current_timestamp)"
                    com.Parameters.AddWithValue("?File", rawData)
                    com.Parameters.AddWithValue("?FileSize", FileSize)
                    com.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function AddAttachmentRequisition(ByVal refno As String, ByVal trntype As String, ByVal fileLocation As Array, ByVal docname As String, ByVal filecode As String) As Boolean
        Dim FileSize As UInt32
        Dim rawData() As Byte
        Dim fs As FileStream

        Try
            For Each flocation As String In fileLocation
                If System.IO.File.Exists(flocation) = True Then
                    com = Nothing : rawData = Nothing : FileSize = Nothing
                    com = New MySqlCommand : com.Connection = conn
                    If countqry("information_schema.tables", "table_schema='" & sqlfiledir & "' and table_name='tbl" & GetAttachmentDate() & "'") = 0 Then
                        com.CommandText = "CREATE TABLE  `" & sqlfiledir & "`.`tbl" & GetAttachmentDate() & "` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `refnumber` varchar(105) CHARACTER SET latin1 NOT NULL,  `trntype` varchar(45) NOT NULL,  `docname` varchar(45) NOT NULL DEFAULT '',  `filecode` varchar(45) NOT NULL DEFAULT '',  `filename` varchar(500) CHARACTER SET latin1 NOT NULL,  `archievedname` text NOT NULL,  `extension` varchar(45) NOT NULL,  `attachment` longblob,  `filesize` bigint(20) unsigned NOT NULL,  `datesaved` datetime NOT NULL,  PRIMARY KEY (`id`)) ENGINE=MyISAM AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
                    End If
                    fs = New FileStream(flocation, FileMode.Open, FileAccess.Read)
                    FileSize = fs.Length

                    rawData = New Byte(FileSize) {}
                    fs.Read(rawData, 0, FileSize)
                    fs.Close()
                    Dim ArchievedName As String = NewMd5FileName(flocation) & Path.GetExtension(flocation)
                    com.CommandText = "delete from " & sqlfiledir & ".tblattachmentlogs where refnumber='" & refno & "' and trntype='" & trntype & "' and docname='" & docname & "' and filecode='" & filecode & "' and databasename='tbl" & GetAttachmentDate() & "' and filename='" & rchar(Path.GetFileName(flocation)) & "'" : com.ExecuteNonQuery()
                    com.CommandText = "delete from " & sqlfiledir & ".`tbl" & GetAttachmentDate() & "` where refnumber='" & refno & "' and trntype='" & trntype & "' and docname='" & docname & "' and filecode='" & filecode & "' and filename='" & rchar(Path.GetFileName(flocation)) & "'" : com.ExecuteNonQuery()

                    com.CommandText = "insert into " & sqlfiledir & ".tblattachmentlogs set refnumber='" & refno & "', trntype='" & trntype & "',docname='" & docname & "',filecode='" & filecode & "', databasename='tbl" & GetAttachmentDate() & "',filename='" & rchar(Path.GetFileName(flocation)) & "',archievedname='" & ArchievedName & "', filesize='" & FileSize & "'" : com.ExecuteNonQuery()
                    com.CommandText = "INSERT INTO " & sqlfiledir & ".`tbl" & GetAttachmentDate() & "` (refnumber,trntype,docname,filecode,filename,archievedname,extension,attachment,filesize,datesaved) " _
                        + " VALUES('" & refno & "','" & trntype & "','" & docname & "','" & filecode & "','" & rchar(Path.GetFileName(flocation)) & "','" & ArchievedName & "','" & Path.GetExtension(flocation) & "',?File,?FileSize,current_timestamp)"
                    com.Parameters.AddWithValue("?File", rawData)
                    com.Parameters.AddWithValue("?FileSize", FileSize)
                    com.ExecuteNonQuery()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", _
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function NewMd5FileName(ByVal str As String) As String
        com.CommandText = "select md5(concat('" & str & "',date_format(current_timestamp,'%Y%m%d%h%i%s'))) as trackdate" : rst = com.ExecuteReader
        While rst.Read
            NewMd5FileName = rst("trackdate").ToString
        End While
        rst.Close()
        Return NewMd5FileName
    End Function

    Public Function GetAttachmentName() As String
        com.CommandText = "select date_format(current_timestamp,'%Y%m%d') as trackdate" : rst = com.ExecuteReader
        While rst.Read
            GetAttachmentName = rst("trackdate").ToString
        End While
        rst.Close()
        Return GetAttachmentName
    End Function

 
End Module
