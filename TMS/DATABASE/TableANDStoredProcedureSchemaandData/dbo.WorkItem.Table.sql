USE [TMS]
GO
/****** Object:  Table [dbo].[WorkItem]    Script Date: 9/1/2023 5:51:28 PM ******/
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
SET IDENTITY_INSERT [dbo].[WorkItem] ON 

INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (1, 1, 1, 1, N'INC1234567')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (2, 1, 1, 2, N'INC98765')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (3, 2, 12, 65, N'Azure')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (4, 3, 14, 79, N'ttt')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (5, 1, 3, 16, N'CHG0001')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (6, 2, 12, 65, N'Nanolearning - Data Protection 2023')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (7, 2, 12, 65, N'Nanolearning - Data Privacy 2023')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (8, 2, 12, 65, N'Nanolearning - Working Securely Remote or in the Office 2023')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (9, 3, 14, 79, N'Added Comments in lession learned crystal report KM catalog document')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (10, 3, 14, 80, N'TMS1')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (11, 4, 18, 79, N'TMS2')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (12, 5, 19, 194, N'Elevated Access')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (13, 5, 20, 197, N'Laptop Heating')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (14, 1, 5, 34, N'MMR')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (15, 3, 16, 189, N'INN')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (16, 1, 5, 33, N'DailyStatusReporting')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (17, 3, 17, 156, N'Return To Office')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (18, 2, 13, 75, N'Docker')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (19, 1, 2, 12, N'REQ45678')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (20, 1, 5, 34, N'MOD - Weekly meeting - MOM')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (21, 1, 6, 44, N'Facial Recognition using Python ')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (22, 1, 4, 115, N'PRO1234567')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (23, 1, 4, 116, N'PRO12345678')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (24, 1, 4, 117, N'PRO123456789')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (25, 2, 13, 72, N'FACE RECOGNITION')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (26, 1, 2, 11, N'REQ123456 Analysis')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (27, 1, 5, 32, N'Yammer API - Overview and Integration - KMP Documentation')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (28, 1, 7, 47, N'VPN')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (29, 1, 7, 47, N'SQUID')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (30, 5, 19, 194, N'HAWKEYE')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (31, 2, 12, 66, N'TIME MANAGEMENT')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (32, 3, 16, 91, N'CHATGPT')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (33, 1, 9, 129, N'First Monitoring')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (34, 1, 9, 130, N'First Monitoring 2
')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (35, 1, 9, 131, N'First Monitoring 3')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (36, 1, 9, 132, N'First Monitoring 4')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (37, 1, 9, 133, N'First Monitoring 5')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (38, 1, 6, 110, N'BIGDATA')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (39, 1, 7, 50, N'Dell.com')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (40, 1, 3, 18, N'CHG0677679')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (41, 1, 3, 19, N'CHG0677679')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (42, 1, 4, 115, N'TASK6122152 || REQ3261360 || RITM3331844 || Squid Proxy Server - Whitelist *.dellcdn.com URLs on OS-UTLP801 (CTC)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (43, 1, 3, 16, N'TASK5632138 || REQ3006442 || RITM3072372 || Removal of temporary Internet access of StackStorm servers through PTC Squid Proxy Server (OS-UTLP701)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (44, 1, 2, 10, N'REQ3006442')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (45, 1, 2, 14, N'TASK5632138 || REQ3006442 || RITM3072372 || Temporary Internet access to StackStorm servers through PTC Squid Proxy Server (OS-UTLP701)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (46, 1, 7, 48, N'CHG0621383')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (47, 1, 8, 125, N'Re-start App-pool as requested by IHSMarkit - INC15167919')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (48, 1, 5, 33, N'Synchup')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (49, 7, 21, 192, N'CHG0569841')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (50, 1, 3, 16, N'CHG0586360')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (51, 1, 6, 110, N'CHG0569836')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (52, 3, 16, 90, N'Virtual machine')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (53, 3, 14, 80, N'BestPracticesSubmission')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (54, 1, 1, 1, N'INC16022040 	TrueSight MD-WWWP842B Total CPU Utilization on MD-WWWP842B is at 100.00%, TH is 80.0%')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (55, 1, 1, 1, N'INC16002297')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (56, 1, 1, 1, N'TrueSight MD-WWWP715T Total CPU Utilization on MD-WWWP715T is at 100.00%, TH is 80.0%')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (57, 1, 8, 54, N'Enviroment Setup')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (58, 1, 1, 1, N'TrueSight MD-WWWP842B Total CPU Utilization on MD-WWWP842B is at 100.00%, TH is 80.0%')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (59, 2, 12, 69, N'TMSDocs')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (60, 1, 10, 139, N'MODPIMASP01')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (61, 1, 10, 140, N'MODPIMASP02')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (62, 1, 10, 141, N'MODPIMASP03')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (63, 1, 10, 142, N'MODPIMASP05')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (64, 1, 10, 144, N'MODPIMASP06')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (65, 1, 10, 145, N'MODPIMASP07')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (66, 1, 10, 146, N'MODPIMASP08')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (67, 1, 10, 147, N'MODPIMASP09')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (68, 1, 2, 15, N'REQ1234 Updates')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (69, 1, 7, 48, N'Start squid proxy service on server OS-UTLP701 and enable the auto-startup as requested by Nathan Shepard.')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (70, 1, 7, 48, N'Enable the auto-startup of squid proxy service on server OS-UTLP801 as requested by Nathan Shepard.')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (71, 1, 7, 48, N'REQ2590266 || TASK4774243 || Squid Proxy Server - Whitelist Azure CDN URLs on OS-UTLP801 (CTC)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (72, 1, 7, 48, N'REQ2590266 || TASK4774243 || Squid Proxy Server - Whitelist Azure CDN URLs on OS-UTLP701 (PTC)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (73, 1, 1, 4, N'INC10717459 | TrueSight MD-WWWP875C Health AT A Glance Total Processor Utilization >= 92% for 10 min.')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (74, 1, 1, 1, N'INC10776871 | TrueSight MD-WWWP776B Health AT A Glance Total Processor Utilization >= 92% for 10 min.')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (75, 1, 1, 1, N'STD- MOD - SERVER/SERVICES RESTART MD-WWWP880A')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (76, 1, 1, 1, N'STD- MOD - SERVER/SERVICES RESTART <INC11076586 | IISReset | MD-WWWA742B>')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (77, 1, 1, 1, N'STD- MOD - SERVER/SERVICES RESTART <INC11099267 | IISReset | MD-WWWA742B>')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (78, 1, 1, 1, N'STD- MOD - SERVER/SERVICES RESTART <INC11108967 | INC11108816 | IISReset | MD-WWWA742A | MD-WWWA742B>')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (79, 1, 1, 1, N'TrueSight MD-WWWP776C Health AT A Glance Total Processor Utilization >= 92% for 10 min.<INC11208802 | IISReset>')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (80, 1, 1, 1, N'INC11213834 | IISRESET | TrueSight MD-WWWP776B Health AT A Glance Total Processor Utilization >= 92% for 10 min.')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (81, 1, 1, 1, N'STD- MOD - <INC12172587 | | IISReset | MD-WWWP712C >')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (82, 1, 1, 2, N'Perform IISReset as requested by IHSMarkit - INC12905269 | High CPU Usage')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (83, 1, 1, 1, N'Perform IISReset as requested by IHSMarkit - INC12905269 | High CPU Usage')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (84, 1, 1, 1, N'	REQ2590266 || TASK4774243 || Squid Proxy Server - Whitelist Azure CDN URLs on OS-UTLP801 (CTC)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (85, 1, 1, 3, N'Restart IIS Service on Server OS-WWWA757B')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (86, 1, 1, 1, N'OS-WWWP859D.PROD.MDGAPP.NET | Memory Low: 97% used (552.9MB free)(Th:92-100)')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (87, 1, 1, 1, N'INC8627716 | OS-WWWP815E.PROD.MDGAPP.NET | CPU High: 100% used')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (88, 1, 4, 27, N'	OS-WWWP815L.PROD.MDGAPP.NET | CPU High: 100% used')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (89, 1, 3, 16, N'CHG0317804')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (90, 1, 3, 16, N'CHG0317793')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (91, 1, 1, 1, N'CHG0331155')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (92, 1, 1, 1, N'CHG0309776')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (93, 1, 1, 1, N'CHG0309701')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (94, 1, 1, 3, N'INC16002297')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (95, 1, 1, 3, N'INC15047294')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (96, 1, 1, 2, N'INC15118653')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (97, 1, 1, 1, N'INC15269599')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (98, 1, 1, 1, N'INC14538395')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (99, 1, 1, 3, N'INC15075662	')
GO
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (100, 3, 16, 189, N'IINNNNN')
SET IDENTITY_INSERT [dbo].[WorkItem] OFF
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
