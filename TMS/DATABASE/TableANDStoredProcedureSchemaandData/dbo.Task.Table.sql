USE [TMS]
GO
/****** Object:  Table [dbo].[Task]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](50) NULL,
	[TaskDescription] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActivityId] [int] NULL,
 CONSTRAINT [PK_tbl_task] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (1, N'IncidentManagement', N'Incident Management related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (2, N'RequestManagement', N'Request Management related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (3, N'ChangeManagement', N'Change Management related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (4, N'ProblemManagement', N'Problem Management related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (5, N'ProjectMeetingAndDocumentation', N'Project Meeting & Documentation related tasksD', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), CAST(N'2023-02-24T01:28:34.000' AS DateTime), 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (6, N'ProjectKM', N'Project Knowledge Management related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (7, N'SquidLocalEnvironment', N'Local Squid server related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (8, N'IISLocalEnvironment', N'Local IIS server related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (9, N'SOMQueueMonitoring', N'SOM Queue Monitoring', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (10, N'PICredentialsCheckout/In', N'PI Credentials Checkout/In', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (11, N'ProjectAdhoc', N'Project Adhoc tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (12, N'Training', N'Training related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 2)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (13, N'POC', N'POC related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 2)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (14, N'NKMPSubmission', N'N-KMP related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (15, N'Interview', N'Interviews related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (16, N'Innovation', N'Innovation related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (17, N'TownHall-GroupMeeting', N'TownHall-GroupMeeting related tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (18, N'CSR', N'CSR tasks', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 4)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (19, N'ITServiceDesk', N'IT Service Desk related issues', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 5)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (20, N'LocalIT', N'Local IT related issues', 1, CAST(N'2023-01-31T05:22:19.000' AS DateTime), NULL, 5)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (21, N'Test_Task1', N'Test_Task1', 1, CAST(N'2023-02-13T03:10:20.000' AS DateTime), NULL, 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (22, N'Test_AfterPaging', N'Test_AfterPaging_Description7', 1, CAST(N'2023-02-21T03:46:05.000' AS DateTime), CAST(N'2023-02-21T03:46:52.000' AS DateTime), 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (23, N'sdsd', N'sadas', 1, CAST(N'2023-02-21T03:47:19.000' AS DateTime), NULL, 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (24, N'test2_taskname', N'test2_taskname_Description2m', 1, CAST(N'2023-02-21T03:59:51.000' AS DateTime), CAST(N'2023-02-24T01:24:47.000' AS DateTime), 8)
SET IDENTITY_INSERT [dbo].[Task] OFF
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_tbl_task_tbl_activity] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activity] ([ActivityId])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_tbl_task_tbl_activity]
GO
