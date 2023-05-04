Imports System.Data.SqlClient

Public Class Yoklama
#Region "degiskenler"
    Public Shared YoklamaID As Integer
    Public Shared OgrenciID As Integer
    Public Shared YoklamaTarih As DateTime
    Public Shared OkulaGeldimi As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared dr As SqlDataReader
#End Region
#Region "fonksiyonlar"
    Public Shared Function YoklamaAra(ByVal tarih As DateTime, ByVal sinif As String) As DataTable
        Dim sqlcumle As String = "Select YoklamaID,b.ADSOYAD,a.Tarih,OkulaGeldimi,c.Adi AS Sınıf From Yoklama AS a INNER JOIN Ogrenci AS b ON a.OgrenciID=b.OgrID INNER JOIN Sinif AS c ON b.SinifID=c.SinifID where Tarih=@p1 AND Adi=@p2 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        da.SelectCommand.Parameters.AddWithValue("@p2", sinif)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub GelmeyenOgrenci(ByVal tarih As DateTime, ByVal sinif As String, ByVal liste As ListBox)
        Dim sqlcumle As String = "Select YoklamaID,b.ADSOYAD,a.Tarih,OkulaGeldimi,c.Adi AS Sınıf From Yoklama AS a INNER JOIN Ogrenci AS b ON a.OgrenciID=b.OgrID INNER JOIN Sinif AS c ON b.SinifID=c.SinifID where Tarih=@p1 AND Adi=@p2 AND a.Durumu='1' AND OkulaGeldimi='Hayır'"
        cmd = New SqlCommand(sqlcumle, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", sinif)
        dr = cmd.ExecuteReader()

        While dr.Read()
            liste.Items.Add(dr("ADSOYAD").ToString())
        End While
    End Sub

    Public Shared Sub YoklamaEkle(ByVal ogrenciID As Integer, ByVal tarih As DateTime, ByVal Okul As String)
        cmd = New SqlCommand("Insert INTO Yoklama(OgrenciID,Tarih,OkulaGeldimi) values(@p1,@p2,@p3)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", Okul)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Yoklama Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub YoklamaGuncelle(ByVal ogrenciID As Integer, ByVal tarih As DateTime, ByVal Okul As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE Yoklama set OgrenciID=@p1,Tarih=@p2,OkulaGeldimi=@p3 where YoklamaID=@p4 ", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", Okul)
        cmd.Parameters.AddWithValue("@p4", ID)
        MessageBox.Show("Yoklama Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmd.ExecuteNonQuery()
    End Sub

    Public Shared Sub YoklamaSil(ByVal ID As Integer, ByVal adsoyad As String, ByVal Tarih As DateTime)
        cmd = New SqlCommand("Update Yoklama set Durumu='false' where YoklamaID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "adlı Öğrencinin" & " " & Tarih.ToShortDateString() & " " & "Tarihli Yoklamasını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("Yoklama Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        End If
    End Sub

    Public Shared Function YoklamaAra(ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where Tarih=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function YoklamaAraVeli(ByVal ogrenciID As Integer) As DataTable
        Dim sqlcumle As String = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function YoklamaAraVeli(ByVal ogrenciID As Integer, ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select YoklamaID,ADSOYAD,Tarih,OkulaGeldimi from Yoklama AS a INNER JOIN Ogrenci ON OgrenciID=OgrID where OgrenciID=@p1 AND Tarih=@p2 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        da.SelectCommand.Parameters.AddWithValue("@p2", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
