USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 11/29/2022 10:07:43 PM ******/
CREATE DATABASE [TMS]
GO
USE [TMS]
GO
/****** Object:  User [usertms]    Script Date: 11/29/2022 10:07:43 PM ******/
CREATE USER [usertms] FOR LOGIN [usertms] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [usertms]
GO
/****** Object:  Table [dbo].[Rolemaster]    Script Date: 11/29/2022 10:07:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rolemaster](
	[Roleid] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[IsAdmin] [int] NULL,
	[createdate] [datetime] NULL,
	[modifydate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 11/29/2022 10:07:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[EmpName] [nvarchar](500) NULL,
	[Roleid] [int] NULL,
	[Password] [nvarchar](500) NULL,
	[Createddate] [datetime] NULL,
	[Modifydate] [datetime] NULL,
	[Isactive] [bit] NULL,
	[empid] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Pic] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[Userdetails]    Script Date: 11/29/2022 10:07:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Userdetails]
AS
SELECT        dbo.Rolemaster.RoleName, dbo.Rolemaster.IsAdmin, dbo.UserMaster.Password, dbo.UserMaster.Createddate, dbo.UserMaster.Modifydate, dbo.UserMaster.Pic, dbo.UserMaster.Email, dbo.UserMaster.Remark, 
                         dbo.UserMaster.empid, dbo.UserMaster.Isactive, dbo.UserMaster.EmpName, dbo.Rolemaster.Roleid
FROM            dbo.UserMaster INNER JOIN
                         dbo.Rolemaster ON dbo.UserMaster.Roleid = dbo.Rolemaster.Roleid


GO
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_modifydate]  DEFAULT (getdate()) FOR [modifydate]
GO

