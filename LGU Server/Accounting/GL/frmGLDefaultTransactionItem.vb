Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Public Class frmGLDefaultTransactionItem
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()

        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmCashItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rst.Close()
    End Sub

    Private Sub frmCashItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SkinManager.EnableMdiFormSkins() : SetIcon(Me)
        ShowUnfilteredProducts()
        ShowfilteredProducts()

    End Sub

    Public Sub ShowUnfilteredProducts()
        Dim productquery As String = ""
        com.CommandText = "select itemcode from tblglreverseitem" : rst = com.ExecuteReader
        While rst.Read
            productquery = productquery + "'" & rst("itemcode").ToString & "',"
        End While
        rst.Close()
        If productquery.Length > 0 Then
            productquery = productquery.Remove(productquery.Length - 1, 1)
            productquery = "where itemcode not in (" & productquery & ")  and sl=1 "
        Else
            productquery = "where sl=1 "
        End If
        LoadXgrid("select itemcode, itemname as 'Item Name', case when debitentry=1 then 'DEBIT' else 'CREDIT' end as 'Default Entry'  from tblglitem " & productquery & " ", "tblglitem", Em_unfiltered, GridView1, Me)
        GridView1.Columns("itemcode").Visible = False
        XgridColMemo({"Item Name"}, GridView1)
        XgridColAlign({"Default Entry"}, GridView1, DevExpress.Utils.HorzAlignment.Center)

        XgridColWidth({"Item Name"}, GridView1, Em_unfiltered.Width - 100)
    End Sub

    Public Sub ShowfilteredProducts()
        LoadXgrid("select itemcode, (select itemname from tblglitem where itemcode= tblglreverseitem.itemcode) as 'Item Name', case when debit=1 then 'DEBIT' else 'CREDIT' end as 'Current Entry'  from tblglreverseitem order by id asc", "tblglreverseitem", Em_filtered, GridView2, Me)
        GridView2.Columns("itemcode").Visible = False
        XgridColMemo({"Item Name"}, GridView2)
        XgridColAlign({"Current Entry"}, GridView2, DevExpress.Utils.HorzAlignment.Center)
        XgridColWidth({"Item Name"}, GridView2, Em_filtered.Width - 100)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarLargeButtonItem2.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdDebit_Click_1(sender As Object, e As EventArgs) Handles cmdDebit.Click
        Dim trap As Boolean = False
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Default Entry").ToString = "CREDIT" Then
                com.CommandText = "insert into tblglreverseitem set itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "itemcode").ToString & "', debit=1" : com.ExecuteNonQuery()
            End If
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Default Entry").ToString = "DEBIT" Then
                trap = True
            End If
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        If trap = True Then
            XtraMessageBox.Show("Some selected item are already a debit entry and cannot be set to a DEBIT as default transaction item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cmdCredit_Click(sender As Object, e As EventArgs) Handles cmdCredit.Click
        Dim trap As Boolean = False
        For I = 0 To GridView1.SelectedRowsCount - 1
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Default Entry").ToString = "DEBIT" Then
                com.CommandText = "insert into tblglreverseitem set itemcode='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "itemcode").ToString & "', debit=0" : com.ExecuteNonQuery()
            End If
            If GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Default Entry").ToString = "CREDIT" Then
                trap = True
            End If
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
        If trap = True Then
            XtraMessageBox.Show("Some selected item are already a debit entry and cannot be set to a CREDIT as default transaction item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles cmdMoveLeft.Click
        For I = 0 To GridView2.SelectedRowsCount - 1
            com.CommandText = "delete from tblglreverseitem where itemcode='" & GridView2.GetRowCellValue(GridView2.GetSelectedRows(I), "itemcode").ToString & "'" : com.ExecuteNonQuery()
        Next
        ShowUnfilteredProducts()
        ShowfilteredProducts()
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If XtraMessageBox.Show("Are you sure you want to continue? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            com.CommandText = "update tbltransactionentries set credit=debit where itemcode in (select itemcode from tblglreverseitem where debit=0) " : com.ExecuteNonQuery()
            com.CommandText = "update tbltransactionentries set debit=0 where itemcode in (select itemcode from tblglreverseitem where debit=0) " : com.ExecuteNonQuery()

            com.CommandText = "update tbltransactionentries set debit=credit where itemcode in (select itemcode from tblglreverseitem where debit=1) " : com.ExecuteNonQuery()
            com.CommandText = "update tbltransactionentries set credit=0 where itemcode in (select itemcode from tblglreverseitem where debit=1) " : com.ExecuteNonQuery()
            XtraMessageBox.Show("Collection entries successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class

