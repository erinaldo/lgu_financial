Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports System.Security
Imports System.IO
Imports DevExpress.XtraEditors

Public Class frmRequisitionBrowseFile

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyDataGridView.RowCount = 0 Then
            XtraMessageBox.Show("Not file to be upload!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If MyDataGridView.RowCount > 0 Then
            For i = 0 To MyDataGridView.RowCount - 1
                If MyDataGridView.Rows(i).Cells("Error").Value() = "1" Then
                    MsgBox("Please check your selected file not more than " & FormatNumber((GlobalAllowableAttachSize / 1024), 2) & " KB", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            Next
        End If
        If MyDataGridView.RowCount > 0 Then
            For i = 0 To MyDataGridView.RowCount - 1
                AddAttachmentRequisition(pid.Text, trntype.Text, {MyDataGridView.Rows(i).Cells("Location").Value()}, docname.Text, filecode.Text)
            Next
        End If
        If frmRequisitionDocManager.Visible = True Then
            frmRequisitionDocManager.filterItem()
        End If
        Me.Close()
        'If MessageBox.Show("Are you sure you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

        '    MsgBox("Atachment successfully uploaded!", MsgBoxStyle.Information)

        'End If
    End Sub

    Private Sub frmLoanAdjustment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadRequestType()
        InitializeOpenFileDialog()
        MyDataGridView.Rows.Clear()
        MyDataGridView.ColumnCount = 5
        MyDataGridView.ColumnHeadersVisible = True

        MyDataGridView.Columns(0).Name = "File Name"
        MyDataGridView.Columns(1).Name = "File Sized"
        MyDataGridView.Columns(2).Name = "Location"
        MyDataGridView.Columns(3).Name = "Error"
        MyDataGridView.Columns(4).Name = "database"

        GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
        GridHideColumn(MyDataGridView, {"Location", "Error", "database"})
        'showExistingFile()
    End Sub

    Public Sub LoadRequestType()
        'select (select description from tbldocumenttype where code=tblapprovingattachment.doccode) as document from tblapprovingattachment where trncode='" & requesttype.Text & "' and appid='-' and doccode not in (SELECT b.docname FROM `tblrequisitionfiles` as a inner join lgufiledir.tblattachmentlogs as b on a.filecode=b.filecode and a.pid=b.refnumber where pid='" & pid.Text & "' and a.applevel='0' and a.requesttype='" & requesttype.Text & "' )
        LoadXgridLookupSearch("select doccode,(select description from tbldocumenttype where code=tblapprovingattachment.doccode) as 'Select' from tblapprovingattachment where trncode='" & requesttype.Text & "'  and doccode not in (select docname from " & sqlfiledir & ".tblattachmentlogs as b where refnumber='" & pid.Text & "'  and trntype='requisition') order by (select description from tbldocumenttype where code=tblapprovingattachment.doccode) asc", "tbldocumenttype", txtFileName, gridfilename)
        gridfilename.Columns("doccode").Visible = False
    End Sub

    Private Sub txtFileName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileName.EditValueChanged
        On Error Resume Next
        docname.Text = txtFileName.Properties.View.GetFocusedRowCellValue("doccode").ToString()
        If docname.Text = "" Then
            Button2.Enabled = False
        Else
            Button2.Enabled = True
            Button2.PerformClick()
        End If
    End Sub
    '

    Public Sub InitializeOpenFileDialog()
        ' Set the file dialog to filter for graphics files. 
        Me.OpenFileDialog1.Filter = _
                "All files (*.*)|*.*"

        ' Allow the user to select multiple images. 
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "My Image Browser"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FileSize As UInt32 : Dim rawData() As Byte : Dim fs As FileStream

        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            ' Read the files 
            Dim file As String
            For Each file In OpenFileDialog1.FileNames
                rawData = Nothing : FileSize = Nothing
                fs = New FileStream(file, FileMode.Open, FileAccess.Read)
                FileSize = fs.Length

                Try
                    MyDataGridView.Rows.Add(System.IO.Path.GetFileNameWithoutExtension(rchar(file)), FormatNumber((FileSize / 1024), 2) & " KB", file, If(checkAttachment(file) = False, 1, 0), "")
                Catch SecEx As SecurityException
                    ' The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" &
                        "Error message: " & SecEx.Message & "\n\n" &
                        "Details (send to Support):\n\n" & SecEx.StackTrace)
                Catch ex As Exception
                    ' Could not load the image - probably permissions-related.
                    MessageBox.Show(("Cannot display the image: " & file.Substring(file.LastIndexOf("\"c)) &
                    ". You may not have permission to read the file, or " + "it may be corrupt." _
                    & ControlChars.Lf & ControlChars.Lf & "Reported error: " & ex.Message))
                End Try
            Next file
            GridColumnAlignment(MyDataGridView, {"File Sized"}, DataGridViewContentAlignment.MiddleRight)
            GridHideColumn(MyDataGridView, {"Location", "Error"})
            If MyDataGridView.RowCount > 0 Then
                For i = 0 To MyDataGridView.RowCount - 1
                    If MyDataGridView.Rows(i).Cells("Error").Value() = "1" Then
                        MyDataGridView.Rows(i).DefaultCellStyle.BackColor = Color.Red
                        MyDataGridView.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
                txtFileName.Properties.ReadOnly = True
            Else
                txtFileName.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub cmdBrowseFile_Click(sender As Object, e As EventArgs) Handles cmdDeleteFile.Click
        Dim dr As DataGridViewRow
        For Each dr In MyDataGridView.SelectedRows
            MyDataGridView.Rows.Remove(dr)
        Next
    End Sub
End Class
