Public Class FrmVeliDuyuru
    Private Sub FrmVeliDuyuru_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridviewduyuru.DataSource = Duyuru.DuyuruListele()
        dtgridviewduyuru.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridviewduyuru.Columns(1).Width = 122
        dtgridviewduyuru.Columns(2).Width = 140
    End Sub

    Private Sub dtgridviewduyuru_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridviewduyuru.CellContentClick
        Baglanti.baglan()
        dtgridviewduyuru.DataSource = Duyuru.DuyuruListele()
        dtgridviewduyuru.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridviewduyuru.Columns(1).Width = 122
        dtgridviewduyuru.Columns(2).Width = 140
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridviewduyuru.DataSource = Duyuru.DuyuruAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class