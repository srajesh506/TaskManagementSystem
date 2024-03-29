USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspCheckLogin]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCheckLogin]
       @UserId nvarchar(50),
       @Password nvarchar(500)
AS
BEGIN
       SET NOCOUNT ON;
       BEGIN
              SELECT r.RoleName, e.RoleId, r.IsAdmin FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.UserId = @UserId and e.Password=@Password and e.IsActive = 1
       END
END
GO
