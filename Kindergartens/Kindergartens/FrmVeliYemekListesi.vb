Public Class FrmVeliYemekListesi
    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridyemeklistesi.DataSource = YemekListesi.YemekListesiAraTarih(Convert.ToDateTime(dttarih.Value.ToShortDateString()))
        dtgridyemeklistesi.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgridyemeklistesi.Columns(2).Width = 142
        dtgridyemeklistesi.Columns(3).Width = 142
        dtgridyemeklistesi.Columns(4).Width = 142
    End Sub

    Private Sub dtgridyemeklistesi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridyemeklistesi.CellContentClick
        Dim row As Integer = e.RowIndex
        rchsabah.Text = dtgridyemeklistesi.Rows(row).Cells(2).Value.ToString()
        rchogle.Text = dtgridyemeklistesi.Rows(row).Cells(3).Value.ToString()
        rchikindi.Text = dtgridyemeklistesi.Rows(row).Cells(4).Value.ToString()
    End Sub
End Class