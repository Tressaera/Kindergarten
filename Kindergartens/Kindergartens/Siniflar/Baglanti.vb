Imports System.Data.SqlClient

Public Class Baglanti
    Public Shared cnn As SqlConnection

    Public Shared Function baglan() As SqlConnection
        cnn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=Anaokuludb;Integrated Security=True;")

        If cnn.State = System.Data.ConnectionState.Closed Then
            cnn.Open()
        End If

        Return cnn
    End Function
End Class
