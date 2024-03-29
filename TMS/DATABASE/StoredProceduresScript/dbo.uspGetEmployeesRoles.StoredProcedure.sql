USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspGetEmployeesRoles] 
       @PageNum INT=1,
       @PageSize INT=5,
       @TotalRecords INT OUTPUT
AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
       SELECT @TotalRecords = COUNT(e.UserId) FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1;

       IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;

       With SortedEmployees AS 
       (
              SELECT ROW_NUMBER() OVER(ORDER BY e.UserId) as RowNum,
              e.UserId AS [User Id], 
              e.EmpName AS [Employee Name], 
              r.RoleName AS Role, 
              e.Email AS [Email ID], 
              e.Remark AS Remarks, 
              e.Password, 
              e.Pic, 
              e.RoleId, 
              e.IsActive
              FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId
              where e.IsActive = 1
       )
       SELECT Top(@RecordsToReturn) * FROM SortedEmployees 
              WHERE RowNum > (@PageNum-1) * @PageSize  

END

GO
