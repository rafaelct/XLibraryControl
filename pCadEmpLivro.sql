USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pCadEmpLivro]    Script Date: 05-Apr-21 3:34:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pCadEmpLivro] 
@ra int,
@codLivro int,
@codretorno tinyint output
as
begin

	set nocount on;
	
	DECLARE @existeAluno int
	DECLARE @existeLivro int
	DECLARE @livroDisponivel int;
	DECLARE @raEmpLivro int;

	-- Verifica se existe aluno cadastrado com o RA informado
	select @existeAluno = ra from tbAlunos where ra = @ra

	if ( @existeAluno is null ) 
	begin
		set @codretorno = 4; 
		return @codretorno;
	end ;

	-- Verifica se existe o livro cadastrado
	select @existeLivro = codLivro from tbLivros where codLivro = @codLivro;
	
	if ( @existeLivro is null ) 
	begin
		set @codretorno = 5; 
		return @codretorno;
	end ;

	

	-- Verifica se o cod do livro solicitado está disponivel para emprestimo
	select  @livroDisponivel = codLivro from tbEmpLivros where codLivro = @codLivro and dataEntrega is null;

	-- se livroDisponivel não for nulo então ele está emprestado
	if ( @livroDisponivel is not null ) 
	begin
		set @codretorno = 2; 
		return @codretorno;
	end ;

	-- Verifica se o aluno já tem algum livro emprestado
	select @raEmpLivro = ra from tbEmpLivros where ra = @ra and dataEntrega is null;
	
	-- se raEmpLivro não for null então o aluno já tem um livro emprestado
	if ( @raEmpLivro is not null ) 
	begin
		set @codretorno = 3; 
		return @codretorno
	end ;

	begin try
		
		insert into tbEmpLivros(ra,codLivro,dataRetirada) values (@ra,@codLivro,GETDATE() );
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

