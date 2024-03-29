USE [TMS]
GO
/****** Object:  Table [dbo].[WorkItemAssignment]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkItemAssignment](
	[WorkItemAssignmentId] [int] IDENTITY(1,1) NOT NULL,
	[WorkItemId] [int] NULL,
	[UserIdAssigned] [nvarchar](50) NULL,
	[UserIdHandedover] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[HandOverOrClosedDate] [datetime] NULL,
	[Status] [int] NULL,
	[Remarks] [nvarchar](200) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkItemAssignment]  WITH CHECK ADD  CONSTRAINT [FK_WorkItemAssignment_Status] FOREIGN KEY([Status])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[WorkItemAssignment] CHECK CONSTRAINT [FK_WorkItemAssignment_Status]
GO
