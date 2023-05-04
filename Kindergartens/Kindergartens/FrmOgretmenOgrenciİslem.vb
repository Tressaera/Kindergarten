Public Class FrmOgretmenOgrenciİslem
    Private Sub FrmOgretmenOgrenciİslem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet7.Sinif' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.SinifTableAdapter.Fill(Me.AnaokuludbDataSet7.Sinif)
        Baglanti.baglan()
        cmbsinifara.DataSource = Sinif.comboboxsiniflarigetir()
        cmbsinifara.DisplayMember = "Adi"
        cmbsinifara.ValueMember = "SinifID"
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
        dtgridogrlistele.Columns(0).Visible = False
        dtgridogrlistele.Columns(1).Width = 139
        dtgridogrlistele.Columns(2).Width = 138
    End Sub

    Private Sub btnsinifara_Click(sender As Object, e As EventArgs) Handles btnsinifara.Click
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.OgrenciAraSinif(CInt(cmbsinifara.SelectedValue))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btndonemiara_Click(sender As Object, e As EventArgs) Handles btndonemiara.Click
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Aramas(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
    End Sub
End Class