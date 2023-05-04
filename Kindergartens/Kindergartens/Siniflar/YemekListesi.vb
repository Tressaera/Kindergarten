Imports System.Data.SqlClient

Public Class YemekListesi
#Region "degiskenler"
    Public Shared YemekListeID As Integer
    Public Shared Tarih As DateTime
    Public Shared Sabah As String
    Public Shared Oglen As String
    Public Shared Ikindi As String
    Public Shared Donem As String
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared dt As DataTable
#End Region

#Region "fonksiyonlar"
    Public Shared Function YemekListele() As DataTable
        Dim sqlcumle As String = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub YemekListesiEkle(ByVal tarih As DateTime, ByVal sabah As String, ByVal ogle As String, ByVal ikindi As String, ByVal donem As String)
        cmd = New SqlCommand("Insert INTO YemekListesi(Tarih,Sabah,Ogle,Ikindi,Donemi) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", sabah)
        cmd.Parameters.AddWithValue("@p3", ogle)
        cmd.Parameters.AddWithValue("@p4", ikindi)
        cmd.Parameters.AddWithValue("@p5", donem)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Yemek Listesi Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub YemekListesiGuncelle(ByVal tarih As DateTime, ByVal sabah As String, ByVal ogle As String, ByVal ikindi As String, ByVal donem As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE YemekListesi set Tarih=@p1,Sabah=@p2,Ogle=@p3,Ikindi=@p4,Donemi=@p5 where YemekListesiID=@p6", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", tarih)
        cmd.Parameters.AddWithValue("@p2", sabah)
        cmd.Parameters.AddWithValue("@p3", ogle)
        cmd.Parameters.AddWithValue("@p4", ikindi)
        cmd.Parameters.AddWithValue("@p5", donem)
        cmd.Parameters.AddWithValue("@p6", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Yemek Listesi Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub YemekListesiSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update YemekListesi set Durumu='false' where YemekListesiID" & "=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Yemek Listesini Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function YemekListesiAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Donemi=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function YemekListesiAraTarih(ByVal dates As DateTime) As DataTable
        Dim sqlcumle As String = "Select YemekListesiID,Tarih,Sabah,Ogle,Ikindi,Donemi from YemekListesi where Tarih=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", dates)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
