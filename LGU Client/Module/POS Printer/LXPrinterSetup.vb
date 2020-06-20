Imports System.IO
Imports System.Management
Imports System.Text
Imports System.IO.Ports

Module LXPrinterSetup
    Dim detailsFile As StreamWriter = Nothing
    Public globalEnableTemporaryDisablePrinting As Boolean
    Public globalEnableLXPrinter As Boolean
    Public globalLXPrinterDevice As String
    Public globalLXPaperSize As Double = 40
    Public globalLXMarginTop As Double = 2
    Public globalLXMarginLeft As Double = 2
    Public globalLXFontName As String
    Public globalLXFontSize As Double = 9

    Public Sub LoadLXPrinterSetup()
        If System.IO.File.Exists(file_PrinterSettings) = True Then
            globalEnableLXPrinter = True
            Dim sr As StreamReader = File.OpenText(file_PrinterSettings)
            Dim br As String = sr.ReadLine() : sr.Close()
            Dim Split As String() = br.Split(",")

            globalLXPrinterDevice = Split(0)
            globalLXPaperSize = Split(1)
            globalLXMarginTop = Split(2)
            globalLXMarginLeft = Split(3)

            globalLXFontName = Split(4)
            globalLXFontSize = Split(5)
        Else
            globalEnableLXPrinter = False
        End If
    End Sub

    Public Function PrintSpaceLine() As String
        PrintSpaceLine = ""
        For i = 0 To globalLXPaperSize - (globalLXMarginLeft * 2)
            PrintSpaceLine = PrintSpaceLine + "-"
        Next
        Return PrintGetSpace(globalLXMarginLeft) + PrintSpaceLine
    End Function

    Public Function PrintSpaceLine(ByVal nextline As Integer) As String
        PrintSpaceLine = ""
        For i = 0 To nextline - 1
            PrintSpaceLine = PrintSpaceLine + Environment.NewLine
        Next
        Return PrintSpaceLine
    End Function

    Public Function PrintCenterText(ByVal value As String) As String
        PrintCenterText = Nothing
        Dim centerText As String = "" : Dim space As String = "" : Dim remVal As String = ""
        If value.Length > globalLXPaperSize Then
            centerText = value
        Else
            centerText = value
            For i = 0 To ((globalLXPaperSize - value.Length) / 2)
                space = space & " "
            Next
        End If
        PrintCenterText = space + centerText & remVal
        Return PrintCenterText
    End Function

    Public Function PrintMidText(ByVal value As String, ByVal location As Integer) As String
        PrintMidText = Nothing
        Dim space As String = ""
        For i = 0 To location - (value / 2)
            space = space & " "
        Next
        PrintMidText = space & value
        Return PrintMidText
    End Function

    Public Function PrintLeftText(ByVal value As String, ByVal leftindex As Integer, ByVal alignment As ContentAlignment, ByVal nextline As Integer)
        If alignment = ContentAlignment.MiddleCenter Then
            Return PrintGetSpace((globalLXMarginLeft + leftindex) - (value.Length / 2)) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        ElseIf alignment = ContentAlignment.MiddleRight Then
            Return PrintGetSpace((globalLXMarginLeft + leftindex) - (value.Length)) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        Else
            Return PrintGetSpace(globalLXMarginLeft + leftindex) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        End If
    End Function

    Public Function PrintLeftTextAdditional(ByVal value As String, ByVal leftindex As Integer, ByVal alignment As ContentAlignment, ByVal nextline As Integer)
        If alignment = ContentAlignment.MiddleCenter Then
            Return PrintGetSpace((leftindex) - (value.Length / 2)) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        ElseIf alignment = ContentAlignment.MiddleRight Then
            Return PrintGetSpace((leftindex) - (value.Length)) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        Else
            Return PrintGetSpace(leftindex) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        End If
    End Function

    Public Function PrintRightText(ByVal value As String, ByVal rightindex As Integer, ByVal alignment As ContentAlignment, ByVal nextline As Integer)
        If alignment = ContentAlignment.MiddleCenter Then
            Return PrintGetSpace(globalLXPaperSize - rightindex - (value.Length / 2)) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        Else
            Return PrintGetSpace(globalLXPaperSize - rightindex - value.Length) + value + If(nextline > 0, PrintSpaceLine(nextline), "")
        End If
    End Function

    'value|leftindex|alignment
    Public Function PrintLineByGroup(ByVal batchgroup As Array, ByVal spacetop As Integer)
        Dim batchdetails As String = ""
        For Each batch In batchgroup
            Dim pergroup As String = ""
            Dim splt As String() = batch.Split("|")
            If splt(2) = "center" Then
                pergroup = PrintGetSpace((Val(splt(1)) - batchdetails.Length) - (splt(0).Length / 2)) & splt(0)
            ElseIf splt(2) = "left" Then
                pergroup = PrintGetSpace(Val(splt(1)) - batchdetails.Length) & splt(0)
            ElseIf splt(2) = "right" Then
                pergroup = PrintGetSpace((Val(splt(1)) - batchdetails.Length) - splt(0).Length) & splt(0)
            End If
            batchdetails += pergroup
        Next
        Return If(spacetop > 0, PrintSpaceLine(spacetop), "") & batchdetails
    End Function

    Public Function PrintLeftRigthText(ByVal value_left As String, ByVal leftindex As Integer, ByVal left_alignment As ContentAlignment, ByVal value_right As String, ByVal rightindex As Integer, ByVal right_alignment As ContentAlignment, ByVal nextline As Integer)
        Dim str As String = ""
        If value_left.Length > (globalLXPaperSize - value_right.Length) Then
            value_left = Split(value_left) & ".."
        End If
        Dim a As Double = (globalLXPaperSize - ((globalLXMarginLeft * 2) + value_left.Length)) - value_right.Length
        str = PrintGetSpace(globalLXMarginLeft) + value_left + PrintGetSpace(a) + value_right + If(nextline > 0, PrintSpaceLine(nextline), "")
        Return str
    End Function

    Public Function Split(ByVal Expression As String)
        Dim Astr As String = Expression
        'Astr = Astr.Remove(Astr.Length - 10, 10)
        Astr = Astr.Remove(globalLXPaperSize - (globalLXPaperSize / 4.25), Astr.Length - (globalLXPaperSize - (globalLXPaperSize / 4.25)))
        Astr = Astr.Remove(Astr.Length - 3, 3)
        ' Astr = Astr.Remove(Astr.Length - (globalLXPaperSize - (globalLXPaperSize / 2)), (globalLXPaperSize / 4))
        Return Astr
    End Function

   

    Public Function PrintGetSpace(ByVal value As Integer)
        PrintGetSpace = ""
        For i = 0 To value - 1
            PrintGetSpace = PrintGetSpace + " "
        Next
        Return PrintGetSpace
    End Function

    Public Function ExecutePrintCommand(ByVal details As String, ByVal accountableform As String)
        If globalEnableLXPrinter = True Then
            Dim Print As New DirectPrinterSetup
            If accountableform = "DEFAULT" Then
                Print.prt(details, globalLXPrinterDevice, False, globalLXFontName, globalLXFontSize, globalLXMarginLeft, globalLXMarginLeft)
            Else
                Dim code As String = ""
                If accountableform = "FORM51" Then
                    code = qrysingledata("defaultcollection", "defaultcollection", "tbldefaultsettings")

                ElseIf accountableform = "CEDULA_INDIVIDUAL" Then
                    code = qrysingledata("defaultcedulaindividual", "defaultcedulaindividual", "tbldefaultsettings")

                ElseIf accountableform = "CEDULA_CORPORATION" Then
                    code = qrysingledata("defaultcedulacorporate", "defaultcedulacorporate", "tbldefaultsettings")

                ElseIf accountableform = "defaultpropertytax" Then
                    code = qrysingledata("defaultpropertytax", "defaultpropertytax", "tbldefaultsettings")

                End If
                com.CommandText = "select * from tblaccountableform where code='" & code & "'" : rst = com.ExecuteReader
                While rst.Read
                    Print.prt(details, globalLXPrinterDevice, CBool(rst("prnLandScape").ToString), If(rst("prnFontName").ToString = "", globalLXFontName, rst("prnFontName").ToString), If(CInt(rst("prnFontSize").ToString) = 0, globalLXFontSize, CInt(rst("prnFontSize").ToString)), 0, 0)
                End While
                rst.Close()
            End If
        End If
        Return True
    End Function


End Module
