USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployees]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetEmployees]
       @UserId nvarchar(50) = null,
       @IsActive int 
       AS
BEGIN
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'SELECT UserId, EmpName FROM dbo.Employee where 1=1'
       IF @UserId is not null 
       BEGIN
              SET @SQL = @SQL + ' and dbo.Employee.UserId = '''+@UserId+''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.Employee.IsActive = 1'
       END
       EXEC(@SQL);   
END
GO
