Public Class FrmOgretmenPanel

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

    Private Sub FrmOgretmenPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paneltemizle()
        labelyazi(lblyazi, "ANASAYFA")
        label3.Text = "Öğretmen:" & " " & Ogretmen.ADSOYAD
    End Sub
    Private Sub btnogrenci_Click(sender As Object, e As EventArgs) Handles btnogrenci.Click
        paneltemizle()
        labelyazi(lblyazi, "ÖĞRENCİ İŞLEMLERİ")
        Dim frm As FrmOgretmenOgrenciİslem = New FrmOgretmenOgrenciİslem()
        Formdegis(frm)
    End Sub

    Private Sub btnveli_Click(sender As Object, e As EventArgs) Handles btnveli.Click
        paneltemizle()
        labelyazi(lblyazi, "VELİ İŞLEMLERİ")
        Dim frm As FrmOgretmenVeliislem = New FrmOgretmenVeliislem()
        Formdegis(frm)
    End Sub

    Private Sub btnders_Click(sender As Object, e As EventArgs) Handles btnders.Click
        paneltemizle()
        labelyazi(lblyazi, "DERS İŞLEMLERİ")
        Dim frm As FrmVeliDers = New FrmVeliDers()
        Formdegis(frm)
    End Sub

    Private Sub btndersprogrami_Click(sender As Object, e As EventArgs) Handles btndersprogrami.Click
        paneltemizle()
        labelyazi(lblyazi, "DERS PROGRAMI")
        Dim frm As FrmVeliDersProgramı = New FrmVeliDersProgramı()
        Formdegis(frm)
    End Sub

    Private Sub btnduyurular_Click(sender As Object, e As EventArgs) Handles btnduyurular.Click
        paneltemizle()
        labelyazi(lblyazi, "DUYURULAR")
        Dim frm As FrmVeliDuyuru = New FrmVeliDuyuru()
        Formdegis(frm)
    End Sub

    Private Sub btnetkinlikler_Click(sender As Object, e As EventArgs) Handles btnetkinlikler.Click
        paneltemizle()
        labelyazi(lblyazi, "ETKİNLİKLER")
        Dim frm As FrmVeliEtkinlik = New FrmVeliEtkinlik()
        Formdegis(frm)
    End Sub

    Private Sub btnyemeklistesi_Click(sender As Object, e As EventArgs) Handles btnyemeklistesi.Click
        paneltemizle()
        labelyazi(lblyazi, "YEMEK LİSTESİ")
        Dim frm As FrmVeliYemekListesi = New FrmVeliYemekListesi()
        Formdegis(frm)
    End Sub

    Private Sub btnyemekbildirimi_Click(sender As Object, e As EventArgs) Handles btnyemekbildirimi.Click
        paneltemizle()
        labelyazi(lblyazi, "YEMEK BİLDİRİMİ")
        Dim frm As FrmOgretmenYemekBildirimi = New FrmOgretmenYemekBildirimi()
        Formdegis(frm)
    End Sub

    Private Sub btnİlacİslemleri_Click(sender As Object, e As EventArgs) Handles btnİlacİslemleri.Click
        paneltemizle()
        labelyazi(lblyazi, "İLAÇ İŞLEMLERİ")
        Dim frm As FrmOgretmenİlacİslem = New FrmOgretmenİlacİslem()
        Formdegis(frm)
    End Sub

    Private Sub btnİlacBildirimi_Click(sender As Object, e As EventArgs) Handles btnİlacBildirimi.Click
        paneltemizle()
        labelyazi(lblyazi, "İLAÇ BİLDİRİMİ")
        Dim frm As FrmOgretmenİlacBildirimi = New FrmOgretmenİlacBildirimi()
        Formdegis(frm)
    End Sub

    Private Sub btnYoklama_Click(sender As Object, e As EventArgs) Handles btnYoklama.Click
        paneltemizle()
        labelyazi(lblyazi, "YOKLAMA İŞLEMLERİ")
        Dim frm As FrmOgretmenYoklama = New FrmOgretmenYoklama()
        Formdegis(frm)
    End Sub

    Private Sub btnGaleri_Click(sender As Object, e As EventArgs) Handles btnGaleri.Click
        paneltemizle()
        labelyazi(lblyazi, "GALERİ")
        Dim frm As FrmOgretmenGaleri = New FrmOgretmenGaleri()
        Formdegis(frm)
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Dim frm As FrmGiris = New FrmGiris()
        frm.Show()
        Me.Hide()
    End Sub
End Class