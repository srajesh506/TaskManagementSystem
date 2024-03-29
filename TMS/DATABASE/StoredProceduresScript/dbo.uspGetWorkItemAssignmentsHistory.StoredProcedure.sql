USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItemAssignmentsHistory]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetWorkItemAssignmentsHistory]
         @WorkitemId int
       AS
BEGIN
       SET NOCOUNT ON;
	   DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'SELECT dbo.WorkItemAssignment.WorkItemAssignmentId as Id, 
                 dbo.WorkItemAssignment.WorkItemId as WorkItemId, 
                 dbo.WorkItem.WorkItemDescription as WorkItem, 
                 ISNULL(dbo.Status.StatusDescription,''--Choose--\'')  as Status,
                 ISNULL(AssignedTo.EmpName,''--Choose--'')  as AssignedTo,
                 FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate, 
                 FORMAT(dbo.WorkItemAssignment.HandOverOrClosedDate,''dd-MMM-yy hh:mm:ss'') as ClosedDate, 
                 ISNULL(HandedOverFrom.EmpName,''NA'')  as HandOverTo,
                 dbo.WorkItemAssignment.Remarks as Remarks
                 FROM 
                 dbo.WorkItemAssignment INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId 
                 INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = dbo.Status.StatusId 
                 LEFT OUTER JOIN dbo.Employee as AssignedTo ON dbo.WorkItemAssignment.UserIdAssigned = AssignedTo.UserId
                 LEFT OUTER JOIN dbo.Employee as HandedOverFrom ON dbo.WorkItemAssignment.UserIdHandedover = HandedOverFrom.UserId'
       
              SET @SQL = @SQL +  ' Where WorkItemAssignment.WorkItemId= ' + Convert(nvarchar(50),@WorkitemId) +' order by StartDate desc'
           --print  @SQL;
            EXEC(@SQL);   
END


GO
