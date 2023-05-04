Public Class FrmOgretmenVeliislem
    Private Sub FrmOgretmenVeliislem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet9.Veli' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.VeliTableAdapter.Fill(Me.AnaokuludbDataSet9.Veli)
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
        dtgridvelilistele.Columns(0).Visible = False
        dtgridvelilistele.Columns(6).Width = 78
        dtgridvelilistele.Columns(7).Width = 79
        dtgridvelilistele.Columns(8).Width = 79
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliAra(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtveliadara_TextChanged(sender As Object, e As EventArgs) Handles txtveliadara.TextChanged
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliAraAD(txtveliadara.Text)
        Baglanti.baglan().Close()
    End Sub
End Class