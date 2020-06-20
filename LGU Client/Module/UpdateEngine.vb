Imports DevExpress.XtraEditors
Imports System.IO
Imports MySql.Data.MySqlClient

Module UpdateEngine
    Dim engineupdated As Boolean = False
    Dim features As String = ""

    Public Sub SystemDatabaseUpdater()
        On Error Resume Next
        Dim updateVersion As String = "" : Dim updateDescription As String = ""
         
        'updateVersion = "2018-08-14"
        'If CBool(qrysingledata("proceedupdate", " if(date_format(databaseversion, '%Y-%m-%d') < '" & updateVersion & "',true,false) as proceedupdate", "tbldatabaseupdatelogs order by databaseversion desc limit 1")) = True Then
        '    com.CommandText = "ALTER TABLE `tblchatlogs` ADD COLUMN `isnotified` BOOLEAN NOT NULL DEFAULT 0 AFTER `isread`;" : com.ExecuteNonQuery() : DatabaseUpdateLogs(updateVersion, rchar(com.CommandText.ToCharArray))
        '    engineupdated = True
        'End If

     
        If engineupdated = True Then
            Dim dversion As Date = updateVersion
            MessageBox.Show("Your database engine was updated to Build Version v" & dversion.ToString("yy.M.d") & Environment.NewLine, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            engineupdated = False
        End If
    End Sub

    Public Function DatabaseUpdateLogs(ByVal nVersions As String, ByVal strQuery As String)
        com.CommandText = "insert into tbldatabaseupdatelogs set databaseversion='" & nVersions & "',dateupdate=current_timestamp,appliedquery='" & strQuery & "'" : com.ExecuteNonQuery()
        Return 0
    End Function

  
End Module
