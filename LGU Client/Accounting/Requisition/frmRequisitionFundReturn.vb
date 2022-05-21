Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System
Imports System.IO
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRequisitionFundReturn

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function

    Private Sub frmRequisitionFundReturn_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmRequisitionFundReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        CreateFundTable()
        LoadSource()
    End Sub


    Public Sub CreateFundTable()
        com.CommandText = "DROP TEMPORARY TABLE IF EXISTS `tmprequisitionfund`" : com.ExecuteNonQuery()
        com.CommandText = "CREATE TEMPORARY TABLE IF NOT EXISTS `tmprequisitionfund` (  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,  `pid` varchar(45) NOT NULL DEFAULT '',  `officeid` varchar(45) NOT NULL DEFAULT '',  `periodcode` varchar(45) NOT NULL DEFAULT '',  `requestno` varchar(45) NOT NULL DEFAULT '',  `monthcode` varchar(2) NOT NULL DEFAULT '',  `classcode` varchar(45) NOT NULL DEFAULT '',  `itemcode` varchar(45) NOT NULL DEFAULT '',  `prevbalance` double NOT NULL DEFAULT '0',  `amount` double NOT NULL DEFAULT '0',  `newbalance` double NOT NULL DEFAULT '0', `original` double NOT NULL DEFAULT '0',  `returnfund` double NOT NULL DEFAULT '0',  `cancelled` tinyint(1) NOT NULL DEFAULT '0',`tempamount` double NOT NULL DEFAULT '0',  PRIMARY KEY (`id`)) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" : com.ExecuteNonQuery()
        com.CommandText = "INSERT INTO tmprequisitionfund select *, 0 from tblrequisitionfund where pid='" & pid.Text & "' and cancelled=0" : com.ExecuteNonQuery()
    End Sub

    Public Sub LoadSource()
        LoadXgrid("select id,classcode as 'Class', date_format(concat(date_format(current_date,'%Y'),'-',monthcode,'-1'),'%M') as 'Month', itemcode as 'Item Code', (select itemname from tblglitem where itemcode=a.itemcode) as 'Item Name', Amount, returnfund as 'Return', tempamount as 'New Return' from tmprequisitionfund as a where pid='" & pid.Text & "'", "tmprequisitionfund", Em, GridView1, Me)

        XgridColAlign({"Item Code", "Class", "Month"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        XgridColCurrency({"Amount", "Return", "New Return"}, GridView1)
        XgridGeneralSummaryCurrency({"Amount", "Return", "New Return"}, GridView1)
        GridView1.BestFitColumns()
        DXgridColumnIndexing(Me.Name, GridView1)
        XgridHideColumn({"id"}, GridView1)
        If Val(GridView1.Columns("New Return").SummaryText) > 0 Then
            cmdSaveChanges.Enabled = True
        Else
            cmdSaveChanges.Enabled = False
        End If
    End Sub

    Private Sub GridView1_DragObjectDrop(sender As Object, e As DragObjectDropEventArgs) Handles GridView1.DragObjectDrop
        XgridColumnDropChanged(GridView1, Me.Name)
    End Sub

    Private Sub GridView1_ColumnWidthChanged(sender As Object, e As ColumnEventArgs) Handles GridView1.ColumnWidthChanged
        XgridColumnWidthChanged(GridView1, Me.Name)
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddItem_Click(sender As Object, e As EventArgs) Handles cmdAddItem.Click
        frmRequisitionFundReturnAmount.id = GridView1.GetFocusedRowCellValue("id").ToString
        frmRequisitionFundReturnAmount.txtRequestedAmount.Text = Val(GridView1.GetFocusedRowCellValue("Amount").ToString) - Val(GridView1.GetFocusedRowCellValue("Return").ToString)
        frmRequisitionFundReturnAmount.txtAmount.Text = GridView1.GetFocusedRowCellValue("New Return").ToString
        frmRequisitionFundReturnAmount.txtAccountTitle.Text = GridView1.GetFocusedRowCellValue("Item Name").ToString
        frmRequisitionFundReturnAmount.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        LoadSource()
    End Sub

    Private Sub cmdForApproval_Click(sender As Object, e As EventArgs) Handles cmdSaveChanges.Click
        If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select * from tmprequisitionfund as a where pid='" & pid.Text & "' and tempamount > 0 ", conn)
            da.Fill(st, 0)
            For cnt = 0 To st.Tables(0).Rows.Count - 1
                With (st.Tables(0))
                    com.CommandText = "update tblrequisitionfund set amount=(amount-" & .Rows(cnt)("tempamount").ToString() & "), returnfund=(returnfund+" & .Rows(cnt)("tempamount").ToString() & ") where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    Dim CurrentMonth As String = MonthName(CInt(getCurrentTransactionMonth(.Rows(cnt)("periodcode").ToString())), False)
                    com.CommandText = "update tblbudgetcomposition set amount=(amount+" & .Rows(cnt)("tempamount").ToString() & "), " & CurrentMonth & "=(" & CurrentMonth & "+" & .Rows(cnt)("tempamount").ToString() & ") where periodcode='" & .Rows(cnt)("periodcode").ToString() & "' and officeid='" & .Rows(cnt)("officeid").ToString() & "' and itemcode='" & .Rows(cnt)("itemcode").ToString() & "'" : com.ExecuteNonQuery()
                End With
            Next
            XtraMessageBox.Show("Return fund successfully updated!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub
End Class