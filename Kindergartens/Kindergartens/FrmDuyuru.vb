Public Class FrmDuyuru
    Private Sub temizle()
        txtbaslik.Text = ""
        rchicerik.Text = ""
        cmbdonem.Text = ""
        cmbdonemara.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmDuyuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruListele()
        Baglanti.baglan().Close()
        dtgridduyurulistele.Columns(0).Visible = False
        dtgridduyurulistele.Columns(3).Width = 224
    End Sub

    Private Sub dtgridduyurulistele_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridduyurulistele.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridduyurulistele.Rows(row).Cells(0).Value.ToString())
        dttarih.Text = dtgridduyurulistele.Rows(row).Cells(1).Value.ToString()
        txtbaslik.Text = dtgridduyurulistele.Rows(row).Cells(2).Value.ToString()
        rchicerik.Text = dtgridduyurulistele.Rows(row).Cells(3).Value.ToString()
        cmbdonem.Text = dtgridduyurulistele.Rows(row).Cells(4).Value.ToString()
    End Sub

    Private Sub btnduyuruekle_Click(sender As Object, e As EventArgs) Handles btnduyuruekle.Click
        Baglanti.baglan()
        Duyuru.DuyuruEkle(dttarih.Value, txtbaslik.Text, rchicerik.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnduyuruguncelle_Click(sender As Object, e As EventArgs) Handles btnduyuruguncelle.Click
        Baglanti.baglan()
        Duyuru.DuyuruGuncelle(dttarih.Value, txtbaslik.Text, rchicerik.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnduyurusil_Click(sender As Object, e As EventArgs) Handles btnduyurusil.Click
        Baglanti.baglan()
        Duyuru.DuyuruSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnTarihara_Click(sender As Object, e As EventArgs) Handles btnTarihara.Click
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridduyurulistele.DataSource = Duyuru.DuyuruListele()
        Baglanti.baglan().Close()
    End Sub
End Class