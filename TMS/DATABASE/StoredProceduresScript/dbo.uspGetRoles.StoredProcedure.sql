USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetRoles]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetRoles]
       @RoleName nvarchar(50) = null
       AS
BEGIN
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(500);
       SET @SQL = 'SELECT * FROM dbo.Role'
       IF @RoleName is not null
       BEGIN
              SET @SQL = @SQL + ' Where dbo.Role.RoleName = '''+@RoleName+''''
       END
       SET @SQL = @SQL + ' order by dbo.Role.RoleId'
       EXEC(@SQL);   
END
GO
