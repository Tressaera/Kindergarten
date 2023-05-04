Public Class FrmVeliDersProgramı
    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgriddersprogrami.DataSource = DersProgrami.DersprogramiAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        dtgriddersprogrami.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgriddersprogrami.Columns(2).Width = 100
        dtgriddersprogrami.Columns(3).Width = 100
        dtgriddersprogrami.Columns(5).Width = 113
        dtgriddersprogrami.Columns(6).Width = 113
    End Sub
End Class