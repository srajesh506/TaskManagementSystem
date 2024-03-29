USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItems]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetWorkItems]
       -- Add the parameters for the stored procedure here
	   @PageNum INT=1,
       @PageSize INT=5,
       @ActivityId int = -1,
       @TaskId int = -1,
       @SubTaskId int = -1,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	   SELECT @TotalRecords = Count(a.ActivityName) from WorkItem w inner join Activity a on w.ActivityId = a.ActivityId left outer join Task t on w.TaskId = t.TaskId left outer join SubTask s on w.SubTaskId = s.SubTaskId where 1=1;
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY w.WorkItemId)SLNO
                           ,a.ActivityName as [Activity Name]
                           ,t.TaskName as [Task Name]
                           ,s.SubTaskName as [SubTask Name]
                           ,w.WorkItemDescription
                           ,w.TaskId
                           ,w.ActivityId
                           ,w.SubTaskId
                           ,w.WorkItemId 
                           from WorkItem w inner join Activity a on w.ActivityId = a.ActivityId 
                           left outer join Task t on w.TaskId = t.TaskId 
                           left outer join SubTask s on w.SubTaskId = s.SubTaskId where 1=1'
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.ActivityId=' + CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.TaskId = ' +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @SubTaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.SubTaskId = ' +CAST(@SubTaskId AS NVARCHAR(10)) 
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar) 
       EXEC(@SQL);   
END
GO
