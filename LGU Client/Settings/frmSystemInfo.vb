Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO

Public Class frmSystemInfo
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmUserInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = ico
        lbltitle.Text = "Coffeecup Client " & fversion
        lbldescription.Text = "Licensed to: " & StrConv(GlobalOrganizationName.Replace("&", "&&"), vbProperCase)
        txtdate.Text = "Date Released " & Format(dversion, "MMMM dd, yyyy")
        Me.Cursor = Cursors.WaitCursor
        'com.CommandText = "select *, date_format(str_to_date(version, '%Y.%m.%d'), '%m/%d/%Y') as date from tblclientsystemupdate where active=1" : rst = com.ExecuteReader
        'If rst.Read Then
        '    'MsgBox(CDate(rst("version").ToString) & " - " & Format(dversion, "mm/dd/yyy"))
        '    If dversion < CDate(rst("date").ToString) Then
        '        txturl.Text = rst("downloadurl").ToString
        '        version.Text = rst("version").ToString
        '        cmdDownload.Text = "Download New Version v" & rst("version").ToString
        '        cmdDownload.Visible = True
        '        lbluptodate.Visible = False
        '        ' txtlink.Visible = True
        '    Else
        '        txturl.Text = ""
        '        version.Text = ""
        '        cmdDownload.Text = "Download New Version"
        '        cmdDownload.Visible = False
        '        lbluptodate.Visible = True
        '        ' txtlink.Visible = False
        '    End If
        'Else
        '    txturl.Text = ""
        '    version.Text = ""
        '    cmdDownload.Text = "Download New Version"
        '    cmdDownload.Visible = False
        '    lbluptodate.Visible = True
        'End If
        'rst.Close()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreset.Click
        Me.Close()
    End Sub

    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        'Me.Cursor = Cursors.WaitCursor
        'frmSystemDownloader.txtFileName.Text = txturl.Text
        'frmSystemDownloader.txtversion.Text = version.Text
        'Me.Cursor = Cursors.Default
        'frmSystemDownloader.ShowDialog()
        'Me.Close()
    End Sub

    Private Sub txtlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles txtlink.LinkClicked
        Dim details As String = ""
        com.CommandText = "select * from tblclientsystemupdate where server=0 order by id desc" : rst = com.ExecuteReader
        While rst.Read
            details += "#v" & rst("version").ToString & " update features:" & Environment.NewLine _
                        + rst("features").ToString & Environment.NewLine & Environment.NewLine
        End While
        rst.Close()

        If System.IO.File.Exists(Application.StartupPath & "\updateinfo.txt") = True Then
            System.IO.File.Delete(Application.StartupPath & "\updateinfo.txt")
        End If
        Dim detailsFile As StreamWriter = Nothing
        detailsFile = New StreamWriter(Application.StartupPath.ToString & "\updateinfo.txt", True)
        detailsFile.WriteLine("Coffeecup Client Update Logs" & Environment.NewLine & Environment.NewLine & details & "Winter S. Bugahod" & Environment.NewLine & "IT-Devt. Katipunan Bank")
        detailsFile.Close()

        Process.Start(Application.StartupPath & "\updateinfo.txt")
    End Sub
End Class