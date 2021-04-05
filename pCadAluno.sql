USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pCadAluno]    Script Date: 05-Apr-21 3:33:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pCadAluno] 
@ra int,
@nome varchar(100),
@ddd int,
@telefone int,
@email varchar(100),
@dataNascimento datetime,
@codretorno tinyint output
as
begin

	set nocount on;
	
	begin try
		
		insert into tbAlunos (nome,ra,ddd,telefone,email,dataNascimento) values (@nome,@ra,@ddd,@telefone,@email,@dataNascimento);
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

