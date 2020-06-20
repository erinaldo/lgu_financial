Imports System.Drawing.Printing

Public Class DirectPrinterSetup
    Friend prnTextContent As String
    Friend prnTextContent2 As String
    Friend prnFontName As String
    Friend prnFontSize As String
    Friend prnMarginTop As Integer
    Friend prnMarginLeft As Integer

    Public Sub prt(ByVal textcontent As String, ByVal printername As String, ByVal landscape As Boolean, ByVal fontname As String, ByVal fontsize As Integer, ByVal MarginTop As Integer, ByVal MarginLeft As Integer)
        Dim prn As New Drawing.Printing.PrintDocument
        prn.PrintController = New StandardPrintController
        prn.DefaultPageSettings.Landscape = landscape

        prnTextContent = textcontent
        prnFontName = fontname
        prnFontSize = fontsize
        prnMarginTop = MarginTop
        prnMarginLeft = MarginLeft

        Using (prn)
            prn.PrinterSettings.PrinterName = printername

            AddHandler prn.PrintPage, AddressOf Me.PrintPageHandler
            prn.Print()
            RemoveHandler prn.PrintPage, AddressOf Me.PrintPageHandler
        End Using
    End Sub
    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Drawing.Printing.PrintPageEventArgs)
        Dim myFont As New Font(prnFontName, prnFontSize)
        Dim myFont2 As New Font("Franklin Gothic", 8)
        args.Graphics.DrawString(prnTextContent, New Font(myFont, FontStyle.Regular), Brushes.Black, prnMarginTop, prnMarginLeft)
        If prnTextContent2 <> "" Then
            args.Graphics.DrawString(prnTextContent2, New Font(myFont2, FontStyle.Regular), Brushes.Black, prnMarginTop, prnMarginLeft)
        End If
    End Sub

End Class
