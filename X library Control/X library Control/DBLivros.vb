Imports System.Data.SqlClient

Public Class DBLivros
    Public myConn As SqlConnection
    Public dr As SqlDataReader

    Public Sub New(sqlConn As SqlConnection)
        Me.myConn = sqlConn
    End Sub

    Public Function TemLivro(codLivro As Integer) As Boolean

        Dim existeLivro = False

        Dim sqlCmd As New SqlCommand("pSelLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", codLivro)

        dr = sqlCmd.ExecuteReader()

        While (dr.Read)

            existeLivro = True

        End While

        dr.Close()

        Return existeLivro

    End Function

    Public Function SelecionaLivro(codLivro As Integer) As Livro

        Dim livro As New Livro()

        Dim sqlCmd As New SqlCommand("pSelLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", codLivro)



        dr = sqlCmd.ExecuteReader()

        While (dr.Read)

            livro.SetCodLivro(dr.GetInt32(0))
            livro.SetTitulo(dr.GetString(1))
            livro.SetAutor(dr.GetString(2))
            livro.SetEditora(dr.GetString(3))
            livro.SetCategoria(dr.GetString(4))


        End While

        dr.Close()

        Return livro

    End Function

    Public Function ListarLivros() As List(Of Livro)

        Dim listaLivros As New List(Of Livro)
        Dim dr1 As SqlDataReader


        Dim sqlCmd As New SqlCommand("pSelLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", 0)

        dr1 = sqlCmd.ExecuteReader()

        While (dr1.Read)

            Dim livro As New Livro()

            livro.SetCodLivro(dr1.GetInt32(0))
            livro.SetTitulo(dr1.GetString(1))
            livro.SetAutor(dr1.GetString(2))
            livro.SetEditora(dr1.GetString(3))
            livro.SetCategoria(dr1.GetString(4))

            listaLivros.Add(livro)

        End While

        dr1.Close()

        Return listaLivros

    End Function


    Public Function Cadastrar(livro As Livro) As Integer
        Dim sqlCmd As New SqlCommand("pCadLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", livro.GetCodLivro())
        sqlCmd.Parameters.AddWithValue("@titulo", livro.GetTitulo())
        sqlCmd.Parameters.AddWithValue("@autor", livro.GetAutor())
        sqlCmd.Parameters.AddWithValue("@editora", livro.GetEditora())
        sqlCmd.Parameters.AddWithValue("@categoria", livro.GetCategoria())


        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function
    Public Function Excluir(codLivro As Integer) As Integer
        Dim sqlCmd As New SqlCommand("pExcLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", codLivro)

        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function

    Public Function Atualizar(livro As Livro) As Integer

        Dim sqlCmd As New SqlCommand("pAtuLivro", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@codLivro", livro.GetCodLivro())
        sqlCmd.Parameters.AddWithValue("@titulo", livro.GetTitulo())
        sqlCmd.Parameters.AddWithValue("@autor", livro.GetAutor())
        sqlCmd.Parameters.AddWithValue("@editora", livro.GetEditora())
        sqlCmd.Parameters.AddWithValue("@categoria", livro.GetCategoria())

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
