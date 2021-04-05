Public Class UiLvAlunos
    Private LvAlunos As ListView

    Public Sub New(LvAlunos As ListView)
        Me.LvAlunos = LvAlunos
    End Sub
    Public Sub Reset()
        LvAlunos.Clear()
        LvAlunos.View = View.Details

        ' Cria coluna para os itens e subitens

        LvAlunos.Columns.Add("RA", 100, HorizontalAlignment.Left)
        LvAlunos.Columns.Add("Nome", 200, HorizontalAlignment.Left)
        LvAlunos.Columns.Add("Telefone", 100, HorizontalAlignment.Left)
        LvAlunos.Columns.Add("E-mail", 150, HorizontalAlignment.Left)
        LvAlunos.Columns.Add("Data de nascimento", 100, HorizontalAlignment.Left)


    End Sub

    Public Sub Add(aluno As Aluno)

        Dim item As New ListViewItem(aluno.GetRa().ToString(), 0)
        item.SubItems.Add(aluno.GetNome())
        item.SubItems.Add("(" + aluno.GetDdd().ToString + ") " + aluno.GetTelefone().ToString)
        item.SubItems.Add(aluno.GetEmail())
        item.SubItems.Add(aluno.GetDataNascimento())
        LvAlunos.Items.Add(item)

    End Sub
End Class
