Imports iTextSharp
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Data.Odbc
Imports System.IO
Module pdf
    Public Function GetDataTable() As DataTable
        Dim dataTable As New DataTable("commande")
        'Create another DataColumn Name
        Dim dataColumn_1 As New DataColumn(commande.data_liste_com.Columns(0).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_1)
        Dim dataColumn_2 As New DataColumn(commande.data_liste_com.Columns(1).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_2)
        Dim dataColumn_3 As New DataColumn(commande.data_liste_com.Columns(2).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_3)
        Dim dataColumn_4 As New DataColumn(commande.data_liste_com.Columns(3).HeaderText.ToString(), GetType(String))
        dataTable.Columns.Add(dataColumn_4)
        'Now Add some row to newly created dataTable
        Dim dataRow As DataRow
        For i As Integer = 0 To commande.data_liste_com.Rows.Count - 1
            dataRow = dataTable.NewRow()
            ' Important you have create New row
            dataRow(commande.data_liste_com.Columns(0).HeaderText.ToString()) = commande.data_liste_com.Rows(i).Cells(0).Value
            dataRow(commande.data_liste_com.Columns(1).HeaderText.ToString()) = commande.data_liste_com.Rows(i).Cells(1).Value
            dataRow(commande.data_liste_com.Columns(2).HeaderText.ToString()) = commande.data_liste_com.Rows(i).Cells(2).Value
            dataRow(commande.data_liste_com.Columns(3).HeaderText.ToString()) = commande.data_liste_com.Rows(i).Cells(3).Value
            dataTable.Rows.Add(dataRow)
        Next
        dataTable.AcceptChanges()
        Return dataTable
    End Function
    Public Sub ExportDataToPDFTable()
        Dim paragraph As New Paragraph
        Dim doc As New Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 10)
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(commande.SaveFileDialog1.FileName + ".pdf", FileMode.Create))
        doc.Open()

        Dim font12BoldRed As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.UNDERLINE Or iTextSharp.text.Font.BOLDITALIC, BaseColor.RED)
        Dim font12Bold As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim font12Normal As New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12.0F, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        'creation d'une instance de table pdf  et ajouter le  nbre de colonne  dans le table 
        Dim PdfTables As New PdfPTable(2)
        PdfTables.TotalWidth = 490.0F
        'fixer la taille du table
        PdfTables.LockedWidth = True
        'taille des colonnes
        Dim widths As Single() = New Single() {2.0F, 2.0F}
        PdfTables.SetWidths(widths)
        PdfTables.HorizontalAlignment = 1 ' 0 --> Left, 1 --> Center, 2 --> Right
        PdfTables.SpacingBefore = 2.0F

        'Decleration pdfCell 
        Dim PdfPCell As PdfPCell = Nothing
        Dim p1 As New Phrase

        'Affectation de valeurs à chaque cellule sous forme de phrases
        PdfPCell = New PdfPCell(New Phrase(New Chunk("commande numero :  " & CInt(commande.txt_num_com.Text), font12Bold)))
        'Alignement de la phrase dans le pdfcell
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        'Add pdfcell dans pdftable
        PdfTables.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("   date BC : " & CStr(commande.date_com.Value).Substring(0, 10), font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTables.AddCell(PdfPCell)
        doc.Add(PdfTables)
        '**********************************************************************************************************************************

        Dim PdfTables1 As New PdfPTable(2)
        PdfTables1.TotalWidth = 490.0F

        PdfTables1.LockedWidth = True

        Dim widths1 As Single() = New Single() {2.0F, 2.0F}
        PdfTables1.SetWidths(widths1)
        PdfTables1.HorizontalAlignment = 1
        PdfTables1.SpacingBefore = 2.0F


        Dim PdfPCell1 As PdfPCell = Nothing

        PdfPCell1 = New PdfPCell(New Phrase(New Chunk("code_client :" & commande.ref_cli.Text, font12Bold)))

        PdfPCell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        PdfTables1.AddCell(PdfPCell1)
        PdfPCell1 = New PdfPCell(New Phrase(New Chunk(" nom client :   " & commande.txt_nom_cli.Text, font12Bold)))
        PdfPCell1.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTables1.AddCell(PdfPCell1)
        doc.Add(PdfTables1)
        '**********************************************************************************************************************************

        Dim PdfTables2 As New PdfPTable(2)
        PdfTables2.TotalWidth = 490.0F

        PdfTables2.LockedWidth = True

        Dim widths2 As Single() = New Single() {2.0F, 2.0F}
        PdfTables2.SetWidths(widths2)
        PdfTables2.HorizontalAlignment = 1
        PdfTables2.SpacingBefore = 2.0F


        Dim PdfPCell2 As PdfPCell = Nothing



        PdfPCell2 = New PdfPCell(New Phrase(New Chunk("date Livraison  :" & CStr(commande.date_liv_com.Value).Substring(0, 10), font12Bold)))

        PdfPCell2.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        PdfTables2.AddCell(PdfPCell2)
        PdfPCell2 = New PdfPCell(New Phrase(New Chunk("    ", font12Bold)))
        PdfPCell2.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTables2.AddCell(PdfPCell2)
        doc.Add(PdfTables2)


        Dim PdfTable As New PdfPTable(4)
        PdfTable.TotalWidth = 490.0F

        PdfTable.LockedWidth = True

        widths = New Single() {1.0F, 1.0F, 1.0F, 1.0F}
        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 1
        PdfTable.SpacingBefore = 2.0F


        PdfPCell = Nothing


        PdfPCell = New PdfPCell(New Phrase(New Chunk("code_article", font12Bold)))

        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("prix", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("quantité", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)
        PdfPCell = New PdfPCell(New Phrase(New Chunk("montant", font12Bold)))
        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        PdfTable.AddCell(PdfPCell)


        Dim dt As DataTable = GetDataTable()
        If dt IsNot Nothing Then

            For rows As Integer = 0 To dt.Rows.Count - 1
                For column As Integer = 0 To 3
                    PdfPCell = New PdfPCell(New Phrase(dt.Rows(rows)(column).ToString(), font12Normal))
                    If column = 0 Or column = 1 Then
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                    Else
                        PdfPCell.HorizontalAlignment = PdfPCell.ALIGN_RIGHT
                    End If
                    PdfTable.AddCell(PdfPCell)
                Next
            Next



            doc.Add(PdfTable)
        End If
        '**********************************************************************************************************************************

        Dim Pdfmnt As New PdfPTable(4)
        Pdfmnt.TotalWidth = 490.0F

        Pdfmnt.LockedWidth = True


        Pdfmnt.SetWidths(widths)
        Pdfmnt.HorizontalAlignment = 1
        Pdfmnt.SpacingBefore = 2.0F


        Dim PdfPCel As PdfPCell = Nothing

        PdfPCel = New PdfPCell(New Phrase(New Chunk("Montant totale :", font12Bold)))

        PdfPCel.HorizontalAlignment = PdfPCell.ALIGN_CENTER

        Pdfmnt.AddCell(PdfPCel)
        PdfPCel = New PdfPCell(New Phrase(New Chunk("", font12Bold)))
        PdfPCel.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Pdfmnt.AddCell(PdfPCel)
        PdfPCel = New PdfPCell(New Phrase(New Chunk("", font12Bold)))
        PdfPCel.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Pdfmnt.AddCell(PdfPCel)
        PdfPCel = New PdfPCell(New Phrase(New Chunk(commande.mnt_tot.Text, font12Bold)))
        PdfPCel.HorizontalAlignment = PdfPCell.ALIGN_CENTER
        Pdfmnt.AddCell(PdfPCel)
        doc.Add(Pdfmnt)
        doc.Close()
    End Sub
End Module
