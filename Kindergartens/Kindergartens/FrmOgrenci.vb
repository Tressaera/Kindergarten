Public Class FrmOgrenci
    Private Sub temizle()
        txtOgrAd.Text = ""
        txtograra.Text = ""
        txtOgrTC.Text = ""
        cmbcins.Text = ""
        cmbdonem.Text = ""
    End Sub
    Shared id As Integer = 0
    Private Sub FrmOgrenci_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        cmbsinif.DataSource = Sinif.comboboxsiniflarigetir()
        cmbsinif.DisplayMember = "Adi"
        cmbsinif.ValueMember = "SinifID"
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
        dtgridogrlistele.Columns(0).Visible = False
        dtgridogrlistele.Columns(2).Width = 92
        dtgridogrlistele.Columns(3).Width = 75
        dtgridogrlistele.Columns(4).Width = 75
        dtgridogrlistele.Columns(5).Width = 75
        dtgridogrlistele.Columns(6).Width = 75
    End Sub

    Private Sub dtgridogrlistele_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridogrlistele.CellContentClick
        Dim rowindex As Integer = Integer.Parse(e.RowIndex.ToString())
        id = Integer.Parse(dtgridogrlistele.Rows(rowindex).Cells(0).Value.ToString())
        txtOgrAd.Text = dtgridogrlistele.Rows(rowindex).Cells(1).Value.ToString()
        txtOgrTC.Text = dtgridogrlistele.Rows(rowindex).Cells(2).Value.ToString()
        dtOgr.Text = dtgridogrlistele.Rows(rowindex).Cells(3).Value.ToString()
        cmbcins.Text = dtgridogrlistele.Rows(rowindex).Cells(4).Value.ToString()
        cmbsinif.Text = dtgridogrlistele.Rows(rowindex).Cells(5).Value.ToString()
        dtkayit.Text = dtgridogrlistele.Rows(rowindex).Cells(6).Value.ToString()
        cmbdonem.Text = dtgridogrlistele.Rows(rowindex).Cells(7).Value.ToString()
    End Sub

    Private Sub btnogrekle_Click(sender As Object, e As EventArgs) Handles btnogrekle.Click
        If txtOgrAd.Text = "" OrElse txtOgrTC.Text = "" OrElse cmbdonem.GetItemText(cmbdonem.SelectedItem) = "" OrElse cmbcins.GetItemText(cmbcins.SelectedItem) = "" Then
            MessageBox.Show("Öğrenci Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Baglanti.baglan()
            Ogrenci.OgrenciEkle(txtOgrAd.Text, txtOgrTC.Text, dtOgr.Value, cmbcins.SelectedItem.ToString(), Integer.Parse(cmbsinif.SelectedValue.ToString()), dtkayit.Value, cmbdonem.SelectedItem.ToString())
            Baglanti.baglan().Close()
        End If

        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnogrguncelle_Click(sender As Object, e As EventArgs) Handles btnogrguncelle.Click
        Baglanti.baglan()
        Ogrenci.OgrenciGuncelle(txtOgrAd.Text, txtOgrTC.Text, dtOgr.Value, cmbcins.GetItemText(cmbcins.SelectedItem), CInt(cmbsinif.SelectedValue), dtkayit.Value, cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnogrencisil_Click(sender As Object, e As EventArgs) Handles btnogrencisil.Click
        Baglanti.baglan()
        Ogrenci.OgrenciSil(id, txtOgrAd.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Aramas(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Listele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtograra_TextChanged(sender As Object, e As EventArgs) Handles txtograra.TextChanged
        Baglanti.baglan()
        dtgridogrlistele.DataSource = Ogrenci.Textboxara(txtograra.Text)
        Baglanti.baglan().Close()
    End Sub
End Class