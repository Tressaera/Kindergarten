Public Class FrmOgretmenİlacBildirimi

    Shared id As Integer
    Private Sub temizle()
        cmbadsoyad.Text = ""
        cmbilacictimi.Text = ""
    End Sub
    Private Sub FrmOgretmenİlacBildirimi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK()
        cmbadsoyad.DisplayMember = "ADSOYAD"
        cmbadsoyad.ValueMember = "OgrID"
        Baglanti.baglan().Close()
    End Sub

    Private Sub dtgridİlacBildirimi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridİlacBildirimi.Rows(row).Cells(0).Value.ToString())
        cmbadsoyad.Text = dtgridİlacBildirimi.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridİlacBildirimi.Rows(row).Cells(2).Value.ToString()
        cmbilacictimi.Text = dtgridİlacBildirimi.Rows(row).Cells(3).Value.ToString()
    End Sub

    Private Sub btnilacbildirimiekle_Click(sender As Object, e As EventArgs) Handles btnilacbildirimiekle.Click
        Baglanti.baglan()
        İlacBildirim.İlacBildirimEkle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbilacictimi.GetItemText(cmbilacictimi.SelectedItem))
        Baglanti.baglan().Close()
        temizle()
        Baglanti.baglan()
        dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnilacbildirimguncelle_Click(sender As Object, e As EventArgs) Handles btnilacbildirimguncelle.Click
        Baglanti.baglan()
        İlacBildirim.İlacBildirimiGuncelle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbilacictimi.GetItemText(cmbilacictimi.SelectedItem), id)
        Baglanti.baglan().Close()
        temizle()
        Baglanti.baglan()
        dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnİlacbildirimiSil_Click(sender As Object, e As EventArgs) Handles btnİlacbildirimiSil.Click
        Baglanti.baglan()
        İlacBildirim.İlacBildirimiSil(id, cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem), dttarih.Value)
        Baglanti.baglan().Close()
        temizle()
        Baglanti.baglan()
        dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        dtgridİlacBildirimi.Columns(0).Visible = False
        dtgridİlacBildirimi.Columns(1).Width = 175
        dtgridİlacBildirimi.Columns(2).Width = 175
        dtgridİlacBildirimi.Columns(3).Width = 175
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridİlacBildirimi.DataSource = İlacBildirim.İlacBildirimiAraTarih(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class