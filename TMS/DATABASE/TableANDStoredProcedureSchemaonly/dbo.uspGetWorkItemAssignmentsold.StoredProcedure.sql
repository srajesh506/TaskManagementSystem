USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItemAssignmentsold]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetWorkItemAssignmentsold]
         @PageNum INT=1,
       @PageSize INT=5,
       @FilterFlag int,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords = Count(dbo.WorkItemAssignment.WorkItemAssignmentId) FROM dbo.WorkItemAssignment INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId 
                 INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = dbo.Status.StatusId 
                 LEFT OUTER JOIN dbo.Employee as AssignedTo ON dbo.WorkItemAssignment.UserIdAssigned = AssignedTo.UserId
                 LEFT OUTER JOIN dbo.Employee as HandedOverFrom ON dbo.WorkItemAssignment.UserIdHandedover = HandedOverFrom.UserId
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY dbo.WorkItemAssignment.StartDate DESC)SLNO,dbo.WorkItemAssignment.WorkItemAssignmentId as Id, 
                 dbo.WorkItemAssignment.WorkItemId as WorkItemId, 
                 dbo.WorkItem.WorkItemDescription as WorkItem, 
                 ISNULL(dbo.Status.StatusDescription,''--Choose--\'')  as Status,
                 ISNULL(AssignedTo.EmpName,''--Choose--'')  as AssignedTo,
                 FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate, 
                 FORMAT(dbo.WorkItemAssignment.HandOverOrClosedDate,''dd-MMM-yy hh:mm:ss'') as ClosedDate, 
                 ISNULL(HandedOverFrom.EmpName,''NA'')  as HandOverTo,
                 dbo.WorkItemAssignment.Remarks as Remarks
                 FROM 
                 dbo.WorkItemAssignment INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId 
                 INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = dbo.Status.StatusId 
                 LEFT OUTER JOIN dbo.Employee as AssignedTo ON dbo.WorkItemAssignment.UserIdAssigned = AssignedTo.UserId
                 LEFT OUTER JOIN dbo.Employee as HandedOverFrom ON dbo.WorkItemAssignment.UserIdHandedover = HandedOverFrom.UserId'
       IF @FilterFlag = 1
       BEGIN
              SET @SQL = @SQL + ' Where dbo.WorkItemAssignment.Status not in (5,6) and  dbo.WorkItemAssignment.HandOverOrClosedDate is null' 
       END
       --SET @SQL = @SQL + ' Order BY dbo.WorkItemAssignment.StartDate'
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
	  --SET @SQL=@SQL + ' order by Id Desc'
	   print @SQL;
       --EXEC(@SQL);   
END


GO
