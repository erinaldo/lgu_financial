Imports MySql.Data.MySqlClient ' this is to import MySQL.NET
Imports System.Drawing
Imports System.IO
Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base

Public Class frmEmpoyeeList
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean

        Return ProcessCmdKey
    End Function

    Private Sub frmEmpoyeeList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = ico
        LoadOffice()
        LoadPickedDataTable("emp_type", txtEmployeeType, gridEmployeeType)
        FilterEmployee()
        txtBirthMonth.Text = CDate(Now.ToShortDateString).ToString("MMMM")
    End Sub


    Public Sub LoadOffice()
        LoadXgridLookupSearch("select officeid, officename as 'Select' from tblcompoffice where deleted=0 order by officename", "tblcompoffice", txtOffice, grid_office)
        grid_office.Columns("officeid").Visible = False
    End Sub
    Private Sub txtOffice_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.EditValueChanged
        On Error Resume Next
        FilterEmployee()
    End Sub

    Private Sub txtEmployeeType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeType.EditValueChanged
        On Error Resume Next
        FilterEmployee()
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        FilterEmployee()
    End Sub

    Private Sub ckViewAll_CheckedChanged(sender As Object, e As EventArgs) Handles ckViewAllType.CheckedChanged, ckViewAllOffice.CheckedChanged
        If ckViewAllOffice.Checked Then
            txtOffice.Enabled = False
        Else
            txtOffice.Enabled = True
        End If
        If ckViewAllType.Checked Then
            txtEmployeeType.Enabled = False
        Else
            txtEmployeeType.Enabled = True
        End If
        FilterEmployee()
    End Sub

    Public Sub FilterEmployee()
        If XtraTabControl1.SelectedTabPage Is tabEmployeeList Then
            FilterEmployeeList()
        ElseIf XtraTabControl1.SelectedTabPage Is tabBirthDay Then
            FilterBirthdayList()
        End If
    End Sub

    Public Sub FilterEmployeeList()
        Try
            Dim strCondition As String = ""
            If txtSearch.Text = "" Then
                strCondition = " (retired=" & ckRetired.CheckState & " or resigned=" & ckResigned.CheckState & ") " & If(ckViewAllType.Checked = True, "", " and employeetype='" & txtEmployeeType.EditValue & "'") & If(ckViewAllOffice.Checked = True, "", " and officeid='" & txtOffice.EditValue & "'") & ""
            Else
                strCondition = " (fullname like '%" & txtSearch.Text & "%' or date_format(birthdate,'%M, %d') like '%" & txtSearch.Text & "%') "
            End If
            LoadXgrid("select id as 'Control No.', " _
                        + " employeeid as 'Employee ID', " _
                        + " Title, Fullname, " _
                        + " date_format(birthdate,'%Y-%m-%d') as 'Birth Date', " _
                        + " (select description from tbldatapicked where id=a.birthplace) as 'Birth Place', " _
                        + " Gender, civilstatus as 'Civil Status', " _
                        + " spousename as 'Spouse Name', " _
                        + " (select description from tbldatapicked where id=a.religion) as 'Religion', " _
                        + " (select description from tbldatapicked where id=a.nationality) as 'Nationality', " _
                        + " Height, Weight, " _
                        + " concat(nullif(per_add_purok,''), nullif(concat(', ', per_add_brgy),''),nullif(concat(', ', per_add_city),''),nullif(concat(', ', per_add_prov),'')) as 'Permanent Address', " _
                        + " concat(nullif(cur_add_purok,''), nullif(concat(', ', cur_add_brgy),''),nullif(concat(', ', cur_add_city),''),nullif(concat(', ', cur_add_prov),'')) as 'Current Address', " _
                        + " contactnumber as 'Cellphone Number', homenumber as 'Home Number', emailaddress as 'Email Address', " _
                        + " inc_cont_person as 'Incase Contact Person', inc_cont_number as 'Incase Contact Number', inc_cont_address as 'Incase Contact Address', " _
                        + " (select officename from tblcompoffice where officeid=a.officeid) as 'Assigned Office', " _
                        + " (select description from tbldatapicked where id=a.designation) as Designation, " _
                        + " (select description from tbldatapicked where id=a.employeetype) as 'Employee Type', " _
                        + " (select description from tbldatapicked where id=a.positionlevel) as 'Position Level', " _
                        + " (select description from tbldatapicked where id=a.baseratepay) as 'Base Rate Pay', " _
                        + " (select description from tbldatapicked where id=a.basicrate) as 'Basic Rate', " _
                        + " date_format(datehired,'%Y-%m-%d') as 'Date Hired', " _
                        + " date_format(dateregular,'%Y-%m-%d') as 'Date Regular', " _
                        + " Resigned " & If(ckResigned.Checked = True, ", date_format(dateresigned,'%M %d, %Y') as 'Date Resigned'", "") & ", " _
                        + " Retired " & If(ckRetired.Checked = True, ", date_format(dateretired,'%M %d, %Y') as 'Date Retired'", "") & " " _
                        + " from tblemployees as a " _
                        + " where " & strCondition & " order by fullname asc", "tblemployees", Em, gridview1, Me)

            XgridColAlign({"Control No.", "Employee ID", "Classification", "Gender", "Birth Date", "Height", "Weight", "Date Hired", "Date Regular"}, gridview1, DevExpress.Utils.HorzAlignment.Center)
            XgridColCurrency({"Basic Rate"}, gridview1)
            XgridGeneralSummaryCurrency({"Basic Rate"}, gridview1)

            com.CommandText = "select * from tblcolumnindex where form='" & Me.Name & "' and gridview='" & gridview1.Name & "' order by colindex asc" : rst = com.ExecuteReader
            While rst.Read
                gridview1.Columns(rst("columnname").ToString).VisibleIndex = rst("colindex")
                If Val(rst("columnwidth").ToString) > 0 Then
                    gridview1.Columns(rst("columnname").ToString).Width = Val(rst("columnwidth").ToString)
                End If

            End While
            rst.Close()
            SaveFilterColumn(gridview1, Me.Text)

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        End Try
    End Sub

    Public Sub FilterBirthdayList()
        Try
            If txtBirthMonth.Text = "" Then Exit Sub

            Dim BirthMonth As Date = CDate(txtBirthMonth.Text & ", 01 " & CDate(Now).Year)
            LoadXgrid("select date_format(birthdate,'%M') as 'Birth Month', employeeid as 'Employee ID',Fullname, (select description from tbldatapicked where id=a.designation) as Designation, (select officename from tblcompoffice where officeid=a.officeid) as 'Office',  date_format(birthdate,'%Y-%m-%d') as 'Birth Date', TIMESTAMPDIFF(year,birthdate,current_date) as 'Age'  from tblemployees as a" _
                + " where resigned=" & ckResigned.CheckState & " and birthdate<>'' " & If(CheckEdit1.Checked = True, "", " and ucase(date_format(birthdate,'%M'))='" & txtBirthMonth.Text & "'") & " and (fullname like '%" & txtSearch.Text & "%' or date_format(birthdate,'%M, %d') like '%" & txtSearch.Text & "%') order by date_format(birthdate,'%m') asc,date_format(birthdate,'%d') asc", "tblemployees", Em_birthday, gridBirthDay, Me)
            XgridColAlign({"Birth Month", "Employee ID", "Control No.", "Age", "Birth Date"}, gridBirthDay, DevExpress.Utils.HorzAlignment.Center)

        Catch errMYSQL As MySqlException
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMYSQL.Message & vbCrLf,
                             "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        Catch errMS As Exception
            XtraMessageBox.Show("Query:" & vbCrLf _
                             & "Message:" & errMS.Message & vbCrLf,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            rst.Close()
        End Try
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        FilterEmployee()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If XtraTabControl1.SelectedTabPage Is tabEmployeeList Then
            frmPayrollEmployeeInformation.id.Text = gridview1.GetFocusedRowCellValue("Control No.").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
        ElseIf XtraTabControl1.SelectedTabPage Is tabBirthDay Then
            frmPayrollEmployeeInformation.id.Text = gridBirthDay.GetFocusedRowCellValue("Control No.").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
        End If
        If frmPayrollEmployeeInformation.Visible = True Then
            frmPayrollEmployeeInformation.Focus()
        Else
            frmPayrollEmployeeInformation.Show()
        End If
    End Sub

#Region "GRID SECURITY FILTER"

    'Private Sub Em_KeyDown(sender As Object, e As KeyEventArgs) Handles Em.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        frmPayrollEmployeeInformation.id.Text = gridview1.GetFocusedRowCellValue("Control No.").ToString : frmPayrollEmployeeInformation.mode.Text = "edit"
    '        If frmPayrollEmployeeInformation.Visible = True Then
    '            frmPayrollEmployeeInformation.Focus()
    '        Else
    '            frmPayrollEmployeeInformation.Show()
    '        End If
    '    End If
    'End Sub

    'Private Sub Em_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseDown
    '    MenuFilter()
    'End Sub

    'Private Sub Em_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Em.MouseUp
    '    MenuFilter()
    'End Sub

    'Private Sub Em_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles Em.Move
    '    MenuFilter()
    'End Sub

    'Public Sub MenuFilter()
    '    On Error Resume Next
    '    If CBool(gridview1.GetFocusedRowCellValue("Actived")) = True Then
    '        cmdActiveInactive.Text = "Set employee inactived"
    '    Else
    '        cmdActiveInactive.Text = "Set employee actived"
    '    End If
    'End Sub

#End Region

#Region "UPDATE EMPLOYEE RECORD"


    'Private Sub cmdSetCompany_Click(sender As Object, e As EventArgs)
    '    frmSetPayrollOffice.Show(Me)
    'End Sub

    'Public Function setCompany(ByVal office As String, ByVal department As String)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set officeid='" & office & "', depid='" & department & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

    'Private Sub cmdSetPosition_Click(sender As Object, e As EventArgs)
    '    frmSetPayrollPosition.Show(Me)
    'End Sub

    'Public Function setPosition(ByVal positionCode As String)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set positioncode='" & positionCode & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

    'Public Function setlevel(ByVal emplevel As String)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set emplevel='" & emplevel & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

    'Private Sub cmdSetEmployeeType_Click(sender As Object, e As EventArgs)
    '    frmSetPayrollEmployeeStatus.Show(Me)
    'End Sub

    'Public Function setEmployeeType(ByVal typecode As String)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set employeetypecode='" & typecode & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

    'Public Function setShift(ByVal typecode As String)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set shiftcode='" & typecode & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

    'Private Sub cmdResigned_Click(sender As Object, e As EventArgs)
    '    If CBool(gridview1.GetFocusedRowCellValue("Resigned").ToString) = True Then
    '        If XtraMessageBox.Show("Are you sure you want to tag as hired selected employee? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
    '            com.CommandText = "update tblemployees set resigned=0 where id='" & gridview1.GetFocusedRowCellValue("Control No.").ToString & "'" : com.ExecuteNonQuery()
    '            FilterEmployee()
    '            XtraMessageBox.Show("Employee successfuly saved!", GlobalOrganizationName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        frmSetPayrollResigned.Show(Me)
    '    End If
    'End Sub
    'Public Function setResigned(ByVal effectivitydate As Date)
    '    For I = 0 To gridview1.SelectedRowsCount - 1
    '        com.CommandText = "update tblemployees set resigned=1, dateresigned='" & ConvertDate(effectivitydate) & "' where id='" & gridview1.GetRowCellValue(gridview1.GetSelectedRows(I), "Control No.").ToString & "'" : com.ExecuteNonQuery()
    '    Next
    '    FilterEmployee()
    '    Return 0
    'End Function

#End Region

    Private Sub cmdActiveInactive_Click(sender As Object, e As EventArgs)
        If XtraMessageBox.Show("Are you sure you want to continue? ", GlobalOrganizationName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            If CBool(gridview1.GetFocusedRowCellValue("Actived")) = True Then
                com.CommandText = "update tblemployees set actived=0 where id='" & gridview1.GetFocusedRowCellValue("Control No.").ToString & "'" : com.ExecuteNonQuery()
            Else
                com.CommandText = "update tblemployees set actived=1 where id='" & gridview1.GetFocusedRowCellValue("Control No.").ToString & "'" : com.ExecuteNonQuery()
            End If
            FilterEmployee()
        End If
    End Sub


    Private Sub ckActived_CheckedChanged(sender As Object, e As EventArgs) Handles ckRetired.CheckedChanged
        FilterEmployee()
    End Sub

    Private Sub ckResigned_CheckedChanged(sender As Object, e As EventArgs) Handles ckResigned.CheckedChanged
        FilterEmployee()
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtSearch.EditValueChanged

    End Sub

    Private Sub TextEdit1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            FilterEmployee()
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedValueChanged(sender As Object, e As EventArgs) Handles txtBirthMonth.SelectedValueChanged
        FilterEmployee()
    End Sub

    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            txtBirthMonth.Enabled = False
        Else
            txtBirthMonth.Enabled = True
        End If
        FilterEmployee()
    End Sub

    Private Sub Print201FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Print201FileToolStripMenuItem.Click
        PrintEmployee201(gridview1.GetFocusedRowCellValue("Control No.").ToString, gridview1.GetFocusedRowCellValue("Fullname").ToString, Me)
    End Sub
    Private Sub PrintServiceRecord_Click(sender As Object, e As EventArgs) Handles PrintServiceRecord.Click
        PrintEmployeeServiceRecord(gridview1.GetFocusedRowCellValue("Control No.").ToString, gridview1.GetFocusedRowCellValue("Fullname").ToString, Me)
    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        If XtraTabControl1.SelectedTabPage Is tabEmployeeList Then
            DXExportGridToExcel(If(ckViewAllOffice.Checked = True, Me.Text, txtOffice.Text), gridview1)
        ElseIf XtraTabControl1.SelectedTabPage Is tabBirthDay Then
            DXExportGridToExcel("BIRTHDAY LIST " & If(CheckEdit1.CheckState = True, "All Employees", "Month " & txtBirthMonth.Text), gridBirthDay)
        End If
    End Sub

    Private Sub cmdColumnSettings_Click(sender As Object, e As EventArgs) Handles cmdColumnSettings.Click
        Dim colname As String = ""
        For I = 0 To gridview1.Columns.Count - 1
            colname += gridview1.Columns(I).FieldName & ","
        Next
        frmColumnFilter.txtColumn.Text = colname.Remove(colname.Count - 1, 1)
        frmColumnFilter.GetFilterInfo(gridview1, Me.Text)
        frmColumnFilter.ShowDialog(Me)
    End Sub

    Private Sub cmdNewEmployee_Click(sender As Object, e As EventArgs) Handles cmdNewEmployee.Click
        If frmPayrollEmployeeInformation.Visible = True Then
            frmPayrollEmployeeInformation.Focus()
        Else
            frmPayrollEmployeeInformation.Show(Me)
        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        If XtraTabControl1.SelectedTabPage Is tabEmployeeList Then
            DXPrintDatagridview(If(ckViewAllOffice.Checked = True, Me.Text, txtOffice.Text), Me.Text, "", gridview1, Me)
        ElseIf XtraTabControl1.SelectedTabPage Is tabBirthDay Then
            DXPrintDatagridview("BIRTH DAY REPORT", If(CheckEdit1.CheckState = True, "All Employees", "Month: " & txtBirthMonth.Text), "", gridBirthDay, Me)
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class