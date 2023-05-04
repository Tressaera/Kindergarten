Imports System.Data.SqlClient

Public Class İlac
#Region "degiskenler"
    Public Shared İlacID As Integer
    Public Shared OgrenciID As Integer
    Public Shared İlacAdi As String
    Public Shared İlacAciklama As String
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared dt As DataTable
#End Region

#Region "fonksiyonlar"
    Public Shared Function İlacListele() As DataTable
        Dim sqlcumle As String = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SinifID=c.SinifID where a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function İlacAraSinif(ByVal sinif As String) As DataTable
        Dim sqlcumle As String = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SinifID=c.SinifID where c.Adi=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", sinif)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function İlacAraADSOYAD(ByVal adsoyad As String) As DataTable
        Dim sqlcumle As String = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama,Adi AS Sınıfı from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID INNER JOIN Sinif AS c ON b.SinifID=c.SinifID where b.ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub İlacEkle(ByVal ogrenciID As Integer, ByVal ilacadi As String, ByVal ilacaciklama As String)
        cmd = New SqlCommand("Insert INTO İlac(OgrenciID,İlacAdi,İlacAciklama) values(@p1,@p2,@p3)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ogrenciID)
        cmd.Parameters.AddWithValue("@p2", ilacadi)
        cmd.Parameters.AddWithValue("@p3", ilacaciklama)
        cmd.ExecuteNonQuery()
        MessageBox.Show("İlaç Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub İlacGuncelle(ByVal ilacadi As String, ByVal ilacaciklama As String, ByVal ID As Integer)
        cmd = New SqlCommand("Update İlac set İlacAdi=@p1,İlacAciklama=@p2 where İlacID=@p3", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ilacadi)
        cmd.Parameters.AddWithValue("@p2", ilacaciklama)
        cmd.Parameters.AddWithValue("@p3", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("İlaç Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function İlacListeleVeli(ByVal ogrenciID As Integer) As DataTable
        Dim sqlcumle As String = "Select İlacID,ADSOYAD,İlacAdi,İlacAciklama from İlac AS a INNER JOIN Ogrenci AS b ON OgrenciID=OgrID where OgrID=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ogrenciID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub İlacSil(ByVal ID As Integer, ByVal ilac As String)
        cmd = New SqlCommand("Update İlac set Durumu='false' where İlacID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(ilac & " " & "adli İlacı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub
#End Region
End Class
