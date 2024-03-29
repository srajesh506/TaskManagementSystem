USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetSubTasks]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetSubTasks]
       @PageNum INT=1,
       @PageSize INT=5,
       @IsActive bit=0,
       @SubTaskId int = -1,
       @TaskId int = -1,
       @ActivityId int = -1,
       @SubTaskName Nvarchar(50) = null,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords = Count(Activity.ActivityName) from SubTask INNER JOIN Task ON SubTask.TaskID = Task.TaskID INNER JOIN Activity On SubTask.ActivityId=Activity.ActivityId where 1=1;
	     IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL NVARCHAR(2000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY SubTaskId) as SLNO
                           ,ActivityName as [Activity Name]
                           ,TaskName as [Task Name]
                           ,SubTaskname as [SubTask Name]
                           ,SubTaskDescription as [SubTask Description]
                           ,SubTask.IsActive
                           ,SubTask.TaskId
                           ,SubTask.ActivityId
                           ,Subtaskid from SubTask
                           INNER JOIN Task ON SubTask.TaskID = Task.TaskID
                           INNER JOIN Activity On SubTask.ActivityId=Activity.ActivityId where 1=1'
       IF @SubTaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.SubTaskId = ' + +CAST(@SubTaskId AS NVARCHAR(10))
       END
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.TaskId = ' + +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.ActivityId = ' + +CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @SubTaskName is not null
       BEGIN  
              SET @SQL = @SQL + ' and dbo.SubTask.SubTaskName = ''' + @SubTaskName + ''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.IsActive = 1'
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       EXEC(@SQL);   
END
GO
