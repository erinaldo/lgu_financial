Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.ComponentModel
Imports System.Security.Permissions

<PermissionSet(SecurityAction.Demand, Name:="FullTrust")> _
<System.Runtime.InteropServices.ComVisibleAttribute(True)> _
Public Class frmChatBoxMain
    Dim img As New ImageList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        ElseIf keyData = (Keys.Control) + Keys.F12 Then
            If LCase(globalusername) = "root" Then
                frmChatboxBlasting.ShowDialog()
            End If
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmChatBoxMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        'Me.Show()

        img.ImageSize = New Size(40, 40)
        WebBrowser1.Navigate("about:blank")
        Dim doc As HtmlDocument = Me.WebBrowser1.Document
        Dim FileDetails = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Templates\Chat\index.html")
        doc.Write(FileDetails)
        ShowContactList()

        'monitor where user is typing
        bwTyping.WorkerSupportsCancellation = True
        AddHandler bwTyping.DoWork, AddressOf bwTyping_DoWork
        AddHandler bwTyping.RunWorkerCompleted, AddressOf bwTyping_RunWorkerCompleted

        bwReceivedMessage.WorkerSupportsCancellation = True
        AddHandler bwReceivedMessage.DoWork, AddressOf bwReceivedMessage_DoWork
        AddHandler bwReceivedMessage.RunWorkerCompleted, AddressOf bwReceivedMessage_RunWorkerCompleted

        bwRefresh.WorkerSupportsCancellation = True
        AddHandler bwRefresh.DoWork, AddressOf bwRefresh_DoWork
        AddHandler bwRefresh.RunWorkerCompleted, AddressOf bwRefresh_RunWorkerCompleted

        'bwSeen.WorkerSupportsCancellation = True
        'AddHandler bwSeen.DoWork, AddressOf bwSeen_DoWork
        'AddHandler bwSeen.RunWorkerCompleted, AddressOf bwSeen_RunWorkerCompleted

        Me.WebBrowser1.ObjectForScripting = Me
        Application.DoEvents()
        
        bwReceivedMessage.RunWorkerAsync()
        bwRefresh.RunWorkerAsync()
    End Sub
    Public Sub RemoveMessage(ByVal val As String)
        If MessageBox.Show("Are you sure you want to remove?", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "UPDATE tblchatlogs set s_deleted=1 where id='" & val & "' and sender='" & globaluserid & "'" : com.ExecuteNonQuery()
            com.CommandText = "UPDATE tblchatlogs set r_deleted=1 where id='" & val & "' and receiver='" & globaluserid & "'" : com.ExecuteNonQuery()
            WebBrowser1.Document.InvokeScript("RemoveElement", {val})
        End If
    End Sub

    Public Sub BeginningCoversationCheck()
        If ListControl1.Count = 0 Then
            If txtAccountid.Text = "" Then
                PanelControl1.Parent = SplitContainerControl2.Panel2
                txtContent.ReadOnly = True
                PanelControl1.Visible = True

                PanelControl1.Width = SplitContainerControl2.Panel2.Width
                PanelControl1.Height = SplitContainerControl2.Panel2.Height
                PanelControl1.BringToFront()

                txtWelcome.Text = "Welcome " & StrConv(globalfullname, vbProperCase) & " to the Coffeecup Chatbox! To begin new conversation, start search by name, position or office name to search user and hit enter key.."
            End If
        Else
            If txtAccountid.Text = "" Then
                txtContent.ReadOnly = True
                PanelControl1.Visible = True
                txtWelcome.Text = "Welcome " & StrConv(globalfullname, vbProperCase) & " to the Coffeecup Chatbox! To begin new conversation, start search by name, position or office name to search user and hit enter key.."
            Else
                txtContent.ReadOnly = False
                PanelControl1.Visible = False
            End If
        End If
    End Sub

    Public Sub ShowContactList()
        If txtSearchUser.Text.Length > 2 Then
            img.Images.Clear()
            ListControl1.Clear()
            Dim cntimg As Integer = 0
            com.CommandText = "select accountid,fullname,designation,profileimg from tblaccounts where coffeecupuser=1 and deleted=0 and (fullname like '%" & rchar(txtSearchUser.Text) & "%' or designation like '%" & rchar(txtSearchUser.Text) & "%' or (select officename from tblcompoffice where officeid=tblaccounts.officeid) like '%" & rchar(txtSearchUser.Text) & "%') order by fullname asc" : rst = com.ExecuteReader
            While rst.Read
                If rst("profileimg").ToString <> "" Then
                    img.Images.Add("userimg", ConvertImageBinary("profileimg"))
                Else
                    img.Images.Add("userimg", My.Resources.no_picture_male)
                End If
                ListControl1.Add(rst("accountid").ToString, StrConv(rst("fullname").ToString, vbProperCase), StrConv(rst("designation").ToString, vbProperCase), "", img.Images(cntimg))
                cntimg += 1
            End While
            rst.Close()
        Else
            img.Images.Clear()
            ListControl1.Clear()
            Dim cntimg As Integer = 0 : Dim unread As String = 0
            com.CommandText = "select *,(select count(*) from tblchatlogs where receiver='" & globaluserid & "' and sender=tblchatheader.contactid and isread=0) as unread, (select if((r_deleted=1 or s_deleted=1),1,0) from tblchatlogs where (receiver='" & globaluserid & "' and sender=tblchatheader.contactid) or (receiver=tblchatheader.contactid and sender='" & globaluserid & "') order by datesent desc limit 1) as lastMessageDeleted, " _
                    + " (select profileimg from tblaccounts where accountid=tblchatheader.contactid) as profileimg, (select designation from tblaccounts where accountid=tblchatheader.contactid) as designation from tblchatheader where ownerid='" & globaluserid & "' and deleted=0 order by lastupdate desc" : rst = com.ExecuteReader
            While rst.Read
                If rst("profileimg").ToString <> "" Then
                    Dim imgProfile = ConvertImageBinary("profileimg")
                    Dim wd As Integer = imgProfile.Height
                    Dim CropRect As New Rectangle((imgProfile.Width / 2) - (wd / 2), 0, wd, imgProfile.Height)
                    Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
                    Using grp = Graphics.FromImage(CropImage)
                        grp.DrawImage(imgProfile, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                    End Using
                    img.Images.Add("userimg", CropImage)
                Else
                    img.Images.Add("userimg", My.Resources.no_picture_male)
                End If

                If CInt(rst("unread").ToString) > 0 Then
                    unread = rst("unread").ToString & " Unread"
                Else
                    unread = ""
                End If
                If CInt(rst("lastMessageDeleted")) > 0 Then
                    ListControl1.Add(rst("contactid").ToString, StrConv(rst("contactname").ToString, vbProperCase), StrConv(rst("designation").ToString, vbProperCase), unread, img.Images(cntimg))
                Else
                    ListControl1.Add(rst("contactid").ToString, StrConv(rst("contactname").ToString, vbProperCase), rst("lastmessage").ToString, unread, img.Images(cntimg))
                End If

                cntimg += 1
            End While
            rst.Close()
            com.CommandText = "update tblchatheader set synched=1 where contactid='" & globaluserid & "'" : com.ExecuteNonQuery()
            ListControl1.Focus()
        End If
        BeginningCoversationCheck()
    End Sub

    Private Sub txtContent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContent.KeyPress
        If e.KeyChar() = Chr(13) Then
            If txtContent.Text <> "" Then
                AddMessage(txtAccountid.Text, txtContent.Text)
                txtContent.Focus() : txtContent.Text = ""
            End If
        End If
    End Sub

    Public Sub LoadAccountProfile()
        If txtAccountid.Text = "" Then Exit Sub
        com.CommandText = "SELECT *,(select officename from tblcompoffice where officeid=tblaccounts.officeid) as office FROM `tblaccounts` where accountid='" & txtAccountid.Text & "'" : rst = com.ExecuteReader
        While rst.Read
            txtfullname.Text = rst("fullname").ToString
            txtNickname.Text = rst("nickname").ToString
            txtOffice.Text = StrConv(rst("office").ToString, vbProperCase)
            txtPosition.Text = StrConv(rst("designation").ToString, vbProperCase)
            txtEmailAddress.Text = If(rst("emailaddress").ToString = "", "No email address", rst("emailaddress").ToString)
            txtContactNumber.Text = If(rst("contactnumber").ToString = "", "No contact number", rst("contactnumber").ToString)
            If rst("profileimg").ToString <> "" Then
                Dim imgProfile = ConvertImageBinary("profileimg")
                Dim wd As Integer = imgProfile.Height
                Dim CropRect As New Rectangle((imgProfile.Width / 2) - (wd / 2), 0, wd, imgProfile.Height)
                Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
                Using grp = Graphics.FromImage(CropImage)
                    grp.DrawImage(imgProfile, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                End Using
                Profileimg.Image = CropImage
            Else
                Profileimg.Image = My.Resources.no_picture_male
            End If
        End While
        rst.Close()

        If countqry("tbllogin", "userid='" & txtAccountid.Text & "'") = 0 Then
            imgstatus.Image = My.Resources.status_offline
            txtStatus.Text = "Offline"
            txtStatus.ForeColor = Color.DimGray
        Else
            com.CommandText = "SELECT *,ROUND(time_to_sec((TIMEDIFF(NOW(), intime))) / 60) as idleminute FROM `tbllogin` where userid='" & txtAccountid.Text & "' order by intime desc limit 1;" : rst = com.ExecuteReader
            While rst.Read
                If rst("outtime").ToString = "" Then
                    imgstatus.Image = My.Resources.status_online
                    txtStatus.Text = "Online"
                    txtStatus.ForeColor = Color.Green

                    'If CInt(rst("idleminute")) > 15 Then
                    '    imgstatus.Image = My.Resources.status_idle
                    '    txtStatus.Text = "Idle"
                    '    txtStatus.ForeColor = Color.Orange
                    'Else
                    '    imgstatus.Image = My.Resources.status_online
                    '    txtStatus.Text = "Online"
                    '    txtStatus.ForeColor = Color.Green
                    'End If
                Else
                    imgstatus.Image = My.Resources.status_offline
                    txtStatus.Text = "Offline"
                    txtStatus.ForeColor = Color.DimGray
                End If
            End While
            rst.Close()
        End If
        com.CommandText = "update tblchatheader set typing=0 where ownerid='" & globaluserid & "' or contactid='" & globaluserid & "'" : com.ExecuteNonQuery()
        ShowLastLog()
        BeginningCoversationCheck()
    End Sub

    Private Sub ListControl1_GotFocus(sender As Object, userid As String) Handles ListControl1.ItemFocus
        txtAccountid.Text = userid
        UpdateLineContactList(userid, False)
    End Sub

    Private Sub ListControl1_ItemClick(sender As Object, userid As String) Handles ListControl1.ItemClick
        txtAccountid.Text = userid
        UpdateLineContactList(userid, False)
    End Sub

    Private Sub txtSearchUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchUser.KeyPress
        If e.KeyChar() = Chr(13) Then
            ShowContactList()
        End If
    End Sub

    Private Sub txtAccountid_EditValueChanged(sender As Object, e As EventArgs) Handles txtAccountid.EditValueChanged
        LoadAccountProfile()
    End Sub

    Public Sub UpdateLineContactList(ByVal userid As String, ByVal movefirst As Boolean)
        Dim unread As String = 0
        img.Images.Clear()
        com.CommandText = "select *,(select count(*) from tblchatlogs where receiver='" & globaluserid & "' and sender=tblchatheader.contactid and isread=0) as unread,(select if((r_deleted=1 or s_deleted=1),1,0) from tblchatlogs where (receiver='" & globaluserid & "' and sender='" & userid & "') or (receiver='" & userid & "' and sender='" & globaluserid & "') order by datesent desc limit 1) as lastMessageDeleted,  " _
                            + " (select profileimg from tblaccounts where accountid=tblchatheader.contactid) as profileimg,(select designation from tblaccounts where accountid=tblchatheader.contactid) as designation from tblchatheader where ownerid='" & globaluserid & "'  and deleted=0  and contactid='" & userid & "'" : rst = com.ExecuteReader
        While rst.Read
            If rst("profileimg").ToString <> "" Then
                Dim imgProfile = ConvertImageBinary("profileimg")
                Dim wd As Integer = imgProfile.Height
                Dim CropRect As New Rectangle((imgProfile.Width / 2) - (wd / 2), 0, wd, imgProfile.Height)
                Dim CropImage = New Bitmap(CropRect.Width, CropRect.Height)
                Using grp = Graphics.FromImage(CropImage)
                    grp.DrawImage(imgProfile, New Rectangle(0, 0, CropRect.Width, CropRect.Height), CropRect, GraphicsUnit.Pixel)
                End Using
                img.Images.Add("userimg", CropImage)
            Else
                img.Images.Add("userimg", My.Resources.no_picture_male)
            End If
            If CInt(rst("unread").ToString) > 0 Then
                unread = rst("unread").ToString & " Unread"
            Else
                unread = ""
            End If

            If CInt(rst("lastMessageDeleted")) > 0 Then
                ListControl1.EditItem(movefirst, userid, StrConv(rst("contactname").ToString, vbProperCase), StrConv(rst("designation").ToString, vbProperCase), unread, img.Images(0))
            Else
                ListControl1.EditItem(movefirst, userid, StrConv(rst("contactname").ToString, vbProperCase), rst("lastmessage").ToString, unread, img.Images(0))
            End If
        End While
        rst.Close()
    End Sub

    Private Sub txtSearchUser_TextChanged(sender As Object, e As EventArgs) Handles txtSearchUser.TextChanged
        If txtSearchUser.Text = "" Then
            ShowContactList()
        End If
    End Sub

    Private Sub Profileimg_Click(sender As Object, e As EventArgs) Handles Profileimg.Click
        frmChatPicturePreview.Width = Profileimg.Image.Width
        frmChatPicturePreview.Height = Profileimg.Image.Height
        frmChatPicturePreview.Profileimg.Image = Profileimg.Image
        frmChatPicturePreview.Text = txtfullname.Text
        If frmChatPicturePreview.Visible = True Then
            frmChatPicturePreview.Focus()
        Else
            frmChatPicturePreview.Show(Me)
        End If
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        ShowContactList()
    End Sub

#Region "Chat events"
    Public Sub ShowLastLog()
        'If txtAccountid.Text = "" Then Exit Sub
        Dim ChatLogs As String = "" : Dim cnt_chat_logs As Integer = 0
        com.CommandText = "select *,date_format(datesent,'%Y-%m-%d') as dt from (select * from tblchatlogs where (receiver='" & globaluserid & "' and sender='" & txtAccountid.Text & "' and r_deleted=0) or (receiver='" & txtAccountid.Text & "' and sender='" & globaluserid & "' and s_deleted=0) order by datesent desc limit 50) as a order by a.datesent asc" : rst = com.ExecuteReader
        While rst.Read
            Dim ChatCaption As String = ""
            If CDate(rst("dt").ToString) = CDate(Now.ToShortDateString) Then
                Dim minutesDiff = DateDiff(DateInterval.Minute, CDate(rst("datesent").ToString), CDate(Now))
                If minutesDiff < 60 Then
                    If minutesDiff = 0 Then
                        ChatCaption = "Just now."
                    Else
                        ChatCaption = minutesDiff & " minutes ago"
                    End If
                Else
                    Dim HourDiff = DateDiff(DateInterval.Hour, CDate(rst("datesent").ToString), CDate(Now))
                    ChatCaption = HourDiff & " hour ago"
                End If
            Else
                ChatCaption = CDate(rst("dt").ToString).ToString("MMMM dd, yyyy")
            End If

            If rst("sender").ToString = globaluserid Then
                If CheckEdit1.Checked = True Then
                    ChatLogs += "<div id=""" & rst("id").ToString & """ class=""from-me""><p>" & rst("message").ToString & "</p><span><a OnClick=""javascript:RemoveMessage('" & rst("id").ToString & "')"">Delete</a> | " & ChatCaption & "</span></div><div class=""clear""></div>"
                Else
                    ChatLogs += "<div id=""" & rst("id").ToString & """ class=""from-me""><p>" & rst("message").ToString & "</p></div><div class=""clear""></div>"
                End If

            Else
                If CheckEdit1.Checked = True Then
                    ChatLogs += "<div id=""" & rst("id").ToString & """ class=""from-them""><p>" & rst("message").ToString & "</p><span><a OnClick=""javascript:RemoveMessage('" & rst("id").ToString & "')"">Delete</a> | " & ChatCaption & "</span></div><div class=""clear""></div>"
                Else
                    ChatLogs += "<div id=""" & rst("id").ToString & """ class=""from-them""><p>" & rst("message").ToString & "</p></div><div class=""clear""></div>"
                End If

            End If
            cnt_chat_logs = 1
        End While
        rst.Close()
        If cnt_chat_logs = 0 Then
            WebBrowser1.Document.InvokeScript("LoadLastChat", {"<div align=""center"">Say hi to " & StrConv(txtfullname.Text, vbProperCase) & "..</div>"})
        Else
            If ChatLogs.Length > 0 Then
                com.CommandText = "Update tblchatlogs set isread=1,dateread=current_timestamp where receiver='" & globaluserid & "' and sender='" & txtAccountid.Text & "'" : com.ExecuteNonQuery()
                WebBrowser1.Document.InvokeScript("LoadLastChat", {ChatLogs.Replace(vbCrLf, "</br>")})

                ''check if seen
                'com.CommandText = "select id,isread,datesent,date_format(datesent,'%Y-%m-%d') as dt  from tblchatlogs where sender='" & globaluserid & "' and receiver='" & txtAccountid.Text & "'  order by datesent desc limit 1" : rst = com.ExecuteReader
                'While rst.Read
                '    If CBool(rst("isread")) = True Then
                '        WebBrowser1.Document.InvokeScript("RemoveElement", {"seen"})
                '        WebBrowser1.Document.InvokeScript("AddDefaultText", {"seen", "<div id=""seen"" class=""default"" align=""right"">Seen.</div>"})
                '    End If
                'End While
                'rst.Close()
            End If
        End If
    End Sub

    Public Sub AddMessage(ByVal accountid As String, ByVal message As String)
        com.CommandText = "insert into tblchatlogs set sender='" & globaluserid & "',sendername='" & LCase(globalfullname) & "', receiver='" & accountid & "', receivername='" & LCase(txtfullname.Text) & "', message='" & rchar(message) & "', datesent=current_timestamp" : com.ExecuteNonQuery()
        'synch my contact list
        If countqry("tblchatheader", "(ownerid='" & globaluserid & "' and contactid='" & accountid & "')") = 0 Then
            com.CommandText = "insert into tblchatheader set synched=1, ownerid='" & globaluserid & "', contactid='" & accountid & "', contactname=(select fullname from tblaccounts where accountid='" & accountid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblchatheader set synched=1,deleted=0, contactname=(select fullname from tblaccounts where accountid='" & accountid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp where (ownerid='" & globaluserid & "' and contactid='" & accountid & "')" : com.ExecuteNonQuery()
        End If

        'synch for thier contact list
        If countqry("tblchatheader", "(ownerid='" & accountid & "' and contactid='" & globaluserid & "')") = 0 Then
            com.CommandText = "insert into tblchatheader set synched=0, ownerid='" & accountid & "', contactid='" & globaluserid & "', contactname=(select fullname from tblaccounts where accountid='" & globaluserid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblchatheader set synched=0, deleted=0, contactname=(select fullname from tblaccounts where accountid='" & globaluserid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp where (ownerid='" & accountid & "' and contactid='" & globaluserid & "')" : com.ExecuteNonQuery()
        End If
        WebBrowser1.Document.InvokeScript("ReplyChat", {message.Replace(vbCrLf, "</br>")})
        UpdateLineContactList(accountid, True)
    End Sub

#End Region

#Region "Send Typing"
    Private Sub txtContent_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContent.TextChanged
        If txtAccountid.Text = "" Then Exit Sub
        'The user has just added, edited or removed a value, so restart the Timer.    
        tmrWatchTyping.Stop()
        com.CommandText = "update tblchatheader set typing=1 where ownerid='" & txtAccountid.Text & "' and contactid='" & globaluserid & "'" : com.ExecuteNonQuery()
        tmrWatchTyping.Start()
    End Sub

    Private Sub tmrWatchTyping_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWatchTyping.Tick
        'The user hasn't changed the input for the specified period, so stop the Timer (which will be started again the next time the user changes the input).
        tmrWatchTyping.Stop()
        com.CommandText = "update tblchatheader set typing=0 where ownerid='" & txtAccountid.Text & "' and contactid='" & globaluserid & "'" : com.ExecuteNonQuery()
    End Sub
#End Region

#Region "Read Typing - background worker"
    Dim bwTyping As BackgroundWorker = New BackgroundWorker
    Private Sub tmrReadTyping_Tick(sender As Object, e As EventArgs) Handles tmrReadTyping.Tick
        If Not bwTyping.IsBusy Then
            bwTyping.RunWorkerAsync()
        End If
    End Sub

    Private Sub DoThreadedStuff()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ReadTyping())
        Else
            ReadTyping()
        End If
    End Sub

    Private Sub bwTyping_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 1
            tmrReadTyping.Stop()
            If bwTyping.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            DoThreadedStuff()
            'System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Private Sub bwTyping_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        tmrReadTyping.Start()
    End Sub
    Public Sub ReadTyping()
        If txtAccountid.Text = "" Then Exit Sub
        msda_chat_typing = Nothing : dst_chat_typing = New DataSet
        msda_chat_typing = New MySqlDataAdapter("select typing from tblchatheader where ownerid='" & globaluserid & "' and contactid='" & txtAccountid.Text & "'", conn)
        msda_chat_typing.Fill(dst_chat_typing, 0)
        For cnt_chat_typing = 0 To dst_chat_typing.Tables(0).Rows.Count - 1
            With (dst_chat_typing.Tables(0))
                If CBool(.Rows(cnt_chat_typing)("typing").ToString()) = True Then
                    'lblDisplay.Text =
                    WebBrowser1.Document.InvokeScript("AddDefaultText", {"typing", "<div id=""typing"" class=""default"" align=""left"">" & StrConv(txtNickname.Text, vbProperCase) & " is typing...</div>"})
                Else
                    'lblDisplay.Text = ""
                    WebBrowser1.Document.InvokeScript("RemoveElement", {"typing"})
                End If
            End With
        Next
    End Sub
#End Region

#Region "Received Chat Message - background worker"
    Dim bwReceivedMessage As BackgroundWorker = New BackgroundWorker
    Private Sub tmrReceivedMessage_Tick(sender As Object, e As EventArgs) Handles tmrReceivedMessage.Tick
        If Not bwReceivedMessage.IsBusy Then
            bwReceivedMessage.RunWorkerAsync()
        End If
    End Sub

    Private Sub DoThreadedRM()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ReceivedMessage())
        Else
            ReceivedMessage()
        End If
    End Sub

    Private Sub bwReceivedMessage_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 1
            tmrReceivedMessage.Stop()
            If bwReceivedMessage.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            DoThreadedRM()
        Next
    End Sub

    Private Sub bwReceivedMessage_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        tmrReceivedMessage.Start()
    End Sub

    Public Sub ReceivedMessage()
        If txtAccountid.Text = "" Then Exit Sub
        msda_chat = Nothing : dst_chat = New DataSet
        msda_chat = New MySqlDataAdapter("select id,message,sender from tblchatlogs where sender='" & txtAccountid.Text & "' and receiver='" & globaluserid & "' and isread=0", conn)
        msda_chat.Fill(dst_chat, 0)
        For cnt_chat = 0 To dst_chat.Tables(0).Rows.Count - 1
            With (dst_chat.Tables(0))
                com.CommandText = "Update tblchatlogs set isread=1, dateread=current_timestamp where id='" & .Rows(cnt_chat)("id").ToString() & "'" : com.ExecuteNonQuery()
                WebBrowser1.Document.InvokeScript("ReceivedChat", {.Rows(cnt_chat)("message").ToString().Replace(vbCrLf, "</br>")})
                'UpdateLineContactList(.Rows(cnt_chat)("sender").ToString(), True)
                'WebBrowser1.Document.InvokeScript("RemoveElement", {"seen"})
            End With
        Next
    End Sub
#End Region

#Region "Live refresh contact list - background worker"
    Dim bwRefresh As BackgroundWorker = New BackgroundWorker
    Private Sub tmrRefreshList_Tick(sender As Object, e As EventArgs) Handles tmrRefreshList.Tick
        If Not bwRefresh.IsBusy Then
            bwRefresh.RunWorkerAsync()
        End If
    End Sub

    Private Sub DoThreadedRefresh()
        If Me.InvokeRequired Then
            Me.Invoke(Sub() RefreshContactList())
        Else
            RefreshContactList()
        End If
    End Sub

    Private Sub bwRefresh_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
        For i = 1 To 1
            tmrRefreshList.Stop()
            If bwRefresh.CancellationPending = True Then
                e.Cancel = True
                Exit For
            End If
            DoThreadedRefresh()
            'System.Threading.Thread.Sleep(1000)
        Next
    End Sub

    Private Sub bwRefresh_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        tmrRefreshList.Start()
    End Sub

    Public Sub RefreshContactList()
        msda_chat = Nothing : dst_chat = New DataSet
        msda_chat = New MySqlDataAdapter("select id,contactid from tblchatheader where ownerid='" & globaluserid & "' and deleted=0 and synched=0 order by lastupdate desc", conn)
        msda_chat.Fill(dst_chat, 0)
        For cnt_chat = 0 To dst_chat.Tables(0).Rows.Count - 1
            With (dst_chat.Tables(0))
                UpdateLineContactList(.Rows(cnt_chat)("contactid").ToString(), True)
                com.CommandText = "update tblchatheader set synched=1 where id='" & .Rows(cnt_chat)("id").ToString() & "'" : com.ExecuteNonQuery()
            End With
        Next
    End Sub
#End Region

#Region "Checking if Message is seen - background worker"
    'Dim bwSeen As BackgroundWorker = New BackgroundWorker
    'Private Sub tmrSeen_Tick(sender As Object, e As EventArgs) Handles tmrSeen.Tick
    '    If Not bwSeen.IsBusy Then
    '        If txtAccountid.Text = "" Then Exit Sub
    '        bwSeen.RunWorkerAsync()
    '    End If
    'End Sub

    'Private Sub DoThreadedSeen()
    '    If Me.InvokeRequired Then
    '        Me.Invoke(Sub() CheckSeenMessage())
    '    Else
    '        CheckSeenMessage()
    '    End If
    'End Sub

    'Private Sub bwSeen_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
    '    Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)
    '    For i = 1 To 1
    '        tmrSeen.Stop()
    '        If bwSeen.CancellationPending = True Then
    '            e.Cancel = True
    '            Exit For
    '        End If
    '        DoThreadedSeen()
    '    Next
    'End Sub

    'Private Sub bwSeen_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
    '    tmrSeen.Start()
    'End Sub

    'Public Sub CheckSeenMessage()
    '    msda_chat_seen = Nothing : dst_chat_seen = New DataSet
    '    msda_chat_seen = New MySqlDataAdapter("select id,datesent,date_format(datesent,'%Y-%m-%d') as dt  from tblchatlogs where sender='" & globaluserid & "' and receiver='" & txtAccountid.Text & "' and isread=1 and isreadupdate=0 order by datesent desc limit 1", conn)
    '    msda_chat_seen.Fill(dst_chat_seen, 0)
    '    For cnt_chat_seen = 0 To dst_chat_seen.Tables(0).Rows.Count - 1
    '        If dst_chat_seen.Tables(0).Rows.Count > 0 Then
    '            With (dst_chat_seen.Tables(0))
    '                WebBrowser1.Document.InvokeScript("RemoveElement", {"seen"})
    '                WebBrowser1.Document.InvokeScript("AddDefaultText", {"seen", "<div id=""seen"" class=""default"" align=""right"">Seen.</div>"})
    '                com.CommandText = "update tblchatlogs set isreadupdate=1 where id='" & .Rows(cnt_chat_seen)("id").ToString() & "'" : com.ExecuteNonQuery()
    '            End With
    '        End If
    '    Next
    'End Sub
#End Region

   
    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        ShowLastLog()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ListControl1.Focus()
    End Sub
     
End Class