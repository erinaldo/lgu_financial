Public Class ListControl

    Public Event ItemClick(sender As Object, Index As String)
    Public Event ItemFocus(sender As Object, Index As String)

    Public Sub Add(userid As String, username As String, description As String, UnreadMsg As String, ProfileImage As Image)
        Dim c As New ListControlItem
        With c
            ' Assign an auto generated name
            .Name = userid
            .Margin = New Padding(0)
            ' set properties
            .Song = username
            .Artist = description
            .Duration = UnreadMsg
            .Image = ProfileImage
        End With
        ' To check when the selection is changed
        AddHandler c.SelectionChanged, AddressOf SelectionChanged
        AddHandler c.Click, AddressOf ItemClicked
        AddHandler c.GotFocus, AddressOf ItemFocused

        flpListBox.Controls.Add(c)
        SetupAnchors()
    End Sub

    Public Sub Remove(Index As Integer)
        Dim c As ListControlItem = flpListBox.Controls(Index)
        Remove(c.Name)  ' call the below sub
    End Sub

    Public Sub Remove(name As String)
        ' grab which control is being removed
        Dim c As ListControlItem = flpListBox.Controls(name)
        flpListBox.Controls.Remove(c)
        ' remove the event hook
        RemoveHandler c.SelectionChanged, AddressOf SelectionChanged
        RemoveHandler c.Click, AddressOf ItemClicked
        ' now dispose off properly
        c.Dispose()
        SetupAnchors()
    End Sub

    Public Sub EditItem(ByVal moveFirst As Boolean, userid As String, username As String, description As String, UnreadMsg As String, ProfileImage As Image)
        Edit(moveFirst, userid, username, description, UnreadMsg, ProfileImage)  ' call the below sub
    End Sub

    Public Sub Edit(ByVal moveFirst As Boolean, userid As String, username As String, description As String, UnreadMsg As String, ProfileImage As Image)
        ' grab which control is being removed
        Dim c As ListControlItem = flpListBox.Controls(userid)
        With c
            ' Assign an auto generated name
            .Name = userid
            .Margin = New Padding(0)
            ' set properties
            .Song = username
            .Artist = description
            .Duration = UnreadMsg
            .Image = ProfileImage
        End With
        SetupAnchors()
        If moveFirst = True Then
            flpListBox.Controls.SetChildIndex(c, 0)
        End If
    End Sub

    Public Sub Clear()
        Do
            If flpListBox.Controls.Count = 0 Then Exit Do
            Dim c As ListControlItem = flpListBox.Controls(0)
            flpListBox.Controls.Remove(c)
            ' remove the event hook
            RemoveHandler c.SelectionChanged, AddressOf SelectionChanged
            RemoveHandler c.Click, AddressOf ItemClicked
            ' now dispose off properly
            c.Dispose()
        Loop
        mLastSelected = Nothing
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return flpListBox.Controls.Count
        End Get
    End Property

    Private Sub SetupAnchors()
        If flpListBox.Controls.Count > 0 Then
            For i = 0 To flpListBox.Controls.Count - 1
                Dim c As Control = flpListBox.Controls(i)
                If i = 0 Then
                    ' Its the first control, all subsequent controls follow 
                    ' the anchor behavior of this control.
                    c.Anchor = AnchorStyles.Left + AnchorStyles.Top
                    If (c.Height * flpListBox.Controls.Count) > flpListBox.Height Then
                        c.Width = flpListBox.Width - SystemInformation.VerticalScrollBarWidth
                    Else
                        c.Width = flpListBox.Width
                    End If
                Else
                    ' It is not the first control. Set its anchor to
                    ' copy the width of the first control in the list.
                    c.Anchor = AnchorStyles.Left + AnchorStyles.Right
                End If
            Next
        End If
    End Sub

    Private Sub flpListBox_Resize(sender As Object, e As System.EventArgs) Handles flpListBox.Resize
        If flpListBox.Controls.Count Then
            flpListBox.Controls(0).Width = flpListBox.Width - SystemInformation.VerticalScrollBarWidth
        End If
    End Sub

    Dim mLastSelected As ListControlItem = Nothing
    Private Sub SelectionChanged(sender As Object)
        If mLastSelected IsNot Nothing Then
            mLastSelected.Selected = False
        End If
        mLastSelected = sender
    End Sub

    Private Sub ItemClicked(sender As Object, e As System.EventArgs)
        RaiseEvent ItemClick(Me, sender.name)
    End Sub

    Private Sub ItemFocused(sender As Object, e As System.EventArgs)
        RaiseEvent ItemFocus(Me, sender.name)
    End Sub
End Class
