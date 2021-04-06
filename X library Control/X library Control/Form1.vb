Imports System.IO

Public Class Form1
    Private Sub TabCadLiv_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edRaAluno.KeyPress, edDddAlu.KeyPress, edTelefoneAlu.KeyPress, edCodLiv.KeyPress, edRaEmp.KeyPress, edCodEmp.KeyPress

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

        If edCodLiv.Text = "" Then
            MsgBox("Cod. do livro deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If


        Dim dbConnectExiste As New DBConnect()
        Dim myConnExiste = dbConnectExiste.Open()

        Dim dbLivrosExiste As New DBLivros(myConnExiste)

        If dbLivrosExiste.TemLivro(edCodLiv.Text) = False Then
            MsgBox("Livro não encontrado", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            dbConnectExiste.Close()
            Return
        End If

        dbConnectExiste.Close()

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

        If edCodLiv.Text = "" Then
            MsgBox("Cod. do livro deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edTituloLiv.Text = "" Then
            MsgBox("Titulo do livro deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edTituloLiv.TextLength = 1 Then
            MsgBox("Titulo não pode ter apenas 1 letra.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ApenasLetras(edTituloLiv.Text) = False Then
            MsgBox("Campo titulo só pode ter letras.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edAutorLiv.Text = "" Then
            MsgBox("Nome do autor deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edAutorLiv.TextLength = 1 Then
            MsgBox("Autor não pode ter apenas 1 letra.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ApenasLetras(edAutorLiv.Text) = False Then
            MsgBox("Campo autor só pode ter letras.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edEditoraLiv.Text = "" Then
            MsgBox("Editora deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edEditoraLiv.TextLength = 1 Then
            MsgBox("Editora não pode ter apenas 1 letra.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ApenasLetras(edEditoraLiv.Text) = False Then
            MsgBox("Campo editora só pode ter letras.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edCategoriaLiv.Text = "" Then
            MsgBox("Categoria deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edCategoriaLiv.TextLength = 1 Then
            MsgBox("Categoria não pode ter apenas 1 letra.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ApenasLetras(edCategoriaLiv.Text) = False Then
            MsgBox("Campo categoria só pode ter letras.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If


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

        edCodLiv.Text = ""
        edAutorLiv.Text = ""
        edEditoraLiv.Text = ""
        edCategoriaLiv.Text = ""


    End Sub

    Private Sub btExcLiv_Click(sender As Object, e As EventArgs) Handles btExcLiv.Click

        If edCodLiv.Text = "" Then
            MsgBox("Cod. do livro deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If


        Dim dbConnectTemEmpLivro As New DBConnect()
        Dim myConnTemEmpLivro = dbConnectTemEmpLivro.Open()
        Dim dbEmpLivros As New DBEmpLivros(myConnTemEmpLivro)
        Dim temEmpLivro = dbEmpLivros.TemLivro(edCodLiv.Text)
        dbConnectTemEmpLivro.Close()

        If temEmpLivro = True Then
            MsgBox("Não é possivel excluir um livro que já tenha sido emprestado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical Or MsgBoxStyle.SystemModal, "Mensagem")
            Return
        End If



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

        edCodLiv.Text = ""
        edAutorLiv.Text = ""
        edEditoraLiv.Text = ""
        edCategoriaLiv.Text = ""

    End Sub

    Private Sub rbDevLiv_CheckedChanged(sender As Object, e As EventArgs) Handles rbDevLiv.CheckedChanged

        If rbEmpLiv.Checked = True Then
            edCodEmp.Enabled = True
        Else
            edCodEmp.Enabled = False
        End If

    End Sub

    Private Sub btConfirmaEmp_Click(sender As Object, e As EventArgs) Handles btConfirmaEmp.Click

        If edRaEmp.Text = "" Then
            MsgBox("RA do aluno deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edCodEmp.Text = "" And rbEmpLiv.Checked = True Then
            MsgBox("Cod. do livro deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        Dim limpaCampos As Boolean
        limpaCampos = False


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
            limpaCampos = True
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

        If limpaCampos = True Then
            edRaEmp.Text = ""
            edCodEmp.Text = ""
        End If

    End Sub

    Private Sub btPesquisarAlu_Click(sender As Object, e As EventArgs) Handles btPesquisarAlu.Click

        If edRaAluno.Text = "" Then
            MsgBox("RA do aluno deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edRaAluno.TextLength <> 8 Then
            MsgBox("RA do aluno deve ter 8 digitos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If



        Dim dbConnectExiste As New DBConnect()
        Dim myConnExiste = dbConnectExiste.Open()

        Dim dbAlunosExiste As New DBAlunos(myConnExiste)




        If dbAlunosExiste.TemAluno(edRaAluno.Text) = False Then
            MsgBox("Aluno não encontrado", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            dbConnectExiste.Close()
            Return
        End If

        dbConnectExiste.Close()

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

        If edRaAluno.Text = "" Then
            MsgBox("RA do aluno deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edRaAluno.TextLength <> 8 Then
            MsgBox("RA do aluno deve ter 8 digitos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edNomeAlu.Text = "" Then
            MsgBox("Nome do aluno deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edNomeAlu.TextLength = 1 Then
            MsgBox("Nome não pode ter apenas 1 letra.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ApenasLetras(edNomeAlu.Text) = False Then
            MsgBox("Campo nome só pode ter letras.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edDddAlu.Text = "" Then
            MsgBox("DDD deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edDddAlu.TextLength <> 2 Then
            MsgBox("DDD precisa ter 2 digitos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edTelefoneAlu.Text = "" Then
            MsgBox("Telefone deve ser preenchido", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edTelefoneAlu.TextLength <> 9 Then
            MsgBox("Telefone precisa ter 9 digitos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edEmailAlu.Text = "" Then
            MsgBox("E-mail deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If ValidaCampos.ValidaEmail(edEmailAlu.Text) = False Then
            MsgBox("E-mail invalido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        Dim limpaCampos As Boolean
        limpaCampos = False

        Dim dataAtual As Date = Now

        Dim contaDias = DateDiff(DateInterval.Day, dtpDataNascAlu.Value, dataAtual)

        ' O aluno deve ter no minimo 4 anos de idade para ser cadastrado no sistema
        If contaDias < 1460 Then
            MsgBox("Data de nascimento não pode ser menor que 4 anos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If


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

                    limpaCampos = True

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

                    limpaCampos = True
                    MsgBox("Cadastro realizado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")
                Else
                    MsgBox("Erro ao tentar efetuar cadastro.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
                End If


            End If

        End If


        If limpaCampos = True Then
            edRaAluno.Text = ""
            edNomeAlu.Text = ""
            edDddAlu.Text = ""
            edTelefoneAlu.Text = ""
            edEmailAlu.Text = ""
            dtpDataNascAlu.Value = dataAtual
        End If

    End Sub

    Private Sub btExcluirAlu_Click_1(sender As Object, e As EventArgs) Handles btExcluirAlu.Click

        If edRaAluno.Text = "" Then
            MsgBox("RA do aluno deve ser preenchido.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        If edRaAluno.TextLength <> 8 Then
            MsgBox("RA do aluno deve ter 8 digitos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If

        Dim dbConnectTemEmpAluno As New DBConnect()
        Dim myConnTemEmpAluno = dbConnectTemEmpAluno.Open()
        Dim dbEmpLivros As New DBEmpLivros(myConnTemEmpAluno)
        Dim temEmpAluno = dbEmpLivros.TemAluno(edRaAluno.Text)
        dbConnectTemEmpAluno.Close()

        If temEmpAluno = True Then
            MsgBox("Não é possivel excluir um aluno que tenha emprestado livro.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Mensagem")
            Return
        End If


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

        Dim dataAtual As Date = Now

        edRaAluno.Text = ""
        edNomeAlu.Text = ""
        edDddAlu.Text = ""
        edTelefoneAlu.Text = ""
        edEmailAlu.Text = ""
        dtpDataNascAlu.Value = dataAtual


    End Sub

    Private Sub btRelAlu_Click(sender As Object, e As EventArgs) Handles btRelAlu.Click

        Dim arquivo As System.IO.StreamWriter

        Try




            Dim sfd As New SaveFileDialog()
            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"

            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then

                MessageBox.Show(sfd.FileName)


                arquivo = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, False)



                Dim dbConnect As New DBConnect()
                Dim myConn = dbConnect.Open()

                Dim dbAlunos As New DBAlunos(myConn)

                Dim listaAlunos As New List(Of Aluno)

                listaAlunos = dbAlunos.ListarAlunos()

                arquivo.WriteLine("RA;NOME;DDD;TELEFONE;E-MAIL;DATA DE NASCIMENTO")

                For Each aluno As Aluno In listaAlunos
                    Dim linha As String
                    linha = aluno.GetRa().ToString + ";" + aluno.GetNome() + ";" + aluno.GetDdd().ToString + ";" + aluno.GetTelefone().ToString + ";" + aluno.GetEmail() + ";" + aluno.GetDataNascimento()
                    arquivo.WriteLine(linha)
                Next

                arquivo.Close()

                MsgBox("Relatorio de alunos gerado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")


            End If

        Catch ex As IOException
            MsgBox("Erro de entrada e saida ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        Catch ex As Exception
            MsgBox("Erro desconhecido ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        End Try




    End Sub

    Private Sub btRelLiv_Click(sender As Object, e As EventArgs) Handles btRelLiv.Click

        Dim arquivo As System.IO.StreamWriter

        Try

            Dim sfd As New SaveFileDialog()
            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"

            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then

                MessageBox.Show(sfd.FileName)


                arquivo = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, False)



                Dim dbConnect As New DBConnect()
                Dim myConn = dbConnect.Open()

                Dim dbLivros As New DBLivros(myConn)

                Dim listaLivros As New List(Of Livro)

                listaLivros = dbLivros.ListarLivros()

                arquivo.WriteLine("COD. LIVRO;TITULO;AUTOR;EDITORA;CATEGORIA")

                For Each livro As Livro In listaLivros
                    Dim linha As String
                    linha = livro.GetCodLivro().ToString + ";" + livro.GetTitulo() + ";" + livro.GetAutor().ToString + ";" + livro.GetEditora().ToString + ";" + livro.GetCategoria()
                    arquivo.WriteLine(linha)
                Next

                arquivo.Close()

                MsgBox("Relatorio de livros gerado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")





            End If

        Catch ex As IOException
            MsgBox("Erro de entrada e saida ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        Catch ex As Exception
            MsgBox("Erro desconhecido ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        End Try

    End Sub

    Private Sub btRelEmp_Click(sender As Object, e As EventArgs) Handles btRelEmp.Click

        Dim arquivo As System.IO.StreamWriter

        Try

            Dim sfd As New SaveFileDialog()
            sfd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"

            If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then

                MessageBox.Show(sfd.FileName)


                arquivo = My.Computer.FileSystem.OpenTextFileWriter(sfd.FileName, False)



                Dim dbConnect As New DBConnect()
                Dim myConn = dbConnect.Open()

                Dim dbEmpLivros As New DBEmpLivros(myConn)

                Dim listaEmpLivros As New List(Of EmpRel)

                listaEmpLivros = dbEmpLivros.ListarEmpLivros()

                arquivo.WriteLine("RA;NOME;DDD;TELEFONE;E-MAIL;DATA DE NASCIMENTO;COD. LIVRO;TITULO;AUTOR;EDITORA;CATEGORIA;DATA DE RETIRADA;DATA DE ENTREGA")

                For Each empRel As EmpRel In listaEmpLivros
                    Dim linha As String

                    If empRel.GetDataEntregaTemNulo() = False Then
                        linha = empRel.GetRa().ToString + ";" + empRel.GetNome() + ";" + empRel.GetDdd().ToString + ";" + empRel.GetTelefone().ToString + ";" + empRel.GetEmail() + ";" + empRel.GetDataNascimento() + ";" + empRel.GetCodLivro().ToString + ";" + empRel.GetTitulo() + ";" + empRel.GetAutor().ToString + ";" + empRel.GetEditora().ToString + ";" + empRel.GetCategoria() + ";" + empRel.GetDataRetirada() + ";" + empRel.GetDataEntrega()
                    Else
                        linha = empRel.GetRa().ToString + ";" + empRel.GetNome() + ";" + empRel.GetDdd().ToString + ";" + empRel.GetTelefone().ToString + ";" + empRel.GetEmail() + ";" + empRel.GetDataNascimento() + ";" + empRel.GetCodLivro().ToString + ";" + empRel.GetTitulo() + ";" + empRel.GetAutor().ToString + ";" + empRel.GetEditora().ToString + ";" + empRel.GetCategoria() + ";" + empRel.GetDataRetirada() + ";"
                    End If

                    arquivo.WriteLine(linha)
                Next

                arquivo.Close()

                MsgBox("Relatorio de emprestimos gerado.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Mensagem")





            End If

        Catch ex As IOException
            MsgBox("Erro de entrada e saida ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        Catch ex As Exception
            MsgBox("Erro desconhecido ao tentar gravar relatorio.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Information, "Mensagem")
            arquivo.Close()
        End Try


    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged

    End Sub
End Class
