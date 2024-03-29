USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateTask]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[uspAddUpdateTask] 
       @TaskId int,
       @TaskName nvarchar(50), 
       @TaskDescription nvarchar(50),
       @ActivityId int,
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[Task]
              ([TaskName]
                ,[TaskDescription]
                ,[ActivityId]
                ,[IsActive]
                ,[CreatedDate])
                values (@TaskName,@TaskDescription,@ActivityId,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[Task] set [TaskName] = @TaskName, [TaskDescription] = @TaskDescription,[ActivityId]=@ActivityId,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [TaskId] = @TaskId
       END
END
GO
