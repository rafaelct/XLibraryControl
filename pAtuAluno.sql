USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pAtuAluno]    Script Date: 05-Apr-21 3:31:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pAtuAluno] 
@ra int,
@nome varchar(100),
@ddd int,
@telefone int,
@email varchar(100),
@dataNascimento datetime,
@codretorno int output
as
begin

	set nocount on;
	
	begin try
		
		update tbAlunos set nome = @nome, ddd = @ddd, telefone = @telefone, email = @email, dataNascimento = @dataNascimento where ra = @ra;

		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

