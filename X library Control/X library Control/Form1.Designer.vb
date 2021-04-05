<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabAlu = New System.Windows.Forms.TabPage()
        Me.btPesquisarAlu = New System.Windows.Forms.Button()
        Me.btExcluirAlu = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpDataNascAlu = New System.Windows.Forms.DateTimePicker()
        Me.edDddAlu = New System.Windows.Forms.TextBox()
        Me.edEmailAlu = New System.Windows.Forms.TextBox()
        Me.edTelefoneAlu = New System.Windows.Forms.TextBox()
        Me.edNomeAlu = New System.Windows.Forms.TextBox()
        Me.edRaAluno = New System.Windows.Forms.TextBox()
        Me.LvAlunos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.btAtualizarAlu = New System.Windows.Forms.Button()
        Me.TabLiv = New System.Windows.Forms.TabPage()
        Me.btPesquisarLiv = New System.Windows.Forms.Button()
        Me.btExcLiv = New System.Windows.Forms.Button()
        Me.lvLivros = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.btAtuLiv = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.edEditoraLiv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.edCategoriaLiv = New System.Windows.Forms.TextBox()
        Me.edAutorLiv = New System.Windows.Forms.TextBox()
        Me.edTituloLiv = New System.Windows.Forms.TextBox()
        Me.edCodLiv = New System.Windows.Forms.TextBox()
        Me.tabEmpLiv = New System.Windows.Forms.TabPage()
        Me.btConfirmaEmp = New System.Windows.Forms.Button()
        Me.rbDevLiv = New System.Windows.Forms.RadioButton()
        Me.rbEmpLiv = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.edCodEmp = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.edRaEmp = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabAlu.SuspendLayout()
        Me.TabLiv.SuspendLayout()
        Me.tabEmpLiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAlu)
        Me.TabControl1.Controls.Add(Me.TabLiv)
        Me.TabControl1.Controls.Add(Me.tabEmpLiv)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(786, 426)
        Me.TabControl1.TabIndex = 0
        '
        'TabAlu
        '
        Me.TabAlu.Controls.Add(Me.btPesquisarAlu)
        Me.TabAlu.Controls.Add(Me.btExcluirAlu)
        Me.TabAlu.Controls.Add(Me.Label13)
        Me.TabAlu.Controls.Add(Me.Label14)
        Me.TabAlu.Controls.Add(Me.Label15)
        Me.TabAlu.Controls.Add(Me.Label16)
        Me.TabAlu.Controls.Add(Me.Label17)
        Me.TabAlu.Controls.Add(Me.dtpDataNascAlu)
        Me.TabAlu.Controls.Add(Me.edDddAlu)
        Me.TabAlu.Controls.Add(Me.edEmailAlu)
        Me.TabAlu.Controls.Add(Me.edTelefoneAlu)
        Me.TabAlu.Controls.Add(Me.edNomeAlu)
        Me.TabAlu.Controls.Add(Me.edRaAluno)
        Me.TabAlu.Controls.Add(Me.LvAlunos)
        Me.TabAlu.Controls.Add(Me.btAtualizarAlu)
        Me.TabAlu.Location = New System.Drawing.Point(4, 24)
        Me.TabAlu.Name = "TabAlu"
        Me.TabAlu.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAlu.Size = New System.Drawing.Size(778, 398)
        Me.TabAlu.TabIndex = 0
        Me.TabAlu.Text = "Alunos"
        Me.TabAlu.UseVisualStyleBackColor = True
        '
        'btPesquisarAlu
        '
        Me.btPesquisarAlu.Image = Global.X_library_Control.My.Resources.Resources.iconfinder_icon_ios7_search_strong_211817
        Me.btPesquisarAlu.Location = New System.Drawing.Point(269, 17)
        Me.btPesquisarAlu.Name = "btPesquisarAlu"
        Me.btPesquisarAlu.Size = New System.Drawing.Size(54, 53)
        Me.btPesquisarAlu.TabIndex = 1
        Me.btPesquisarAlu.UseVisualStyleBackColor = True
        '
        'btExcluirAlu
        '
        Me.btExcluirAlu.Image = Global.X_library_Control.My.Resources.Resources.iconfinder___Trash_Can_Delete_Remove__3844424
        Me.btExcluirAlu.Location = New System.Drawing.Point(691, 296)
        Me.btExcluirAlu.Name = "btExcluirAlu"
        Me.btExcluirAlu.Size = New System.Drawing.Size(64, 64)
        Me.btExcluirAlu.TabIndex = 9
        Me.btExcluirAlu.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(467, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Data de nascimento:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(52, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "E-mail:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(467, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 15)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Telefone:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(52, 76)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 15)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Nome:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(52, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 15)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "RA:"
        '
        'dtpDataNascAlu
        '
        Me.dtpDataNascAlu.CustomFormat = "dd/MM/yyyy"
        Me.dtpDataNascAlu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataNascAlu.Location = New System.Drawing.Point(593, 123)
        Me.dtpDataNascAlu.Name = "dtpDataNascAlu"
        Me.dtpDataNascAlu.Size = New System.Drawing.Size(106, 23)
        Me.dtpDataNascAlu.TabIndex = 7
        '
        'edDddAlu
        '
        Me.edDddAlu.Location = New System.Drawing.Point(528, 76)
        Me.edDddAlu.MaxLength = 2
        Me.edDddAlu.Name = "edDddAlu"
        Me.edDddAlu.Size = New System.Drawing.Size(47, 23)
        Me.edDddAlu.TabIndex = 4
        '
        'edEmailAlu
        '
        Me.edEmailAlu.Location = New System.Drawing.Point(110, 123)
        Me.edEmailAlu.MaxLength = 80
        Me.edEmailAlu.Name = "edEmailAlu"
        Me.edEmailAlu.Size = New System.Drawing.Size(234, 23)
        Me.edEmailAlu.TabIndex = 6
        '
        'edTelefoneAlu
        '
        Me.edTelefoneAlu.Location = New System.Drawing.Point(581, 76)
        Me.edTelefoneAlu.MaxLength = 9
        Me.edTelefoneAlu.Name = "edTelefoneAlu"
        Me.edTelefoneAlu.Size = New System.Drawing.Size(118, 23)
        Me.edTelefoneAlu.TabIndex = 5
        '
        'edNomeAlu
        '
        Me.edNomeAlu.Location = New System.Drawing.Point(110, 76)
        Me.edNomeAlu.MaxLength = 100
        Me.edNomeAlu.Name = "edNomeAlu"
        Me.edNomeAlu.Size = New System.Drawing.Size(319, 23)
        Me.edNomeAlu.TabIndex = 3
        '
        'edRaAluno
        '
        Me.edRaAluno.Location = New System.Drawing.Point(110, 31)
        Me.edRaAluno.MaxLength = 8
        Me.edRaAluno.Name = "edRaAluno"
        Me.edRaAluno.Size = New System.Drawing.Size(146, 23)
        Me.edRaAluno.TabIndex = 0
        '
        'LvAlunos
        '
        Me.LvAlunos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LvAlunos.HideSelection = False
        Me.LvAlunos.Location = New System.Drawing.Point(23, 173)
        Me.LvAlunos.Name = "LvAlunos"
        Me.LvAlunos.Size = New System.Drawing.Size(651, 196)
        Me.LvAlunos.TabIndex = 31
        Me.LvAlunos.UseCompatibleStateImageBehavior = False
        Me.LvAlunos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "RA"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telefone"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "E-mail"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Data de nascimento"
        '
        'btAtualizarAlu
        '
        Me.btAtualizarAlu.Image = Global.X_library_Control.My.Resources.Resources.iconfinder_floppy_285657
        Me.btAtualizarAlu.Location = New System.Drawing.Point(691, 226)
        Me.btAtualizarAlu.Name = "btAtualizarAlu"
        Me.btAtualizarAlu.Size = New System.Drawing.Size(64, 64)
        Me.btAtualizarAlu.TabIndex = 8
        Me.btAtualizarAlu.UseVisualStyleBackColor = True
        '
        'TabLiv
        '
        Me.TabLiv.Controls.Add(Me.btPesquisarLiv)
        Me.TabLiv.Controls.Add(Me.btExcLiv)
        Me.TabLiv.Controls.Add(Me.lvLivros)
        Me.TabLiv.Controls.Add(Me.btAtuLiv)
        Me.TabLiv.Controls.Add(Me.Label6)
        Me.TabLiv.Controls.Add(Me.edEditoraLiv)
        Me.TabLiv.Controls.Add(Me.Label8)
        Me.TabLiv.Controls.Add(Me.Label7)
        Me.TabLiv.Controls.Add(Me.Label9)
        Me.TabLiv.Controls.Add(Me.Label10)
        Me.TabLiv.Controls.Add(Me.edCategoriaLiv)
        Me.TabLiv.Controls.Add(Me.edAutorLiv)
        Me.TabLiv.Controls.Add(Me.edTituloLiv)
        Me.TabLiv.Controls.Add(Me.edCodLiv)
        Me.TabLiv.Location = New System.Drawing.Point(4, 24)
        Me.TabLiv.Name = "TabLiv"
        Me.TabLiv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLiv.Size = New System.Drawing.Size(778, 398)
        Me.TabLiv.TabIndex = 1
        Me.TabLiv.Text = "Livros"
        Me.TabLiv.UseVisualStyleBackColor = True
        '
        'btPesquisarLiv
        '
        Me.btPesquisarLiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btPesquisarLiv.Image = Global.X_library_Control.My.Resources.Resources.iconfinder_icon_ios7_search_strong_211817
        Me.btPesquisarLiv.Location = New System.Drawing.Point(267, 12)
        Me.btPesquisarLiv.Name = "btPesquisarLiv"
        Me.btPesquisarLiv.Size = New System.Drawing.Size(53, 54)
        Me.btPesquisarLiv.TabIndex = 11
        Me.btPesquisarLiv.UseVisualStyleBackColor = True
        '
        'btExcLiv
        '
        Me.btExcLiv.Image = Global.X_library_Control.My.Resources.Resources.iconfinder___Trash_Can_Delete_Remove__3844424
        Me.btExcLiv.Location = New System.Drawing.Point(700, 291)
        Me.btExcLiv.Name = "btExcLiv"
        Me.btExcLiv.Size = New System.Drawing.Size(64, 64)
        Me.btExcLiv.TabIndex = 17
        Me.btExcLiv.UseVisualStyleBackColor = True
        '
        'lvLivros
        '
        Me.lvLivros.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvLivros.HideSelection = False
        Me.lvLivros.Location = New System.Drawing.Point(42, 199)
        Me.lvLivros.Name = "lvLivros"
        Me.lvLivros.Size = New System.Drawing.Size(651, 196)
        Me.lvLivros.TabIndex = 42
        Me.lvLivros.UseCompatibleStateImageBehavior = False
        Me.lvLivros.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "RA"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Nome"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Telefone"
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "E-mail"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Data de nascimento"
        '
        'btAtuLiv
        '
        Me.btAtuLiv.Image = Global.X_library_Control.My.Resources.Resources.iconfinder_floppy_285657
        Me.btAtuLiv.Location = New System.Drawing.Point(700, 221)
        Me.btAtuLiv.Name = "btAtuLiv"
        Me.btAtuLiv.Size = New System.Drawing.Size(64, 64)
        Me.btAtuLiv.TabIndex = 16
        Me.btAtuLiv.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(466, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Editora:"
        '
        'edEditoraLiv
        '
        Me.edEditoraLiv.Location = New System.Drawing.Point(516, 124)
        Me.edEditoraLiv.Name = "edEditoraLiv"
        Me.edEditoraLiv.Size = New System.Drawing.Size(177, 23)
        Me.edEditoraLiv.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(466, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Autor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(46, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Categoria:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(46, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Titulo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(46, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 15)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Cod.:"
        '
        'edCategoriaLiv
        '
        Me.edCategoriaLiv.Location = New System.Drawing.Point(115, 124)
        Me.edCategoriaLiv.Name = "edCategoriaLiv"
        Me.edCategoriaLiv.Size = New System.Drawing.Size(223, 23)
        Me.edCategoriaLiv.TabIndex = 14
        '
        'edAutorLiv
        '
        Me.edAutorLiv.Location = New System.Drawing.Point(516, 77)
        Me.edAutorLiv.Name = "edAutorLiv"
        Me.edAutorLiv.Size = New System.Drawing.Size(177, 23)
        Me.edAutorLiv.TabIndex = 13
        '
        'edTituloLiv
        '
        Me.edTituloLiv.Location = New System.Drawing.Point(115, 77)
        Me.edTituloLiv.Name = "edTituloLiv"
        Me.edTituloLiv.Size = New System.Drawing.Size(319, 23)
        Me.edTituloLiv.TabIndex = 12
        '
        'edCodLiv
        '
        Me.edCodLiv.Location = New System.Drawing.Point(115, 32)
        Me.edCodLiv.Name = "edCodLiv"
        Me.edCodLiv.Size = New System.Drawing.Size(146, 23)
        Me.edCodLiv.TabIndex = 10
        '
        'tabEmpLiv
        '
        Me.tabEmpLiv.Controls.Add(Me.btConfirmaEmp)
        Me.tabEmpLiv.Controls.Add(Me.rbDevLiv)
        Me.tabEmpLiv.Controls.Add(Me.rbEmpLiv)
        Me.tabEmpLiv.Controls.Add(Me.Label12)
        Me.tabEmpLiv.Controls.Add(Me.edCodEmp)
        Me.tabEmpLiv.Controls.Add(Me.Label11)
        Me.tabEmpLiv.Controls.Add(Me.edRaEmp)
        Me.tabEmpLiv.Location = New System.Drawing.Point(4, 24)
        Me.tabEmpLiv.Name = "tabEmpLiv"
        Me.tabEmpLiv.Size = New System.Drawing.Size(778, 398)
        Me.tabEmpLiv.TabIndex = 2
        Me.tabEmpLiv.Text = "Emprestimo de livros"
        Me.tabEmpLiv.UseVisualStyleBackColor = True
        '
        'btConfirmaEmp
        '
        Me.btConfirmaEmp.Image = Global.X_library_Control.My.Resources.Resources.iconfinder_floppy_285657
        Me.btConfirmaEmp.Location = New System.Drawing.Point(287, 131)
        Me.btConfirmaEmp.Name = "btConfirmaEmp"
        Me.btConfirmaEmp.Size = New System.Drawing.Size(64, 64)
        Me.btConfirmaEmp.TabIndex = 22
        Me.btConfirmaEmp.UseVisualStyleBackColor = True
        '
        'rbDevLiv
        '
        Me.rbDevLiv.AutoSize = True
        Me.rbDevLiv.Location = New System.Drawing.Point(177, 39)
        Me.rbDevLiv.Name = "rbDevLiv"
        Me.rbDevLiv.Size = New System.Drawing.Size(97, 19)
        Me.rbDevLiv.TabIndex = 19
        Me.rbDevLiv.Text = "Devolver livro"
        Me.rbDevLiv.UseVisualStyleBackColor = True
        '
        'rbEmpLiv
        '
        Me.rbEmpLiv.AutoSize = True
        Me.rbEmpLiv.Checked = True
        Me.rbEmpLiv.Location = New System.Drawing.Point(44, 39)
        Me.rbEmpLiv.Name = "rbEmpLiv"
        Me.rbEmpLiv.Size = New System.Drawing.Size(104, 19)
        Me.rbEmpLiv.TabIndex = 18
        Me.rbEmpLiv.TabStop = True
        Me.rbEmpLiv.Text = "Emprestar livro"
        Me.rbEmpLiv.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(44, 153)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 15)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Cod.:"
        '
        'edCodEmp
        '
        Me.edCodEmp.Location = New System.Drawing.Point(100, 153)
        Me.edCodEmp.Name = "edCodEmp"
        Me.edCodEmp.Size = New System.Drawing.Size(146, 23)
        Me.edCodEmp.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(42, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(26, 15)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "RA:"
        '
        'edRaEmp
        '
        Me.edRaEmp.Location = New System.Drawing.Point(100, 92)
        Me.edRaEmp.MaxLength = 8
        Me.edRaEmp.Name = "edRaEmp"
        Me.edRaEmp.Size = New System.Drawing.Size(146, 23)
        Me.edRaEmp.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "X Library Control"
        Me.TabControl1.ResumeLayout(False)
        Me.TabAlu.ResumeLayout(False)
        Me.TabAlu.PerformLayout()
        Me.TabLiv.ResumeLayout(False)
        Me.TabLiv.PerformLayout()
        Me.tabEmpLiv.ResumeLayout(False)
        Me.tabEmpLiv.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabAlu As TabPage
    Friend WithEvents TabLiv As TabPage
    Friend WithEvents tabEmpLiv As TabPage
    Friend WithEvents btExcLiv As Button
    Friend WithEvents lvLivros As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btAtuLiv As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents edEditoraLiv As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents edCategoriaLiv As TextBox
    Friend WithEvents edAutorLiv As TextBox
    Friend WithEvents edTituloLiv As TextBox
    Friend WithEvents edCodLiv As TextBox
    Friend WithEvents btPesquisarLiv As Button
    Friend WithEvents rbDevLiv As RadioButton
    Friend WithEvents rbEmpLiv As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents edCodEmp As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents edRaEmp As TextBox
    Friend WithEvents btConfirmaEmp As Button
    Friend WithEvents btPesquisarAlu As Button
    Friend WithEvents btExcluirAlu As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents dtpDataNascAlu As DateTimePicker
    Friend WithEvents edDddAlu As TextBox
    Friend WithEvents edEmailAlu As TextBox
    Friend WithEvents edTelefoneAlu As TextBox
    Friend WithEvents edNomeAlu As TextBox
    Friend WithEvents edRaAluno As TextBox
    Friend WithEvents LvAlunos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents btAtualizarAlu As Button
End Class
