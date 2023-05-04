Imports System.Data.SqlClient

Public Class Ders
#Region "degiskenler"
    Public Shared DersID As Integer
    Public Shared DersAdi As String
    Public Shared DersAciklama As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared dr As SqlDataReader
#End Region

#Region "fonksiyonlar"
    Public Shared Function Listele() As DataTable
        Dim sqlcumle As String = "Select DersID,DersAdi,Aciklama from Ders where Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub DersEkle(ByVal ders As String, ByVal Aciklama As String)
        cmd = New SqlCommand("Insert Into Ders(DersAdi,Aciklama) values(@p1,@p2)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ders)
        cmd.Parameters.AddWithValue("@p2", Aciklama)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Ders Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub DersGuncelle(ByVal ders As String, ByVal Aciklama As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE Ders set DersAdi=@p1,Aciklama=@p2 where DersID=@p3", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ders)
        cmd.Parameters.AddWithValue("@p2", Aciklama)
        cmd.Parameters.AddWithValue("@p3", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Ders Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function DersAra(ByVal ders As String) As DataTable
        Dim sqlcumle As String = "Select DersID,DersAdi,Aciklama from Ders Where DersAdi LIKE '%'+@p1+'%' AND Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ders)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub DersSil(ByVal id As Integer, ByVal adsoyad As String)
        cmd = New SqlCommand("UPDATE Ders set Durumu='false' where DersID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", id)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(adsoyad & " " & "adlı Dersi Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub
#End Region
End Class
