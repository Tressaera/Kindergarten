Public Class FrmSinifBilgileri
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub temizle()
        txtkontenjan.Text = ""
        txtsinifadi.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmSinifBilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet6.Ogretmen' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.OgretmenTableAdapter.Fill(Me.AnaokuludbDataSet6.Ogretmen)
        Baglanti.baglan()
        cmbogretmen.DataSource = Ogretmen.OgretmenAdSoyadGetir()
        cmbogretmen.ValueMember = "OgretmenID"
        cmbogretmen.DisplayMember = "ADSOYAD"
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifListele()
        Baglanti.baglan().Close()
        dtgsinif.Columns(0).Visible = False
        dtgsinif.Columns(1).Width = 120
        dtgsinif.Columns(2).Width = 120
        dtgsinif.Columns(3).Width = 167
    End Sub
    Private Sub dtgsinif_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgsinif.CellContentClick
        Dim row As Integer = Integer.Parse(e.RowIndex.ToString())
        id = Integer.Parse(dtgsinif.Rows(row).Cells(0).Value.ToString())
        txtsinifadi.Text = dtgsinif.Rows(row).Cells(1).Value.ToString()
        txtkontenjan.Text = dtgsinif.Rows(row).Cells(2).Value.ToString()
        cmbdonem.Text = dtgsinif.Rows(row).Cells(3).Value.ToString()
        cmbogretmen.Text = dtgsinif.Rows(row).Cells(4).Value.ToString()
    End Sub

    Private Sub btnsinifekle_Click(sender As Object, e As EventArgs) Handles btnsinifekle.Click
        Sinif.Sinifekle(txtsinifadi.Text, Integer.Parse(txtkontenjan.Text), cmbdonem.GetItemText(cmbdonem.SelectedItem), CInt(cmbogretmen.SelectedValue))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnsinifguncelle_Click(sender As Object, e As EventArgs) Handles btnsinifguncelle.Click
        Baglanti.baglan()
        Sinif.Guncelle(txtsinifadi.Text, Integer.Parse(txtkontenjan.Text), cmbdonem.GetItemText(cmbdonem.SelectedItem), CInt(cmbogretmen.SelectedValue), id)
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnsinifsil_Click(sender As Object, e As EventArgs) Handles btnsinifsil.Click
        Baglanti.baglan()
        Sinif.SinifSil(id, txtsinifadi.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifListele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtsinifadiara_TextChanged(sender As Object, e As EventArgs) Handles txtsinifadiara.TextChanged
        Baglanti.baglan()
        dtgsinif.DataSource = Sinif.SinifAra(txtsinifadiara.Text)
        Baglanti.baglan().Close()
    End Sub


End Class