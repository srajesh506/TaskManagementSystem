USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateEmployee]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddUpdateEmployee]
       @EmpName nvarchar(500),
       @RoleID int,
       @Password nvarchar(500),
       @IsActive bit,
       @UserId nvarchar(50),
       @Remark nvarchar(500),
       @Email nvarchar(500),
       @Pic nvarchar(50),

       @UpdateFlag int
       AS
BEGIN
       SET NOCOUNT OFF;
       IF @UpdateFlag = 0
       BEGIN
              INSERT into [TMS].[dbo].[Employee]
              ([EmpName]
              ,[RoleId]
              ,[Password]
              ,[CreatedDate]
              ,[IsActive]
              ,[UserId]
              ,[Remark]
              ,[Email]
              ,[Pic])
              Values (@EmpName, @RoleId, @Password,Format(GETDATE(),'dd-MMM-yy hh:mm:ss'),@IsActive,@UserId,@Remark,@Email,@Pic)
       END
       ELSE IF @UpdateFlag = 1
       BEGIN
              UPDATE [TMS].[dbo].[Employee] 
              SET [EmpName] = @EmpName
              ,[RoleId] = @RoleId
              ,[Password]= @Password
              ,[ModifyDate] = Format(GETDATE(),'dd-MMM-yy hh:mm:ss')
              ,[IsActive] = @IsActive
              ,[Remark] = @Remark
              ,[Email] = @Email
              ,[Pic] = @Pic
              WHERE [UserId] = @UserId
       END
END

GO
