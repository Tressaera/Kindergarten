Imports System.Data.SqlClient

Public Class Ogrenci
#Region "degisken"
    Public Shared ID As Integer
    Public Shared ADSOYAD As String
    Public Shared TC As String
    Public Shared DogumTarihi As String
    Public Shared Cinsiyet As String
    Public Shared SinifID As Integer
    Public Shared KayitTarihi As DateTime
    Public Shared Donemi As String
    Public Shared da As SqlDataAdapter
    Public Shared cmd As SqlCommand
    Public Shared dt As DataTable
#End Region

#Region "fonksiyonlar"
    Public Shared Sub OgrenciEkle(ByVal adsoyad As String, ByVal tc As String, ByVal dogumtarihi As DateTime, ByVal cinsiyet As String, ByVal sinifID As Integer, ByVal kayittarihi As DateTime, ByVal donemi As String)
        cmd = New SqlCommand("INSERT INTO Ogrenci(ADSOYAD,TC,DogumTarihi,Cinsiyet,SinifID,KayitTarihi,Donemi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adsoyad)
        cmd.Parameters.AddWithValue("@p2", tc)
        cmd.Parameters.AddWithValue("@p3", dogumtarihi)
        cmd.Parameters.AddWithValue("@p4", cinsiyet)
        cmd.Parameters.AddWithValue("@p5", sinifID)
        cmd.Parameters.AddWithValue("@p6", kayittarihi)
        cmd.Parameters.AddWithValue("@p7", donemi)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Öğrenci Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub OgrenciGuncelle(ByVal adsoyad As String, ByVal tc As String, ByVal dogum As DateTime, ByVal cinsiyet As String, ByVal sinifID As Integer, ByVal kayit As DateTime, ByVal donem As String, ByVal id As Integer)
        cmd = New SqlCommand("UPDATE Ogrenci set ADSOYAD=@p1,TC=@p2,DogumTarihi=@p3,Cinsiyet=@p4,SinifID =@p5,KayitTarihi=@p6,Donemi=@p7 where OgrID=@p8", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adsoyad)
        cmd.Parameters.AddWithValue("@p2", tc)
        cmd.Parameters.AddWithValue("@p3", dogum)
        cmd.Parameters.AddWithValue("@p4", cinsiyet)
        cmd.Parameters.AddWithValue("@p5", sinifID)
        cmd.Parameters.AddWithValue("@p6", kayit)
        cmd.Parameters.AddWithValue("@p7", donem)
        cmd.Parameters.AddWithValue("@p8", id)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Öğrenci Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function Listele() As DataTable
        Dim sqlcumle As String = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Donemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SinifID=b.SinifID where a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function Aramas(ByVal arama As String) As DataTable
        Dim sqlcumle As String = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Donemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SinifID=b.SinifID where a.Donemi=@p1 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", arama)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function Textboxara(ByVal arama As String) As DataTable
        Dim sqlcumle As String = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Donemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SinifID=b.SinifID where ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", arama)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub OgrenciSil(ByVal ID As Integer, ByVal adsoyad As String)
        Dim sqlcumle As String = "Update Ogrenci Set Durumu='false' where ogrID=@p1"
        cmd = New SqlCommand(sqlcumle, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "Adlı Öğrenciyi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function OgrenciAdsoyadCEK() As DataTable
        da = New SqlDataAdapter("Select OGRID,ADSOYAD from Ogrenci where Durumu='1'", Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function OgrenciAraSinif(ByVal ID As Integer) As DataTable
        Dim sqlcumle As String = "Select OgrID,ADSOYAD,TC,DogumTarihi,Cinsiyet,Adi,KayitTarihi,Donemi from Ogrenci AS a INNER JOIN Sinif AS b ON a.SinifID=b.SinifID where a.SinifID=@p1 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function OgrenciVeliCek(ByVal veliID As Integer) As DataTable
        da = New SqlDataAdapter("SELECT b.OGRID,a.ADSOYAD FROM Veli AS b INNER JOIN Ogrenci AS a ON b.OGRID=a.OgrID WHERE VeliID=@p1 AND b.Durumu='1'", Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", veliID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
