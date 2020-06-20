Imports System.Runtime.InteropServices, System.IO, DShowNET, DShowNET.Device, System.Drawing, System.Drawing.Imaging, System.Collections, System.ComponentModel, System.Diagnostics
Imports System.Data, DirectShowLib
Imports MySql.Data.MySqlClient

Module Camera
    Public firstActive As Boolean
    Public capFilter As DShowNET.IBaseFilter
    Public graphBuilder As DShowNET.IGraphBuilder
    Public capGraph As DShowNET.ICaptureGraphBuilder2
    Public sampGrabber As DShowNET.ISampleGrabber
    Public mediaCtrl As DShowNET.IMediaControl
    Public mediaEvt As DShowNET.IMediaEventEx
    Public videoWin As DShowNET.IVideoWindow
    Public baseGrabFlt As DShowNET.IBaseFilter
    Public videoInfoHeader As DShowNET.VideoInfoHeader
    Public captured As Boolean = True
    Public bufferedSize As Integer
    Public savedArray As Byte()
    Public capDevices As ArrayList
    Public Const WM_GRAPHNOTIFY As Integer = &H8001
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_CLIPCHILDREN As Integer = &H2000000
    Public Const WS_CLIPSIBLINGS As Integer = &H4000000
    Public Delegate Sub CaptureDone()
    Public rotCookie As Integer = 0
    Public mediaControl As DirectShowLib.IMediaControl = Nothing
    Public theDevice As DirectShowLib.IBaseFilter = Nothing
    Public ActiveCamera As Boolean
    Public m_rot As DsROTEntry = Nothing


    Public Function ResizedImage(ByVal img As Image) As Image
        ResizedImage = Nothing
        If img Is Nothing Then Exit Function
        Dim Original As New Bitmap(img)
        img = Original

        Dim m As Int32 = 350
        Dim n As Int32 = m * Original.Height / Original.Width

        Dim Thumb As New Bitmap(m, n, Original.PixelFormat)
        Thumb.SetResolution(Original.HorizontalResolution, Original.VerticalResolution)

        Dim g As Graphics = Graphics.FromImage(Thumb)
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High

        g.DrawImage(Original, New Rectangle(0, 0, m, n))
        ResizedImage = Thumb
        Return ResizedImage
    End Function

    Public Function ImageInsertUpdate(ByVal qry As String, ByVal imgfld As String, ByVal tbl As String, ByVal otherfield As String, ByVal Ximg As Image, ByVal myform As Form)
        Try
            Dim arrImage As Byte()
            If Not Ximg Is Nothing Then
                Ximg = ResizedImage(Ximg)
                Dim mstream As New System.IO.MemoryStream()
                Ximg.Save(mstream, System.Drawing.Imaging.ImageFormat.Gif)
                arrImage = mstream.GetBuffer()
                mstream.Close()
            End If

            If countqry(tbl, qry) = 0 Then
                With com
                    .CommandText = "insert into " & tbl & " set " & imgfld & " = @file " & otherfield
                    .Connection = conn
                    .Parameters.AddWithValue("@file", arrImage)
                    .ExecuteNonQuery()
                End With
                com.Parameters.Clear()
            Else
                With com
                    .CommandText = "Update " & tbl & " set " & imgfld & " = @file " & otherfield & " where " & qry
                    .Connection = conn
                    .Parameters.AddWithValue("@file", arrImage)
                    .ExecuteNonQuery()
                End With
                com.Parameters.Clear()
            End If


        Catch errMYSQL As MySqlException
            MessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf _
                             & "Details:" & errMYSQL.StackTrace, _
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch errMS As Exception
            MessageBox.Show("Form:" & myform.Name & vbCrLf _
                             & "Module:" & "form_load" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf _
                             & "Details:" & errMS.StackTrace, _
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return 0
    End Function
 
End Module
