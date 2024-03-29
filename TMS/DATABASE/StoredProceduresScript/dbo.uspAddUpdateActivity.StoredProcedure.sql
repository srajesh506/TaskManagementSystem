USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateActivity]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[uspAddUpdateActivity] 
       -- Add the parameters for the stored procedure here
       @ActivityId int,
       @ActivityName nvarchar(500), 
       @ActivityDescription nvarchar(2000),
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[Activity]
              ([ActivityName]
                ,[ActivityDescription]
                ,[IsActive]
                ,[CreatedDate])
                values (@ActivityName,@ActivityDescription,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[Activity] set [ActivityName] = @ActivityName, [ActivityDescription] = @ActivityDescription,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [ActivityId] = @ActivityId
       END
END

GO
