USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddWorkItemAssignment]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspAddWorkItemAssignment] 
	-- Add the parameters for the stored procedure here
	@WorkItemAssignmentId int, 
	@WorkItemId int,
	@UserId int,
	@Status int,
	@Remarks nvarchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	Declare @tempDate datetime;
	Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
	IF @UserId != 0
	Begin
		Declare @tempempid int;	
		Select @tempempid = UserIdAssigned from [TMS].[dbo].[WorkItemAssignment] where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId;
		if @tempempid is NOT Null
		Begin
			update [TMS].[dbo].[WorkItemAssignment] set [TMS].[dbo].[WorkItemAssignment].Status = 6, HandOverOrClosedDate = @tempDate, UserIdHandedover = @UserId where WorkItemAssignmentId = @WorkItemAssignmentId AND WorkItemId = @WorkItemId	
			Insert into [TMS].[dbo].[WorkItemAssignment] (WorkItemId,[UserIdAssigned],StartDate,[Status]) values (@WorkItemId,@UserId,@tempDate,1)
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
