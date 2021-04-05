Imports System.Data.SqlClient

Public Class DBConnect

    REM Private strCon As String = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"
    Private strCon As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=biblioteca;Integrated Security=True"
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Public Function Open()
        myConn = New SqlConnection(Me.strCon)
        myConn.Open()

        Return myConn
    End Function

    Public Sub Close()
        myConn.Close()
    End Sub

End Class
