Imports System.Data.SqlClient

Public Class YemekBildirimi
#Region "degiskenler"
    Public Shared YemekBildirimID As Integer
    Public Shared OgrenciID As Integer
    Public Shared Tarih As DateTime
    Public Shared Aciklama As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region

#Region "fonksiyonlar"
    Public Shared Sub YemekBildirimEkle(ByVal ogrenciID As Integer, ByVal Tarih As DateTime, ByVal aciklama As String)
        cmd = New SqlCommand("Insert Into YemekBildirimi(OgrenciID,Tarih,Aciklama) values(@p1,@p2,@p3)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", Tarih)
        cmd.Parameters.AddWithValue("@p3", aciklama)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Yemek Bildirimi  Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub YemekBildirimGuncelle(ByVal ogrenciID As Integer, ByVal Tarih As DateTime, ByVal aciklama As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE YemekBildirimi set OgrenciID=@p1,Tarih=@p2,Aciklama=@p3 where YemekBildirimID=@p4", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", Tarih)
        cmd.Parameters.AddWithValue("@p3", aciklama)
        cmd.Parameters.AddWithValue("@p4", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Yemek Bildirimi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function YemekBildirimAra(ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where Tarih=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub YemekBildirimSil(ByVal ID As Integer, ByVal adsoyad As String, ByVal Tarih As DateTime)
        cmd = New SqlCommand("Update YemekBildirimi set Durumu='false' where YemekBildirimID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "adlı Öğrencinin" & " " & Tarih.ToLongDateString() & " " & " Tarihli Kaydını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Yemek Bildirimi Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        End If
    End Sub

    Public Shared Function YemekBildirimiVeli(ByVal ogrenciID As Integer) As DataTable
        da = New SqlDataAdapter("Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND a.Durumu='True' ", Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function YemekBildirimiVeli(ByVal ogrenciID As Integer, ByVal tarih As DateTime) As DataTable
        da = New SqlDataAdapter("Select YemekBildirimID,ADSOYAD,Tarih,Aciklama AS 'Yemeğini Yedimi' from YemekBildirimi AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND Tarih=@p2 AND a.Durumu='True' ", Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        da.SelectCommand.Parameters.AddWithValue("@p2", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
