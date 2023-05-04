Public Class Frmilac
    Private Sub Frmilac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet13.Sinif' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.SinifTableAdapter.Fill(Me.AnaokuludbDataSet13.Sinif)
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListele()
        Baglanti.baglan().Close()
        Baglanti.baglan()
        cmbsinif.DataSource = Sinif.comboboxsiniflarigetir()
        cmbsinif.DisplayMember = "Adi"
        cmbsinif.ValueMember = "SinifID"
        Baglanti.baglan().Close()
        dtgridilac.Columns(0).Visible = False
        dtgridilac.Columns(1).Width = 133
        dtgridilac.Columns(2).Width = 120
        dtgridilac.Columns(3).Width = 250
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacAraSinif(cmbsinif.GetItemText(cmbsinif.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacAraADSOYAD(txtOgrenci.Text)
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtOgrenci_TextChanged(sender As Object, e As EventArgs) Handles txtOgrenci.TextChanged
        Baglanti.baglan()
        dtgridilac.DataSource = İlac.İlacListele()
        Baglanti.baglan().Close()
    End Sub
End Class