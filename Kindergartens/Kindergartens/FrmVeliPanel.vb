Public Class FrmVeliPanel
    Private Sub labelyazi(ByVal lbl As Label, ByVal değer As String)
        lbl.Text = değer
    End Sub

    Private Sub Formdegis(ByVal frm As Form)
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        pnlcontainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub paneltemizle()
        pnlcontainer.Controls.Clear()
    End Sub
    Private Sub FrmVeliPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelyazi(lblyazi, "ANASAYFA")
        label3.Text = "Veli:" & " " & Veli.ADSOYAD.ToString()
    End Sub

    Private Sub btnDersler_Click(sender As Object, e As EventArgs) Handles btnDersler.Click
        paneltemizle()
        labelyazi(lblyazi, "DERSLER")
        Dim frm As FrmVeliDers = New FrmVeliDers()
        Formdegis(frm)
    End Sub

    Private Sub btnDersprogrami_Click(sender As Object, e As EventArgs) Handles btnDersprogrami.Click
        paneltemizle()
        labelyazi(lblyazi, "DERS PROGRAMI")
        Dim frm As FrmVeliDersProgramı = New FrmVeliDersProgramı()
        Formdegis(frm)
    End Sub

    Private Sub btnDuyurular_Click(sender As Object, e As EventArgs) Handles btnDuyurular.Click
        paneltemizle()
        labelyazi(lblyazi, "DUYURULAR")
        Dim frm As FrmVeliDuyuru = New FrmVeliDuyuru()
        Formdegis(frm)
    End Sub

    Private Sub btnEtkinlikler_Click(sender As Object, e As EventArgs) Handles btnEtkinlikler.Click
        paneltemizle()
        labelyazi(lblyazi, "ETKİNLİKLER")
        Dim frm As FrmVeliEtkinlik = New FrmVeliEtkinlik()
        Formdegis(frm)
    End Sub

    Private Sub btnYemekListesi_Click(sender As Object, e As EventArgs) Handles btnYemekListesi.Click
        paneltemizle()
        labelyazi(lblyazi, "YEMEK LİSTESİ")
        Dim frm As FrmVeliYemekListesi = New FrmVeliYemekListesi()
        Formdegis(frm)
    End Sub

    Private Sub btnYemekBildirimi_Click(sender As Object, e As EventArgs) Handles btnYemekBildirimi.Click
        paneltemizle()
        labelyazi(lblyazi, "YEMEK BİLDİRİMİ")
        Dim frm As FrmVeliYemekBildirim = New FrmVeliYemekBildirim()
        Formdegis(frm)
    End Sub

    Private Sub btnGaleri_Click(sender As Object, e As EventArgs) Handles btnGaleri.Click
        paneltemizle()
        labelyazi(lblyazi, "GALERİ")
        Dim frm As FrmVeliGaleri = New FrmVeliGaleri()
        Formdegis(frm)
    End Sub

    Private Sub btnÖdemeler_Click(sender As Object, e As EventArgs) Handles btnÖdemeler.Click
        paneltemizle()
        labelyazi(lblyazi, "ÖDEMELER")
        Dim frm As FrmVeliÖdemeler = New FrmVeliÖdemeler()
        Formdegis(frm)
    End Sub

    Private Sub btnYoklama_Click(sender As Object, e As EventArgs) Handles btnYoklama.Click
        paneltemizle()
        labelyazi(lblyazi, "YOKLAMA LİSTESİ")
        Dim frm As FrmVeliYoklama = New FrmVeliYoklama()
        Formdegis(frm)
    End Sub

    Private Sub btnİlacislemleri_Click(sender As Object, e As EventArgs) Handles btnİlacislemleri.Click
        paneltemizle()
        labelyazi(lblyazi, "İLAÇ İŞLEMLERİ")
        Dim frm As FrmVeliİlac = New FrmVeliİlac()
        Formdegis(frm)
    End Sub

    Private Sub btnİlacBildirimi_Click(sender As Object, e As EventArgs) Handles btnİlacBildirimi.Click
        paneltemizle()
        labelyazi(lblyazi, "İLAÇ BİLDİRİMİ")
        Dim frm As FrmVeliİlacBildirimi = New FrmVeliİlacBildirimi()
        Formdegis(frm)
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Dim frm As FrmGiris = New FrmGiris()
        frm.Show()
        Me.Hide()
    End Sub
End Class