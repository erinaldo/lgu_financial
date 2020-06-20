Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.Skins

Public Class frmChatboxBlasting

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Checked)
            Next
        Else
            For I = 0 To CheckedListBox1.Items.Count - 1
                CheckedListBox1.SetItemCheckState(I, CheckState.Unchecked)
            Next
        End If

    End Sub

    Private Sub frmChatboxBlasting_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmChatboxBlasting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        CheckedListBox1.Items.Clear()
        LoaodActiveUser()
        LoadToComboBoxDB("select * from tblaccounts where deleted=0 order by fullname asc", "fullname", "accountid", txtUserAccount)
    End Sub
    Public Sub LoaodActiveUser()
        com.CommandText = "SELECT distinct userid, fullname FROM `tbllogin` inner join tblaccounts on  tbllogin.userid =tblaccounts.accountid where deleted=0 order by fullname;" : rst = com.ExecuteReader
        While rst.Read
            CheckedListBox1.Items.Add(rst("userid").ToString & ":" & rst("fullname").ToString, True)
        End While
        rst.Close()

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If MessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            ProgressBar1.Value = 0
            ProgressBar1.Maximum = CheckedListBox1.CheckedItems.Count
            'For I = 0 To CheckedListBox1.CheckedItems.Count - 1
            '    CheckedListBox1.SetItemCheckState(I, CheckState.Checked)
            'Next
            Dim cnt As Integer = 1
            For Each itm In CheckedListBox1.CheckedItems
                Dim Split As String() = itm.ToString().Split(":")
                AddMessage(userid.Text, txtUserAccount.Text, Split(0), Split(1), txtContent.Text)
                ProgressBar1.Value = cnt
                cnt += 1
            Next
            MsgBox("Message successfully blasted")
        End If
    End Sub

    Public Sub AddMessage(ByVal senderid As String, ByVal sendername As String, ByVal receiverid As String, ByVal receivername As String, ByVal message As String)
        com.CommandText = "insert into tblchatlogs set sender='" & senderid & "',sendername='" & LCase(sendername) & "', receiver='" & receiverid & "', receivername='" & LCase(receivername) & "', message='" & rchar(message) & "', datesent=current_timestamp, s_deleted=1" : com.ExecuteNonQuery()
        'synch my contact list
        If countqry("tblchatheader", "(ownerid='" & senderid & "' and contactid='" & receiverid & "')") = 0 Then
            com.CommandText = "insert into tblchatheader set synched=1, deleted=1, ownerid='" & senderid & "', contactid='" & receiverid & "', contactname=(select fullname from tblaccounts where accountid='" & receiverid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblchatheader set synched=1, deleted=1, contactname=(select fullname from tblaccounts where accountid='" & receiverid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp where (ownerid='" & senderid & "' and contactid='" & receiverid & "')" : com.ExecuteNonQuery()
        End If

        'synch for thier contact list
        If countqry("tblchatheader", "(ownerid='" & receiverid & "' and contactid='" & senderid & "')") = 0 Then
            com.CommandText = "insert into tblchatheader set synched=0, ownerid='" & receiverid & "', contactid='" & senderid & "', contactname=(select fullname from tblaccounts where accountid='" & senderid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp" : com.ExecuteNonQuery()
        Else
            com.CommandText = "UPDATE tblchatheader set synched=0, contactname=(select fullname from tblaccounts where accountid='" & senderid & "'), lastmessage='" & rchar(message) & "', lastupdate=current_timestamp where (ownerid='" & receiverid & "' and contactid='" & senderid & "')" : com.ExecuteNonQuery()
        End If
    End Sub

    Private Sub txtUserAccount_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtUserAccount.SelectedValueChanged
        userid.Text = DirectCast(txtUserAccount.SelectedItem, ComboBoxItem).HiddenValue
    End Sub
End Class