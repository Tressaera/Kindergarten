Imports System.Data.SqlClient

Public Class Veli

#Region "degiskenler"
    Public Shared ID As Integer
    Public Shared ADSOYAD As String
    Public Shared OGRID As Integer
    Public Shared telefon As String
    Public Shared adres As String
    Public Shared Kuladi As String
    Public Shared Sifre As String
    Public Shared Yillikfiyat As Integer
    Public Shared Donemi As String
    Public Shared da As SqlDataAdapter
    Public Shared cmd As SqlCommand
    Public Shared dt As DataTable
#End Region


    Public Shared Function VeliListele() As DataTable
        Dim sqlcumle As String = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Donemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub Veliekle(ByVal adsoyad As String, ByVal ogrID As Integer, ByVal telefon As String, ByVal Adres As String, ByVal kulad As String, ByVal Sifre As String, ByVal yillikfiyat As Integer, ByVal dönemi As String)
        cmd = New SqlCommand("INSERT INTO veli(ADSOYAD,OGRID,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,Donemi,Durumu) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,1)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adsoyad)
        cmd.Parameters.AddWithValue("@p2", ogrID)
        cmd.Parameters.AddWithValue("@p3", telefon)
        cmd.Parameters.AddWithValue("@p4", Adres)
        cmd.Parameters.AddWithValue("@p5", kulad)
        cmd.Parameters.AddWithValue("@p6", Sifre)
        cmd.Parameters.AddWithValue("@p7", yillikfiyat)
        cmd.Parameters.AddWithValue("@p8", dönemi)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Veli Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub VeliGuncelle(ByVal adsoyad As String, ByVal ogrID As Integer, ByVal telefon As String, ByVal Adres As String, ByVal kulad As String, ByVal Sifre As String, ByVal yillikfiyat As Integer, ByVal dönemi As String, ByVal id As Integer)
        cmd = New SqlCommand("UPDATE veli set ADSOYAD=@p1,OGRID=@p2,Telefon=@p3,Adres=@p4,KullaniciAdi=@p5,Sifre=@p6,YillikFiyat=@p7,Donemi=@p8 where VeliID=@p9", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adsoyad)
        cmd.Parameters.AddWithValue("@p2", ogrID)
        cmd.Parameters.AddWithValue("@p3", telefon)
        cmd.Parameters.AddWithValue("@p4", Adres)
        cmd.Parameters.AddWithValue("@p5", kulad)
        cmd.Parameters.AddWithValue("@p6", Sifre)
        cmd.Parameters.AddWithValue("@p7", yillikfiyat)
        cmd.Parameters.AddWithValue("@p8", dönemi)
        cmd.Parameters.AddWithValue("@p9", id)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Veli Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function VeliAra(ByVal dönem As String) As DataTable
        Dim sqlcumle As String = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Donemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.Durumu='1' AND a.Donemi=@p1"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", dönem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub VeliSil(ByVal id As Integer, ByVal adsoyad As String)
        Dim sqlcumle As String = "Update Veli Set Durumu='false' where VeliID=@p1"
        cmd = New SqlCommand(sqlcumle, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", id)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "adlı Veliyi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function VeliAraAD(ByVal adsoyad As String) As DataTable
        Dim sqlcumle As String = "Select VeliID,a.ADSOYAD,b.ADSOYAD AS ÖğrenciAdSoyad,Telefon,Adres,KullaniciAdi,Sifre,YillikFiyat,a.Donemi from Veli AS a INNER JOIN Ogrenci AS b ON a.OGRID=b.OgrID where a.ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function ComboboxVeliADSOYADcek() As DataTable
        da = New SqlDataAdapter("Select VeliID,ADSOYAD from Veli where Durumu='1' ", Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function GirisYap(ByVal kulad As String, ByVal sifre As String) As Boolean
        Dim command As String = "Select * from Veli where KullaniciAdi=@p1 AND Sifre=@p2"
        Dim cmd As SqlCommand = New SqlCommand(command, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", kulad)
        cmd.Parameters.AddWithValue("@p2", sifre)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            ID = Integer.Parse(dr("VeliID").ToString())
            ADSOYAD = dr("ADSOYAD").ToString()
            OGRID = Integer.Parse(dr("OGRID").ToString())
            Return True
        Else
            Return False
        End If
    End Function

End Class
