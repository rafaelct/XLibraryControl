USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pRelEmpLivro]    Script Date: 05-Apr-21 11:26:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pRelEmpLivro] 
as
begin

	set nocount on;
	
	
		select alunos.ra, alunos.nome, alunos.ddd, alunos.telefone, alunos.email, alunos.dataNascimento, 
		       livros.codLivro, livros.titulo, livros.autor, livros.editora, livros.categoria,
			   empLivros.dataRetirada,empLivros.dataEntrega
			   from tbAlunos alunos, tbLivros livros, tbEmpLivros empLivros 
			   where empLivros.ra = alunos.ra and empLivros.codLivro = livros.codLivro
end;


GO

