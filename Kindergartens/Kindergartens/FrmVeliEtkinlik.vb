Public Class FrmVeliEtkinlik
    Private Sub FrmVeliEtkinlik_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridEtkinlik.DataSource = Etkinlik.EtkinlikListele()
        dtgridEtkinlik.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridEtkinlik.Columns(2).Width = 158
        dtgridEtkinlik.Columns(3).Width = 250
    End Sub

    Private Sub dtgridEtkinlik_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridEtkinlik.CellContentClick
        Dim row As Integer = e.RowIndex
        txtetkinlikbaslik.Text = dtgridEtkinlik.Rows(row).Cells(2).Value.ToString()
        rchetkinlikbilgi.Text = dtgridEtkinlik.Rows(row).Cells(3).Value.ToString()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridEtkinlik.DataSource = Etkinlik.EtkinlikAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class