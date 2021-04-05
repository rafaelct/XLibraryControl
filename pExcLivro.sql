USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pExcLivro]    Script Date: 05-Apr-21 3:36:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pExcLivro] 
@codLivro int,
@codretorno tinyint output
as
begin

	set nocount on;
	
	begin try
		
		delete tbLivros where codLivro = @codLivro;
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

