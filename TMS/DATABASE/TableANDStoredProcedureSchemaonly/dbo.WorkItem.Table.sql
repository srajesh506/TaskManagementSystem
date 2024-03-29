USE [TMS]
GO
/****** Object:  Table [dbo].[WorkItem]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkItem](
	[WorkItemId] [int] IDENTITY(1,1) NOT NULL,
	[ActivityId] [int] NULL,
	[TaskId] [int] NULL,
	[SubTaskId] [int] NULL,
	[WorkItemDescription] [nvarchar](500) NULL,
 CONSTRAINT [PK_WorkItem] PRIMARY KEY CLUSTERED 
(
	[WorkItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkItem]  WITH CHECK ADD  CONSTRAINT [FK_WorkItem_Activity] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activity] ([ActivityId])
GO
ALTER TABLE [dbo].[WorkItem] CHECK CONSTRAINT [FK_WorkItem_Activity]
GO
ALTER TABLE [dbo].[WorkItem]  WITH CHECK ADD  CONSTRAINT [FK_WorkItem_SubTask] FOREIGN KEY([SubTaskId])
REFERENCES [dbo].[SubTask] ([SubTaskId])
GO
ALTER TABLE [dbo].[WorkItem] CHECK CONSTRAINT [FK_WorkItem_SubTask]
GO
ALTER TABLE [dbo].[WorkItem]  WITH CHECK ADD  CONSTRAINT [FK_WorkItem_Task] FOREIGN KEY([TaskId])
REFERENCES [dbo].[Task] ([TaskId])
GO
ALTER TABLE [dbo].[WorkItem] CHECK CONSTRAINT [FK_WorkItem_Task]
GO
