USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspTimeBasedReport]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[uspTimeBasedReport] 
	@DateFrom DateTime,
	@DateTo DateTime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	   DECLARE @SQL VARCHAR(5000);
	    SET @SQL ='SELECT dbo.WorkItem.WorkItemDescription AS WorkItem, FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate, 
	              FORMAT(dbo.WorkItemAssignment.[HandOverOrClosedDate],''dd-MMM-yy hh:mm:ss'') AS ClosedDate, ISNULL(StatusDescription,''--Choose--'') AS Status, 
				  ISNULL(Employee_1.EmpName, ''--Choose--'') AS Employee, ISNULL(dbo.Employee.EmpName,''NA'') AS HandedoverTO FROM dbo.WorkItemAssignment INNER JOIN 
				  dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemAssignmentId = dbo.WorkItem.WorkItemId INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
				  LEFT OUTER JOIN dbo.Employee ON dbo.WorkItemAssignment.UserIdHandedover = dbo.Employee.userid LEFT OUTER JOIN dbo.Employee AS Employee_1 
				  ON dbo.WorkItemAssignment.UserIdAssigned = Employee_1.userid where DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) Between ''' + FORMAT(@DateFrom, 'dd-MMM-yy') + ''' and ''' + FORMAT(@DateTo, 'dd-MMM-yy') + ''''
	  EXEC(@SQL);	
	   --PRINT @SQL
END
GO
