Imports System.IO
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Design
Imports System.Xml
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions


Module mySettings
    Public initialID As String = ""
    Public myID As String = ""
    Public globaldate As String
    Public removechar As Char() = "\".ToCharArray()
    Public sb As New System.Text.StringBuilder
    Public MemoEdit As New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Public SpinEdit As New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

    Public ComboBoxEdit As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public colImageEdit As New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Public globaltheme As String = "Visual Studio 2013 Dark"
    Public TargetFile As String
    Public ico As Icon

    Public SystemRemoted As Boolean = False
    Public Remotetype As Integer
    Public remotecountdown As Integer

    Public GlobalAllowableAttachSize As Double = 10240
    Public GlobalGLitemname As String = "if(a.level=0, a.itemname,if(a.level=1,concat('   ',a.itemname),if(a.level=2,concat('           ',a.itemname),if(a.level=3,concat('                  ',a.itemname),concat('                         ',a.itemname)))))"

    Public Function TextBoxColorCode(ByVal txtbox As DevExpress.XtraEditors.TextEdit)
        If txtbox.Text = "APPROVED" Then
            txtbox.BackColor = Color.Lime
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "CLOSED" Then
            txtbox.BackColor = Color.Gold
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "FOR APPROVAL" Or txtbox.Text = "ON HOLD" Or txtbox.Text = "PENDING PAYMENT" Then
            txtbox.BackColor = Color.DarkOrange
            txtbox.ForeColor = Color.Black

        ElseIf txtbox.Text = "DISAPPROVED" Or txtbox.Text = "CANCELLED" Then
            txtbox.BackColor = Color.Red
            txtbox.ForeColor = Color.White

        ElseIf txtbox.Text = "DELIVERED" Or txtbox.Text = "DISBURSED" Then
            txtbox.BackColor = Color.LightSeaGreen
            txtbox.ForeColor = Color.Black
        End If
        Return 0
    End Function

    Public Sub loadIcons()
        TargetFile = Application.StartupPath + "\ico.ico"
        ico = New Icon(TargetFile)
    End Sub
    Public Sub SetIcon(ByVal form As DevExpress.XtraEditors.XtraForm)
        form.Icon = ico
    End Sub


#Region "IMAGE VARIABLES"
    Public imgBytes As Byte() = Nothing
    Public stream As MemoryStream = Nothing
    Public img As Image = Nothing
    Public sqlcmd As New MySqlCommand
    Public sql As String
    Public arrImage() As Byte = Nothing
#End Region

#Region "COMPONENT TOOL VARIABLES"
    Public Row As DataRow : Public Rows() As DataRow : Public I As Integer : Public todelete As String
    Public combogrid As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public combogrid2 As New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Public PicEdit As New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
