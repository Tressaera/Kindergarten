Public Class FrmVeliİlac
    Shared id As Integer
    Private Sub temizle()
        txtilac.Text = ""
        rchaciklama.Text = ""
    End Sub
    Private Sub FrmVeliİlac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet11.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.OgrenciTableAdapter.Fill(Me.AnaokuludbDataSet11.Ogrenci)
        Baglanti.baglan()
        cmbadsoyad.DataSource = Ogrenci.OgrenciVeliCek(Veli.ID)
        cmbadsoyad.DisplayMember = "ADSOYAD"
        cmbadsoyad.ValueMember = "OGRID"
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID)
        dtgridilac.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridilac.Columns(1).Width = 150
        dtgridilac.Columns(2).Width = 150
        dtgridilac.Columns(3).Width = 188
    End Sub

    Private Sub dtgridilac_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridilac.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridilac.Rows(row).Cells(0).Value.ToString())
        cmbadsoyad.Text = dtgridilac.Rows(row).Cells(1).Value.ToString()
        txtilac.Text = dtgridilac.Rows(row).Cells(2).Value.ToString()
        rchaciklama.Text = dtgridilac.Rows(row).Cells(3).Value.ToString()
    End Sub

    Private Sub btnilacekle_Click(sender As Object, e As EventArgs) Handles btnilacekle.Click
        Baglanti.baglan()
        İlac.İlacEkle(CInt(cmbadsoyad.SelectedValue), txtilac.Text, rchaciklama.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID)
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnilacguncelle_Click(sender As Object, e As EventArgs) Handles btnilacguncelle.Click
        Baglanti.baglan()
        İlac.İlacEkle(CInt(cmbadsoyad.SelectedValue), txtilac.Text, rchaciklama.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID)
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnSil_Click(sender As Object, e As EventArgs) Handles btnSil.Click
        Baglanti.baglan()
        İlac.İlacSil(id, txtilac.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListeleVeli(Veli.OGRID)
        Baglanti.baglan().Close()
        temizle()
    End Sub
End Class