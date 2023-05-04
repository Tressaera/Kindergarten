Imports System.Data.SqlClient

Public Class GelirGider
#Region "degiskenler"
    Public Shared GelirgiderID As Integer
    Public Shared gelirgider As String
    Public Shared gelirgiderTarih As DateTime
    Public Shared Gelirgidertutar As Integer
    Public Shared gelirgiderturu As String
    Public Shared odemeturu As String
    Public Shared Donemi As String
    Public Shared dt As DataTable
    Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
    Public Shared toplamgelir As Integer
#End Region

#Region "fonksiyonlar"
    Public Shared Function GelirGiderListele() As DataTable
        Dim sqlcumle As String = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Durumu='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub GelirGiderEkle(ByVal gelirgider As String, ByVal tarih As DateTime, ByVal tutar As Integer, ByVal gelirgidertur As String, ByVal odemetur As String, ByVal donem As String)
        cmd = New SqlCommand("INSERT INTO GelirGider(GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem) values(@p1,@p2,@p3,@p4,@p5,@p6)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", gelirgider)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", tutar)
        cmd.Parameters.AddWithValue("@p4", gelirgidertur)
        cmd.Parameters.AddWithValue("@p5", odemetur)
        cmd.Parameters.AddWithValue("@p6", donem)
        cmd.ExecuteNonQuery()
    End Sub

    Public Shared Sub GelirGiderGuncelle(ByVal gelirgider As String, ByVal tarih As DateTime, ByVal tutar As Integer, ByVal gelirgidertur As String, ByVal odemetur As String, ByVal donem As String, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE GelirGider set GelirGider=@p1,Tarih=@p2,Tutar=@p3,GelirGiderTuru=@p4,OdemeTuru=@p5,Donem=@p6 where GelirGiderID=@p7", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", gelirgider)
        cmd.Parameters.AddWithValue("@p2", tarih)
        cmd.Parameters.AddWithValue("@p3", tutar)
        cmd.Parameters.AddWithValue("@p4", gelirgidertur)
        cmd.Parameters.AddWithValue("@p5", odemetur)
        cmd.Parameters.AddWithValue("@p6", donem)
        cmd.Parameters.AddWithValue("@p7", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Gider Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub GelirGiderSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update GelirGider set Durumu='false' where GelirGiderID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Kaydı Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function GelirGiderAraTarih(ByVal Giris As DateTime, ByVal Cikis As DateTime) As DataTable
        Dim sqlcumle As String = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Tarih between @p1 and @p2 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", Giris)
        da.SelectCommand.Parameters.AddWithValue("@p2", Cikis)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function GelirGiderAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select GelirGiderID,GelirGider,Tarih,Tutar,GelirGiderTuru,OdemeTuru,Donem from GelirGider where Donem=@p1 AND Durumu='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
