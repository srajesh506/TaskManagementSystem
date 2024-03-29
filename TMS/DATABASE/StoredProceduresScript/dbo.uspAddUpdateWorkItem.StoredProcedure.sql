USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItem]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddUpdateWorkItem] 
       @WorkItemId int,
       @ActivityId int, 
       @TaskId int,
       @SubTaskId int,
       @WorkItemDescription nvarchar(500),
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[WorkItem]([ActivityId],[TaskId],[SubTaskId],[WorkItemDescription]) values (@ActivityId,@TaskId,@SubTaskId,@WorkItemDescription)
              DECLARE @Id INT = SCOPE_IDENTITY();
              Insert into [TMS].[dbo].[WorkItemAssignment]([WorkItemId],[Status]) values (@Id,1)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[WorkItem] set [ActivityId] = @ActivityId, [TaskId] = @TaskId,[SubTaskId]=@SubTaskId,[WorkItemDescription]=@WorkItemDescription where [WorkItemId] = @WorkItemId;
       END
END
GO
