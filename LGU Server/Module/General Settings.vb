Module General_Settings
    Public ReportHeaderImg As Image = Nothing
    Public ReportFooterImg As Image = Nothing

    Public Sub LoadGeneralSettings()
        com.CommandText = "select * from tblgeneralsettings"
        rst = com.ExecuteReader
        While rst.Read

        End While
        rst.Close()

        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\letterhead.jpg") = True Then
            ReportHeaderImg = Image.FromFile(Application.StartupPath.ToString & "\img\letterhead.jpg")
        End If
        If System.IO.File.Exists(Application.StartupPath.ToString & "\img\letterfooter.jpg") = True Then
            ReportFooterImg = Image.FromFile(Application.StartupPath.ToString & "\img\letterfooter.jpg")
        End If
    End Sub

End Module
