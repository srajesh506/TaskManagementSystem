USE [TMS]
GO
/****** Object:  Table [dbo].[SubTask]    Script Date: 9/1/2023 5:45:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubTask](
	[SubTaskId] [int] IDENTITY(1,1) NOT NULL,
	[SubTaskName] [nvarchar](50) NULL,
	[SubTaskDescription] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[TaskId] [int] NULL,
	[ActivityId] [int] NULL,
 CONSTRAINT [PK_SubTask] PRIMARY KEY CLUSTERED 
(
	[SubTaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
