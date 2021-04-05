USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pExcAluno]    Script Date: 05-Apr-21 3:35:49 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pExcAluno] 
@ra int,
@codretorno tinyint output
as
begin

	set nocount on;
	
	begin try
		
		delete tbAlunos where ra = @ra
		set @codretorno = 0
		
	end try
	begin catch
		set @codretorno = 1	
	end catch

	return @codretorno

end;


GO

