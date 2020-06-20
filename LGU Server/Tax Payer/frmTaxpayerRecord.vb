Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmTaxpayerRecord
    Private Sub frmTaxpayerRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub
 
    Public Sub LoadReport()
        LoadXgrid("Select cifid as 'Taxpayer Code',(select description from tbldatapicked where id=a.agencycode) as 'Agency', " _
                        + " Fullname, " _
                        + " lcase(Address) as 'Address', " _
                        + " if(contactno='(____) ___-____','',Contactno) as 'Contact No.', " _
                        + " if(Gender='M','Male', 'Female') as 'Gender', " _
                        + " ucase(civilstatus) as 'Civil Status', " _
                        + " (select description from tbldatapicked where id=a.citizenship) as 'Citizenship', " _
                        + " date_format(birthdate,'%M %d, %Y') as 'Birth Date', " _
                        + " (select description from tbldatapicked where id=a.birthplace) as 'Birth Place', " _
                        + " Height, Weight, " _
                        + " (select description from tbldatapicked where id=a.profession) as 'Profession', " _
                        + " TIN, " _
                        + " date_format(dateentry,'%Y-%m-%d %r') as 'Date Entry', " _
                        + " (select fullname from tblaccounts where accountid=a.entryby) as 'Entry By'  from tbltaxpayerprofile as a where deleted=0 order by fullname asc", "tbltaxpayerprofile", Em, GridView1, Me)

        XgridColAlign({"Taxpayer Code", "Agency", "Contact No.", "Gender", "Civil Status", "Citizenship", "Height", "Weight", "TIN", "Date Entry"}, GridView1, DevExpress.Utils.HorzAlignment.Center)
        GridView1.BestFitColumns()
    End Sub

    
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExportToExcel.ItemClick
        ExportGridToExcel(Me.Text, GridView1)
    End Sub

    Private Sub BarLargeButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdClose.ItemClick
        Me.Close()
    End Sub

    Private Sub cmdLocalData_Click(sender As Object, e As EventArgs) Handles cmdLocalData.Click
        LoadReport()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If XtraMessageBox.Show("Are you sure you want to permanently remove selected item? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Dim I As Integer = 0
            For I = 0 To GridView1.SelectedRowsCount - 1
                com.CommandText = "UPDATE tbltaxpayerprofile set deleted=1,deletedby='" & globaluserid & "',datedeleted=current_timestamp where cifid='" & GridView1.GetRowCellValue(GridView1.GetSelectedRows(I), "Taxpayer Code") & "' " : com.ExecuteNonQuery()
            Next
            LoadReport()
        End If
    End Sub

    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        frmTaxPayerInfo.mode.Text = ""
        frmTaxPayerInfo.mode.Text = "view"
        frmTaxPayerInfo.cifid.Text = GridView1.GetFocusedRowCellValue("Taxpayer Code").ToString
        If frmTaxPayerInfo.Visible = False Then
            frmTaxPayerInfo.Show(Me)
        Else
            frmTaxPayerInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub cmdAddnew_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAddnew.ItemClick
        If frmTaxPayerInfo.Visible = False Then
            frmTaxPayerInfo.Show(Me)
        Else
            frmTaxPayerInfo.WindowState = FormWindowState.Normal
        End If
    End Sub

End Class

