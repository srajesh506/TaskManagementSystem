USE [TMS]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 9/1/2023 5:46:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[IsAdmin] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (1, N'Administrator', 1, CAST(N'2023-01-31T05:27:48.000' AS DateTime), CAST(N'2023-01-31T14:49:30.783' AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (2, N'ProjectManager', 1, CAST(N'2023-01-31T05:27:48.000' AS DateTime), CAST(N'2023-01-31T14:49:30.803' AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (3, N'TeamMember', 0, CAST(N'2023-01-31T05:27:48.000' AS DateTime), CAST(N'2023-01-31T14:49:30.820' AS DateTime))
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Rolemaster_createdate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Rolemaster_modifydate]  DEFAULT (getdate()) FOR [ModifyDate]
GO
