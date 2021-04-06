Public Class Aluno

    Private nome As String
    Private ra As Integer
    Private ddd As Integer
    Private telefone As Integer
    Private email As String
    Private dataNascimento As Date

    Public Sub SetNome(nome As String)
        Me.nome = nome
    End Sub

    Public Sub SetRa(ra As Integer)
        Me.ra = ra
    End Sub

    Public Sub SetDdd(ddd As Integer)
        Me.ddd = ddd
    End Sub

    Public Sub SetTelefone(telefone As Integer)
        Me.telefone = telefone
    End Sub

    Public Sub SetEmail(email As String)
        Me.email = email
    End Sub

    Public Sub SetDataNascimento(dataNascimento As Date)
        Me.dataNascimento = dataNascimento
    End Sub

    Public Function GetNome()
        Return Me.nome
    End Function
    Public Function GetRa()
        Return Me.ra
    End Function
    Public Function GetDdd()
        Return Me.ddd
    End Function
    Public Function GetTelefone()
        Return Me.telefone
    End Function
    Public Function GetEmail()
        Return Me.email
    End Function

    Public Function GetDataNascimento()
        Return Me.dataNascimento
    End Function


End Class
