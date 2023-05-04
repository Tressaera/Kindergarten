Public Class FrmVeliDers
    Private Sub FrmVeliDers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        dtgdersgoruntule.Columns(0).Visible = False
        Baglanti.baglan().Close()
        dtgdersgoruntule.Columns(1).Width = 150
        dtgdersgoruntule.Columns(2).Width = 289
    End Sub

    Private Sub dtgdersgoruntule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgdersgoruntule.CellContentClick
        Dim row As Integer = e.RowIndex
        rchaciklama.Text = dtgdersgoruntule.Rows(row).Cells(2).Value.ToString()
    End Sub
End Class