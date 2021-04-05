USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pSelAluno]    Script Date: 05-Apr-21 3:36:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pSelAluno] 
@ra int
as
begin

	set nocount on;
	
	
		if @ra <> 0 select nome,ra,ddd,telefone,email,dataNascimento from tbAlunos where ra = @ra;
		else select nome,ra,ddd,telefone,email,dataNascimento from tbAlunos;

end;


GO

