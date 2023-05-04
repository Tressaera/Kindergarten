Public Class FrmVeliGaleri
    Private i As Integer = 0
    Private Listem As List(Of String) = New List(Of String)(Galeri.ResimYollarınıcek())

    Private Sub btngeri_Click(sender As Object, e As EventArgs) Handles btngeri.Click
        i -= 1
        pctresim.ImageLocation = Listem(i).ToString()

        If i = 0 Then
            MessageBox.Show("İlk Resim")
            btngeri.Enabled = False
            btnileri.Enabled = True
        End If
    End Sub

    Private Sub btnileri_Click(sender As Object, e As EventArgs) Handles btnileri.Click
        pctresim.ImageLocation = Listem(i).ToString()
        i += 1

        If Listem.Count = i Then
            MessageBox.Show("Resim Gösterisi Bitti")
            btnileri.Enabled = False
            btngeri.Enabled = True
        End If
    End Sub
End Class