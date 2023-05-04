Public Class FrmVeliYemekBildirim
    Private Sub FrmVeliYemekBildirim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimiVeli(Veli.OGRID)
        dtgridyemekbildirim.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridyemekbildirim.Columns(3).Width = 348
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimiVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class