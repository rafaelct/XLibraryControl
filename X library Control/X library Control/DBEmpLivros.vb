Imports System.Data.SqlClient

Public Class DBEmpLivros
    Public myConn As SqlConnection
    Public dr As SqlDataReader

    Public Sub New(sqlConn As SqlConnection)
        Me.myConn = sqlConn
    End Sub

    Public Function Emprestar(empLivro As EmpLivro) As Integer
        Dim sqlCmd As New SqlCommand("pCadEmpLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", empLivro.GetRa())
        sqlCmd.Parameters.AddWithValue("@codLivro", empLivro.GetCodLivro())

        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function

    Public Function Devolver(empLivro As EmpLivro) As Integer
        Dim sqlCmd As New SqlCommand("pDevEmpLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", empLivro.GetRa())

        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function

End Class
