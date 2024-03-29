USE [TMS]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDescription] [nvarchar](150) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (1, N'Open')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (2, N'InProgress')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (3, N'Monitoring')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (4, N'Pending')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (5, N'Completed')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (6, N'HandedOver')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
