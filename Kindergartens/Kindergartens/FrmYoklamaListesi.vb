Public Class FrmYoklamaListesi
    Private Sub FrmYoklamaListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet12.Sinif' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.SinifTableAdapter.Fill(Me.AnaokuludbDataSet12.Sinif)
        Baglanti.baglan()
        cmbsinif.DataSource = Sinif.comboboxsiniflarigetir()
        cmbsinif.DisplayMember = "Adi"
        cmbsinif.ValueMember = "SinifID"
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        listBox1.Items.Clear()
        Baglanti.baglan()
        dtgridYoklamaListesi.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarih.Value.ToShortDateString()), cmbsinif.GetItemText(cmbsinif.SelectedItem))
        Baglanti.baglan()
        Baglanti.baglan()
        Yoklama.GelmeyenOgrenci(Convert.ToDateTime(dttarih.Value.ToShortDateString()), cmbsinif.GetItemText(cmbsinif.SelectedItem), listBox1)
        Baglanti.baglan().Close()
        dtgridYoklamaListesi.Columns(0).Visible = False
        dtgridYoklamaListesi.Columns(1).Width = 143
        dtgridYoklamaListesi.Columns(2).Width = 143
        dtgridYoklamaListesi.Columns(3).Width = 144
        dtgridYoklamaListesi.Columns(4).Width = 144
    End Sub
End Class