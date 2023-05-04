Public Class FrmVeliÖdemeler
    Private Sub FrmVeliÖdemeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridodemeler.DataSource = Aidat.AidatGoruntuleVeli(Veli.ID)
        dtgridodemeler.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridodemeler.Columns(1).Width = 148
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridodemeler.DataSource = Aidat.AidatGoruntuleVeli(Veli.ID, Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class