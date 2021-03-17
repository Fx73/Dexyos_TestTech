Public Class MainForm

    Public Const LARGEUR = 6
    Public Const HAUTEUR = 11

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 1 To HAUTEUR
            MyDataGridView.Rows.Add()
        Next
    End Sub


    Private Sub MyTextBox_TextChanged(sender As Object, e As EventArgs) Handles MyTextBox.TextChanged
        'Changement du nombre de colonne
        Dim nbpixels = MyTextBox.Text.Length * LARGEUR + 1

        While MyDataGridView.ColumnCount > nbpixels
            MyDataGridView.Columns.RemoveAt(MyDataGridView.ColumnCount - 1)
        End While
        While MyDataGridView.ColumnCount < nbpixels
            MyDataGridView.Columns.Add("", "")
        End While


        'Effacement de la précedante ecriture
        For index = 1 To HAUTEUR - 1
            MyDataGridView.Rows.RemoveAt(1)
            MyDataGridView.Rows.Add()
        Next

        'Dessin
        Dim col = 1
        For Each chiffre In MyTextBox.Text
            For Each barre In GetBarresLCD(chiffre)
                Dessine(col, barre)

            Next
            col += LARGEUR
        Next


    End Sub


    Private Sub Dessine(col, barre)
        Select Case barre
            Case "A"
                MyDataGridView.Rows(1).Cells().Item(col + 1).Style.BackColor = Color.Black
                MyDataGridView.Rows(1).Cells().Item(col + 2).Style.BackColor = Color.Black
                MyDataGridView.Rows(1).Cells().Item(col + 3).Style.BackColor = Color.Black

            Case "G"
                MyDataGridView.Rows(5).Cells().Item(col + 1).Style.BackColor = Color.Black
                MyDataGridView.Rows(5).Cells().Item(col + 2).Style.BackColor = Color.Black
                MyDataGridView.Rows(5).Cells().Item(col + 3).Style.BackColor = Color.Black

            Case "D"
                MyDataGridView.Rows(9).Cells().Item(col + 1).Style.BackColor = Color.Black
                MyDataGridView.Rows(9).Cells().Item(col + 2).Style.BackColor = Color.Black
                MyDataGridView.Rows(9).Cells().Item(col + 3).Style.BackColor = Color.Black

            Case "B"
                MyDataGridView.Rows(2).Cells().Item(col + 4).Style.BackColor = Color.Black
                MyDataGridView.Rows(3).Cells().Item(col + 4).Style.BackColor = Color.Black
                MyDataGridView.Rows(4).Cells().Item(col + 4).Style.BackColor = Color.Black

            Case "C"
                MyDataGridView.Rows(6).Cells().Item(col + 4).Style.BackColor = Color.Black
                MyDataGridView.Rows(7).Cells().Item(col + 4).Style.BackColor = Color.Black
                MyDataGridView.Rows(8).Cells().Item(col + 4).Style.BackColor = Color.Black

            Case "F"
                MyDataGridView.Rows(2).Cells().Item(col).Style.BackColor = Color.Black
                MyDataGridView.Rows(3).Cells().Item(col).Style.BackColor = Color.Black
                MyDataGridView.Rows(4).Cells().Item(col).Style.BackColor = Color.Black

            Case "E"
                MyDataGridView.Rows(6).Cells().Item(col).Style.BackColor = Color.Black
                MyDataGridView.Rows(7).Cells().Item(col).Style.BackColor = Color.Black
                MyDataGridView.Rows(8).Cells().Item(col).Style.BackColor = Color.Black

        End Select
    End Sub


    '    A
    '    _
    ' F |G|  B
    '    - 
    ' E |_|  C
    '    D

    Function GetBarresLCD(n) As String
        Select Case n
            Case "0" : Return "ABCDEF"
            Case "1" : Return "BC"
            Case "2" : Return "ABGED"
            Case "3" : Return "ABCDG"
            Case "4" : Return "FBGC"
            Case "5" : Return "AFGCD"
            Case "6" : Return "AFEDCG"
            Case "7" : Return "ABC"
            Case "8" : Return "ABCDEFG"
            Case "9" : Return "ABCDFG"
            Case Else : Return ""
        End Select
    End Function


End Class
