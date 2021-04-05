Public Class Form1
    Private Sub TabCadLiv_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)

        Dim validaCampos As New ValidaCampos
        e.KeyChar = ValidaCampos.ApenasNumeros(e.KeyChar)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

        'lbAlunos.Items.Add("12345678   Rafael Costa Teixeira   (11) 939285496   rafa@teste.com.br   05/06/1982")
        'lbAlunos.Items.Add("84849394   Teste 1                 (11) 404049332   test@teste.com.br   03/04/1999")
        'Dim item1 As New ListViewItem("12345678", 0)
        'item1.SubItems.Add("Rafael Costa Teixeira")
        'item1.SubItems.Add("(11) 939285496")
        'item1.SubItems.Add("rafa@teste.com.br")
        'item1.SubItems.Add("05/06/1982")

        'Dim item2 As New ListViewItem("84849394", 0)
        'item2.SubItems.Add("Teste 1")
        'item2.SubItems.Add("(11) 404049332")
        'item2.SubItems.Add("test@teste.com.br")
        'item2.SubItems.Add("03/04/1999")
        '
        'LvAlunos.FullRowSelect = True
        'LvAlunos.Items.Add(item1)
        'LvAlunos.Items.Add(item2)


        Dim aluno As New Aluno()
        Dim uiLvAlunos As New UiLvAlunos(LvAlunos)

        aluno.SetNome(edNomeAlu.Text)
        aluno.SetRa(edRaAluno.Text)
        aluno.SetDdd(edDddAlu.Text)
        aluno.SetTelefone(edTelefoneAlu.Text)
        aluno.SetEmail(edEmailAlu.Text)
        aluno.SetDataNascimento(dtpDataNascAlu.Value)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbAlunos As New DBAlunos(myConn)

        Dim existeAluno = dbAlunos.TemAluno(aluno.GetRa())
        dbConnect.Close()

        If existeAluno Then

            Dim resposta = MsgBox("Tem certeza que deseja atualizar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectAtu As New DBConnect()
                Dim myConnAtu = dbConnectAtu.Open()

                Dim dbAlunosAtu As New DBAlunos(myConnAtu)
                Dim codigoRetorno = dbAlunosAtu.Atualizar(aluno)
                dbConnectAtu.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Atualização realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvAlunos.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbAlunosLst As New DBAlunos(myConnLst)
                    Dim listaAlunos = dbAlunosLst.ListarAlunos()
                    For Each itemlista As Aluno In listaAlunos
                        uiLvAlunos.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar atualização.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Tem certeza que deseja cadastrar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta1 = MsgBoxResult.Yes Then

                Dim dbConnectCad As New DBConnect()
                Dim myConnCad = dbConnectCad.Open()
                Dim dbAlunosCad As New DBAlunos(myConnCad)
                Dim codRetorno1 = dbAlunosCad.Cadastrar(aluno)
                dbConnectCad.Close()

                If codRetorno1 = 0 Then
                    uiLvAlunos.Add(aluno)
                    MsgBox("Cadastro realizado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                Else
                    MsgBox("Erro ao tentar efetuar cadastro.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If


            End If

        End If









    End Sub

    Private Sub LvAlunos_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim selectedListViewItemCollection = LvAlunos.SelectedItems

        Dim itemSelecionado = selectedListViewItemCollection.Item(0)

        MsgBox(itemSelecionado.SubItems.Item(0).Text, vbDefaultButton1, "Mensagem")



        MsgBox(itemSelecionado.Text, vbDefaultButton1, "Mensagem")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbAlunos As New DBAlunos(myConn)

        Dim listaAlunos = dbAlunos.ListarAlunos()

        LvAlunos.FullRowSelect = True

        Dim uiLvAlunos As New UiLvAlunos(LvAlunos)
        uiLvAlunos.Reset()

        For Each aluno As Aluno In listaAlunos
            'Dim item As New ListViewItem(aluno.GetRa().ToString(), 0)
            'item.SubItems.Add(aluno.GetNome())
            'item.SubItems.Add("(" + aluno.GetDdd().ToString + ") " + aluno.GetTelefone().ToString)
            'item.SubItems.Add(aluno.GetEmail())
            'item.SubItems.Add(aluno.GetDataNascimento())
            'LvAlunos.Items.Add(item)

            uiLvAlunos.Add(aluno)


        Next

        dbConnect.Close()


        Dim dbConnectLivros As New DBConnect()
        Dim myConnLivros = dbConnectLivros.Open()
        Dim dbLivros As New DBLivros(myConnLivros)

        Dim listaLivros = dbLivros.ListarLivros()

        lvLivros.FullRowSelect = True

        Dim uiLvLivros As New UiLvLivros(lvLivros)
        uiLvLivros.Reset()

        For Each livro As Livro In listaLivros
            'Dim item As New ListViewItem(aluno.GetRa().ToString(), 0)
            'item.SubItems.Add(aluno.GetNome())
            'item.SubItems.Add("(" + aluno.GetDdd().ToString + ") " + aluno.GetTelefone().ToString)
            'item.SubItems.Add(aluno.GetEmail())
            'item.SubItems.Add(aluno.GetDataNascimento())
            'LvAlunos.Items.Add(item)

            uiLvLivros.Add(livro)


        Next

        'Dim item1 As New ListViewItem("12345678", 0)
        'item1.SubItems.Add("Rafael Costa Teixeira")
        'item1.SubItems.Add("(11) 939285496")
        'item1.SubItems.Add("rafa@teste.com.br")
        'item1.SubItems.Add("05/06/1982")
        '
        'Dim item2 As New ListViewItem("84849394", 0)
        'item2.SubItems.Add("Teste 1")
        'item2.SubItems.Add("(11) 404049332")
        'item2.SubItems.Add("test@teste.com.br")
        'item2.SubItems.Add("03/04/1999")


        'LvAlunos.Items.Add(item1)
        'LvAlunos.Items.Add(item2)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()

        Dim dbAlunos As New DBAlunos(myConn)

        Dim aluno As New Aluno()

        aluno = dbAlunos.SelecionaAluno(edRaAluno.Text)

        edRaAluno.Text = aluno.GetRa()
        edNomeAlu.Text = aluno.GetNome()
        edDddAlu.Text = aluno.GetDdd()
        edTelefoneAlu.Text = aluno.GetTelefone()
        edEmailAlu.Text = aluno.GetEmail()
        dtpDataNascAlu.Value = aluno.GetDataNascimento()


    End Sub

    Private Sub edRaAluno_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub edDddAlu_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btExcluirAlu_Click(sender As Object, e As EventArgs)

        'LvAlunos.Clear()
        'LvAlunos.View = View.Details

        ' Cria coluna para os itens e subitens

        'LvAlunos.Columns.Add("RA", 100, HorizontalAlignment.Left)
        'LvAlunos.Columns.Add("Nome", 200, HorizontalAlignment.Left)
        'LvAlunos.Columns.Add("Telefone", 100, HorizontalAlignment.Left)
        'LvAlunos.Columns.Add("E-mail", 150, HorizontalAlignment.Left)
        'LvAlunos.Columns.Add("Data de nascimento", 100, HorizontalAlignment.Left)

        'Dim uiLvAlunos As New UiLvAlunos(LvAlunos)
        'UiLvAlunos.Reset()




        Dim uiLvAlunos As New UiLvAlunos(LvAlunos)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbAlunos As New DBAlunos(myConn)

        Dim existeAluno = dbAlunos.TemAluno(edRaAluno.Text)
        dbConnect.Close()

        If existeAluno Then

            Dim resposta = MsgBox("Tem certeza que deseja excluir ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectExc As New DBConnect()
                Dim myConnExc = dbConnectExc.Open()

                Dim dbAlunosExc As New DBAlunos(myConnExc)
                Dim codigoRetorno = dbAlunosExc.Excluir(edRaAluno.Text)
                dbConnectExc.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Exclusão realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvAlunos.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbAlunosLst As New DBAlunos(myConnLst)
                    Dim listaAlunos = dbAlunosLst.ListarAlunos()
                    For Each itemlista As Aluno In listaAlunos
                        uiLvAlunos.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar exclusão.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Registro inexistente", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")


        End If





    End Sub

    Private Sub btPesquisarLiv_Click(sender As Object, e As EventArgs) Handles btPesquisarLiv.Click


        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()

        Dim dbLivros As New DBLivros(myConn)

        Dim livro As New Livro()

        livro = dbLivros.SelecionaLivro(edCodLiv.Text)

        edCodLiv.Text = livro.GetCodLivro()
        edTituloLiv.Text = livro.GetTitulo()
        edAutorLiv.Text = livro.GetAutor()
        edEditoraLiv.Text = livro.GetEditora()
        edCategoriaLiv.Text = livro.GetCategoria()



    End Sub

    Private Sub btAtuLiv_Click(sender As Object, e As EventArgs) Handles btAtuLiv.Click


        Dim livro As New Livro()
        Dim uiLvLivros As New UiLvLivros(lvLivros)

        livro.SetCodLivro(edCodLiv.Text)
        livro.SetTitulo(edTituloLiv.Text)
        livro.SetAutor(edAutorLiv.Text)
        livro.SetEditora(edEditoraLiv.Text)
        livro.SetCategoria(edCategoriaLiv.Text)


        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbLivros As New DBLivros(myConn)

        Dim existeLivro = dbLivros.TemLivro(livro.GetCodLivro())
        dbConnect.Close()

        If existeLivro Then

            Dim resposta = MsgBox("Tem certeza que deseja atualizar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectAtu As New DBConnect()
                Dim myConnAtu = dbConnectAtu.Open()

                Dim dbLivrosAtu As New DBLivros(myConnAtu)
                Dim codigoRetorno = dbLivrosAtu.Atualizar(livro)
                dbConnectAtu.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Atualização realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvLivros.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbLivrosLst As New DBLivros(myConnLst)
                    Dim listaLivros = dbLivrosLst.ListarLivros()
                    For Each itemlista As Livro In listaLivros
                        uiLvLivros.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar atualização.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Tem certeza que deseja cadastrar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta1 = MsgBoxResult.Yes Then

                Dim dbConnectCad As New DBConnect()
                Dim myConnCad = dbConnectCad.Open()
                Dim dbLivrosCad As New DBLivros(myConnCad)
                Dim codRetorno1 = dbLivrosCad.Cadastrar(livro)
                dbConnectCad.Close()

                If codRetorno1 = 0 Then
                    uiLvLivros.Add(livro)
                    MsgBox("Cadastro realizado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                Else
                    MsgBox("Erro ao tentar efetuar cadastro.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If


            End If

        End If



    End Sub

    Private Sub btExcLiv_Click(sender As Object, e As EventArgs) Handles btExcLiv.Click


        Dim uiLvLivros As New UiLvLivros(lvLivros)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbLivros As New DBLivros(myConn)

        Dim existeLivro = dbLivros.TemLivro(edCodLiv.Text)
        dbConnect.Close()

        If existeLivro Then

            Dim resposta = MsgBox("Tem certeza que deseja excluir ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectExc As New DBConnect()
                Dim myConnExc = dbConnectExc.Open()

                Dim dbLivrosExc As New DBLivros(myConnExc)
                Dim codigoRetorno = dbLivrosExc.Excluir(edCodLiv.Text)
                dbConnectExc.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Exclusão realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvLivros.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbLivrosLst As New DBLivros(myConnLst)
                    Dim listaLivros = dbLivrosLst.ListarLivros()
                    For Each itemlista As Livro In listaLivros
                        uiLvLivros.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar exclusão.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Registro inexistente", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")


        End If


    End Sub

    Private Sub rbDevLiv_CheckedChanged(sender As Object, e As EventArgs) Handles rbDevLiv.CheckedChanged

        If rbEmpLiv.Checked = True Then
            edCodEmp.Enabled = True
        Else
            edCodEmp.Enabled = False
        End If

    End Sub

    Private Sub btConfirmaEmp_Click(sender As Object, e As EventArgs) Handles btConfirmaEmp.Click

        Dim empLivro As New EmpLivro()

        empLivro.SetRa(edRaEmp.Text)

        If rbEmpLiv.Checked = True Then
            empLivro.SetCodLivro(edCodEmp.Text)
        End If

        Dim codigoRetorno As New Integer()

        Dim dbConnectEmpLivros As New DBConnect()
        Dim myConnEmpLivros = dbConnectEmpLivros.Open()

        Dim dbEmpLivros As New DBEmpLivros(myConnEmpLivros)


        If rbEmpLiv.Checked = True Then
            codigoRetorno = dbEmpLivros.Emprestar(empLivro)
        Else
            codigoRetorno = dbEmpLivros.Devolver(empLivro)
        End If

        Dim resposta As New Integer()

        If codigoRetorno = 0 Then
            resposta = MsgBox("Operação realizada", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
        End If

        If codigoRetorno = 1 Then
            resposta = MsgBox("Ocorreu um erro ao tentar executar a operação.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

        If codigoRetorno = 2 And rbEmpLiv.Checked = True Then
            resposta = MsgBox("Livro não disponivel, já esta emprestado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

        If codigoRetorno = 2 And rbEmpLiv.Checked = False Then
            resposta = MsgBox("O aluno não possui livro emprestado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

        If codigoRetorno = 3 Then
            resposta = MsgBox("Aluno já tem um livro emprestado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

        If codigoRetorno = 4 Then
            resposta = MsgBox("Aluno não encontrado no sistema.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

        If codigoRetorno = 5 Then
            resposta = MsgBox("Livro não encontrado no sistema.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
        End If

    End Sub

    Private Sub btPesquisarAlu_Click(sender As Object, e As EventArgs) Handles btPesquisarAlu.Click

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()

        Dim dbAlunos As New DBAlunos(myConn)

        Dim aluno As New Aluno()

        aluno = dbAlunos.SelecionaAluno(edRaAluno.Text)

        edRaAluno.Text = aluno.GetRa()
        edNomeAlu.Text = aluno.GetNome()
        edDddAlu.Text = aluno.GetDdd()
        edTelefoneAlu.Text = aluno.GetTelefone()
        edEmailAlu.Text = aluno.GetEmail()
        dtpDataNascAlu.Value = aluno.GetDataNascimento()


    End Sub

    Private Sub btAtualizarAlu_Click(sender As Object, e As EventArgs) Handles btAtualizarAlu.Click


        Dim aluno As New Aluno()
        Dim uiLvAlunos As New UiLvAlunos(LvAlunos)

        aluno.SetNome(edNomeAlu.Text)
        aluno.SetRa(edRaAluno.Text)
        aluno.SetDdd(edDddAlu.Text)
        aluno.SetTelefone(edTelefoneAlu.Text)
        aluno.SetEmail(edEmailAlu.Text)
        aluno.SetDataNascimento(dtpDataNascAlu.Value)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbAlunos As New DBAlunos(myConn)

        Dim existeAluno = dbAlunos.TemAluno(aluno.GetRa())
        dbConnect.Close()

        If existeAluno Then

            Dim resposta = MsgBox("Tem certeza que deseja atualizar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectAtu As New DBConnect()
                Dim myConnAtu = dbConnectAtu.Open()

                Dim dbAlunosAtu As New DBAlunos(myConnAtu)
                Dim codigoRetorno = dbAlunosAtu.Atualizar(aluno)
                dbConnectAtu.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Atualização realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvAlunos.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbAlunosLst As New DBAlunos(myConnLst)
                    Dim listaAlunos = dbAlunosLst.ListarAlunos()
                    For Each itemlista As Aluno In listaAlunos
                        uiLvAlunos.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar atualização.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Tem certeza que deseja cadastrar ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta1 = MsgBoxResult.Yes Then

                Dim dbConnectCad As New DBConnect()
                Dim myConnCad = dbConnectCad.Open()
                Dim dbAlunosCad As New DBAlunos(myConnCad)
                Dim codRetorno1 = dbAlunosCad.Cadastrar(aluno)
                dbConnectCad.Close()

                If codRetorno1 = 0 Then
                    uiLvAlunos.Add(aluno)
                    MsgBox("Cadastro realizado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                Else
                    MsgBox("Erro ao tentar efetuar cadastro.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If


            End If

        End If


    End Sub

    Private Sub btExcluirAlu_Click_1(sender As Object, e As EventArgs) Handles btExcluirAlu.Click

        Dim uiLvAlunos As New UiLvAlunos(LvAlunos)

        Dim dbConnect As New DBConnect()
        Dim myConn = dbConnect.Open()
        Dim dbAlunos As New DBAlunos(myConn)

        Dim existeAluno = dbAlunos.TemAluno(edRaAluno.Text)
        dbConnect.Close()

        If existeAluno Then

            Dim resposta = MsgBox("Tem certeza que deseja excluir ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")

            If resposta = MsgBoxResult.Yes Then
                Dim dbConnectExc As New DBConnect()
                Dim myConnExc = dbConnectExc.Open()

                Dim dbAlunosExc As New DBAlunos(myConnExc)
                Dim codigoRetorno = dbAlunosExc.Excluir(edRaAluno.Text)
                dbConnectExc.Close()

                If codigoRetorno = 0 Then
                    MsgBox("Exclusão realizada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                    uiLvAlunos.Reset()

                    Dim dbConnectLst As New DBConnect()
                    Dim myConnLst = dbConnectLst.Open()

                    Dim dbAlunosLst As New DBAlunos(myConnLst)
                    Dim listaAlunos = dbAlunosLst.ListarAlunos()
                    For Each itemlista As Aluno In listaAlunos
                        uiLvAlunos.Add(itemlista)
                    Next
                Else
                    MsgBox("Erro ao tentar efetuar exclusão.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If

            End If


        Else
            Dim resposta1 = MsgBox("Registro inexistente", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")


        End If



    End Sub
End Class
