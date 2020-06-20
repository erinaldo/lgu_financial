﻿Module Transaction

    'Public Function getGlobalTrnid() As String
    '    Dim strs As Date
    '    Dim finalstr As String = ""

    '    com.CommandText = "select current_timestamp as trnid"
    '    rst = com.ExecuteReader
    '    While rst.Read
    '        strs = rst("trnid").ToString
    '        finalstr = strs.ToString("yyyyMMddhhmmss")
    '    End While
    '    rst.Close()
    '    Return finalstr
    'End Function

    Public Function GetSequenceNo(ByVal periodcode As String, ByVal fieldname As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0
        com.CommandText = "select " & fieldname & " from tblfundperiod where periodcode='" & periodcode & "' " : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst(fieldname).ToString.Length
            strng = Val(rst(fieldname).ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblfundperiod set " & fieldname & "='" & newNumber & "' where periodcode='" & periodcode & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Sub UpdateAccountableForm(ByVal invrefno As String)
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0 : Dim seriesto As Integer = 0
        com.CommandText = "select currentno, seriesto from tblforminventory where id='" & invrefno & "' " : rst = com.ExecuteReader()
        While rst.Read
            seriesto = Val(rst("seriesto"))
            NumberLen = rst("currentno").ToString.Length
            strng = Val(rst("currentno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        If Val(newNumber) > Val(seriesto) Then
            com.CommandText = "update tblforminventory set currentno='0' where id='" & invrefno & "'" : com.ExecuteNonQuery()
        Else
            com.CommandText = "update tblforminventory set currentno='" & newNumber & "' where id='" & invrefno & "'" : com.ExecuteNonQuery()
        End If
    End Sub

    Public Function GetRequisitionSeries()
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0 : Dim seriesto As Integer = 0
        If countrecord("tblrequisitionseries") = 0 Then
            com.CommandText = "insert into tblrequisitionseries set seriesno='000000'" : com.ExecuteNonQuery()
        End If

        com.CommandText = "select seriesno from tblrequisitionseries" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblrequisitionseries set seriesno='" & newNumber & "'" : com.ExecuteNonQuery()
        Return newNumber

    End Function

    Public Function GetRequestNumber(ByVal fundcode As String, ByVal requesttype As String) As String
        Dim strng As Integer = 0 : Dim newNumber As String = "" : Dim NumberLen As Integer = 0 : Dim seriesto As Integer = 0
        If countqry("tblrequisitiontypeseries", "periodcode='" & fundcode & "' and requesttype='" & requesttype & "'") = 0 Then
            com.CommandText = "insert into tblrequisitiontypeseries set periodcode='" & fundcode & "',requesttype='" & requesttype & "', seriesno='0000'" : com.ExecuteNonQuery()
        End If

        com.CommandText = "select seriesno from tblrequisitiontypeseries where periodcode='" & fundcode & "' and requesttype='" & requesttype & "'" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        com.CommandText = "update tblrequisitiontypeseries set seriesno='" & newNumber & "' where periodcode='" & fundcode & "' and requesttype='" & requesttype & "'" : com.ExecuteNonQuery()
        Return newNumber
    End Function

    Public Function getVoucherNumber(ByVal year As String, ByVal table As String)
        Dim strng As Integer = 1 : Dim newNumber As String = "" : Dim NumberLen As Integer = 3
        com.CommandText = "select seriesno from " & table & " where yeartrn='" & year & "' order by seriesno desc limit 1" : rst = com.ExecuteReader()
        While rst.Read
            NumberLen = rst("seriesno").ToString.Length
            strng = Val(rst("seriesno").ToString) + 1
        End While
        rst.Close()
        If NumberLen > strng.ToString.Length Then
            Dim a As Integer = NumberLen - strng.ToString.Length
            If a = 10 Then
                newNumber = "0000000000" & strng
            ElseIf a = 9 Then
                newNumber = "000000000" & strng
            ElseIf a = 8 Then
                newNumber = "00000000" & strng
            ElseIf a = 7 Then
                newNumber = "0000000" & strng
            ElseIf a = 6 Then
                newNumber = "000000" & strng
            ElseIf a = 5 Then
                newNumber = "00000" & strng
            ElseIf a = 4 Then
                newNumber = "0000" & strng
            ElseIf a = 3 Then
                newNumber = "000" & strng
            ElseIf a = 2 Then
                newNumber = "00" & strng
            ElseIf a = 1 Then
                newNumber = "0" & strng
            Else
                newNumber = strng
            End If
        Else
            newNumber = strng
        End If
        Return newNumber
    End Function

End Module
