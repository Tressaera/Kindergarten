Imports System.Data.SqlClient

Public Class Yonetici

#Region "degiskenler"
    Public Shared ID As Integer
        Public Shared ADSOYAD As String
        Public Shared KullaniciAdi As String
        Public Shared Sifre As String
#End Region


    Public Shared Function GirisYap(ByVal Kulad As String, ByVal sifre As String) As Boolean
        Dim command As String = "Select * from Yonetici where KullaniciAdi=@p1 AND Sifre=@p2"
        Dim cmd As SqlCommand = New SqlCommand(command, Baglanti.baglan())
        cmd.Parameters.AddWithValue("@p1", Kulad)
        cmd.Parameters.AddWithValue("@p2", sifre)
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        If dr.Read() Then
            ID = Integer.Parse(dr("YoneticiID").ToString())
            ADSOYAD = dr("ADSOYAD").ToString()
            Return True
        Else
            Return False
        End If
    End Function
End Class
