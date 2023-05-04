Public Class FrmOgretmenGaleri
    Private Sub btnresimekle_Click(sender As Object, e As EventArgs) Handles btnresimekle.Click
        Baglanti.baglan()
        Galeri.Resimekle(txtResimAdi.Text, dttarih.Value, txtresimyolu.Text)
        Baglanti.baglan().Close()
        txtResimAdi.Text = ""
        txtresimyolu.Text = ""
    End Sub
    Private i As Integer = 0
    Private Listem As List(Of String) = New List(Of String)(Galeri.ResimYollarınıcek())

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        OpenFileDialog1.ShowDialog()
        txtresimyolu.Text = OpenFileDialog1.FileName
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

    Private Sub btngeri_Click(sender As Object, e As EventArgs) Handles btngeri.Click
        i -= 1
        pctresim.ImageLocation = Listem(i).ToString()

        If i = 0 Then
            MessageBox.Show("İlk Resim")
            btngeri.Enabled = False
            btnileri.Enabled = True
        End If
    End Sub
End Class