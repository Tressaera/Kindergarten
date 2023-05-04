Public Class FrmVeliYoklama
    Private Sub FrmVeliYoklama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridYoklama.DataSource = Yoklama.YoklamaAraVeli(Veli.OGRID)
        dtgridYoklama.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridYoklama.Columns(1).Width = 185
        dtgridYoklama.Columns(2).Width = 150
        dtgridYoklama.Columns(3).Width = 150
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridYoklama.DataSource = Yoklama.YoklamaAraVeli(Veli.OGRID, Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class