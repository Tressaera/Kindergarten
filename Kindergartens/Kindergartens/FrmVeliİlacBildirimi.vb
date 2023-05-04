Public Class FrmVeliİlacBildirimi
    Private Sub FrmVeliİlacBildirimi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridilacbildirim.DataSource = İlacBildirim.İlacBildirimiAraVeli(Veli.OGRID)
        dtgridilacbildirim.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridilacbildirim.Columns(3).Width = 162
        dtgridilacbildirim.Columns(2).Width = 163
        dtgridilacbildirim.Columns(1).Width = 163
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridilacbildirim.DataSource = İlacBildirim.İlacBildirimiAraVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class