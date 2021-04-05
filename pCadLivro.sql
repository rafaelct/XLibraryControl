USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pCadLivro]    Script Date: 05-Apr-21 3:34:55 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pCadLivro] 
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
		
		insert into tbLivros (codLivro,titulo,autor,editora,categoria) values (@codLivro,@titulo,@autor,@editora,@categoria);
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

