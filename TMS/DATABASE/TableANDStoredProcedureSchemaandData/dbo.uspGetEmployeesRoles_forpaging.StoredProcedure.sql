USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles_forpaging]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetEmployeesRoles_forpaging] 
      @page int,
	  @PageSize nvarchar(50)=2
AS
BEGIN
       SET NOCOUNT ON;
	    DECLARE @SQL VARCHAR(5000);
		 DECLARE @SQL_P VARCHAR(5000);
		DECLARE @PreviouspageLimit nvarchar(50);
		SET @PreviouspageLimit = (@page - 1) * @PageSize;

		 SET @SQL ='SELECT  TOP ' + @PageSize  + ' e.UserId AS [User Id], e.EmpName AS [Employee Name], r.RoleName AS Role, e.Email AS [Email ID], e.Remark AS Remarks, e.Password, e.Pic, e.RoleId, e.IsActive
                     FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1'
					  --print @SQL;

	   IF @page!=1
	   BEGIN
	        SET @SQL_P='SELECT  TOP ' + @PreviouspageLimit + ' e.UserId FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1'
	        SET @SQL = @SQL + ' and e.UserId NOT IN   (' + @SQL_P  +')'
	   END
	   --print @SQL;
	    exec(@SQL);
	 
	 
	   
      
END
GO
