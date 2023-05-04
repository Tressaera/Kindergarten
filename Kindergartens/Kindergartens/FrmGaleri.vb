Public Class FrmGaleri
    Private Sub temizle()
        txtResimAdi.Text = ""
        txtresimyolu.Text = ""
    End Sub

    Private i As Integer = 0
    Private Listem As List(Of String) = New List(Of String)(Galeri.ResimYollarınıcek())

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        OpenFileDialog1.ShowDialog()
        txtresimyolu.Text = OpenFileDialog1.FileName
    End Sub

    Shared id As Integer

    Private Sub FrmGaleri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridresim.DataSource = Galeri.ResimListele()
        Baglanti.baglan().Close()
        dtgridresim.Columns(0).Visible = False
        dtgridresim.Columns(1).Width = 165
        dtgridresim.Columns(2).Width = 165
        dtgridresim.Columns(3).Width = 150
    End Sub

    Private Sub btnresimekle_Click(sender As Object, e As EventArgs) Handles btnresimekle.Click
        Baglanti.baglan()
        Galeri.Resimekle(txtResimAdi.Text, dttarih.Value, txtresimyolu.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridresim.DataSource = Galeri.ResimListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnresimguncelle_Click(sender As Object, e As EventArgs) Handles btnresimguncelle.Click
        Baglanti.baglan()
        Galeri.ResimGuncelle(txtResimAdi.Text, dttarih.Value, txtresimyolu.Text, id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridresim.DataSource = Galeri.ResimListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnResimSil_Click(sender As Object, e As EventArgs) Handles btnResimSil.Click
        Baglanti.baglan()
        Galeri.ResimSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridresim.DataSource = Galeri.ResimListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub dtgridresim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridresim.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridresim.Rows(row).Cells(0).Value.ToString())
        txtResimAdi.Text = dtgridresim.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridresim.Rows(row).Cells(2).Value.ToString()
        txtresimyolu.Text = dtgridresim.Rows(row).Cells(3).Value.ToString()
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

    Private Sub btnileri_Click(sender As Object, e As EventArgs) Handles btnileri.Click
        pctresim.ImageLocation = Listem(i).ToString()
        i += 1

        If Listem.Count = i Then
            MessageBox.Show("Resim Gösterisi Bitti")
            btnileri.Enabled = False
            btngeri.Enabled = True
        End If
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridresim.DataSource = Galeri.ResimListele()
        Baglanti.baglan().Close()
    End Sub
End Class