USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetAssigneeBasedReport]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetAssigneeBasedReport] 
       @PageNum INT=1,
       @PageSize INT=5,
       @DateFrom DateTime,
       @DateTo DateTime,
       @RangeFlagChecked bit = 0,
       @UserId nvarchar(50) = null,
	   @TotalRecords INT = 0 OUTPUT
AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords =Count( dbo.WorkItem.WorkItemDescription) FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY SubTaskId) as SLNO,dbo.WorkItem.WorkItemDescription AS WorkItem
                        ,FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate
                        ,FORMAT(dbo.WorkItemAssignment.[HandOverOrClosedDate],''dd-MMM-yy hh:mm:ss'') AS EndDate
                        ,ISNULL(Status.StatusDescription,''Open'') AS Status
                        ,ISNULL(EmployeeAssigned.EmpName, ''Not Assigned'') AS [Assiged To]
                        ,ISNULL(EmployeeHandedOver.EmpName,''NA'') AS [HandedOver To]
                        FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1'
       IF @UserID is not null
       BEGIN
              SET @SQL = @SQL + ' and dbo.WorkItemAssignment.UserIdAssigned=''' + @UserId + ''' '
       END
       IF @RangeFlagChecked = 1
       BEGIN
              SET @SQL = @SQL + ' and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) Between ''' + FORMAT(@DateFrom, 'dd-MMM-yy') + ''' and ''' + FORMAT(@DateTo, 'dd-MMM-yy') + ''''
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       print @SQL;
	   EXEC(@SQL); 
END


GO
