USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddRole]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===========================================
-- Description: Adds a new role in Database 
-- ===========================================
CREATE PROCEDURE [dbo].[uspAddRole]
       @RoleName nvarchar(50),
       @IsAdmin bit
       AS
BEGIN
       SET NOCOUNT OFF;
       Insert into [TMS].[dbo].[Role] ([RoleName],[IsAdmin],[CreatedDate],[ModifyDate]) values (@RoleName,@IsAdmin,Format(GETDATE(),'dd-MMM-yy hh:mm:ss'),null)
END
GO
