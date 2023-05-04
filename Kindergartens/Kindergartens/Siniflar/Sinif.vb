Imports System.Data.SqlClient

Public Class Sinif
#Region "degiskenler"
    Shared frm As FrmOgrenci = New FrmOgrenci()
    Public Shared ID As Integer
    Public Shared Sinifadi As String
    Public Shared Kontenjan As Integer
    Public Shared Donem As String
    Public Shared OgretmenID As Integer
    Public Shared dt As DataTable
    Public Shared da As SqlDataAdapter
    Public Shared cmd As SqlCommand
#End Region

#Region "fonksiyonlar"
    Public Shared Function comboboxsiniflarigetir() As DataTable
        dt = New DataTable()
        da = New SqlDataAdapter("Select SinifID,Adi from Sinif where Durumu='1' ", Baglanti.baglan())
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub Sinifekle(ByVal sinifadi As String, ByVal kontenjan As Integer, ByVal donem As String, ByVal ogretmenID As Integer)
        cmd = New SqlCommand("INSERT INTO Sinif(Adi,Kontenjan,Donem,OgretmenID) values(@p1,@p2,@p3,@p4)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", sinifadi)
        cmd.Parameters.AddWithValue("@p2", kontenjan)
        cmd.Parameters.AddWithValue("@p3", donem)
        cmd.Parameters.AddWithValue("@p4", ogretmenID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Sınıf Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Function SinifListele() As DataTable
        Dim sqlcumle As String = "Select SinifID,Adi,Kontenjan,a.Donem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where a.Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub Guncelle(ByVal sinifadi As String, ByVal kontenjan As Integer, ByVal donem As String, ByVal ogretmenID As Integer, ByVal id As Integer)
        cmd = New SqlCommand("UPDATE Sinif set Adi=@p1,Kontenjan=@p2,Donem=@p3,OgretmenID=@p4 where SinifID=@p5", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", sinifadi)
        cmd.Parameters.AddWithValue("@p2", kontenjan)
        cmd.Parameters.AddWithValue("@p3", donem)
        cmd.Parameters.AddWithValue("@p4", ogretmenID)
        cmd.Parameters.AddWithValue("@p5", id)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Sinif Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub SinifSil(ByVal id As Integer, ByVal ad As String)
        cmd = New SqlCommand("UPDATE Sinif set Durumu='false' where SınıfID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", id)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(ad & " " & "adlı Sınıfı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function SinifAra(ByVal ad As String) As DataTable
        Dim sqlcumle As String = "Select SinifID,Adi,Kontenjan,a.Donem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where Adi LIKE '%'+@p1+'%'AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", ad)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function SinifAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select SinifID,Adi,Kontenjan,a.Donem,ADSOYAD from Sinif AS a INNER JOIN Ogretmen AS b ON a.OgretmenID=b.OgretmenID where a.Donem=@p1 AND a.Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region

End Class
