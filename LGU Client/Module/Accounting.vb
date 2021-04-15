Imports MySql.Data.MySqlClient

Module Accounting
    Public Function CancelVoucher(ByVal voucherid As String, ByVal pid As String, ByVal remarks As String)
        Try
            com.CommandText = "update tbldisbursementvoucher set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where voucherid='" & voucherid & "' " : com.ExecuteNonQuery()
            com.CommandText = "update tblrequisition set voucher=0 where pid in (select pid from tbldisbursementvoucher where voucherid='" & voucherid & "')" : com.ExecuteNonQuery()

            com.CommandText = "update tbljournalentryvoucher set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where dvid='" & voucherid & "' " : com.ExecuteNonQuery()
            com.CommandText = "update tbljournalentryitem set cancelled=1 where jevno in (select jevno from tbljournalentryvoucher where dvid='" & voucherid & "')" : com.ExecuteNonQuery()

            com.CommandText = "update tblrequisitionfund set cancelled=1 where pid in (select pid from tbldisbursementvoucher where voucherid='" & voucherid & "')" : com.ExecuteNonQuery()

            com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='', mainreference='" & pid & "', subreference='" & pid & "', status='Cancelled', remarks='" & remarks & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()

            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select *, (select monthcode from tblbudgetcomposition where periodcode=a.periodcode and itemcode=a.itemcode and officeid=a.officeid) current_month_period, " _
                                      + " (select date_format(concat(date_format(current_date,'%Y'),'-',monthcode,'-1'),'%M') from tblbudgetcomposition where periodcode=a.periodcode and itemcode=a.itemcode and officeid=a.officeid) as monthname " _
                                      + " from tblrequisitionfund as a where pid in (select pid from tbldisbursementvoucher where voucherid='" & voucherid & "')", conn)
            da.Fill(st, 0)
            For cnt = 0 To st.Tables(0).Rows.Count - 1
                With (st.Tables(0))
                    If Val(.Rows(cnt)("current_month_period").ToString()) > Val(.Rows(cnt)("monthcode").ToString()) Then
                        com.CommandText = "update tblbudgetcomposition set " _
                            + " amount=amount+" & .Rows(cnt)("amount").ToString() & ", " _
                            + .Rows(cnt)("monthname").ToString() & "=" & .Rows(cnt)("monthname").ToString() & "+" & .Rows(cnt)("amount").ToString() & " " _
                            + " where periodcode='" & .Rows(cnt)("periodcode").ToString() & "' and itemcode='" & .Rows(cnt)("itemcode").ToString() & "' and officeid='" & .Rows(cnt)("officeid").ToString() & "'" : com.ExecuteNonQuery()
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function CancelRequisition(ByVal pid As String, ByVal remarks As String)
        Try
            com.CommandText = "update tblrequisition set approved=0, cancelled=1, cancelledby='" & globaluserid & "',datecancelled=current_timestamp where pid ='" & pid & "'" : com.ExecuteNonQuery()
            com.CommandText = "update tblrequisitionfund set cancelled=1 where pid ='" & pid & "'" : com.ExecuteNonQuery()

            com.CommandText = "update tbldisbursementvoucher set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where pid='" & pid & "' " : com.ExecuteNonQuery()

            com.CommandText = "update tbljournalentryvoucher set cancelled=1,cancelledby='" & globaluserid & "',datecancelled=current_timestamp where dvid in (select voucherid from tbldisbursementvoucher where pid='" & pid & "')" : com.ExecuteNonQuery()
            com.CommandText = "update tbljournalentryitem set cancelled=1 where jevno in (select jevno from tbljournalentryvoucher where dvid in (select voucherid from tbldisbursementvoucher where pid='" & pid & "'))" : com.ExecuteNonQuery()

            com.CommandText = "insert into tblapprovalhistory set apptype='requisition', trncode='', mainreference='" & pid & "', subreference='" & pid & "', status='Cancelled', remarks='" & remarks & "', applevel=0, officeid='" & compOfficeid & "', confirmid='" & globaluserid & "', confirmby='" & globalfullname & "', position='" & globalposition & "', dateconfirm=current_timestamp,finalapprover=0" : com.ExecuteNonQuery()

            da = Nothing : st = New DataSet
            da = New MySqlDataAdapter("select *, (select monthcode from tblbudgetcomposition where periodcode=a.periodcode and itemcode=a.itemcode and officeid=a.officeid) current_month_period, " _
                                      + " (select date_format(concat(date_format(current_date,'%Y'),'-',monthcode,'-1'),'%M') from tblbudgetcomposition where periodcode=a.periodcode and itemcode=a.itemcode and officeid=a.officeid) as monthname " _
                                      + " from tblrequisitionfund as a where pid ='" & pid & "'", conn)
            da.Fill(st, 0)
            For cnt = 0 To st.Tables(0).Rows.Count - 1
                With (st.Tables(0))
                    If Val(.Rows(cnt)("current_month_period").ToString()) > Val(.Rows(cnt)("monthcode").ToString()) Then
                        com.CommandText = "update tblbudgetcomposition set " _
                           + " amount=amount+" & .Rows(cnt)("amount").ToString() & ", " _
                           + .Rows(cnt)("monthname").ToString() & "=" & .Rows(cnt)("monthname").ToString() & "+" & .Rows(cnt)("amount").ToString() & " " _
                           + " where periodcode='" & .Rows(cnt)("periodcode").ToString() & "' and itemcode='" & .Rows(cnt)("itemcode").ToString() & "' and officeid='" & .Rows(cnt)("officeid").ToString() & "'" : com.ExecuteNonQuery()
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Module
