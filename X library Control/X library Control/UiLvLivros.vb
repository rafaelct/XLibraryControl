Public Class UiLvLivros
    Private lvLivros As ListView

    Public Sub New(lvLivros As ListView)
        Me.lvLivros = lvLivros
    End Sub
    Public Sub Reset()
        lvLivros.Clear()
        lvLivros.View = View.Details

        ' Cria coluna para os itens e subitens

        lvLivros.Columns.Add("Cod. Livro", 100, HorizontalAlignment.Left)
        lvLivros.Columns.Add("Titulo", 200, HorizontalAlignment.Left)
        lvLivros.Columns.Add("Autor", 100, HorizontalAlignment.Left)
        lvLivros.Columns.Add("Editora", 150, HorizontalAlignment.Left)
        lvLivros.Columns.Add("Categoria", 100, HorizontalAlignment.Left)


    End Sub

    Public Sub Add(livro As Livro)

        Dim item As New ListViewItem(livro.GetCodLivro().ToString(), 0)
        item.SubItems.Add(livro.GetTitulo())
        item.SubItems.Add(livro.GetAutor())
        item.SubItems.Add(livro.GetEditora())
        item.SubItems.Add(livro.GetCategoria())
        lvLivros.Items.Add(item)

    End Sub
End Class
