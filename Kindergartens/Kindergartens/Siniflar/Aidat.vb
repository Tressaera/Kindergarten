Imports System.Data.SqlClient

Public Class Aidat
#Region "degiskenler"
    Public Shared aidatID As Integer
    Public Shared VeliID As Integer
    Public Shared AidatTarih As DateTime
    Public Shared Tutar As Integer
    Public Shared OdemeTuru As String
    Public Shared Donem As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region

#Region "fonksiyonlar"
    Public Shared Function AidatListele() As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub AidatEkle(ByVal veliID As Integer, ByVal tarih As DateTime, ByVal tutar As Integer, ByVal odemetur As String, ByVal donem As String)
        cmd = New SqlCommand("Insert INTO Aidat(VeliID,Tarih,Tutar,OdemeTuru,Donem) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", veliID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", tutar)
        cmd.Parameters.AddWithValue("@p4", odemetur)
        cmd.Parameters.AddWithValue("@p5", donem)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Aidat Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub AidatGuncelle(ByVal veliID As Integer, ByVal tarih As DateTime, ByVal tutar As Integer, ByVal odemetur As String, ByVal donem As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE Aidat set VeliID=@p1,Tarih=@p2,Tutar=@p3,OdemeTuru=@p4,Donem=@p5 where AidatID=@p6", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", veliID)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", tutar)
        cmd.Parameters.AddWithValue("@p4", odemetur)
        cmd.Parameters.AddWithValue("@p5", donem)
        cmd.Parameters.AddWithValue("@p6", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Aidat Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub AidatSil(ByVal ID As Integer, ByVal adsoyad As String, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update Aidat set Durumu='false' where AidatID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "Adlı Velinin" & " " & tarih.ToShortDateString() & " " & "Tarihli Aidatını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function AidatAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where Donem=@p1 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function AidatAraTarih(ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where Tarih=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function AidatAraVeli(ByVal adsoyad As String) As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,a.Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID where ADSOYAD LIKE '%'+@p1+'%' AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function AidatGoruntuleVeli(ByVal veliID As Integer) As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where a.VeliID=@p1 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", veliID)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function AidatGoruntuleVeli(ByVal veliID As Integer, ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select AidatID,ADSOYAD,Tarih,Tutar,OdemeTuru,Donem from Aidat AS a INNER JOIN Veli AS b ON a.VeliID=b.VeliID  where a.VeliID=@p1 AND Tarih=@p2 AND a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", veliID)
        da.SelectCommand.Parameters.AddWithValue("@p2", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
