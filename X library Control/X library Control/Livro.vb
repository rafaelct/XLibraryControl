Public Class Livro
    Private codLivro As Integer
    Private titulo As String
    Private autor As String
    Private categoria As String
    Private editora As String

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

End Class
