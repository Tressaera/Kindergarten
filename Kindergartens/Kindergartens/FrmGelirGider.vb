Imports System.Data.SqlClient

Public Class FrmGelirGider
    Private Sub temizle()
        txtfiyat.Text = ""
        cmbdonem.Text = ""
        cmbdonemara.Text = ""
        cmbgider.Text = ""
        cmbgiderturu.Text = ""
        cmbOdemeTuru.Text = ""
    End Sub

    Shared id As Integer

    Private Sub donemgrafikaktar()
        Baglanti.baglan()
        Dim cmd As SqlCommand = New SqlCommand("SELECT Sum(Tutar) AS 'GELİR' FROM GelirGider WHERE GelirGider='Gelir' AND Donem=@p2 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn)
        cmd.Parameters.AddWithValue("@p2", cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Me.chart1.Series("Gelir").Points.AddXY("Gelir-Gider", (dr("GELİR")).ToString())
        End If
    End Sub

    Private Sub donemgrafikaktar2()
        Baglanti.baglan()
        Dim cmd As SqlCommand = New SqlCommand("SELECT Sum(Tutar) AS 'Gider' FROM GelirGider WHERE GelirGider='Gider' AND Donem=@p1 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn)
        cmd.Parameters.AddWithValue("@p1", cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Me.chart1.Series("Gider").Points.AddXY("Gelir-Gider", (dr("Gider")).ToString())
        End If

        Baglanti.baglan().Close()
    End Sub

    Private Sub TarihGrafikaktar()
        Baglanti.baglan()
        Dim cmd As SqlCommand = New SqlCommand("SELECT Sum(Tutar) AS 'Gelir' FROM GelirGider WHERE GelirGider='Gelir' AND Tarih between @p1 AND @p2 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn)
        cmd.Parameters.AddWithValue("@p1", Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()))
        cmd.Parameters.AddWithValue("@p2", Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()))
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Me.chart1.Series("Gelir").Points.AddXY("Gelir-Gider", (dr("Gelir")).ToString())
        End If

        Baglanti.baglan().Close()
    End Sub

    Private Sub TarihGrafikaktar2()
        Baglanti.baglan()
        Dim cmd As SqlCommand = New SqlCommand("SELECT Sum(Tutar) AS 'Gider' FROM GelirGider WHERE GelirGider='Gider' AND Tarih between @p3 AND @p4 AND Durumu='1' GROUP BY Gelirgider", Baglanti.cnn)
        cmd.Parameters.AddWithValue("@p3", Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()))
        cmd.Parameters.AddWithValue("@p4", Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()))
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            Me.chart1.Series("Gider").Points.AddXY("Gelir-Gider", (dr("Gider")).ToString())
        End If

        Baglanti.baglan().Close()
    End Sub
    Private Sub FrmGelirGider_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderListele()
        Baglanti.baglan().Close()
        dtgridgelirgider.Columns(0).Visible = False
        dtgridgelirgider.Columns(1).Width = 80
        dtgridgelirgider.Columns(3).Width = 80
        dtgridgelirgider.Columns(2).Width = 80
        dtgridgelirgider.Columns(6).Width = 80
        dtgridgelirgider.Columns(4).Width = 114
    End Sub

    Private Sub dtgridgelirgider_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridgelirgider.CellContentClick
        Dim row As Integer = e.RowIndex
        id = Integer.Parse(dtgridgelirgider.Rows(row).Cells(0).Value.ToString())
        cmbgider.Text = dtgridgelirgider.Rows(row).Cells(1).Value.ToString()
        dttarih.Text = dtgridgelirgider.Rows(row).Cells(2).Value.ToString()
        txtfiyat.Text = dtgridgelirgider.Rows(row).Cells(3).Value.ToString()
        cmbgiderturu.Text = dtgridgelirgider.Rows(row).Cells(4).Value.ToString()
        cmbOdemeTuru.Text = dtgridgelirgider.Rows(row).Cells(5).Value.ToString()
        cmbdonem.Text = dtgridgelirgider.Rows(row).Cells(6).Value.ToString()
    End Sub

    Private Sub btngiderekle_Click(sender As Object, e As EventArgs) Handles btngiderekle.Click
        Baglanti.baglan()
        GelirGider.GelirGiderEkle(cmbgider.GetItemText(cmbgider.SelectedItem), dttarih.Value, Integer.Parse(txtfiyat.Text), cmbgiderturu.GetItemText(cmbgiderturu.SelectedItem), cmbOdemeTuru.GetItemText(cmbOdemeTuru.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem))
        Baglanti.baglan().Close()
        MessageBox.Show("Gider Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btngiderguncelle_Click(sender As Object, e As EventArgs) Handles btngiderguncelle.Click
        Baglanti.baglan()
        GelirGider.GelirGiderGuncelle(cmbgider.GetItemText(cmbgider.SelectedItem), dttarih.Value, Integer.Parse(txtfiyat.Text), cmbgiderturu.GetItemText(cmbgiderturu.SelectedItem), cmbOdemeTuru.GetItemText(cmbOdemeTuru.SelectedItem), cmbdonem.GetItemText(cmbdonem.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btngelirgidersil_Click(sender As Object, e As EventArgs) Handles btngelirgidersil.Click
        Baglanti.baglan()
        GelirGider.GelirGiderSil(id, dttarih.Value)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btntarihara_Click(sender As Object, e As EventArgs) Handles btntarihara.Click
        For Each series In chart1.Series
            series.Points.Clear()
        Next

        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderAraTarih(Convert.ToDateTime(dtgiristarih.Value.ToShortDateString()), Convert.ToDateTime(dtcikistarih.Value.ToShortDateString()))
        Baglanti.baglan().Close()
        TarihGrafikaktar()
        TarihGrafikaktar2()
    End Sub

    Private Sub btndonemara_Click(sender As Object, e As EventArgs) Handles btndonemara.Click
        For Each series In chart1.Series
            series.Points.Clear()
        Next

        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderAraDonem(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
        donemgrafikaktar()
        donemgrafikaktar2()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridgelirgider.DataSource = GelirGider.GelirGiderListele()
        Baglanti.baglan().Close()
    End Sub
End Class