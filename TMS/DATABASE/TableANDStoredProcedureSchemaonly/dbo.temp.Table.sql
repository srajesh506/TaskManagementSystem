USE [TMS]
GO
/****** Object:  Table [dbo].[temp]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temp](
	[Activity Name] [nvarchar](500) NOT NULL,
	[Task Name] [nvarchar](50) NULL,
	[SubTask Name] [nvarchar](50) NULL,
	[TaskId] [int] NULL,
	[ActivityId] [int] NULL,
	[SubTaskId] [int] NOT NULL
) ON [PRIMARY]
GO
