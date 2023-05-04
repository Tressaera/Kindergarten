Public Class FrmOgretmenYemekBildirimi
    Private Sub temizle()
        cmbyemekyedimi.Text = ""
        cmbadsoyad.Text = ""
    End Sub

    Shared id As Integer

    Private Sub FrmOgretmenYemekBildirimi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet5.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.OgrenciTableAdapter.Fill(Me.AnaokuludbDataSet5.Ogrenci)
        'TODO: Bu kod satırı 'AnaokuludbDataSet4.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Baglanti.baglan()
        cmbadsoyad.DataSource = Ogrenci.OgrenciAdsoyadCEK()
        cmbadsoyad.DisplayMember = "ADSOYAD"
        cmbadsoyad.ValueMember = "OgrID"
        Baglanti.baglan().Close()
    End Sub
    Private Sub btnyemekbildirimiekle_Click(sender As Object, e As EventArgs) Handles btnyemekbildirimiekle.Click
        Baglanti.baglan()
        YemekBildirimi.YemekBildirimEkle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbyemekyedimi.GetItemText(cmbyemekyedimi.SelectedItem))
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnyemekbildirimguncelle_Click(sender As Object, e As EventArgs) Handles btnyemekbildirimguncelle.Click
        Baglanti.baglan()
        YemekBildirimi.YemekBildirimGuncelle(CInt(cmbadsoyad.SelectedValue), dttarih.Value, cmbyemekyedimi.GetItemText(cmbyemekyedimi.SelectedItem), id)
        Baglanti.baglan()
        temizle()
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyemekbildirimsil_Click(sender As Object, e As EventArgs) Handles btnyemekbildirimsil.Click
        Baglanti.baglan()
        YemekBildirimi.YemekBildirimSil(id, cmbadsoyad.GetItemText(cmbadsoyad.SelectedItem), dttarih.Value)
        Baglanti.baglan().Close()
        temizle()
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        dtgridyemekbildirim.Columns(0).Visible = False
        dtgridyemekbildirim.Columns(1).Width = 181
        dtgridyemekbildirim.Columns(2).Width = 181
        dtgridyemekbildirim.Columns(3).Width = 182
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridyemekbildirim.DataSource = YemekBildirimi.YemekBildirimAra(Convert.ToDateTime(dttarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub dtgridyemekbildirim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridyemekbildirim.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridyemekbildirim.Rows(row).Cells(0).Value.ToString())
        cmbadsoyad.Text = dtgridyemekbildirim.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridyemekbildirim.Rows(row).Cells(2).Value.ToString()
        cmbyemekyedimi.Text = dtgridyemekbildirim.Rows(row).Cells(3).Value.ToString()
    End Sub
End Class