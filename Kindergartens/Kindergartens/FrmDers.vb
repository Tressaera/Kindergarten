Public Class FrmDers
    Private Sub temizle()
        txtDersad.Text = ""
        rchaciklama.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmDers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        Baglanti.baglan().Close()
        dtgdersgoruntule.Columns(0).Visible = False
        dtgdersgoruntule.Columns(1).Width = 150
        dtgdersgoruntule.Columns(2).Width = 313
    End Sub
    Private Sub dtgdersgoruntule_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgdersgoruntule.CellContentClick
        Dim rowindex As Integer = e.RowIndex
        id = Integer.Parse(dtgdersgoruntule.Rows(rowindex).Cells(0).Value.ToString())
        txtDersad.Text = dtgdersgoruntule.Rows(rowindex).Cells(1).Value.ToString()
        rchaciklama.Text = dtgdersgoruntule.Rows(rowindex).Cells(2).Value.ToString()
    End Sub

    Private Sub btndersekle_Click(sender As Object, e As EventArgs) Handles btndersekle.Click
        Baglanti.baglan()
        Ders.DersEkle(txtDersad.Text, rchaciklama.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btndersguncelle_Click(sender As Object, e As EventArgs) Handles btndersguncelle.Click
        Baglanti.baglan()
        Ders.DersGuncelle(txtDersad.Text, rchaciklama.Text, id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnderssil_Click(sender As Object, e As EventArgs) Handles btnderssil.Click
        Baglanti.baglan()
        Ders.DersSil(id, txtDersad.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.Listele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtdersara_TextChanged(sender As Object, e As EventArgs) Handles txtdersara.TextChanged
        Baglanti.baglan()
        dtgdersgoruntule.DataSource = Ders.DersAra(txtdersara.Text)
        Baglanti.baglan().Close()
    End Sub
End Class