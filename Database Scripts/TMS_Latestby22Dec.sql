USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 12/22/2022 5:38:40 PM ******/
CREATE DATABASE [TMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TMS] SET RECOVERY FULL 
GO
ALTER DATABASE [TMS] SET  MULTI_USER 
GO
ALTER DATABASE [TMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TMS', N'ON'
GO
USE [TMS]
GO
/****** Object:  User [usertms]    Script Date: 12/22/2022 5:38:40 PM ******/
CREATE USER [usertms] FOR LOGIN [usertms] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [usertms]
GO
/****** Object:  Table [dbo].[Rolemaster]    Script Date: 12/22/2022 5:38:40 PM ******/
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
/****** Object:  Table [dbo].[tbl_activity]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_activity](
	[activityid] [int] IDENTITY(1,1) NOT NULL,
	[activityname] [nvarchar](500) NOT NULL,
	[activitydescription] [nvarchar](2000) NULL,
	[isactive] [bit] NULL,
	[createddate] [datetime] NULL,
	[modifydate] [datetime] NULL,
 CONSTRAINT [PK_tbl_activity] PRIMARY KEY CLUSTERED 
(
	[activityid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_RemarkAssignment]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_RemarkAssignment](
	[Id] [int] NULL,
	[AssigmentitemId] [int] NULL,
	[empid] [int] NULL,
	[StartDate] [datetime] NULL,
	[HandOverDate] [datetime] NULL,
	[Status] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_status]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_subtask]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_subtask](
	[subtaskid] [int] IDENTITY(1,1) NOT NULL,
	[subtaskname] [nvarchar](50) NULL,
	[subtaskdescription] [nvarchar](50) NULL,
	[isactive] [bit] NULL,
	[createddate] [datetime] NULL,
	[modifydate] [datetime] NULL,
	[taskid] [int] NULL,
	[activityid] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_subtask_old]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_subtask_old](
	[subtaskid] [int] IDENTITY(1,1) NOT NULL,
	[subtaskname] [nvarchar](50) NULL,
	[subtaskdescription] [nvarchar](50) NULL,
	[isactive] [bit] NULL,
	[createddate] [datetime] NULL,
	[modifydate] [datetime] NULL,
	[taskid] [int] NULL,
	[activityid] [int] NULL,
 CONSTRAINT [PK_tbl_subtask] PRIMARY KEY CLUSTERED 
(
	[subtaskid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_task]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_task](
	[taskid] [int] IDENTITY(1,1) NOT NULL,
	[taskname] [nvarchar](50) NULL,
	[taskdescription] [nvarchar](50) NULL,
	[isactive] [bit] NULL,
	[createddate] [datetime] NULL,
	[modifydate] [datetime] NULL,
	[activityid] [int] NULL,
 CONSTRAINT [PK_tbl_task] PRIMARY KEY CLUSTERED 
(
	[taskid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_taskgroup]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_taskgroup](
	[task_id] [int] IDENTITY(1,1) NOT NULL,
	[task_Name] [nvarchar](500) NULL,
	[task_Des] [nvarchar](2000) NULL,
	[isactive] [bit] NULL,
	[Createddate] [datetime] NULL,
	[Modifydate] [datetime] NULL,
 CONSTRAINT [PK_tbl_taskgroup] PRIMARY KEY CLUSTERED 
(
	[task_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_workitems]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_workitems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[activityid] [int] NULL,
	[taskid] [int] NULL,
	[subtaskid] [int] NULL,
	[Remark] [nvarchar](500) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_workitemsassignment]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_workitemsassignment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[assigmentitemId] [int] NULL,
	[empid] [int] NULL,
	[Start_Date] [datetime] NULL,
	[HandOver/ClosedDate] [datetime] NULL,
	[Status] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 12/22/2022 5:38:40 PM ******/
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
/****** Object:  View [dbo].[View_SubtaskRelateTaskandActivity]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_SubtaskRelateTaskandActivity]
AS
SELECT        dbo.tbl_subtask.subtaskid, dbo.tbl_activity.activityname, dbo.tbl_task.taskname, dbo.tbl_subtask.subtaskname, dbo.tbl_subtask.subtaskdescription, dbo.tbl_subtask.isactive, dbo.tbl_subtask.taskid, 
                         dbo.tbl_subtask.activityid
FROM            dbo.tbl_subtask INNER JOIN
                         dbo.tbl_task ON dbo.tbl_subtask.taskid = dbo.tbl_task.taskid INNER JOIN
                         dbo.tbl_activity ON dbo.tbl_subtask.activityid = dbo.tbl_activity.activityid
WHERE        (dbo.tbl_activity.isactive = 1)

GO
/****** Object:  View [dbo].[View_workitems]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_workitems]
AS
SELECT        dbo.View_SubtaskRelateTaskandActivity.activityid, dbo.tbl_workitems.Remark, dbo.View_SubtaskRelateTaskandActivity.activityname, dbo.View_SubtaskRelateTaskandActivity.taskname, 
                         dbo.View_SubtaskRelateTaskandActivity.subtaskname, dbo.View_SubtaskRelateTaskandActivity.taskid, dbo.View_SubtaskRelateTaskandActivity.subtaskid, dbo.View_SubtaskRelateTaskandActivity.isactive, 
                         dbo.tbl_workitems.Id
FROM            dbo.View_SubtaskRelateTaskandActivity INNER JOIN
                         dbo.tbl_workitems ON dbo.View_SubtaskRelateTaskandActivity.activityid = dbo.tbl_workitems.activityid AND dbo.View_SubtaskRelateTaskandActivity.taskid = dbo.tbl_workitems.taskid AND 
                         dbo.View_SubtaskRelateTaskandActivity.subtaskid = dbo.tbl_workitems.subtaskid

GO
/****** Object:  View [dbo].[View_AssignTask]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_AssignTask]
AS
SELECT        dbo.tbl_assignmentItems.Id, dbo.View_SubtaskRelateTaskandActivity.activityname, dbo.View_SubtaskRelateTaskandActivity.taskname, dbo.View_SubtaskRelateTaskandActivity.subtaskname, dbo.tbl_assignmentItems.Remark, 
                         dbo.View_SubtaskRelateTaskandActivity.activityid, dbo.View_SubtaskRelateTaskandActivity.taskid, dbo.View_SubtaskRelateTaskandActivity.subtaskid, dbo.View_SubtaskRelateTaskandActivity.isactive
FROM            dbo.View_SubtaskRelateTaskandActivity INNER JOIN
                         dbo.tbl_assignmentItems ON dbo.View_SubtaskRelateTaskandActivity.activityid = dbo.tbl_assignmentItems.activityid AND dbo.View_SubtaskRelateTaskandActivity.taskid = dbo.tbl_assignmentItems.taskid AND 
                         dbo.View_SubtaskRelateTaskandActivity.subtaskid = dbo.tbl_assignmentItems.subtaskid

GO
/****** Object:  View [dbo].[Userdetails]    Script Date: 12/22/2022 5:38:40 PM ******/
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
/****** Object:  View [dbo].[View_taskrelateactivity]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_taskrelateactivity]
AS
SELECT        dbo.tbl_task.taskid, dbo.tbl_activity.activityname, dbo.tbl_task.taskname, dbo.tbl_task.taskdescription, dbo.tbl_task.isactive, dbo.tbl_activity.activityid
FROM            dbo.tbl_activity INNER JOIN
                         dbo.tbl_task ON dbo.tbl_activity.activityid = dbo.tbl_task.activityid
WHERE        (dbo.tbl_activity.isactive = 1)

GO
/****** Object:  View [dbo].[View_workitemsassignment]    Script Date: 12/22/2022 5:38:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_workitemsassignment]
AS
SELECT        dbo.tbl_workitemsassignment.empid, dbo.tbl_workitemsassignment.Start_Date, dbo.tbl_workitemsassignment.[HandOver/ClosedDate], dbo.tbl_workitemsassignment.Status, dbo.tbl_workitems.Remark
FROM            dbo.tbl_workitemsassignment RIGHT OUTER JOIN
                         dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id

GO
SET IDENTITY_INSERT [dbo].[Rolemaster] ON 

INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (1, N'Admin', 1, CAST(0x0000AF5500011CDF AS DateTime), CAST(0x0000AF5500011CDF AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (2, N'Manager', 1, CAST(0x0000AF55000133A2 AS DateTime), CAST(0x0000AF55000133A2 AS DateTime))
INSERT [dbo].[Rolemaster] ([Roleid], [RoleName], [IsAdmin], [createdate], [modifydate]) VALUES (3, N'Employee', 1, CAST(0x0000AF550001559C AS DateTime), CAST(0x0000AF550001559C AS DateTime))
SET IDENTITY_INSERT [dbo].[Rolemaster] OFF
SET IDENTITY_INSERT [dbo].[tbl_activity] ON 

INSERT [dbo].[tbl_activity] ([activityid], [activityname], [activitydescription], [isactive], [createddate], [modifydate]) VALUES (1, N'Project BAU', N'Project BAU', 1, CAST(0x0000AF6501202365 AS DateTime), CAST(0x0000AF650179097C AS DateTime))
INSERT [dbo].[tbl_activity] ([activityid], [activityname], [activitydescription], [isactive], [createddate], [modifydate]) VALUES (2, N'Knowledge Management
', N'Knowledge Management
', 1, CAST(0x0000AF6501202367 AS DateTime), CAST(0x0000AF650179BA70 AS DateTime))
INSERT [dbo].[tbl_activity] ([activityid], [activityname], [activitydescription], [isactive], [createddate], [modifydate]) VALUES (3, N'Organizational Activity
', N'Organizational Activity
', 1, CAST(0x0000AF6501202367 AS DateTime), CAST(0x0000AF650179C3D0 AS DateTime))
INSERT [dbo].[tbl_activity] ([activityid], [activityname], [activitydescription], [isactive], [createddate], [modifydate]) VALUES (4, N'Employee Engagement
', N'Employee Engagement
', 1, CAST(0x0000AF6501202367 AS DateTime), CAST(0x0000AF650179CAD8 AS DateTime))
INSERT [dbo].[tbl_activity] ([activityid], [activityname], [activitydescription], [isactive], [createddate], [modifydate]) VALUES (5, N'IT Issues

', N'IT Issues

', 1, CAST(0x0000AF6501202367 AS DateTime), CAST(0x0000AF650179DC6C AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_activity] OFF
SET IDENTITY_INSERT [dbo].[tbl_status] ON 

INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (1, N'Open')
INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (2, N'InProgress')
INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (3, N'Pending')
INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (4, N'Monitoring')
INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (5, N'Completed')
INSERT [dbo].[tbl_status] ([StatusId], [Status]) VALUES (6, N'HandedOver')
SET IDENTITY_INSERT [dbo].[tbl_status] OFF
SET IDENTITY_INSERT [dbo].[tbl_subtask] ON 

INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (1, N'Analysis', N'Analysis', 1, CAST(0x0000AF660113ED1C AS DateTime), NULL, 1, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (2, N'Analysis', N'Analysis', 1, CAST(0x0000AF6601140A68 AS DateTime), NULL, 2, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (3, N'Analysis', N'Analysis', 1, CAST(0x0000AF6601142688 AS DateTime), NULL, 3, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (4, N'Analysis', N'Analysis', 1, CAST(0x0000AF6601143CCC AS DateTime), NULL, 4, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (5, N'QMSDocuments', N'QMSDocuments', 1, CAST(0x0000AF660114543C AS DateTime), NULL, 5, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (6, N'ArtifactCreation', N'ArtifactCreation', 1, CAST(0x0000AF660114705C AS DateTime), NULL, 6, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (7, N'EnviornmentSetup', N'EnviornmentSetup', 1, CAST(0x0000AF660114831C AS DateTime), NULL, 7, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (8, N'EnviornmentSetup', N'EnviornmentSetup', 1, CAST(0x0000AF660114B328 AS DateTime), NULL, 8, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (9, N'Analysis', N'Analysis', 1, CAST(0x0000AF660114CCF0 AS DateTime), NULL, 11, 1)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (10, N'LMS', N'LMS', 1, CAST(0x0000AF660114E208 AS DateTime), NULL, 12, 2)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (11, N'EnviornmentSetup', N'EnviornmentSetup', 1, CAST(0x0000AF660114F84C AS DateTime), NULL, 13, 2)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (12, N'LessonsLearnt', N'LessonsLearnt', 1, CAST(0x0000AF6601150D64 AS DateTime), NULL, 14, 3)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (13, N'ProjectLevel', N'ProjectLevel', 1, CAST(0x0000AF6601152600 AS DateTime), NULL, 15, 3)
INSERT [dbo].[tbl_subtask] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (14, N'Documentation', N'Documentation', 1, CAST(0x0000AF6601153794 AS DateTime), NULL, 16, 3)
SET IDENTITY_INSERT [dbo].[tbl_subtask] OFF
SET IDENTITY_INSERT [dbo].[tbl_subtask_old] ON 

INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (1, N'Analysis', N'Analysis', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (2, N'InterimChecks', N'InterimChecks', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (3, N'Review', N'Review', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (4, N'Meeting', N'Meeting', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (5, N'Communication', N'Communication', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (6, N'RCADraft', N'RCADraft', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (7, N'RCAReview', N'RCAReview', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (8, N'IncidentTracker', N'IncidentTracker', 1, NULL, NULL, 1, 1)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (9, N'Analysis', N'Analysis', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (10, N'Fulfillment', N'Fulfillment', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (11, N'Review', N'Review', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (12, N'Meeting', N'Meeting', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (13, N'Communication', N'Communication', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (14, N'RequestTracker', N'RequestTracker', 1, NULL, NULL, 2, 2)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (15, N'Analysis', N'Analysis', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (16, N'DraftChange', N'DraftChange', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (17, N'PeerReviewChange', N'PeerReviewChange', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (18, N'InternalCAB', N'InternalCAB', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (19, N'ClientCAB', N'ClientCAB', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (20, N'ImplementationTask', N'ImplementationTask', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (21, N'ValidationTask', N'ValidationTask', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (22, N'Meeting', N'Meeting', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (23, N'Communication', N'Communication', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (24, N'Review', N'Review', 1, NULL, NULL, 3, 3)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (25, N'Analysis', N'Analysis', 1, NULL, NULL, 4, 4)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (26, N'PeerReviewAnalysis', N'PeerReviewAnalysis', 1, NULL, NULL, 4, 4)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (27, N'Meeting', N'Meeting', 1, NULL, NULL, 4, 4)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (28, N'Communication', N'Communication', 1, NULL, NULL, 4, 4)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (29, N'ProblemTracker', N'ProblemTracker', 1, NULL, NULL, 4, 4)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (30, N'QMSDocuments', N'QMSDocuments', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (31, N'DailyStatusReporting', N'DailyStatusReporting', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (32, N'WeeklyReporting', N'WeeklyReporting', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (33, N'MonthlyReporting', N'MonthlyReporting', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (34, N'MMR', N'MMR', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (35, N'DailySyncUp', N'DailySyncUp', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (36, N'WeeklyCatchUp', N'WeeklyCatchUp', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (37, N'Audit', N'Audit', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (38, N'MOM', N'MOM', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (39, N'DailyActivityTracker', N'DailyActivityTracker', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (40, N'TrainingTracker', N'TrainingTracker', 1, NULL, NULL, 5, 5)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (41, N'ArtifactCreation', N'ArtifactCreation', 1, NULL, NULL, 6, 6)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (42, N'ArtifactUpdate', N'ArtifactUpdate', 1, NULL, NULL, 6, 6)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (43, N'ArtifactReview', N'ArtifactReview', 1, NULL, NULL, 6, 6)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (44, N'EnviornmentSetup', N'EnviornmentSetup', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (45, N'Analysis', N'Analysis', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (46, N'ConfigurationChange', N'ConfigurationChange', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (47, N'Testing', N'Testing', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (48, N'Troubleshooting', N'Troubleshooting', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (49, N'Documentation', N'Documentation', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (50, N'Review', N'Review', 1, NULL, NULL, 7, 7)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (51, N'EnviornmentSetup', N'EnviornmentSetup', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (52, N'Analysis', N'Analysis', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (53, N'Scripting', N'Scripting', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (54, N'ConfigurationChange', N'ConfigurationChange', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (55, N'Testing', N'Testing', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (56, N'Troubleshooting', N'Troubleshooting', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (57, N'Documentation', N'Documentation', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (58, N'Review', N'Review', 1, NULL, NULL, 8, 8)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (59, N'Analysis', N'Analysis', 1, NULL, NULL, 11, 11)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (60, N'Communication', N'Communication', 1, NULL, NULL, 11, 11)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (61, N'LMS', N'LMS', 1, NULL, NULL, 12, 12)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (62, N'Webinar', N'Webinar', 1, NULL, NULL, 12, 12)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (63, N'Online', N'Online', 1, NULL, NULL, 12, 12)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (64, N'Documentation', N'Documentation', 1, NULL, NULL, 12, 12)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (65, N'Review', N'Review', 1, NULL, NULL, 12, 12)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (66, N'EnviornmentSetup', N'EnviornmentSetup', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (67, N'Analysis', N'Analysis', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (68, N'Implementation', N'Implementation', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (69, N'Testing', N'Testing', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (70, N'Troubleshooting', N'Troubleshooting', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (71, N'Documentation', N'Documentation', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (72, N'Demo', N'Demo', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (73, N'Review', N'Review', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (74, N'RnDForNewIdea', N'RnDForNewIdea', 1, NULL, NULL, 13, 13)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (75, N'LessonsLearnt', N'LessonsLearnt', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (76, N'BestPractices', N'BestPractices', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (77, N'ReusableComponents', N'ReusableComponents', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (78, N'Review', N'Review', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (79, N'Meeting', N'Meeting', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (80, N'Communication', N'Communication', 1, NULL, NULL, 14, 14)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (81, N'ProjectLevel', N'ProjectLevel', 1, NULL, NULL, 15, 15)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (82, N'AccountLevel', N'AccountLevel', 1, NULL, NULL, 15, 15)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (83, N'OrganizationLevel', N'OrganizationLevel', 1, NULL, NULL, 15, 15)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (84, N'Meeting', N'Meeting', 1, NULL, NULL, 15, 15)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (85, N'Communication', N'Communication', 1, NULL, NULL, 15, 15)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (86, N'Documentation', N'Documentation', 1, NULL, NULL, 16, 16)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (87, N'Meeting', N'Meeting', 1, NULL, NULL, 16, 16)
INSERT [dbo].[tbl_subtask_old] ([subtaskid], [subtaskname], [subtaskdescription], [isactive], [createddate], [modifydate], [taskid], [activityid]) VALUES (88, N'Communication', N'Communication', 1, NULL, NULL, 16, 16)
SET IDENTITY_INSERT [dbo].[tbl_subtask_old] OFF
SET IDENTITY_INSERT [dbo].[tbl_task] ON 

INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (1, N'IncidentManagement
', N'IncidentManagement', 1, NULL, CAST(0x0000AF65016B7A64 AS DateTime), 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (2, N'RequestManagement
', N'RequestManagement', 1, NULL, CAST(0x0000AF65016BBC04 AS DateTime), 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (3, N'ChangeManagement', N'ChangeManagement', 1, NULL, CAST(0x0000AF65016BC7BC AS DateTime), 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (4, N'ProblemManagement', N'ProblemManagement', 1, NULL, CAST(0x0000AF65016BD374 AS DateTime), 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (5, N'ProjectMeetingAndDocumentation', N'ProjectMeetingAndDocumentation', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (6, N'ProjectKM', N'ProjectKM', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (7, N'SquidLocalEnvironment', N'SquidLocalEnvironment', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (8, N'IISLocalEnvironment', N'IISLocalEnvironment', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (9, N'SOMQueueMonitoring', N'SOMQueueMonitoring', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (10, N'PICredentialsCheckout/In', N'PICredentialsCheckout/In', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (11, N'ProjectAdhoc', N'ProjectAdhoc', 1, NULL, NULL, 1)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (12, N'Training', N'Training', 1, NULL, NULL, 2)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (13, N'POC', N'POC', 1, NULL, NULL, 2)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (14, N'NKMPSubmission', N'NKMPSubmission', 1, NULL, NULL, 3)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (15, N'Interview', N'Interview', 1, NULL, NULL, 3)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (16, N'Innovation', N'Innovation', 1, NULL, NULL, 3)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (17, N'TownHall-GroupMeeting', N'TownHall-GroupMeeting', 1, NULL, NULL, 3)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (18, N'ITServiceDesk', N'ITServiceDesk', 1, NULL, CAST(0x0000AF65016BDF2C AS DateTime), 5)
INSERT [dbo].[tbl_task] ([taskid], [taskname], [taskdescription], [isactive], [createddate], [modifydate], [activityid]) VALUES (19, N'LocalIT', N'LocalIT', 1, NULL, NULL, 5)
SET IDENTITY_INSERT [dbo].[tbl_task] OFF
SET IDENTITY_INSERT [dbo].[tbl_taskgroup] ON 

INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (14, N'Analysis', N'Dashboard, KPI', 1, CAST(0x0000AF6501165DB8 AS DateTime), NULL)
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (15, N'Data Collection', N'Student, Client, Vendors', 1, CAST(0x0000AF6501168914 AS DateTime), NULL)
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (16, N'Followups', N'Payment Followups,etc', 1, CAST(0x0000AF650116C604 AS DateTime), NULL)
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (17, N'Meetings ', N'Team Meetings, Discussions', 1, CAST(0x0000AF650116F4E4 AS DateTime), CAST(0x0000AF6501188F0C AS DateTime))
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (18, N'Reports', N'MIS, Data Cleaning', 1, CAST(0x0000AF6501172040 AS DateTime), NULL)
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (19, N'Review', N'Any type of Review', 1, CAST(0x0000AF6501173C60 AS DateTime), NULL)
INSERT [dbo].[tbl_taskgroup] ([task_id], [task_Name], [task_Des], [isactive], [Createddate], [Modifydate]) VALUES (20, N'Social Marketing', N'Post on FB,LinkdIn etc.', 1, CAST(0x0000AF650117969C AS DateTime), CAST(0x0000AF6501187B20 AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_taskgroup] OFF
SET IDENTITY_INSERT [dbo].[tbl_workitems] ON 

INSERT [dbo].[tbl_workitems] ([Id], [activityid], [taskid], [subtaskid], [Remark]) VALUES (14, 1, 1, 1, N'Incident INC15085265 has been assigned to you, MOD-Application Support. Priority: 2 - High')
INSERT [dbo].[tbl_workitems] ([Id], [activityid], [taskid], [subtaskid], [Remark]) VALUES (13, 1, 1, 1, N'Incident INC15085269')
SET IDENTITY_INSERT [dbo].[tbl_workitems] OFF
SET IDENTITY_INSERT [dbo].[tbl_workitemsassignment] ON 

INSERT [dbo].[tbl_workitemsassignment] ([Id], [assigmentitemId], [empid], [Start_Date], [HandOver/ClosedDate], [Status]) VALUES (12, 14, 123456, CAST(0x0000AF7300000000 AS DateTime), NULL, 1)
INSERT [dbo].[tbl_workitemsassignment] ([Id], [assigmentitemId], [empid], [Start_Date], [HandOver/ClosedDate], [Status]) VALUES (13, 13, 184877, CAST(0x0000AF7300000000 AS DateTime), NULL, 3)
SET IDENTITY_INSERT [dbo].[tbl_workitemsassignment] OFF
INSERT [dbo].[UserMaster] ([EmpName], [Roleid], [Password], [Createddate], [Modifydate], [Isactive], [empid], [Remark], [Email], [Pic]) VALUES (N'Naman', 1, N'+y+qq+9ALYkDwfLT4r/UnKPH5aZCxyLrlMGq5WQyJVc=', CAST(0x0000AF5D001CF9F8 AS DateTime), CAST(0x0000AF5D002A3000 AS DateTime), 1, N'111111', N'Manage Activity', N'Naman@nttdata.com', N'111111.jpg')
INSERT [dbo].[UserMaster] ([EmpName], [Roleid], [Password], [Createddate], [Modifydate], [Isactive], [empid], [Remark], [Email], [Pic]) VALUES (N'Karan', 3, N'FkkBmgtFtuhebgbtOmKo+Mm6z24oOelD75adKL6f9ak=', CAST(0x0000AF5C016F4388 AS DateTime), NULL, 1, N'123456', N'Manage', N'karan@nttdata.com', N'')
INSERT [dbo].[UserMaster] ([EmpName], [Roleid], [Password], [Createddate], [Modifydate], [Isactive], [empid], [Remark], [Email], [Pic]) VALUES (N'Rajesh', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF55000F4C68 AS DateTime), CAST(0x0000AF6D011A3168 AS DateTime), 1, N'184877', N'Admin and SOM Activity', N'184877@nttdata.com', N'184877.jpg')
INSERT [dbo].[UserMaster] ([EmpName], [Roleid], [Password], [Createddate], [Modifydate], [Isactive], [empid], [Remark], [Email], [Pic]) VALUES (N'Test', 1, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(0x0000AF6D011B9800 AS DateTime), CAST(0x0000AF6D011BD874 AS DateTime), 1, N'999999', N'Testing', N'test@nttdata.com', N'999999.jpg')
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_createdate]  DEFAULT (getdate()) FOR [createdate]
GO
ALTER TABLE [dbo].[Rolemaster] ADD  CONSTRAINT [DF_Rolemaster_modifydate]  DEFAULT (getdate()) FOR [modifydate]
GO
ALTER TABLE [dbo].[tbl_subtask_old]  WITH CHECK ADD  CONSTRAINT [FK_tbl_subtask_tbl_task] FOREIGN KEY([taskid])
REFERENCES [dbo].[tbl_task] ([taskid])
GO
ALTER TABLE [dbo].[tbl_subtask_old] CHECK CONSTRAINT [FK_tbl_subtask_tbl_task]
GO
ALTER TABLE [dbo].[tbl_task]  WITH CHECK ADD  CONSTRAINT [FK_tbl_task_tbl_activity] FOREIGN KEY([activityid])
REFERENCES [dbo].[tbl_activity] ([activityid])
GO
ALTER TABLE [dbo].[tbl_task] CHECK CONSTRAINT [FK_tbl_task_tbl_activity]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[5] 2[41] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "UserMaster"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 228
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "Rolemaster"
            Begin Extent = 
               Top = 6
               Left = 335
               Bottom = 191
               Right = 509
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Userdetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Userdetails'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[5] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_SubtaskRelateTaskandActivity"
            Begin Extent = 
               Top = 10
               Left = 295
               Bottom = 256
               Right = 483
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_assignmentItems"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 199
               Right = 227
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2025
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AssignTask'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_AssignTask'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[5] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_activity"
            Begin Extent = 
               Top = 105
               Left = 576
               Bottom = 326
               Right = 762
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_task"
            Begin Extent = 
               Top = 0
               Left = 808
               Bottom = 228
               Right = 978
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_subtask"
            Begin Extent = 
               Top = 1
               Left = 143
               Bottom = 213
               Right = 331
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubtaskRelateTaskandActivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubtaskRelateTaskandActivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[32] 4[5] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_activity"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 261
               Right = 224
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_task"
            Begin Extent = 
               Top = 6
               Left = 262
               Bottom = 268
               Right = 432
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 2730
         Width = 2985
         Width = 4095
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_taskrelateactivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_taskrelateactivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[52] 4[5] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_SubtaskRelateTaskandActivity"
            Begin Extent = 
               Top = 6
               Left = 380
               Bottom = 252
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_workitems"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 271
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2025
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitems'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitems'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[49] 4[5] 2[17] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_workitems"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 210
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_workitemsassignment"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 211
               Right = 454
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 4425
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitemsassignment'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitemsassignment'
GO
USE [master]
GO
ALTER DATABASE [TMS] SET  READ_WRITE 
GO
