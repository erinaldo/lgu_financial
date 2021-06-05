Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Module Template

    Public Function PrintRegistry(ByVal print As Boolean, ByVal report_title As String, ByVal month As String, ByVal query As String, ByVal colItemNameParam As Array, ByVal filename As String, ByVal form As Form) As String
        Dim TableRow As String = ""
        Dim Template As String = Application.StartupPath.ToString & "\Templates\COA_Registry.html"
        Dim SaveLocation As String = Application.StartupPath.ToString & "\Printing\COA_Registry_" & filename & ".html"

        If Not IO.Directory.Exists(Application.StartupPath.ToString & "\Printing") Then
            IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing")
        End If

        If IO.File.Exists(SaveLocation) = True Then
            IO.File.Delete(SaveLocation)
        End If

        My.Computer.FileSystem.CopyFile(Template, SaveLocation)

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[municipality]", compname), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[address]", compadd), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[report_title]", UCase(report_title)), False)
        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[month]", StrConv(month, vbProperCase)), False)

        'Voucher Item
        Dim colItem As String = ""
        For Each arrCol In colItemNameParam
            colItem += " <th align='center'><b>" & arrCol & "</b></th> "
        Next
        com.CommandText = Replace(query, Chr(160), Chr(64)) : rst = com.ExecuteReader
        While rst.Read
            Dim itemValue As String = ""
            For Each itemRowValue In colItemNameParam
                itemValue += " <td align='right'>" & If(rst(itemRowValue).ToString.Length > 0, FormatNumber(rst(itemRowValue).ToString, 2), "&nbsp") & "</td> "
            Next

            If itemValue.Length = 0 Then
                itemValue = "<td align='right'>&nbsp</td>"
            End If
            TableRow += "<tr> " _
                           + " <td align='right'>" & If(rst("Amount of Appropriation").ToString.Length > 0, FormatNumber(rst("Amount of Appropriation").ToString, 2), "&nbsp") & "</td> " _
                           + " <td align='right'>" & If(rst("Amount of Allotment").ToString.Length > 0, FormatNumber(rst("Amount of Allotment").ToString, 2), "&nbsp") & "</td> " _
                           + " <td align='center' >" & If(rst("Date").ToString.Length > 1, CDate(rst("Date").ToString).ToString("MM/dd/yyyy"), "&nbsp") & "</td> " _
                           + " <td align='center'>" & rst("Reference/CAFOA No.").ToString & "</td> " _
                           + " <td>" & rst("Particulars").ToString & "</td> " _
                           + " <td align='right'>" & If(rst("Total Amount of Allotment Obligation").ToString.Length > 0, FormatNumber(rst("Total Amount of Allotment Obligation").ToString, 2), "&nbsp") & "</td> " _
                           + itemValue _
                     + " </tr> " & Chr(13)

        End While
        rst.Close()


        If colItem.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalcol]", colItemNameParam.Length), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[itemcolumn]", colItem), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[totalcol]", "1"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[itemcolumn]", ""), False)
        End If

        If TableRow.Length > 0 Then
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[table_row]", TableRow), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[table_row]", ""), False)
        End If

        My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[preparedby]", UCase(GlobalAccountantName)), False)
        DigitalReportSigniture(SaveLocation, GlobalAccountantID, "prepared")

        If print Then
            PrintViaInternetExplorer(SaveLocation.Replace("\", "/"), form)
        End If

        Return SaveLocation
    End Function

    Public Sub DigitalReportSigniture(ByVal SaveLocation As String, ByVal userid As String, ByVal code_command As String)
        If Not System.IO.Directory.Exists(Application.StartupPath.ToString & "\Printing\Signature") Then
            System.IO.Directory.CreateDirectory(Application.StartupPath.ToString & "\Printing\Signature")
        End If

        Dim pic As New PictureEdit
        Dim sig As Image = getAccountSignature(userid)
        If Not sig Is Nothing Then
            pic.Image = getAccountSignature(userid)
            pic.Image.Save(Application.StartupPath.ToString & "\Printing\Signature\" & userid & ".png")
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[sig_" & code_command & "]", Application.StartupPath.ToString & "\Printing\Signature\" & userid & ".png"), False)
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_" & code_command & "]", ""), False)
        Else
            My.Computer.FileSystem.WriteAllText(SaveLocation, My.Computer.FileSystem.ReadAllText(SaveLocation).Replace("[hide_" & code_command & "]", "hidden"), False)
        End If
    End Sub

End Module
