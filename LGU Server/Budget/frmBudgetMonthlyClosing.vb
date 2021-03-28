Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmBudgetMonthlyClosing
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Escape) Then
            Me.Close()
        End If
        Return ProcessCmdKey
    End Function
    Private Sub frmProductMesurement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetIcon(Me)
        LoadData()
    End Sub

    Public Sub LoadData()
        LoadXgridNoPaint("select id, monthcode, monthname as 'Month', Closed from tblbudgetmonthly where fundperiod='" & periodcode.Text & "' order by monthcode asc ", "tblbudgetmonthly", Em, GridView1, Me)
        XgridHideColumn({"id", "monthcode"}, GridView1)
        If GridView1.RowCount > 0 Then
            cmdOk.Text = "RESET CURRENT MONTH"
            cmdOk.Appearance.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            cmdOk.Appearance.BackColor2 = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Else
            cmdOk.Text = "Create monthly budget for " & frmBudgetMonthly.txtFund.Text
            cmdOk.Appearance.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            cmdOk.Appearance.BackColor2 = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show("Are you sure you want to " & cmdOk.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "delete from tblbudgetmonthly where fundperiod='" & periodcode.Text & "' " : com.ExecuteNonQuery()
                com.CommandText = "delete from tblbudgethistory where periodcode='" & periodcode.Text & "' " : com.ExecuteNonQuery()
                com.CommandText = "update tblbudgetcomposition set monthcode='',amount=0,january=0,february=0,march=0,april=0,may=0,june=0,july=0,august=0,september=0,october=0,november=0,december=0 where periodcode='" & periodcode.Text & "' " : com.ExecuteNonQuery()
                LoadData()
                XtraMessageBox.Show("Budget quarter successfully reseted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If XtraMessageBox.Show("Are you sure you want to " & cmdOk.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select *, amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.monthcode=a.monthcode And b.itemcode=a.itemcode And b.officeid=a.officeid and a.cancelled=0) as balance from tblbudgetcomposition as b where periodcode='" & periodcode.Text & "' and totalbudget > 0", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set monthcode='01',amount=totalbudget,january=totalbudget,february=0,march=0,april=0,may=0,june=0,july=0,august=0,september=0,october=0,november=0,december=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set monthcode='01',amount=totalbudget/12,january=totalbudget/12,february=totalbudget/12,march=totalbudget/12,april=totalbudget/12,may=totalbudget/12,june=totalbudget/12,july=totalbudget/12,august=totalbudget/12,september=totalbudget/12,october=totalbudget/12,november=totalbudget/12,december=totalbudget/12 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If
                    End With
                Next

                com.CommandText = "INSERT INTO `tblbudgetmonthly` (`fundperiod`,`monthcode`,`monthname`,`closed`) VALUES " _
                                         + " ('" & periodcode.Text & "','01','January','0'), " _
                                         + " ('" & periodcode.Text & "','02','February','0'), " _
                                         + " ('" & periodcode.Text & "','03','March','0'), " _
                                         + " ('" & periodcode.Text & "','04','April','0'), " _
                                         + " ('" & periodcode.Text & "','05','May','0'), " _
                                         + " ('" & periodcode.Text & "','06','June','0'), " _
                                         + " ('" & periodcode.Text & "','07','July','0'), " _
                                         + " ('" & periodcode.Text & "','08','August','0'), " _
                                         + " ('" & periodcode.Text & "','09','September','0'), " _
                                         + " ('" & periodcode.Text & "','10','October','0'), " _
                                         + " ('" & periodcode.Text & "','11','November','0'), " _
                                         + " ('" & periodcode.Text & "','12','December','0');" : com.ExecuteNonQuery()
                LoadData()
                XtraMessageBox.Show("Budget month successfully created!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub cmdCloseBalanceDefault_Click(sender As Object, e As EventArgs) Handles cmdCloseBalanceDefault.Click
        CloseMonthlyTransaction(False)
    End Sub

    Private Sub cmdCloseBalanceRecompute_Click(sender As Object, e As EventArgs) Handles cmdCloseBalanceRecompute.Click
        CloseMonthlyTransaction(True)
    End Sub

    Public Sub CloseMonthlyTransaction(ByVal Recompute As Boolean)
        If CBool(GridView1.GetFocusedRowCellValue("Closed").ToString()) = True Then
            XtraMessageBox.Show("Selected month is already closed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf countqry("tblbudgetmonthly", "fundperiod='" & periodcode.Text & "' and cast(monthcode as unsigned) < " & Val(GridView1.GetFocusedRowCellValue("monthcode").ToString()) & " and closed=0") > 0 Then
            XtraMessageBox.Show("Closing advance month is not allowed. please close previous month first!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        If XtraMessageBox.Show("Are you sure you want to mark as done " & GridView1.GetFocusedRowCellValue("Month").ToString() & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            If Recompute Then
                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select * from tblrequisitionfund where periodcode='" & periodcode.Text & "' and monthcode='" & GridView1.GetFocusedRowCellValue("monthcode").ToString() & "' and cancelled=0 order by id asc", conn)
                msda.Fill(dst, 0)
                For x = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        Dim previousBalance As Double = Val(qrysingledata("bal", " amount-ifnull((select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.monthcode=a.monthcode And b.officeid=a.officeid and a.cancelled=0 and id< " & .Rows(x)("id").ToString() & "),0) as bal", "tblbudgetcomposition as b where periodcode='" & periodcode.Text & "' and itemcode='" & .Rows(x)("itemcode").ToString() & "' and officeid='" & .Rows(x)("officeid").ToString() & "'"))
                        com.CommandText = "update tblrequisitionfund set prevbalance='" & previousBalance & "', newbalance='" & previousBalance - Val(.Rows(x)("amount").ToString()) & "' where id='" & .Rows(x)("id").ToString() & "'" : com.ExecuteNonQuery()
                    End With
                Next
            End If


            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select *, (select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.monthcode=a.monthcode And b.officeid=a.officeid and a.cancelled=0) as totaluse from tblbudgetcomposition as b where periodcode='" & periodcode.Text & "' and totalbudget > 0", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))

                    Dim MonthSetup As Date = CDate(GridView1.GetFocusedRowCellValue("monthcode").ToString() & "/1/" & Now.Year)
                    Dim MonthCodeCurrent As String = GridView1.GetFocusedRowCellValue("monthcode").ToString()
                    Dim MonthCodenext As String = Val(GridView1.GetFocusedRowCellValue("monthcode").ToString()) + 1
                    Dim MonthCodeNextNew As String = If(MonthCodenext.Length = 1, "0" & MonthCodenext, MonthCodenext)
                    Dim MonthNameCurrent As String = MonthSetup.ToString("MMMM")
                    Dim MonthNameNext As String = MonthSetup.AddMonths(1).ToString("MMMM")

                    Dim TotalBudget As Double = Val(.Rows(cnt)("totalbudget").ToString())
                    Dim TotalUse As Double = Val(.Rows(cnt)("totaluse").ToString())
                    Dim Balance As Double = Val(.Rows(cnt)("amount").ToString()) - TotalUse


                    com.CommandText = "DELETE from tblbudgethistory where periodcode='" & .Rows(cnt)("periodcode").ToString() & "' and monthcode='" & .Rows(cnt)("monthcode").ToString() & "' and officeid='" & .Rows(cnt)("officeid").ToString() & "' and itemcode='" & .Rows(cnt)("itemcode").ToString() & "' and classcode='" & .Rows(cnt)("classcode").ToString() & "'" : com.ExecuteNonQuery()
                    If TotalBudget > 0 Then
                        com.CommandText = "insert into tblbudgethistory set periodcode='" & .Rows(cnt)("periodcode").ToString() & "', " _
                                                   + " fundcode='" & .Rows(cnt)("fundcode").ToString() & "', " _
                                                   + " yearcode='" & .Rows(cnt)("yearcode").ToString() & "', " _
                                                   + " officeid='" & .Rows(cnt)("officeid").ToString() & "', " _
                                                   + " classcode='" & .Rows(cnt)("classcode").ToString() & "', " _
                                                   + " itemcode='" & .Rows(cnt)("itemcode").ToString() & "', " _
                                                   + " itemname='" & rchar(.Rows(cnt)("itemname").ToString()) & "', " _
                                                   + " monthcode='" & .Rows(cnt)("monthcode").ToString() & "', " _
                                                   + " totalbudget='" & .Rows(cnt)("totalbudget").ToString() & "', " _
                                                   + " amount='" & .Rows(cnt)("amount").ToString() & "', " _
                                                   + " expended='" & TotalUse & "', " _
                                                   + " balance='" & Balance & "'" _
                                                   + " " : com.ExecuteNonQuery()
                    End If

                    If MonthCodeCurrent = "12" Then
                        com.CommandText = "update tblbudgetcomposition set amount=0, " & MonthNameCurrent & "=" & Balance & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    Else
                        Dim NextMonthBudget As Double = Val(.Rows(cnt)(MonthNameNext).ToString())
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set monthcode='" & MonthCodeNextNew & "', " & MonthNameCurrent & "=0, amount=" & Balance & ", " & MonthNameNext & "=" & Balance & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set monthcode='" & MonthCodeNextNew & "', " & MonthNameCurrent & "=0, amount=" & NextMonthBudget + Balance & ", " & MonthNameNext & "=" & NextMonthBudget + Balance & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If
                    End If
                End With
            Next
            com.CommandText = "update tblbudgetmonthly set closed=1 where fundperiod='" & periodcode.Text & "' and monthcode='" & GridView1.GetFocusedRowCellValue("monthcode").ToString() & "'" : com.ExecuteNonQuery()
            XtraMessageBox.Show(GridView1.GetFocusedRowCellValue("Month").ToString() & " successfully done!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
        End If
    End Sub
End Class