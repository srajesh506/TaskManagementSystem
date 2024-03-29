USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItemAssignment]    Script Date: 9/1/2023 5:51:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===========================================================================================================================================================
-- Description: Assign a user to an unassigned WorkItem or Handover a workitem to other user
--                          Update the Status of WorkItem Assignment to "InProgress, Pending" etc 
--                         Update any Remarks against WorkItem Assignment
-- ===========================================================================================================================================================
CREATE PROCEDURE [dbo].[uspAddUpdateWorkItemAssignment] 
       @WorkItemAssignmentId int, 
       @WorkItemId int,
       @UserId nvarchar(50)=null,
       @Status int,
       @Remarks nvarchar(200)
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UserId is not null
       Begin
              Declare @tempempid nvarchar(50);
			  Declare @tempstatus nvarchar(500);
              Select @tempempid = UserIdAssigned,@tempstatus=Status from [TMS].[dbo].[WorkItemAssignment] where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId;
              if @tempempid is NOT Null
              Begin
                     update [TMS].[dbo].[WorkItemAssignment] set HandOverOrClosedDate = @tempDate, UserIdHandedover = @UserId where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId  
                     Insert into [TMS].[dbo].[WorkItemAssignment] (WorkItemId,[UserIdAssigned],StartDate,[Status]) values (@WorkItemId,@UserId,@tempDate,@tempstatus)
              End
              Else
              Begin
                     update [TMS].[dbo].[WorkItemAssignment] set UserIdAssigned = @UserId, StartDate = @tempDate where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId
              End
       END
       If @status != 0
       BEGIN
              If @status = 5 or @status = 6
              Begin
                     update [TMS].[dbo].[WorkItemAssignment] set Status = @status,  HandOverOrClosedDate = @tempDate where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId
              End
              Else
              Begin
                     update [TMS].[dbo].[WorkItemAssignment] set Status = @status where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId  
              End
       END
       If @remarks != ''
       BEGIN
              update [TMS].[dbo].[WorkItemAssignment] set remarks = @remarks where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId
       END
END
GO