#End Region

    Public Function rchar(ByVal str As String)
        str = str.Replace("'", "''")
        str = str.Replace("\", "\\")
        Return str
    End Function

    Public Function RemoveWhiteSpaces(ByVal str As String, ByVal removeSpecialChar As Boolean)
        Dim newStrstr As String = str
        newStrstr = Regex.Replace(newStrstr, " {2,}", "S")
        newStrstr = Regex.Replace(newStrstr, "\\s+", "")
        If removeSpecialChar = True Then
            newStrstr = RemoveSpecialCharacter(newStrstr)
        Else
            newStrstr = newStrstr.Replace("'", "''")
            newStrstr = newStrstr.Replace("\", "\\")
        End If
        Return newStrstr
    End Function

    Public Function RemoveSpecialCharacter(ByVal str As String)
        Dim removechar As Char() = "!@#$%^&*()_+-={}|[]\:;'<>?/".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function

    Public Function getGlobalTrnid(ByVal init As String, ByVal endid As String)
        Dim strs As Date
        Dim finalstr As String = ""

        com.CommandText = "select current_timestamp as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
            finalstr = strs.ToString("yyyyMMddhhmmss")
        End While
        rst.Close()
        finalstr = init & "-" & finalstr & "-" & endid
        Return finalstr
    End Function
    Public Function getGlobalRequestid(ByVal init As String, ByVal endid As String)
        Dim strs As Date
        Dim finalstr As String = ""

        com.CommandText = "select current_timestamp as trnid"
        rst = com.ExecuteReader
        While rst.Read
            strs = rst("trnid").ToString
            finalstr = strs.ToString("yyyy-MM-dd")
        End While
        rst.Close()
        finalstr = init & "-" & finalstr.Replace("-", "") & "-" & endid
        Return finalstr
    End Function
    Public Function XgridColNumber(ByVal i As String, ByVal xgrid As DevExpress.XtraGrid.Views.Grid.GridView)
        Try
            xgrid.Columns(i).DisplayFormat.FormatType = FormatType.Numeric
            xgrid.Columns(i).DisplayFormat.FormatString = "N0"
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
        Return 0
    End Function
    Public Sub loadLoginAppearance()
        Dim imgBytes As Byte() = Nothing
        Dim stream As MemoryStream = Nothing
        Dim img As Image = Nothing

        com.CommandText = "select * from tblappearance where form='frmLogin'"
        rst = com.ExecuteReader
        While rst.Read
            complogwidth = rst("width").ToString
            complogheight = rst("height").ToString

            If rst("img").ToString <> "" Then
                imgBytes = CType(rst("img"), Byte())
                stream = New MemoryStream(imgBytes, 0, imgBytes.Length)
                img = Image.FromStream(stream)
                complogimg = img
            End If

        End While
        rst.Close()
    End Sub

    Public Function GlobalTime()
        Dim a As String = ""
        com.CommandText = "SELECT current_time as currtime" : rst = com.ExecuteReader()
        While rst.Read
            a = rst("currtime").ToString
        End While
        rst.Close()
        Return a
    End Function
    Public Sub LoadGlobalDate()
        Dim dg As String = ""
        com.CommandText = "select current_date as trackdate"
        rst = com.ExecuteReader
        While rst.Read
            globaldate = ConvertDate(rst("trackdate").ToString)
        End While
        rst.Close()
    End Sub
    Public Function GlobalDateTime()
        Dim gdatetime As String = ""
        gdatetime = globaldate + " " + GlobalTime()
        Return gdatetime
    End Function
    Public Function ConvertDate(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd")
    End Function
    Public Function ConvertServerTime(ByVal d As Date)
        Return d.ToString("HH:mm:ss")
    End Function
    Public Function ConvertDateTime(ByVal d As Date)
        Return d.ToString("yyyy-MM-dd HH:mm:ss")
    End Function
    Public Function CC(ByVal m As String)
        Return m.Replace(",", "")
    End Function
    Public Function ProperDate(ByVal d As Date)
        Return d.ToString("MM/dd/yyyy")
    End Function

    Public Function strConvert(ByVal txt As String) As String
        Dim str As String
        str = StrConv(txt, vbProperCase)
        Return str
    End Function
    Public Function GetDateTimeID()
        com.CommandText = "SELECT date_format(current_timestamp,'%Y%m%d-%r') as currtime" : rst = com.ExecuteReader()
        Dim removechar As Char() = ":/AMPM ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        While rst.Read()

            Dim str As String = rst("currtime").ToString
            For Each ch As Char In str
                If Array.IndexOf(removechar, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
            initialID = StrConv(initialID, vbUpperCase)
            myID = sb.ToString
        End While
        rst.Close()
        Return myID
    End Function
   
    Public Function getcodeid(ByVal code As String, ByVal table As String, ByVal initialcode As String)
        Dim strng = ""
        Try
            If CInt(countrecord(table)) = 0 Then
                strng = initialcode
            Else
                com.CommandText = "select (" & code & " + 1) as code from " & table & " order by " & code & " desc limit 1" : rst = com.ExecuteReader()
                While rst.Read
                    strng = rst("code").ToString
                End While
                rst.Close()
            End If
        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()

        Catch errMS As Exception
            XtraMessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PrintError()
        End Try
        Return strng.ToString
    End Function

    Public Function globalinitialID(ByVal txt As String)
        ' Split string based on spaces
        Dim s As String = ""
        Dim finalinitial As String = ""
        Dim words As String() = txt.Split(New Char() {" "c})

        ' Use For Each loop over words and display them
        Dim word As String
        For Each word In words
            s = s + word.Remove(1, word.Count - 1)
        Next
        com.CommandText = "SELECT current_timestamp as currtime" : rst = com.ExecuteReader()
        Dim removechar As Char() = ":/AMPM ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        While rst.Read()

            Dim str As String = rst("currtime").ToString
            For Each ch As Char In str
                If Array.IndexOf(removechar, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
            finalinitial = StrConv(s.Remove(3, s.Length - 3), vbUpperCase) & "-" & sb.ToString

        End While
        rst.Close()
        Return finalinitial.ToString
    End Function
    Public Function getdateid()
        Dim removechar As Char() = ":/AMPM- ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim str As String = GlobalDateTime()
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function
    Public Function getuserid()
        Dim userid = 0
        If CInt(countrecord("tblaccounts")) = 0 Then
            userid = 101
        Else
            com.CommandText = "select accountid from tblaccounts order by accountid desc limit 1" : rst = com.ExecuteReader()
            While rst.Read
                userid = Val(rst("accountid")) + 1
            End While
            rst.Close()
        End If
        Return userid.ToString
    End Function
    Public Function convertid(ByVal a As String)
        Dim removechar As Char() = ":/AMPM- ".ToCharArray()
        Dim sb As New System.Text.StringBuilder
        Dim dt As DateTime
        dt = a.ToString

        Dim str As String = dt.ToString("yyyy-MM-dd")
        For Each ch As Char In str
            If Array.IndexOf(removechar, ch) = -1 Then
                sb.Append(ch)
            End If
        Next
        Return sb.ToString
    End Function

    Public Function countrecordstat(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where status=1"
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function countqry(ByVal tbl As String, ByVal where As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " where " & where
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function countqrybySpecificColumn(ByVal tbl As String, ByVal ColumnName As String, ByVal where As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(" & ColumnName & ") as cnt from " & tbl & " where " & where
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function countrecord(ByVal tbl As String)
        Dim cnt As Integer = 0
        com.CommandText = "select count(*) as cnt from " & tbl & " "
        rst = com.ExecuteReader
        While rst.Read
            cnt = rst("cnt")
        End While
        rst.Close()
        Return cnt
    End Function

    Public Function countrecordserver(ByVal tbl As String)
        Dim cnt As Integer = 0
        comclient.CommandText = "select count(*) as cnt from " & tbl & " "
        rstclient = comclient.ExecuteReader
        While rstclient.Read
            cnt = rstclient("cnt")
        End While
        rstclient.Close()
        Return cnt
    End Function
    Public Function countqryserver(ByVal tbl As String, ByVal where As String)
        Dim cnt As Integer = 0
        comclient.CommandText = "select count(*) as cnt from " & tbl & " where " & where
        rstclient = comclient.ExecuteReader
        While rstclient.Read
            cnt = rstclient("cnt")
        End While
        rstclient.Close()
        Return cnt
    End Function
    Public Function codeGenerator(ByVal table As String, ByVal field As String, ByVal length As Integer, ByVal initialcode As String, ByVal startfrom As String)
        Dim strng = ""

        If CInt(countrecord(table)) = 0 Then
            strng = initialcode & startfrom
        Else
            com.CommandText = "select " & field & " from " & table & " order by right(" & field & "," & length & ") desc limit 1" : rst = com.ExecuteReader()
            Dim removechar As Char() = initialcode.ToCharArray()
            Dim sb As New System.Text.StringBuilder
            While rst.Read
                Dim str As String = rst(field).ToString
                For Each ch As Char In str
                    If Array.IndexOf(removechar, ch) = -1 Then
                        sb.Append(ch)
                    End If
                Next
            End While
            rst.Close()
            strng = initialcode & Val(sb.ToString) + 1
        End If
        Return strng.ToString
    End Function

    Public Function checkAttachment(ByVal dir As String) As Boolean
        Dim fs1 As FileStream
        Try
            If dir <> "" Then
                If System.IO.File.Exists(dir) = True Then
                    fs1 = New FileStream(dir, FileMode.OpenOrCreate, FileAccess.Read)
                    Dim iFileSize As UInt32
                    iFileSize = fs1.Length
                    ' MsgBox(iFileSize & " Bytes" & Environment.NewLine & (iFileSize / 1024) & " KB" & Environment.NewLine & (iFileSize / 1024) / 1024 & " MB")
                    If iFileSize > GlobalAllowableAttachSize Then
                        Return False
                    End If
                End If
            End If
        Catch errMS As Exception
            XtraMessageBox.Show("Module:" & "Image Attachment" & vbCrLf _
                               & "Message:" & errMS.Message, vbCrLf _
                               & "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public FileAttach(10) As String
    Public Function LoadGLItem(ByVal groupcode As String, ByVal itemcode As String, ByVal txtbox As DevExpress.XtraEditors.SearchLookUpEdit, ByVal grdview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal form As DevExpress.XtraEditors.XtraForm)
        LoadGridviewAppearance(grdview)
        LoadXgridLookupSearch("select itemcode, itemname as 'Item Name' from tblglitem  where itemcode<> " & groupcode & " and (groupcode='" & groupcode & "' or itemcode='" & itemcode & "') order by itemname asc", "tblglitem", txtbox, grdview, form)
        grdview.Columns("itemcode").Visible = False
        Return 0
    End Function
    Public Function GetAttachmentName()
        GetAttachmentName = compinitialcode & "-" & getdateid() & "-" & globaluserid
        Return GetAttachmentName
    End Function

    Public Function GetOfficeid()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0 : Dim seriesto As Integer = 0
        com.CommandText = "select seriesno from tblcompofficeseries" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblcompofficeseries set seriesno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber

    End Function

End Module