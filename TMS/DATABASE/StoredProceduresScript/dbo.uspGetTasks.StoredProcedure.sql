USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetTasks]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetTasks]
       @PageNum INT=1,
       @PageSize INT=5,
       @IsActive bit = 0,
       @TaskId int = -1,
       @ActivityId int = -1,
       @TaskName Nvarchar(50) = null,
	    @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
 DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(1000);
	    SELECT @TotalRecords = COUNT(TaskId) FROM dbo.Task where IsActive = 1;
	     IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;

      SET @SQL = 'With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY TaskId)SLNO
                           ,ActivityName as [Activity Name]
                           ,TaskName as [Task Name]
                           ,TaskDescription as [Task Description]
                           ,Task.IsActive
                           ,taskid
                           ,Task.ActivityId
                           FROM dbo.Task inner join dbo.Activity on dbo.Task.ActivityId = dbo.Activity.ActivityId
                           where 1=1'
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.TaskId = ' + +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.ActivityId = ' + +CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @TaskName is not null
       BEGIN  
              SET @SQL = @SQL + ' and dbo.Task.TaskName = ''' + @TaskName + ''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.IsActive =1'
       END
	    SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       EXEC(@SQL);   
	   --print @SQL;
END
GO
