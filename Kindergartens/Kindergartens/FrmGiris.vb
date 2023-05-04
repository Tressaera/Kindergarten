Public Class FrmGiris
    Private Sub temizle()
        txtkuladogretmen.Text = ""
        txtkuladveli.Text = ""
        txtkuladyönetici.Text = ""
        txtsifreogretmen.Text = ""
        txtsifreveli.Text = ""
        txtsifreyönetici.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub btnYönetici_Click(sender As Object, e As EventArgs) Handles btnYönetici.Click
        Baglanti.baglan()
        Dim kontrol As Boolean = Yonetici.GirisYap(txtkuladyönetici.Text, txtsifreyönetici.Text)

        If kontrol Then
            Dim frm As FrmYönetici = New FrmYönetici()
            frm.Show()
            Me.Hide()
        ElseIf txtkuladyönetici.Text = "" OrElse txtsifreyönetici.Text = "" Then
            MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If

        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnögretmen_Click(sender As Object, e As EventArgs) Handles btnögretmen.Click
        Baglanti.baglan()
        Dim kontrol As Boolean = Ogretmen.GirisYap(txtkuladogretmen.Text, txtsifreogretmen.Text)

        If kontrol Then
            Dim frm As FrmOgretmenPanel = New FrmOgretmenPanel()
            frm.Show()
            Me.Hide()
        ElseIf txtkuladogretmen.Text = "" OrElse txtsifreogretmen.Text = "" Then
            MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If

        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub btnveli_Click(sender As Object, e As EventArgs) Handles btnveli.Click
        Baglanti.baglan()
        Dim kontrol As Boolean = Veli.GirisYap(txtkuladveli.Text, txtsifreveli.Text)

        If kontrol Then
            Dim frm As FrmVeliPanel = New FrmVeliPanel()
            frm.Show()
            Me.Hide()
        ElseIf txtkuladveli.Text = "" OrElse txtsifreveli.Text = "" Then
            MessageBox.Show("Lütfen Kullanıcı Adı veya Şifreyi Boş Bırakmayınız...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If

        Baglanti.baglan().Close()
        temizle()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblsaat.Text = DateTime.Now.ToString()
    End Sub
End Class
