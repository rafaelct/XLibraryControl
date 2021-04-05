Imports System.Data.SqlClient

Public Class DBAlunos
    Public myConn As SqlConnection
    Public dr As SqlDataReader

    Public Sub New(sqlConn As SqlConnection)
        Me.myConn = sqlConn
    End Sub

    Public Function TemAluno(ra As Integer) As Boolean

        Dim existeAluno = False

        Dim sqlCmd As New SqlCommand("pSelAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", ra)

        dr = sqlCmd.ExecuteReader()

        While (dr.Read)

            existeAluno = True

        End While

        dr.Close()

        Return existeAluno

    End Function

    Public Function SelecionaAluno(ra As Integer) As Aluno

        Dim aluno As New Aluno()

        Dim sqlCmd As New SqlCommand("pSelAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", ra)



        dr = sqlCmd.ExecuteReader()

        While (dr.Read)

            aluno.SetNome(dr.GetString(0))
            aluno.SetRa(dr.GetInt32(1))
            aluno.SetDdd(dr.GetInt32(2))
            aluno.SetTelefone(dr.GetInt32(3))
            aluno.SetEmail(dr.GetString(4))
            aluno.SetDataNascimento(dr.GetDateTime(5))

        End While

        dr.Close()

        Return aluno

    End Function

    Public Function ListarAlunos() As List(Of Aluno)

        Dim listaAlunos As New List(Of Aluno)
        Dim dr1 As SqlDataReader


        Dim sqlCmd As New SqlCommand("pSelAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", 0)

        dr1 = sqlCmd.ExecuteReader()

        While (dr1.Read)

            Dim aluno As New Aluno()

            aluno.SetNome(dr1.GetString(0))
            aluno.SetRa(dr1.GetInt32(1))
            aluno.SetDdd(dr1.GetInt32(2))
            aluno.SetTelefone(dr1.GetInt32(3))
            aluno.SetEmail(dr1.GetString(4))
            aluno.SetDataNascimento(dr1.GetDateTime(5))

            listaAlunos.Add(aluno)

        End While

        dr1.Close()

        Return listaAlunos

    End Function


    Public Function Cadastrar(aluno As Aluno) As Integer
        Dim sqlCmd As New SqlCommand("pCadAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@nome", aluno.GetNome())
        sqlCmd.Parameters.AddWithValue("@ra", aluno.GetRa())
        sqlCmd.Parameters.AddWithValue("@ddd", aluno.GetDdd())
        sqlCmd.Parameters.AddWithValue("@telefone", aluno.GetTelefone())
        sqlCmd.Parameters.AddWithValue("@email", aluno.GetEmail())
        sqlCmd.Parameters.AddWithValue("@dataNascimento", aluno.GetDataNascimento())

        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function
    Public Function Excluir(ra As Integer) As Integer
        Dim sqlCmd As New SqlCommand("pExcAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@ra", ra)

        sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int).Direction = ParameterDirection.Output
        ' Cria o parametro de retorno
        Dim parametroRetorno As New SqlParameter()

        parametroRetorno = sqlCmd.Parameters.Add("@codretorno", SqlDbType.Int)
        parametroRetorno.Direction = ParameterDirection.ReturnValue
        sqlCmd.ExecuteReader()

        Dim codretorno = parametroRetorno.Value

        Return codretorno



    End Function

    Public Function Atualizar(aluno As Aluno) As Integer

        Dim sqlCmd As New SqlCommand("pAtuAluno", Me.myConn)
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = 36000
        sqlCmd.Parameters.AddWithValue("@nome", aluno.GetNome())
        sqlCmd.Parameters.AddWithValue("@ra", aluno.GetRa())
        sqlCmd.Parameters.AddWithValue("@ddd", aluno.GetDdd())
        sqlCmd.Parameters.AddWithValue("@telefone", aluno.GetTelefone())
        sqlCmd.Parameters.AddWithValue("@email", aluno.GetEmail())
        sqlCmd.Parameters.AddWithValue("@dataNascimento", aluno.GetDataNascimento())

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
