Imports System.Data.SqlClient

Public Class Galeri
#Region "degiskenler"
    Public Shared ResimID As Integer
    Public Shared ResimAdi As String
    Public Shared ResimTarihi As DateTime
    Public Shared ResimYolu As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared dr As SqlDataReader
    Public Shared Liste As List(Of String)
#End Region

#Region "fonksiyonlar"
    Public Shared Sub Resimekle(ByVal adi As String, ByVal tarih As DateTime, ByVal resimyolu As String)
        cmd = New SqlCommand("INSERT INTO Galeri(ResimAdi,Tarih,ResimYolu) values(@p1,@p2,@p3)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adi)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", resimyolu)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Resim Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub ResimGuncelle(ByVal adi As String, ByVal tarih As DateTime, ByVal resimyolu As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE Galeri set ResimAdi=@p1,Tarih=@p2,ResimYolu=@p3 where ResimID=@p4", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", adi)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", resimyolu)
        cmd.Parameters.AddWithValue("@p4", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Resim Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function ResimListele() As DataTable
        da = New SqlDataAdapter("Select ResimID,ResimAdi,Tarih,ResimYolu from Galeri where Durumu='1'", Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub ResimSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("UPDATE Galeri set Durumu='false' where ResimID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Resmi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function ResimYollarınıcek() As List(Of String)
        Liste = New List(Of String)()
        cmd = New SqlCommand("Select ResimYolu from Galeri where Durumu='1' ", Baglanti.baglan())
        dr = cmd.ExecuteReader()

        While dr.Read()
            Liste.Add(dr("ResimYolu").ToString())
        End While

        Return Liste
    End Function
#End Region

End Class
