USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pSelEmpLivro]    Script Date: 05-Apr-21 11:50:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pSelEmpLivro]
@codLivro int
as
begin

	set nocount on;
	
	
		select codLivro from tbEmpLivros where codLivro = @codLivro;

end;


GO

