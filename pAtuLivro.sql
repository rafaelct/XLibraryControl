USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pAtuLivro]    Script Date: 05-Apr-21 3:33:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pAtuLivro] 
@codLivro int,
@titulo varchar(200),
@autor varchar(100),
@editora varchar(100),
@categoria varchar(100),
@codretorno tinyint output
as
begin

	set nocount on;
	
	begin try
		
		update tbLivros set titulo = @titulo, autor = @autor, editora = @editora, categoria = @categoria where codLivro = @codLivro;
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

