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


    Public Function ListarEmpLivros() As List(Of EmpRel)

        Dim listaEmpLivros As New List(Of EmpRel)
        Dim dr1 As SqlDataReader


        Dim sqlCmd As New SqlCommand("pRelEmpLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        'sqlCmd.Parameters.AddWithValue("@codLivro", 0)

        dr1 = sqlCmd.ExecuteReader()

        While (dr1.Read)

            Dim empRel As New EmpRel()

            empRel.SetRa(dr1.GetInt32(0))
            empRel.SetNome(dr1.GetString(1))
            empRel.SetDdd(dr1.GetInt32(2))
            empRel.SetTelefone(dr1.GetInt32(3))
            empRel.SetEmail(dr1.GetString(4))
            empRel.SetDataNascimento(dr1.GetDateTime(5))
            empRel.SetCodLivro(dr1.GetInt32(6))
            empRel.SetTitulo(dr1.GetString(7))
            empRel.SetAutor(dr1.GetString(8))
            empRel.SetEditora(dr1.GetString(9))
            empRel.SetCategoria(dr1.GetString(10))
            empRel.SetDataRetirada(dr1.GetDateTime(11))

            If dr1.IsDBNull(12) = False Then
                empRel.SetDataEntrega(dr1.GetDateTime(12))
            Else
                empRel.SetDataEntregaTemNulo(True)
            End If

            listaEmpLivros.Add(empRel)

        End While

        dr1.Close()

        Return listaEmpLivros

    End Function

End Class
