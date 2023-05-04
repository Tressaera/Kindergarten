Public Class FrmAidat
    Private Sub temizle()
        cmbdonem.Text = ""
        cmbdonemara.Text = ""
        cmbodemeturu.Text = ""
        txttutar.Text = ""
        txtveliara.Text = ""
    End Sub

    Shared id As Integer
    Private Sub FrmAidat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet14.Veli' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.VeliTableAdapter.Fill(Me.AnaokuludbDataSet14.Veli)
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatListele()
        Baglanti.baglan().Close()
        Baglanti.baglan()
        cmbveli.DataSource = Veli.ComboboxVeliADSOYADcek()
        cmbveli.DisplayMember = "ADSOYAD"
        cmbveli.ValueMember = "VeliID"
        Baglanti.baglan().Close()
        cmbgelir.Text = "Gelir"
        cmbgelirturu.Text = "Veli Ödemesi"
        dtgridaidat.Columns(0).Visible = False
        dtgridaidat.Columns(1).Width = 134
        dtgridaidat.Columns(2).Width = 134
        dtgridaidat.Columns(3).Width = 134
        dtgridaidat.Columns(4).Width = 134
    End Sub

    Private Sub dtgridaidat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridaidat.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridaidat.Rows(row).Cells(0).Value.ToString())
        cmbveli.Text = dtgridaidat.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridaidat.Rows(row).Cells(2).Value.ToString()
        txttutar.Text = dtgridaidat.Rows(row).Cells(3).Value.ToString()
        cmbodemeturu.Text = dtgridaidat.Rows(row).Cells(4).Value.ToString()
        cmbdonem.Text = dtgridaidat.Rows(row).Cells(5).Value.ToString()
    End Sub

    Private Sub btnaidatekle_Click(sender As Object, e As EventArgs) Handles btnaidatekle.Click
        Baglanti.baglan()
        Aidat.AidatEkle(CInt(cmbveli.SelectedValue), dttarih.Value, Integer.Parse(txttutar.Text), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        GelirGider.GelirGiderEkle(cmbgelir.GetItemText(cmbgelir.SelectedItem), dttarih.Value, Integer.Parse(txttutar.Text), cmbgelirturu.GetItemText(cmbgelirturu.SelectedItem), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem))
        MessageBox.Show("Gelir Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnaidatguncelle_Click(sender As Object, e As EventArgs) Handles btnaidatguncelle.Click
        Baglanti.baglan()
        Aidat.AidatGuncelle(CInt(cmbveli.SelectedValue), dttarih.Value, Integer.Parse(txttutar.Text), cmbodemeturu.GetItemText(cmbodemeturu.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnaidatsil_Click(sender As Object, e As EventArgs) Handles btnaidatsil.Click
        Baglanti.baglan()
        Aidat.AidatSil(id, cmbveli.GetItemText(cmbveli.SelectedItem), dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btntarihara_Click(sender As Object, e As EventArgs) Handles btntarihara.Click
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtveliara_TextChanged(sender As Object, e As EventArgs) Handles txtveliara.TextChanged
        Baglanti.baglan()
        dtgridaidat.DataSource = Aidat.AidatAraVeli(txtveliara.Text)
        Baglanti.baglan().Close()
    End Sub
End Class