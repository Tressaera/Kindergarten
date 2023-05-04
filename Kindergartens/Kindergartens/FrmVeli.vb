Public Class FrmVeli
    Private Sub temizle()
        txtkulad.Text = ""
        txtsifre.Text = ""
        txtveliadsoyad.Text = ""
        txtyillikfiyat.Text = ""
        msktel.Text = ""
        rchadres.Text = ""
    End Sub
    Shared id As Integer
    Private Sub FrmVeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'AnaokuludbDataSet8.Ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.OgrenciTableAdapter.Fill(Me.AnaokuludbDataSet8.Ogrenci)
        Baglanti.baglan()
        cmbogrenci.DataSource = Ogrenci.OgrenciAdsoyadCEK()
        cmbogrenci.DisplayMember = "ADSOYAD"
        cmbogrenci.ValueMember = "OgrID"
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
        dtgridvelilistele.Columns(0).Visible = False
        dtgridvelilistele.Columns(5).Width = 75
        dtgridvelilistele.Columns(6).Width = 50
        dtgridvelilistele.Columns(7).Width = 65
    End Sub

    Private Sub dtgridvelilistele_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgridvelilistele.CellContentClick
        Dim row As Integer = Integer.Parse(e.RowIndex.ToString())
        id = Integer.Parse(dtgridvelilistele.Rows(row).Cells(0).Value.ToString())
        txtveliadsoyad.Text = dtgridvelilistele.Rows(row).Cells(1).Value.ToString()
        cmbogrenci.Text = dtgridvelilistele.Rows(row).Cells(2).Value.ToString()
        msktel.Text = dtgridvelilistele.Rows(row).Cells(3).Value.ToString()
        rchadres.Text = dtgridvelilistele.Rows(row).Cells(4).Value.ToString()
        txtkulad.Text = dtgridvelilistele.Rows(row).Cells(5).Value.ToString()
        txtsifre.Text = dtgridvelilistele.Rows(row).Cells(6).Value.ToString()
        txtyillikfiyat.Text = dtgridvelilistele.Rows(row).Cells(7).Value.ToString()
        cmbdonemi.Text = dtgridvelilistele.Rows(row).Cells(8).Value.ToString()
    End Sub

    Private Sub btnveliekle_Click(sender As Object, e As EventArgs) Handles btnveliekle.Click
        If txtveliadsoyad.Text = "" OrElse txtyillikfiyat.Text = "" OrElse txtkulad.Text = "" OrElse txtsifre.Text = "" Then
            MessageBox.Show("Veli Bilgilerini Boş Bırakmayınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Baglanti.baglan()
            Veli.Veliekle(txtveliadsoyad.Text, CInt(cmbogrenci.SelectedValue), msktel.Text, rchadres.Text, txtkulad.Text, txtsifre.Text, Integer.Parse(txtyillikfiyat.Text), cmbdonemi.GetItemText(cmbdonemi.SelectedItem))
            Baglanti.baglan().Close()
            Baglanti.baglan()
            dtgridvelilistele.DataSource = Veli.VeliListele()
            Baglanti.baglan().Close()
        End If

        temizle()
    End Sub

    Private Sub btnguncelle_Click(sender As Object, e As EventArgs) Handles btnguncelle.Click
        Baglanti.baglan()
        Veli.VeliGuncelle(txtveliadsoyad.Text, CInt(cmbogrenci.SelectedValue), msktel.Text, rchadres.Text, txtkulad.Text, txtsifre.Text, Integer.Parse(txtyillikfiyat.Text), cmbdonemi.GetItemText(cmbdonemi.SelectedItem), id)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnveliSil_Click(sender As Object, e As EventArgs) Handles btnveliSil.Click
        Baglanti.baglan()
        Veli.VeliSil(id, txtveliadsoyad.Text)
        Baglanti.baglan().Close()
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnara_Click(sender As Object, e As EventArgs) Handles btnara.Click
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliAra(cmbdonemara.GetItemText(cmbdonemara.SelectedItem))
        Baglanti.baglan().Close()
    End Sub

    Private Sub btnyenile_Click(sender As Object, e As EventArgs) Handles btnyenile.Click
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliListele()
        Baglanti.baglan().Close()
    End Sub

    Private Sub txtveliara_TextChanged(sender As Object, e As EventArgs) Handles txtveliara.TextChanged
        Baglanti.baglan()
        dtgridvelilistele.DataSource = Veli.VeliAraAD(txtveliara.Text)
        Baglanti.baglan().Close()
    End Sub
End Class