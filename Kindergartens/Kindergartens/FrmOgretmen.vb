Public Class FrmOgretmen
    Private Sub Temizle()
        txtOgretmenAd.Text = ""
        txtogretmenkulad.Text = ""
        txtogretmenmaas.Text = ""
        txtogretmensifre.Text = ""
        txtogretmenTc.Text = ""
        mskogretmentel.Text = ""
        rchogretmenadres.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmOgretmen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele()
        Baglanti.baglan().Close()
        dtgridogretmenlistele.Columns(0).Visible = False
        dtgridogretmenlistele.Columns(2).Width = 75
        dtgridogretmenlistele.Columns(3).Width = 78
        dtgridogretmenlistele.Columns(5).Width = 60
        dtgridogretmenlistele.Columns(6).Width = 75
        dtgridogretmenlistele.Columns(7).Width = 75
        dtgridogretmenlistele.Columns(8).Width = 68
    End Sub

    Private Sub dtgridogretmenlistele_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridogretmenlistele.CellContentClick
        Dim row As Integer = Integer.Parse(e.RowIndex.ToString())
        id = Integer.Parse(dtgridogretmenlistele.Rows(row).Cells(0).Value.ToString())
        txtOgretmenAd.Text = dtgridogretmenlistele.Rows(row).Cells(1).Value.ToString()
        txtogretmenTc.Text = dtgridogretmenlistele.Rows(row).Cells(2).Value.ToString()
        dtOgretmen.Text = dtgridogretmenlistele.Rows(row).Cells(3).Value.ToString()
        rchogretmenadres.Text = dtgridogretmenlistele.Rows(row).Cells(4).Value.ToString()
        txtogretmenmaas.Text = dtgridogretmenlistele.Rows(row).Cells(5).Value.ToString()
        mskogretmentel.Text = dtgridogretmenlistele.Rows(row).Cells(6).Value.ToString()
        txtogretmenkulad.Text = dtgridogretmenlistele.Rows(row).Cells(7).Value.ToString()
        txtogretmensifre.Text = dtgridogretmenlistele.Rows(row).Cells(8).Value.ToString()
    End Sub

    Private Sub btnogretmenekle_Click(sender As Object, e As EventArgs) Handles btnogretmenekle.Click
        If txtogretmenkulad.Text = "" OrElse txtogretmenmaas.Text = "" OrElse txtOgretmenAd.Text = "" OrElse txtogretmensifre.Text = "" OrElse txtogretmenTc.Text = "" Then
            MessageBox.Show("Öğretmen Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Baglanti.baglan()
            Ogretmen.OgretmenEkle(txtOgretmenAd.Text, txtogretmenTc.Text, dtOgretmen.Value, rchogretmenadres.Text, Integer.Parse(txtogretmenmaas.Text), mskogretmentel.Text, txtogretmenkulad.Text, txtogretmensifre.Text)
            Baglanti.baglan().Close()
            Baglanti.baglan()
            dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele()
            Baglanti.baglan().Close()
        End If

        Temizle()
    End Sub

    Private Sub btnogretmenguncelle_Click(sender As Object, e As EventArgs) Handles btnogretmenguncelle.Click
        Baglanti.baglan()
        Ogretmen.OgretmenGuncelle(txtOgretmenAd.Text, txtogretmenTc.Text, dtOgretmen.Value, rchogretmenadres.Text, Integer.Parse(txtogretmenmaas.Text), mskogretmentel.Text, txtogretmenkulad.Text, txtogretmensifre.Text, id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele()
        Baglanti.baglan().Close()
        Temizle()
    End Sub

    Private Sub btnogretmensil_Click(sender As Object, e As EventArgs) Handles btnogretmensil.Click
        Baglanti.baglan()
        Ogretmen.OgretmenSil(id, txtOgretmenAd.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele()
        Baglanti.baglan().Close()
        Temizle()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridogretmenlistele.DataSource = Ogretmen.OgretmenListele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtogretmenara_TextChanged(sender As Object, e As EventArgs) Handles txtogretmenara.TextChanged
        Baglanti.baglan()
        dtgridogretmenlistele.DataSource = Ogretmen.OgretmenAra(txtogretmenara.Text)
        Baglanti.baglan().Close()
    End Sub
End Class