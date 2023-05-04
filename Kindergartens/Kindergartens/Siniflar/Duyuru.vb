Imports System.Data.SqlClient

Public Class Duyuru
#Region "degiskenler"
    Public Shared DuyuruID As Integer
    Public Shared Duyurutarih As DateTime
    Public Shared DuyuruBaslik As String
    Public Shared Duyuruİcerik As String
    Public Shared Donem As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region

#Region "fonksiyonlar"
    Public Shared Sub DuyuruEkle(ByVal tarih As DateTime, ByVal baslik As String, ByVal icerik As String, ByVal donem As String)
        cmd = New SqlCommand("Insert INTO Duyuru(Tarih,Baslik,İcerik,Donem) values(@p1,@p2,@p3,@p4)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", baslik)
        cmd.Parameters.AddWithValue("@p3", icerik)
        cmd.Parameters.AddWithValue("@p4", donem)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Duyuru Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function DuyuruListele() As DataTable
        Dim sqlcumle As String = "Select DuyuruID,Tarih,Baslik,İcerik,Donem from Duyuru where Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub DuyuruGuncelle(ByVal tarih As DateTime, ByVal baslik As String, ByVal icerik As String, ByVal donem As String, ByVal ID As Integer)
        cmd = New SqlCommand("Update Duyuru set Tarih=@p1,Baslik=@p2,İcerik=@p3,Donem=@p4 where DuyuruID=@p5", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", baslik)
        cmd.Parameters.AddWithValue("@p3", icerik)
        cmd.Parameters.AddWithValue("@p4", donem)
        cmd.Parameters.AddWithValue("@p5", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Duyuru Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub DuyuruSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update Duyuru set Durumu='false' where DuyuruID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Duyuruyu Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function DuyuruAraTarih(ByVal dates As DateTime) As DataTable
        Dim sqlcumle As String = "Select DuyuruID,Tarih,Baslik,İcerik,Donem from Duyuru where Tarih=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", dates)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function DuyuruAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select DuyuruID,Tarih,Baslik,İcerik,Donem from Duyuru where Donem=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
