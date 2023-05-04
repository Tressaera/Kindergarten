Public Class FrmYönetici
    Public Sub Formdegis(ByVal frm As Form)
        frm.MdiParent = Me
        frm.FormBorderStyle = FormBorderStyle.None
        pnlcontainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub yaziyaz(ByVal yazi As String)
        lblyazi.Text = yazi.ToString()
    End Sub

    Private Sub paneltemizle()
        pnlcontainer.Controls.Clear()
    End Sub
    Private Sub FrmYönetici_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbladsoyad.Text = "Yönetici:" & " " & Yonetici.ADSOYAD
        yaziyaz("ANASAYFA")
    End Sub
    Private Sub btnogrislem_Click(sender As Object, e As EventArgs) Handles btnogrislem.Click
        paneltemizle()
        yaziyaz("ÖĞRENCİ İŞLEMLERİ")
        Dim frm As FrmOgrenci = New FrmOgrenci()
        Formdegis(frm)
    End Sub

    Private Sub btnveliislem_Click(sender As Object, e As EventArgs) Handles btnveliislem.Click
        paneltemizle()
        yaziyaz("VELİ İŞLEMLERİ")
        Dim frm As FrmVeli = New FrmVeli()
        Formdegis(frm)
    End Sub

    Private Sub btnogretmenislem_Click(sender As Object, e As EventArgs) Handles btnogretmenislem.Click
        paneltemizle()
        yaziyaz("ÖĞRETMEN İŞLEMLERİ")
        Dim frm As FrmOgretmen = New FrmOgretmen()
        Formdegis(frm)
    End Sub

    Private Sub btnsinifbilgiislem_Click(sender As Object, e As EventArgs) Handles btnsinifbilgiislem.Click
        paneltemizle()
        yaziyaz("SINIF BİLGİLERİ")
        Dim frm As FrmSinifBilgileri = New FrmSinifBilgileri()
        Formdegis(frm)
    End Sub

    Private Sub btndersislem_Click(sender As Object, e As EventArgs) Handles btndersislem.Click
        paneltemizle()
        yaziyaz("DERS İŞLEMLERİ")
        Dim frm As FrmDers = New FrmDers()
        Formdegis(frm)
    End Sub

    Private Sub btndersprogramislem_Click(sender As Object, e As EventArgs) Handles btndersprogramislem.Click
        paneltemizle()
        yaziyaz("DERS PROGRAMI")
        Dim frm As FrmDersProgrami = New FrmDersProgrami()
        Formdegis(frm)
    End Sub

    Private Sub btnduyuruislem_Click(sender As Object, e As EventArgs) Handles btnduyuruislem.Click
        paneltemizle()
        yaziyaz("DUYURU İŞLEMLERİ")
        Dim frm As FrmDuyuru = New FrmDuyuru()
        Formdegis(frm)
    End Sub

    Private Sub btnetkinlikislem_Click(sender As Object, e As EventArgs) Handles btnetkinlikislem.Click
        paneltemizle()
        yaziyaz("ETKİNLİK İŞLEMLERİ")
        Dim frm As FrmEtkinlik = New FrmEtkinlik()
        Formdegis(frm)
    End Sub

    Private Sub btnyemeklisteişlem_Click(sender As Object, e As EventArgs) Handles btnyemeklisteişlem.Click
        paneltemizle()
        yaziyaz("YEMEK LİSTESİ")
        Dim frm As FrmYemekListesi = New FrmYemekListesi()
        Formdegis(frm)
    End Sub

    Private Sub btnilacislem_Click(sender As Object, e As EventArgs) Handles btnilacislem.Click
        paneltemizle()
        yaziyaz("İLAÇ LİSTESİ")
        Dim frm As Frmilac = New Frmilac()
        Formdegis(frm)
    End Sub

    Private Sub btnYoklamalisteislem_Click(sender As Object, e As EventArgs) Handles btnYoklamalisteislem.Click
        paneltemizle()
        yaziyaz("YOKLAMA LİSTESİ")
        Dim frm As FrmYoklamaListesi = New FrmYoklamaListesi()
        Formdegis(frm)
    End Sub

    Private Sub btngelirgiderislem_Click(sender As Object, e As EventArgs) Handles btngelirgiderislem.Click
        paneltemizle()
        yaziyaz("GELİR-GİDER İŞLEMLERİ")
        Dim frm As FrmGelirGider = New FrmGelirGider()
        Formdegis(frm)
    End Sub

    Private Sub btnaidat_Click(sender As Object, e As EventArgs) Handles btnaidat.Click
        paneltemizle()
        yaziyaz("AİDAT İŞLEMLERİ")
        Dim frm As FrmAidat = New FrmAidat()
        Formdegis(frm)
    End Sub

    Private Sub btnGaleri_Click(sender As Object, e As EventArgs) Handles btnGaleri.Click
        paneltemizle()
        yaziyaz("GALERİ")
        Dim frm As FrmGaleri = New FrmGaleri()
        Formdegis(frm)
    End Sub

    Private Sub btncikis_Click(sender As Object, e As EventArgs) Handles btncikis.Click
        Dim frm As FrmGiris = New FrmGiris()
        frm.Show()
        Me.Hide()
    End Sub
End Class