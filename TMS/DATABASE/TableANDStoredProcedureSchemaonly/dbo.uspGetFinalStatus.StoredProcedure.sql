USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetFinalStatus]    Script Date: 9/1/2023 5:50:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetFinalStatus]
       @WorkitemId int
AS
BEGIN
       SET NOCOUNT ON;
          DECLARE @SQL VARCHAR(5000);
          SET @SQL ='SELECT TOP (1) dbo.WorkItemAssignment.WorkItemId, dbo.WorkItemAssignment.Status, dbo.Status.StatusDescription
                     FROM   dbo.WorkItemAssignment INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = dbo.Status.StatusId WHERE (dbo.WorkItemAssignment.WorkItemId = '+ CONVERT(varchar, @WorkitemId)  +' )
                     ORDER BY dbo.WorkItemAssignment.Status DESC'
          --if @ExcludeHandedOver = 1
          --BEGIN
          --           SET @SQL = @SQL + ' where Statusid <> 6'
          --END
		 print @SQL; 
       --EXEC(@SQL); 
END
GO
