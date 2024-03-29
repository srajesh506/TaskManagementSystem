USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateSubTask]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[uspAddUpdateSubTask] 
       -- Add the parameters for the stored procedure here
       @SubTaskId int,
       @SubTaskName nvarchar(50), 
       @SubTaskDescription nvarchar(50),
       @ActivityId int,
       @TaskId int,
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[SubTask]
              ([SubTaskName]
                ,[SubTaskDescription]
                ,[ActivityId]
                ,[TaskId]
                ,[IsActive]
                ,[CreatedDate])
                values (@SubTaskName,@SubTaskDescription,@ActivityId,@TaskId,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[SubTask] set [SubTaskName] = @SubTaskName, [SubTaskDescription] = @SubTaskDescription,[ActivityId]=@ActivityId,[TaskId]=@TaskId,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [SubTaskId] = @SubTaskId
       END
END
GO
