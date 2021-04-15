Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Data
Imports System.Management
Imports Microsoft.VisualBasic
Imports System.Net.Mail
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Data.OleDb

Module ConectionSetup
    Public provider As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Public li As String = Environment.NewLine
    Public Em As DataGridView

    Public FileProperties As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Public fversion As String = FileProperties.FileVersion.ToString.Remove(FileProperties.FileVersion.ToString.Length - 2, 2)
    Public dversion As Date = Date.ParseExact(fversion, "yy.M.d", provider)
    Public GlobalApplicationName As String = "Coffeecup Client"
    Public formclose As Boolean
    Public conn As New MySqlConnection
    Public hda As MySqlDataAdapter
    Public da As MySqlDataAdapter
    Public msda As MySqlDataAdapter
    Public msda_chat As MySqlDataAdapter
    Public msda_chat_logs As MySqlDataAdapter
    Public msda_chat_typing As MySqlDataAdapter
    Public msda_chat_seen As MySqlDataAdapter
    Public msdastock As MySqlDataAdapter
    Public msda2 As MySqlDataAdapter
    Public coupon_adapter As MySqlDataAdapter

    Public da_manumaker As MySqlDataAdapter
    Public st_menumaker As New DataSet

    Public hst As New DataSet
    Public st As New DataSet
    Public dst As New DataSet
    Public dst_chat As New DataSet
    Public dst_chat_logs As New DataSet
    Public dst_chat_typing As New DataSet
    Public dst_chat_seen As New DataSet
    Public dststock As New DataSet
    Public dst2 As New DataSet
    Public dst3 As New DataSet
    Public coupon_dst As New DataSet

    Public com As New MySqlCommand
    Public rst As MySqlDataReader

    Public GlobalApplicationPath As String = Application.StartupPath.ToString
    Public file_Attachment As String = Application.StartupPath.ToString & "\Resources\Attachment\"
    Public file_conn As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".conn"
    Public file_PrinterSettings As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".printer"
    Public file_QueuePrinterSettings As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".queue.printer"
    Public file_PoleDisplaySettings As String = Application.StartupPath.ToString & "\" & My.Application.Info.AssemblyName & ".pole.display"

    'Public file_inventory_payments As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".payments.xml"
    'Public file_inventory_consumables As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".consumables.xml"
    'Public file_inventory_bffe As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".bffe.xml"

    'Public file_request_particular As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_particular.xml"
    'Public file_request_online As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_online.xml"
    'Public file_request_received As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_received.xml"
    'Public file_request_pending As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_pending.xml"
    'Public file_request_approved As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_approved.xml"
    'Public file_request_cancelled As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_cancelled.xml"
    'Public file_request_cancelled_item As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_cancelled_item.xml"
    'Public file_request_incoming_transfer As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".request_incoming.xml"

    'Public file_particular_received As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_received.xml"
    'Public file_particular_requested As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_requested.xml"

    'Public file_global_items As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_item.xml"
    'Public file_global_itemvendors As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".particular_itemvendors.xml"
    'Public file_global_vendors As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".vendors.xml"

    'Public file_stockouts_current As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_current.xml"
    'Public file_stockouts_items As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_items.xml"
    'Public file_stockouts_summary As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".stockouts_summary.xml"

    'Public file_download As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".download"
    'Public file_notifications As String = Application.StartupPath.ToString & "\Resources\" & My.Application.Info.AssemblyName & ".notifications.xml"

    Public sqlserver As String
    Public sqlport As String
    Public sqluser As String
    Public sqlpass As String
    Public sqldatabase As String
    Public sqlfiledir As String

    Public connclient As New MySqlConnection 'for MySQLDatabase Connection
    Public msdaclient As MySqlDataAdapter 'is use to update the dataset and datasource
    Public dstclient As New DataSet 'miniature of your table - cache table to client
    Public comclient As New MySqlCommand
    Public rstclient As MySqlDataReader
    Public ConnectedServer As Boolean = False

    Public clientserver As String
    Public clientport As String
    Public clientuser As String
    Public clientpass As String
    Public clientdatabase As String

    Public Function OpenMysqlConnection() As Boolean
        Dim strSetup As String = ""
        Dim sr As StreamReader = File.OpenText(file_conn)
        Dim br As String = sr.ReadLine() : sr.Close()
        strSetup = DecryptTripleDES(br) : Dim cnt As Integer = 0
        For Each word In strSetup.Split(New Char() {","c})
            If cnt = 0 Then
                sqlserver = word
            ElseIf cnt = 1 Then
                sqlport = word
            ElseIf cnt = 2 Then
                sqluser = word
            ElseIf cnt = 3 Then
                sqlpass = word
            ElseIf cnt = 4 Then
                sqldatabase = word
            ElseIf cnt = 5 Then
                sqlfiledir = word

            End If
            cnt = cnt + 1
        Next
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
        Catch errMYSQL As MySqlException
            globallogin = False
            Return False
        End Try
        Return True
    End Function

    Public Function CheckConnectionServer() As Boolean
        Try
            conn.Close()
            conn = New MySql.Data.MySqlClient.MySqlConnection
            conn.ConnectionString = "server=" & sqlserver & "; Port=" & sqlport & "; user id=" & sqluser & "; password=" & sqlpass & "; database=" & sqldatabase & "; Connection Timeout=6000000 ; Allow Zero Datetime=True"
            conn.Open()
            com.Connection = conn
            com.CommandTimeout = 6000000
        Catch errMYSQL As MySqlException
            'MessageBox.Show("Can't connect database server on '" & sqlserver & "'", _
            '              "Connection Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    Public Function OpenClientServer() As Boolean
        Try
            connclient.Close()
            connclient = New MySql.Data.MySqlClient.MySqlConnection
            connclient.ConnectionString = "server=" & clientserver & "; Port=" & clientport & "; user id=" & clientuser & "; password=" & clientpass & "; database=" & clientdatabase & "; Connection Timeout=10; allow user variables=true"
            connclient.Open()
            comclient.Connection = connclient
            comclient.CommandTimeout = 6000000
            OpenClientServer = True

        Catch errMYSQL As MySqlException
            MessageBox.Show("Message:" & errMYSQL.Message & vbCrLf, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        Catch errMS As Exception
            MessageBox.Show("Message:" & errMS.Message & vbCrLf, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            OpenClientServer = False
            Return False
        End Try
    End Function

    Public Class ComboBoxItem
        Private displayValue As String
        Private m_hiddenValue As String

        Public Sub New(ByVal d As String, ByVal h As String)
            displayValue = d
            m_hiddenValue = h
        End Sub

        Public ReadOnly Property HiddenValue() As String
            Get
                Return m_hiddenValue
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return displayValue
        End Function
    End Class

    Public Function getGlobalTrnid()
        Dim finalstr As String = Now.ToString("yyMMddhhmmss")
        finalstr = finalstr
        Return finalstr
    End Function

    Public Function getGlobalid()
        Dim finalstr As String = Now.ToString("yyyyMMddhhmmss")

        finalstr = finalstr
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

    Public Function DepreciationReduce(ByVal unitcost As Double, ByVal age As Double, ByVal rate As Double) As Double
        DepreciationReduce = unitcost
        For I = 0 To age - 1
            Dim year1depn = DepreciationReduce * (rate / 100)
            DepreciationReduce = DepreciationReduce - year1depn
        Next
        Return DepreciationReduce
    End Function

    Public Function DepreciationStraight(ByVal unitcost As Double, ByVal age As Double, ByVal NumberOfYears As Double) As Double
        Dim value As Double = 0 : Dim bookValue As Double = 0
        If NumberOfYears > 0 Then
            Dim devidedRate = unitcost / NumberOfYears
            DepreciationStraight = 0
            Dim asMonth As Double = age / 12
            For I = 0 To asMonth - 1
                DepreciationStraight = DepreciationStraight + devidedRate
            Next
            value = unitcost - DepreciationStraight
            If value > 0 Then
                bookValue = value
            Else
                bookValue = 1
            End If
        Else
            bookValue = 1
        End If
        Return bookValue
    End Function

End Module
