USE [TMS]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 9/1/2023 5:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[ActivityName] [nvarchar](500) NOT NULL,
	[ActivityDescription] [nvarchar](2000) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_activity] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Activity] ON 

INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (1, N'ProjectBAU', N'Project BAU Activities', 1, CAST(N'2023-01-31T05:18:52.000' AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (2, N'KnowledgeManagement', N'KM Activities - Trainings & POC', 1, CAST(N'2023-01-31T05:18:52.000' AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (3, N'OrganizationalActivity', N'Organizational Activities - Interviews, Innovations, NKMP etc', 1, CAST(N'2023-01-31T05:18:52.000' AS DateTime), CAST(N'2023-02-03T05:22:12.000' AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (4, N'EmployeeEngagement', N'Employee Engagement Activities - CSR, Quiz etc', 1, CAST(N'2023-01-31T05:18:52.000' AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (5, N'ITIssues', N'IT Issues related activities', 1, CAST(N'2023-01-31T05:18:52.000' AS DateTime), CAST(N'2023-02-20T06:27:27.000' AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (6, N'Testing', N'test', 0, CAST(N'2023-01-31T15:00:54.000' AS DateTime), CAST(N'2023-01-31T15:00:58.000' AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (7, N'Test', N'Test_D', 1, CAST(N'2023-02-13T03:10:00.000' AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (8, N'test2', N'testsdasdsadsadadddddmm', 1, CAST(N'2023-02-20T04:46:57.000' AS DateTime), CAST(N'2023-02-24T01:24:15.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Activity] OFF
GO
