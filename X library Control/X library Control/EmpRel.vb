Public Class EmpRel

    Private nome As String
    Private ra As Integer
    Private ddd As Integer
    Private telefone As Integer
    Private email As String
    Private dataNascimento As Date

    Private codLivro As Integer
    Private titulo As String
    Private autor As String
    Private categoria As String
    Private editora As String

    Private dataRetirada As Date
    Private dataEntrega As Date

    Private dataEntregaTemNulo As Boolean

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


    Public Sub SetCodLivro(codLivro As Integer)
        Me.codLivro = codLivro
    End Sub
    Public Sub SetTitulo(titulo As String)
        Me.titulo = titulo
    End Sub
    Public Sub SetAutor(autor As String)
        Me.autor = autor
    End Sub
    Public Sub SetCategoria(categoria As String)
        Me.categoria = categoria
    End Sub
    Public Sub SetEditora(editora As String)
        Me.editora = editora
    End Sub


    Public Function GetCodLivro()
        Return Me.codLivro
    End Function

    Public Function GetTitulo()
        Return Me.titulo
    End Function

    Public Function GetAutor()
        Return Me.autor
    End Function

    Public Function GetCategoria()
        Return Me.categoria
    End Function

    Public Function GetEditora()
        Return Me.editora
    End Function


    Public Sub SetDataRetirada(dataRetirada As Date)
        Me.dataRetirada = dataRetirada
    End Sub

    Public Sub SetDataEntrega(dataEntrega As Date)
        Me.dataEntrega = dataEntrega
    End Sub

    Public Function GetDataRetirada() As Date
        Return Me.dataRetirada
    End Function

    Public Function GetDataEntrega() As Date
        Return Me.dataEntrega
    End Function

    Public Sub SetDataEntregaTemNulo(dataEntregaTemNulo As Boolean)
        Me.dataEntregaTemNulo = dataEntregaTemNulo
    End Sub

    Public Function GetDataEntregaTemNulo() As Boolean
        Return Me.dataEntregaTemNulo
    End Function


End Class
