Imports System.Data.SqlClient

Public Class İlacBildirim
#Region "degiskenler"
    Public Shared İlacBildirimID As Integer
    Public Shared OgrenciID As Integer
    Public Shared Tarih As DateTime
    Public Shared Aciklama As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region

#Region "fonksiyonlar"
    Public Shared Sub İlacBildirimEkle(ByVal ogrenciID As Integer, ByVal tarih As DateTime, ByVal aciklama As String)
        cmd = New SqlCommand("INSERT INTO İlacBildirimi(OgrenciID,Tarih,Aciklama) values(@p1,@p2,@p3)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", aciklama)
        cmd.ExecuteNonQuery()
        MessageBox.Show("İlaç Bildirimi Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub İlacBildirimiGuncelle(ByVal ogrenciID As Integer, ByVal tarih As DateTime, ByVal aciklama As String, ByVal ID As Integer)
        cmd = New SqlCommand("Update İlacBildirimi set OgrenciID=@p1,Tarih=@p2,Aciklama=@p3 where İlacBildirimiID=@p4", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", aciklama)
        cmd.Parameters.AddWithValue("@p4", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("İlaç Bildirimi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub İlacBildirimiSil(ByVal ID As Integer, ByVal adsoyad As String, ByVal Tarih As DateTime)
        cmd = New SqlCommand("Update İlacBildirimi set Durumu='false' where İlacBildirimiID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "adlı Öğrencinin" & " " & Tarih.ToLongDateString() & " " & "Tarihli İlaç Bildirimini Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
            MessageBox.Show("İlaç Bildirimi Silindi", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
        End If
    End Sub

    Public Shared Function İlacBildirimiAraTarih(ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where Tarih=@p1 AND b.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function İlacBildirimiAraVeli(ByVal ogrenciID As Integer) As DataTable
        Dim sqlcumle As String = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama  AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where OgrenciID=@p1 AND b.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function İlacBildirimiAraVeli(ByVal ogrenciID As Integer, ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select İlacBildirimiID,ADSOYAD,Tarih,Aciklama  AS 'İlacını İçtimi' from İlacBildirimi AS b INNER JOIN Ogrenci ON OgrenciID=OgrID  where OgrenciID=@p1 AND Tarih=@p2 AND b.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        da.SelectCommand.Parameters.AddWithValue("@p2", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region


End Class
