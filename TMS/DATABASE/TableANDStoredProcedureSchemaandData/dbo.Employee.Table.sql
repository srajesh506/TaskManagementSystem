USE [TMS]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpName] [nvarchar](500) NULL,
	[RoleId] [int] NULL,
	[Password] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[IsActive] [bit] NULL,
	[UserId] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Pic] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Karan Gupta', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(N'2022-11-22T00:55:42.000' AS DateTime), CAST(N'2023-02-13T04:05:48.000' AS DateTime), 1, N'184873', N'Admin', N'184873@nttdata.com', N'184873.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Rajesh Shukla', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(N'2022-11-22T00:55:42.000' AS DateTime), CAST(N'2023-02-24T01:54:02.000' AS DateTime), 1, N'184877', N'Admin', N'184877@nttdata.com', N'184877.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Naman Singh', 3, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(N'2022-11-22T00:55:42.000' AS DateTime), CAST(N'2023-02-13T03:54:26.000' AS DateTime), 1, N'184878', N'Admin', N'184878@nttdata.com', N'184878.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Sachin Kumar', 3, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(N'2023-01-31T01:22:41.000' AS DateTime), NULL, 0, N'184890', N'Team Member', N'184890@nttdata.com', N'184890.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Test', 1, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(N'2023-02-08T03:43:36.000' AS DateTime), NULL, 1, N'198987', N'test', N'test@nttdata.com', N'198987.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Ashish', 2, N'+hDvpdNKNVn7AQ8ND/BMpM84pEw3x2UbkAveaoAA5qo=', CAST(N'2023-02-07T01:01:31.000' AS DateTime), CAST(N'2023-02-13T03:54:29.000' AS DateTime), 1, N'Ashish123', N'ABC', N'Ashish.Tyagi@nttdata.com', N'Ashish123.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp1', 1, N'hRzVSy0umV3/J0Awi3UvPfM0iIva+H53AaUgSRLCDIc=', CAST(N'2023-02-09T05:01:04.000' AS DateTime), NULL, 1, N'emp1', N'empremark1', N'emp@nttdata.com', N'emp1.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp2', 1, N'WcOMyG7a7olgKkxuwG4fsgGlViDAWQDlB4m9gH7PNW4=', CAST(N'2023-02-09T05:01:52.000' AS DateTime), NULL, 1, N'emp2', N'empremark2', N'emp2@nttdata.com', N'emp2.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp3', 1, N'QikJ01rPD+2GJnXur4d+HS3DqThnBcRnJUqL4peLZGo=', CAST(N'2023-02-13T02:59:17.000' AS DateTime), NULL, 1, N'emp3', N'emp3_Remark', N'emp3@nttdata.com', N'emp3.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp4', 3, N'Kl/zdRG578wIpfQUxkIe7nR8KCaetMGbTkhGg8WFwnA=', CAST(N'2023-02-13T03:01:23.000' AS DateTime), CAST(N'2023-02-13T03:54:41.000' AS DateTime), 1, N'emp4', N'emp4_Remark', N'emp4@nttdata.com', N'emp4.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Sachin', 3, N'XjFWxI1p2x9RiGA6vGfvP+ehgJ863+cf1JY33YE9GT4=', CAST(N'2023-02-07T01:02:15.000' AS DateTime), CAST(N'2023-02-13T03:54:36.000' AS DateTime), 1, N'Sachin123', N'kjkldsa', N'sachin@nttdata.com', N'Sachin123.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Test', 3, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(N'2023-02-07T01:02:42.000' AS DateTime), NULL, 1, N'test', N'kjhkd', N'test@gmail.com', N'test.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'test1', 3, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(N'2023-02-07T01:03:21.000' AS DateTime), CAST(N'2023-02-13T03:54:48.000' AS DateTime), 1, N'test1', N'dsad', N'test@gmail.com', N'test1.jpg')
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Role] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Role]
GO
