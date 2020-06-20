Imports System.Security.Cryptography
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports System.Management
Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation
Imports DevExpress.XtraGrid.Views.Grid

Module Security
    Public Function keyloger(ByVal str As String)
        com.CommandText = "insert into tblsystemlogs set DESCRIPTION='" & str & "', UPDATEBY='" & globalfullname & "', DATELOGS=CURRENT_TIMESTAMP"
        com.ExecuteNonQuery()
        Return 0
    End Function
     
    Public Sub FilterAccessPermission(ByVal currentRibbon As DevExpress.XtraBars.Ribbon.RibbonControl)
        Dim msg As String = ""
        Dim mCurrentItem As BarItem
        If LCase(globaluser) = "root" Then
            For Each currentPage As RibbonPage In currentRibbon.Pages
                msg += currentPage.Text & Environment.NewLine
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    For Each currenLink As BarItemLink In currentGroup.ItemLinks
                        msg += "-" & currenLink.Item.Caption & Environment.NewLine
                        mCurrentItem = currenLink.Item
                        currenLink.Item.Visibility = BarItemVisibility.Always
                    Next currenLink
                Next currentGroup
            Next
            ' MsgBox(msg)
        Else
            For Each currentPage As RibbonPage In currentRibbon.Pages
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    For Each currenLink As BarItemLink In currentGroup.ItemLinks
                        mCurrentItem = currenLink.Item
                        currenLink.Item.Visibility = BarItemVisibility.Never
                    Next currenLink
                Next currentGroup
            Next

            For Each currentPage As RibbonPage In currentRibbon.Pages
                Dim p As Integer = 0
                For Each currentGroup As RibbonPageGroup In currentPage.Groups
                    Dim c As Integer = 0
                    com.CommandText = "select * from tblpermissionstemplate where percode='" & globalPermissionAccess & "' and grouppermission='" & currentPage.Name & "'" : rst = com.ExecuteReader
                    While rst.Read
                        For Each currenLink As BarItemLink In currentGroup.ItemLinks
                            mCurrentItem = currenLink.Item
                            If currenLink.Item.Name = rst("menus").ToString Then
                                currenLink.Item.Visibility = BarItemVisibility.Always
                                c = c + 1
                            End If
                        Next currenLink
                    End While
                    rst.Close()
                    If c = 0 Then
                        currentGroup.Visible = False
                    Else
                        currentGroup.Visible = True
                        p = p + 1
                    End If
                Next currentGroup
                If p = 0 Then
                    currentPage.Visible = False
                Else
                    currentPage.Visible = True
                End If
            Next
        End If
    End Sub

    Public Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

End Module
