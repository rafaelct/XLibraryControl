USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pDevEmpLivro]    Script Date: 05-Apr-21 3:35:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pDevEmpLivro] 
@ra int,
@codretorno tinyint output
as
begin

	set nocount on;
	
	DECLARE @existeAluno int;
	DECLARE @codEmpLivro int;

		-- Verifica se existe aluno cadastrado com o RA informado
	select @existeAluno = ra from tbAlunos where ra = @ra

	if ( @existeAluno is null ) 
	begin
		set @codretorno = 4; 
		return @codretorno;
	end ;


	-- Verifica se o aluno tem algum livro empresta que não foi entregue
	select @codEmpLivro = codEmpLivro from tbEmpLivros where ra = @ra and dataEntrega is null;

	-- se codEmpLivro for nulo então aluno não tem livro emprestado
	if ( @codEmpLivro is null ) 
	begin
	set @codretorno = 2; 
	return @codretorno;
	end ;

	begin try
		
		update tbEmpLivros set dataEntrega = GETDATE() where codEmpLivro = @codEmpLivro;
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

