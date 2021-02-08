Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.XtraGrid.Views.Grid
Imports MySql.Data.MySqlClient

Public Class frmBudgetQuarterActivate
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
        LoadXgridNoPaint("select id, quartercode, quartername as 'Quarter', Closed from tblbudgetquarter where fundperiod='" & periodcode.Text & "' order by quartername asc ", "tblbudgetquarter", Em, GridView1, Me)
        XgridHideColumn({"id", "quartercode"}, GridView1)
        If GridView1.RowCount > 0 Then
            cmdOk.Text = "RESET CURRENT QUARTER"
            cmdOk.Appearance.BackColor = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            cmdOk.Appearance.BackColor2 = Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Else
            cmdOk.Text = "Create quarterly budget for " & frmBudgetQuarterly.txtFund.Text
            cmdOk.Appearance.BackColor = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            cmdOk.Appearance.BackColor2 = Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        End If
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show("Are you sure you want to " & cmdOk.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                com.CommandText = "delete from tblbudgetquarter where fundperiod='" & periodcode.Text & "' " : com.ExecuteNonQuery()
                com.CommandText = "update tblbudgetcomposition set quarter='',amount=0,quarter1=0,quarter2=0,quarter3=0,quarter4=0 where periodcode='" & periodcode.Text & "' " : com.ExecuteNonQuery()
                LoadData()
                XtraMessageBox.Show("Budget quarter successfully reseted!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            If XtraMessageBox.Show("Are you sure you want to " & cmdOk.Text & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                dst = Nothing : dst = New DataSet
                msda = New MySqlDataAdapter("select *, amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.quarter=a.quarter And b.itemcode=a.itemcode And b.officeid=a.officeid and a.cancelled=0) as balance from tblbudgetcomposition as b where periodcode='" & periodcode.Text & "' and totalbudget > 0", conn)
                msda.Fill(dst, 0)
                For cnt = 0 To dst.Tables(0).Rows.Count - 1
                    With (dst.Tables(0))
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set quarter='Q1',amount=totalbudget,quarter1=totalbudget,quarter2=0,quarter3=0,quarter4=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set quarter='Q1',amount=totalbudget/4,quarter1=totalbudget/4,quarter2=totalbudget/4,quarter3=totalbudget/4,quarter4=totalbudget/4 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If
                    End With
                Next
                com.CommandText = "insert into tblbudgetquarter (fundperiod,quartercode,quartername,quarterbegin,quarterend,closed) values ('" & periodcode.Text & "','Q1','1st Quarter','01','03',0),('" & periodcode.Text & "','Q2','2nd Quarter','04','06',0),('" & periodcode.Text & "','Q3','3rd Quarter','07','09',0),('" & periodcode.Text & "','Q4','4th Quarter','10','12',0);" : com.ExecuteNonQuery()
                LoadData()
                XtraMessageBox.Show("Budget quarter successfully created!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        LoadData()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        If CBool(GridView1.GetFocusedRowCellValue("Closed").ToString()) = True Then
            XtraMessageBox.Show("Selected quarter is already closed!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q2" Then
            If countqry("tblbudgetquarter", "fundperiod='" & periodcode.Text & "' and quartercode='Q1' and closed=0") > 0 Then
                XtraMessageBox.Show("Closing advance quarter is not allowed. please close previous quarter first!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q3" Then
            If countqry("tblbudgetquarter", "fundperiod='" & periodcode.Text & "' and (quartercode='Q1' or quartercode='Q2') and closed=0") > 0 Then
                XtraMessageBox.Show("Closing advance quarter is not allowed. please close previous quarter first!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q4" Then
            If countqry("tblbudgetquarter", "fundperiod='" & periodcode.Text & "' and (quartercode='Q1' or quartercode='Q2' or quartercode='Q3') and closed=0") > 0 Then
                XtraMessageBox.Show("Closing advance quarter is not allowed. please close previous quarter first!", compname, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

        End If

        If XtraMessageBox.Show("Are you sure you want to mark as done " & GridView1.GetFocusedRowCellValue("Quarter").ToString() & "?", compname, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            dst = Nothing : dst = New DataSet
            msda = New MySqlDataAdapter("select *, amount-(select ifnull(sum(amount),0) from tblrequisitionfund as a where b.periodcode=a.periodcode And b.itemcode=a.itemcode And b.quarter=a.quarter And b.officeid=a.officeid and a.cancelled=0) as balance from tblbudgetcomposition as b where periodcode='" & periodcode.Text & "' and totalbudget > 0", conn)
            msda.Fill(dst, 0)
            For cnt = 0 To dst.Tables(0).Rows.Count - 1
                With (dst.Tables(0))
                    If GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q1" Then
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set quarter1=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q2', amount=" & Val(.Rows(cnt)("balance").ToString()) & ", quarter2=" & Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set quarter1=" & .Rows(cnt)("balance").ToString() & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q2', amount=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & ", quarter2=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If

                    ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q2" Then
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set quarter2=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q3', amount=" & Val(.Rows(cnt)("balance").ToString()) & ", quarter3=" & Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set quarter2=" & .Rows(cnt)("balance").ToString() & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q3', amount=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & ", quarter3=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If

                    ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q3" Then
                        If countqry("tblglaroexemption", "itemcode='" & .Rows(cnt)("itemcode").ToString() & "'") > 0 Then
                            com.CommandText = "update tblbudgetcomposition set quarter3=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q4', amount=" & Val(.Rows(cnt)("balance").ToString()) & ", quarter4=" & Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        Else
                            com.CommandText = "update tblbudgetcomposition set quarter3=" & .Rows(cnt)("balance").ToString() & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                            com.CommandText = "update tblbudgetcomposition set quarter='Q4', amount=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & ", quarter4=" & Val(Val(.Rows(cnt)("totalbudget").ToString()) / 4) + Val(.Rows(cnt)("balance").ToString()) & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        End If
                    ElseIf GridView1.GetFocusedRowCellValue("quartercode").ToString() = "Q4" Then
                        com.CommandText = "update tblbudgetcomposition set quarter4=" & .Rows(cnt)("balance").ToString() & " where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                        com.CommandText = "update tblbudgetcomposition set quarter='', amount=0 where id='" & .Rows(cnt)("id").ToString() & "'" : com.ExecuteNonQuery()
                    End If
                End With
            Next
            com.CommandText = "update tblbudgetquarter set closed=1 where fundperiod='" & periodcode.Text & "' and quartercode='" & GridView1.GetFocusedRowCellValue("quartercode").ToString() & "'" : com.ExecuteNonQuery()
            LoadData()
            XtraMessageBox.Show(GridView1.GetFocusedRowCellValue("Quarter").ToString() & " successfully done!", compname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class