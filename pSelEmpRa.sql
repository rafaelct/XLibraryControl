USE [biblioteca]
GO

/****** Object:  StoredProcedure [dbo].[pSelEmpRa]    Script Date: 05-Apr-21 11:51:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[pSelEmpRa]
@ra int
as
begin

	set nocount on;
	
	
		select ra from tbEmpLivros where ra = @ra;

end;


GO

