Imports System.Data.SqlClient

Public Class FrmDersProgrami
    Private Sub temizle()
        cmbders1.Text = ""
        cmbders2.Text = ""
        cmbders3.Text = ""
        cmbders4.Text = ""
        cmbders5.Text = ""
        cmbders6.Text = ""
        cmbdonem.Text = ""
        cmbdonemara.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmDersProgrami_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele()
        Baglanti.baglan().Close()
        Dim sqlcumle As String = "Select DersAdi from Ders where Durumu='1' "
        Dim cmd As SqlCommand = New SqlCommand(sqlcumle, Baglanti.baglan())
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        While dr.Read()
            cmbders1.Items.Add(dr("DersAdi"))
            cmbders2.Items.Add(dr("DersAdi"))
            cmbders3.Items.Add(dr("DersAdi"))
            cmbders4.Items.Add(dr("DersAdi"))
            cmbders5.Items.Add(dr("DersAdi"))
            cmbders6.Items.Add(dr("DersAdi"))
        End While

        dtgridDersprogrami.Columns(0).Visible = False
    End Sub

    Private Sub dtgridDersprogrami_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridDersprogrami.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridDersprogrami.Rows(row).Cells(0).Value.ToString())
        cmbders1.Text = dtgridDersprogrami.Rows(row).Cells(1).Value.ToString()
        cmbders2.Text = dtgridDersprogrami.Rows(row).Cells(2).Value.ToString()
        cmbders3.Text = dtgridDersprogrami.Rows(row).Cells(3).Value.ToString()
        cmbders4.Text = dtgridDersprogrami.Rows(row).Cells(4).Value.ToString()
        cmbders5.Text = dtgridDersprogrami.Rows(row).Cells(5).Value.ToString()
        cmbders6.Text = dtgridDersprogrami.Rows(row).Cells(6).Value.ToString()
        cmbdonem.Text = dtgridDersprogrami.Rows(row).Cells(7).Value.ToString()
        dttarih.Text = dtgridDersprogrami.Rows(row).Cells(8).Value.ToString()
    End Sub

    Private Sub btnDersprogramiEkle_Click(sender As Object, e As EventArgs) Handles btnDersprogramiEkle.Click
        Baglanti.baglan()
        DersProgrami.DersprogramiEkle(cmbders1.GetItemText(cmbders1.SelectedItem), cmbders2.GetItemText(cmbders2.SelectedItem), cmbders3.GetItemText(cmbders3.SelectedItem), cmbders4.GetItemText(cmbders4.SelectedItem), cmbders5.GetItemText(cmbders5.SelectedItem), cmbders6.GetItemText(cmbders6.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnDersProgramiGuncelle_Click(sender As Object, e As EventArgs) Handles btnDersProgramiGuncelle.Click
        Baglanti.baglan()
        DersProgrami.DersprogramiGuncelle(cmbders1.GetItemText(cmbders1.SelectedItem), cmbders2.GetItemText(cmbders2.SelectedItem), cmbders3.GetItemText(cmbders3.SelectedItem), cmbders4.GetItemText(cmbders4.SelectedItem), cmbders5.GetItemText(cmbders5.SelectedItem), cmbders6.GetItemText(cmbders6.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), dttarih.Value, id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btndersprogramiSil_Click(sender As Object, e As EventArgs) Handles btndersprogramiSil.Click
        Baglanti.baglan()
        DersProgrami.DersProgramiSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btntarihara_Click(sender As Object, e As EventArgs) Handles btntarihara.Click
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersprogramiAraTarih(Convert.ToDateTime(dtTarihara.Value.ToShortDateString()))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridDersprogrami.DataSource = DersProgrami.DersProgramiListele()
        Baglanti.baglan().Close()
    End Sub
End Class