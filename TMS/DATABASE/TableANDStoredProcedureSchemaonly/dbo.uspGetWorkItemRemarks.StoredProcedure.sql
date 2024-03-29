USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItemRemarks]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspGetWorkItemRemarks] 
	@Id int
AS
BEGIN
	
	SET NOCOUNT ON;
	if exists(SELECT 1 from WorkItemAssignment where WorkItemAssignmentId=@Id and Remarks is not null)
	RETURN 1; ---REMARKS EXISTS
	ELSE
	RETURN 0; --REMARKS DOES NOT EXISTS
END

GO
