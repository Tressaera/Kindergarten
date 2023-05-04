Public Class FrmYemekListesi
    Private Sub temizle()
        rchikindi.Text = ""
        rchogle.Text = ""
        rchsabah.Text = ""
        cmbdonem.Text = ""
        cmbdonemara.Text = ""
    End Sub

    Shared id As Integer
    Private Sub FrmYemekListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListele()
        Baglanti.baglan().Close()
        dtgridyemeklistesi.Columns(0).Visible = False
        dtgridyemeklistesi.Columns(2).Width = 120
        dtgridyemeklistesi.Columns(3).Width = 121
        dtgridyemeklistesi.Columns(4).Width = 121
    End Sub

    Private Sub dtgridyemeklistesi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridyemeklistesi.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridyemeklistesi.Rows(row).Cells(0).Value.ToString())
        dttarih.Text = dtgridyemeklistesi.Rows(row).Cells(1).Value.ToString()
        rchsabah.Text = dtgridyemeklistesi.Rows(row).Cells(2).Value.ToString()
        rchogle.Text = dtgridyemeklistesi.Rows(row).Cells(3).Value.ToString()
        rchikindi.Text = dtgridyemeklistesi.Rows(row).Cells(4).Value.ToString()
        cmbdonem.Text = dtgridyemeklistesi.Rows(row).Cells(5).Value.ToString()
    End Sub

    Private Sub btnYemekListesiEkle_Click(sender As Object, e As EventArgs) Handles btnYemekListesiEkle.Click
        Baglanti.baglan()
        YemekListesi.YemekListesiEkle(dttarih.Value, rchsabah.Text, rchogle.Text, rchikindi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnYemekListesiGuncelle_Click(sender As Object, e As EventArgs) Handles btnYemekListesiGuncelle.Click
        Baglanti.baglan()
        YemekListesi.YemekListesiGuncelle(dttarih.Value, rchsabah.Text, rchogle.Text, rchikindi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnyemeklistesisil_Click(sender As Object, e As EventArgs) Handles btnyemeklistesisil.Click
        Baglanti.baglan()
        YemekListesi.YemekListesiSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btntarihara_Click(sender As Object, e As EventArgs) Handles btntarihara.Click
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListele()
        Baglanti.baglan().Close()
    End Sub
End Class