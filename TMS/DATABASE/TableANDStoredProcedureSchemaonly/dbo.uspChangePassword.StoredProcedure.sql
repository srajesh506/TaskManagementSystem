USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspChangePassword]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspChangePassword]
       @UserId nvarchar(50),
       @Password nvarchar(500)
AS
BEGIN
       SET NOCOUNT ON;
       BEGIN
              UPDATE [TMS].[dbo].[Employee] SET [Password]= @Password, [ModifyDate] = Format(GETDATE(),'dd-MMM-yy hh:mm:ss') WHERE [UserId] = @UserId + ' [IsActive] = 1'
       END
END
GO
