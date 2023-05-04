Public Class FrmOgretmenYoklama
    Private Sub temizle()
        cmbadsoyad.Text = ""
        cmbokul.Text = ""
    End Sub

    Shared id As Integer
    Private Sub FrmOgretmenYoklama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK()
        cmbadsoyad.DisplayMember = "ADSOYAD"
        cmbadsoyad.ValueMember = "OgrID"
        Baglanti.baglan().Close()
    End Sub

    Private Sub dtgridyoklama_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridyoklama.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridyoklama.Rows(row).Cells(0).Value.ToString())
        cmbadsoyad.Text = dtgridyoklama.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridyoklama.Rows(row).Cells(2).Value.ToString()
        cmbokul.Text = dtgridyoklama.Rows(row).Cells(3).Value.ToString()
    End Sub

    Private Sub btnyoklamaekle_Click(sender As Object, e As EventArgs) Handles btnyoklamaekle.Click
        Baglanti.baglan()
        Yoklama.YoklamaEkle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbokul.GetItemText(cmbokul.SelectedItem))
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnyoklamaguncelle_Click(sender As Object, e As EventArgs) Handles btnyoklamaguncelle.Click
        Baglanti.baglan()
        Yoklama.YoklamaGuncelle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbokul.GetItemText(cmbokul.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnyoklamasil_Click(sender As Object, e As EventArgs) Handles btnyoklamasil.Click
        Baglanti.baglan()
        Yoklama.YoklamaSil(id, cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem), dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        dtgridyoklama.Columns(0).Visible = False
        dtgridyoklama.Columns(1).Width = 167
        dtgridyoklama.Columns(2).Width = 167
        dtgridyoklama.Columns(3).Width = 167
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridyoklama.DataSource = Yoklama.YoklamaAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub
End Class