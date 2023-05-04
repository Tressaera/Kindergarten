Public Class FrmEtkinlik
    Private Sub temizle()
        txtbaslik.Text = ""
        cmbdonem.Text = ""
        rchbilgi.Text = ""
        cmbdonemara.Text = ""
    End Sub

    Shared id As Integer

    Private Sub FrmEtkinlik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele()
        Baglanti.baglan().Close()
        dtgridetkinliklistele.Columns(0).Visible = False
        dtgridetkinliklistele.Columns(2).Width = 125
        dtgridetkinliklistele.Columns(3).Width = 189
    End Sub

    Private Sub dtgridetkinliklistele_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridetkinliklistele.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridetkinliklistele.Rows(row).Cells(0).Value.ToString())
        dttarih.Text = dtgridetkinliklistele.Rows(row).Cells(1).Value.ToString()
        txtbaslik.Text = dtgridetkinliklistele.Rows(row).Cells(2).Value.ToString()
        rchbilgi.Text = dtgridetkinliklistele.Rows(row).Cells(3).Value.ToString()
        cmbdonem.Text = dtgridetkinliklistele.Rows(row).Cells(4).Value.ToString()
    End Sub

    Private Sub btnetkinlikekle_Click(sender As Object, e As EventArgs) Handles btnetkinlikekle.Click
        Baglanti.baglan()
        Etkinlik.EtkinlikEkle(dttarih.Value, txtbaslik.Text, rchbilgi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnetkinlikguncelle_Click(sender As Object, e As EventArgs) Handles btnetkinlikguncelle.Click
        Baglanti.baglan()
        Etkinlik.EtkinlikGuncelle(dttarih.Value, txtbaslik.Text, rchbilgi.Text, cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnEtkinlikSil_Click(sender As Object, e As EventArgs) Handles btnEtkinlikSil.Click
        Baglanti.baglan()
        Etkinlik.EtkinlikSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btntarihara_Click(sender As Object, e As EventArgs) Handles btntarihara.Click
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridetkinliklistele.DataSource = Etkinlik.EtkinlikListele()
        Baglanti.baglan().Close()
    End Sub
End Class