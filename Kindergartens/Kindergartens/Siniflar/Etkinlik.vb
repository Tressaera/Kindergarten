Imports System.Data.SqlClient

Public Class Etkinlik
#Region "degiskenler"
    Public Shared EtkinlikID As Integer
    Public Shared EtkinlikTarih As DateTime
    Public Shared EtkinlikBaslik As String
    Public Shared Etkinlikİcerik As String
    Public Shared EtkinlikDonem As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region

#Region "fonksiyonlar"
    Public Shared Function EtkinlikListele() As DataTable
        Dim sqlcumle As String = "Select EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub EtkinlikEkle(ByVal tarih As DateTime, ByVal baslik As String, ByVal icerik As String, ByVal donem As String)
        cmd = New SqlCommand("Insert INTO Etkinlik(Tarih,Baslik,İcerik,Donem) values(@p1,@p2,@p3,@p4)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", baslik)
        cmd.Parameters.AddWithValue("@p3", icerik)
        cmd.Parameters.AddWithValue("@p4", donem)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Etkinlik Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub EtkinlikGuncelle(ByVal tarih As DateTime, ByVal baslik As String, ByVal icerik As String, ByVal donem As String, ByVal ID As Integer)
        cmd = New SqlCommand("Update Etkinlik set Tarih=@p1,Baslik=@p2,İcerik=@p3,Donem=@p4 where EtkinlikID=@p5", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", baslik)
        cmd.Parameters.AddWithValue("@p3", icerik)
        cmd.Parameters.AddWithValue("@p4", donem)
        cmd.Parameters.AddWithValue("@p5", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Etkinlik Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub EtkinlikSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update Etkinlik set Durumu='false' where EtkinlikID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Etkinliği Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function EtkinlikAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Donem=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function EtkinlikAraTarih(ByVal tarih As DateTime) As DataTable
        Dim sqlcumle As String = "Select  EtkinlikID,Tarih,Baslik,İcerik,Donem from Etkinlik where Tarih=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", tarih)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
