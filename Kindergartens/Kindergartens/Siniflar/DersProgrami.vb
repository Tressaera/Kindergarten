Imports System.Data.SqlClient

Public Class DersProgrami
#Region "degiskenler"
    Public Shared DersProgramiID As Integer
    Public Shared Tarih As DateTime
    Public Shared Donem As String
    Public Shared Ders1 As String
    Public Shared Ders2 As String
    Public Shared Ders3 As String
    Public Shared Ders4 As String
    Public Shared Ders5 As String
    Public Shared Ders6 As String
    Public Shared da As SqlDataAdapter
    Public Shared cmd As SqlCommand
    Public Shared dt As DataTable
#End Region
#Region "fonksiyonlar"
    Public Shared Function DersProgramiListele() As DataTable
        Dim sqlcumle As String = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Donem,Tarih from DersProgrami where Durum='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Sub DersprogramiEkle(ByVal ders1 As String, ByVal ders2 As String, ByVal ders3 As String, ByVal ders4 As String, ByVal ders5 As String, ByVal ders6 As String, ByVal donem As String, ByVal dt As DateTime)
        cmd = New SqlCommand("Insert Into Dersprogrami(Ders1,Ders2,Ders3,Ders4,Ders5,Ders6,Donem,Tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ders1)
        cmd.Parameters.AddWithValue("@p2", ders2)
        cmd.Parameters.AddWithValue("@p3", ders3)
        cmd.Parameters.AddWithValue("@p4", ders4)
        cmd.Parameters.AddWithValue("@p5", ders5)
        cmd.Parameters.AddWithValue("@p6", ders6)
        cmd.Parameters.AddWithValue("@p7", donem)
        cmd.Parameters.AddWithValue("@p8", dt)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Ders Programı Başarıyla Eklendi", "Kayıt Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub DersprogramiGuncelle(ByVal ders1 As String, ByVal ders2 As String, ByVal ders3 As String, ByVal ders4 As String, ByVal ders5 As String, ByVal ders6 As String, ByVal donem As String, ByVal dt As DateTime, ByVal ID As Integer)
        cmd = New SqlCommand("UPDATE DersProgrami set Ders1=@p1,Ders2=@p2,Ders3=@p3,Ders4=@p4,Ders5=@p5,Ders6=@p6,Donem=@p7,Tarih=@p8 where DersprogramiID=@p9", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ders1)
        cmd.Parameters.AddWithValue("@p2", ders2)
        cmd.Parameters.AddWithValue("@p3", ders3)
        cmd.Parameters.AddWithValue("@p4", ders4)
        cmd.Parameters.AddWithValue("@p5", ders5)
        cmd.Parameters.AddWithValue("@p6", ders6)
        cmd.Parameters.AddWithValue("@p7", donem)
        cmd.Parameters.AddWithValue("@p8", dt)
        cmd.Parameters.AddWithValue("@p9", ID)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Ders Programı Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Shared Sub DersProgramiSil(ByVal ID As Integer, ByVal tarih As DateTime)
        cmd = New SqlCommand("Update DersProgrami set Durumu='false' where DersProgramiID=@p1", Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", ID)
        Dim cevap As DialogResult
        cevap = MessageBox.Show(tarih.ToLongDateString() & " " & "Tarihli Ders Programını Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cevap = DialogResult.Yes Then
            cmd.ExecuteNonQuery()
        Else
        End If
    End Sub

    Public Shared Function DersprogramiAraTarih(ByVal dates As DateTime) As DataTable
        Dim sqlcumle As String = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Donem,Tarih from DersProgrami where Tarih=@p1 AND Durum='1'"
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", dates)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Shared Function DersProgramiAraDonem(ByVal donem As String) As DataTable
        Dim sqlcumle As String = "Select DersProgramiID,Ders1 AS '1.DERS',Ders2 AS '2.DERS',Ders3 AS '3.DERS',Ders4 AS '4.DERS',Ders5 AS '5.DERS',Ders6 AS '6.DERS',Donem,Tarih from DersProgrami where Donem=@p1 AND Durum='1' "
        da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
        da.SelectCommand.Parameters.AddWithValue("@p1", donem)
        dt = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
#End Region
End Class
