USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pSelLivro]    Script Date: 05-Apr-21 3:36:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pSelLivro] 
@codLivro int
as
begin

	set nocount on;
	
	
		if @codLivro <> 0 select codLivro,titulo,autor,editora,categoria from tbLivros where codLivro = @codLivro;
		else select codLivro,titulo,autor,editora,categoria from tbLivros

end;


GO

