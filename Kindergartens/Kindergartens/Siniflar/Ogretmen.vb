Imports System.Data.SqlClient

Public Class Ogretmen
#Region "degiskenler"
    Public Shared OgretmenID As Integer
        Public Shared ADSOYAD As String
        Public Shared TC As String
        Public Shared dogumtarihi As DateTime
        Public Shared Adres As String
        Public Shared Maas As Integer
        Public Shared telefon As String
        Public Shared KullaniciAdi As String
        Public Shared Sifre As String
        Public Shared dt As DataTable
        Public Shared cmd As SqlCommand
    Public Shared da As SqlDataAdapter
#End Region


    Public Shared Sub OgretmenEkle(ByVal adsoyad As String, ByVal tc As String, ByVal dogumtarih As DateTime, ByVal adres As String, ByVal maas As Integer, ByVal Telefon As String, ByVal kullaniciadi As String, ByVal sifre As String)
            cmd = New SqlCommand("INSERT INTO Ogretmen(ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.baglan())
            cmd.Parameters.AddWithValue("@p1", adsoyad)
            cmd.Parameters.AddWithValue("@p2", tc)
            cmd.Parameters.AddWithValue("@p3", dogumtarih)
            cmd.Parameters.AddWithValue("@p4", adres)
            cmd.Parameters.AddWithValue("@p5", maas)
            cmd.Parameters.AddWithValue("@p6", Telefon)
            cmd.Parameters.AddWithValue("@p7", kullaniciadi)
            cmd.Parameters.AddWithValue("@p8", sifre)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Öğretmen Başarıyla Eklendi", "Kayıt EKleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Public Shared Function OgretmenListele() As DataTable
            Dim sqlcumle As String = "Select OgretmenID,ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre from Ogretmen where Durumu='1'"
            da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
            dt = New DataTable()
            da.Fill(dt)
            Return dt
        End Function

        Public Shared Sub OgretmenGuncelle(ByVal adsoyad As String, ByVal tc As String, ByVal DogumTarihi As DateTime, ByVal adres As String, ByVal maas As Integer, ByVal Telefon As String, ByVal kullaniciadi As String, ByVal sifre As String, ByVal ID As Integer)
            cmd = New SqlCommand("UPDATE Ogretmen SET ADSOYAD=@p1,TC=@p2,DogumTarihi=@p3,Adres=@p4,Maas=@p5,Telefon=@p6,KullaniciAdi=@p7,Sifre=@p8 where OgretmenID=@p9", Baglanti.baglan())
            cmd.Parameters.AddWithValue("@p1", adsoyad)
            cmd.Parameters.AddWithValue("@p2", tc)
            cmd.Parameters.AddWithValue("@p3", DogumTarihi)
            cmd.Parameters.AddWithValue("@p4", adres)
            cmd.Parameters.AddWithValue("@p5", maas)
            cmd.Parameters.AddWithValue("@p6", Telefon)
            cmd.Parameters.AddWithValue("@p7", kullaniciadi)
            cmd.Parameters.AddWithValue("@p8", sifre)
            cmd.Parameters.AddWithValue("@p9", ID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Öğretmen Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Public Shared Sub OgretmenSil(ByVal id As Integer, ByVal adsoyad As String)
            Dim sqlcumle As String = "Update Ogretmen Set Durumu='false' where OgretmenID=@p1"
            cmd = New SqlCommand(sqlcumle, Baglanti.baglan())
            cmd.Parameters.AddWithValue("@p1", id)
            Dim cevap As DialogResult
            cevap = MessageBox.Show(adsoyad & " " & "adlı Öğretmeni Silmek İstediğinize emin misiniz?", "Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If cevap = DialogResult.Yes Then
                cmd.ExecuteNonQuery()
            Else
            End If
        End Sub

        Public Shared Function OgretmenAra(ByVal adsoyad As String) As DataTable
            Dim sqlcumle As String = "Select OgretmenID,ADSOYAD,TC,DogumTarihi,Adres,Maas,Telefon,KullaniciAdi,Sifre from Ogretmen where ADSOYAD LIKE '%'+@p1+'%' AND Durumu='1'"
            da = New SqlDataAdapter(sqlcumle, Baglanti.baglan())
            da.SelectCommand.Parameters.AddWithValue("@p1", adsoyad)
            dt = New DataTable()
            da.Fill(dt)
            Return dt
        End Function

        Public Shared Function OgretmenAdSoyadGetir() As DataTable
            da = New SqlDataAdapter("Select OgretmenID,ADSOYAD from Ogretmen where Durumu='1'", Baglanti.baglan())
            dt = New DataTable()
            da.Fill(dt)
            Return dt
        End Function

    Public Shared Function GirisYap(ByVal Kulad As String, ByVal sifre As String) As Boolean
        Dim command As String = "Select * from Ogretmen where KullaniciAdi=@p1 AND Sifre=@p2"
        Dim cmd As SqlCommand = New SqlCommand(command, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", Kulad)
        cmd.Parameters.AddWithValue("@p2", sifre)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            OgretmenID = Integer.Parse(dr("OgretmenID").ToString())
            ADSOYAD = dr("ADSOYAD").ToString()
            Return True
        Else
            Return False
        End If
    End Function
End Class
