Public Class FrmOgretmenİlacİslem
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmOgretmenİlacİslem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbsinif.DataSource = Sinif.comboboxsiniflarigetir()
        cmbsinif.DisplayMember = "Adi"
        cmbsinif.ValueMember = "SinifID"
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridviewİlac.DataSource = İlac.İlacAraSinif(cmbsinif.GetItemText(cmbsinif.SelectedItem))
        Baglanti.baglan().Close()
        dtgridviewİlac.Columns(0).Visible = False
        dtgridviewİlac.Columns(1).Width = 150
        dtgridviewİlac.Columns(2).Width = 125
        dtgridviewİlac.Columns(3).Width = 228
    End Sub
End Class