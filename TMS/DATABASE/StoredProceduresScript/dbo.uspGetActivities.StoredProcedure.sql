USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetActivities]    Script Date: 9/1/2023 5:48:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspGetActivities] 
       @PageNum INT=1,
       @PageSize INT=5,
       @IsActive bit = 0,
       @ActivityId int = -1,
       @ActivityName NVarchar(50) = null,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	   SELECT @TotalRecords = COUNT(ActivityId) FROM dbo.Activity where IsActive = 1;
	     IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(500);
       SET @SQL = 'With SortedEmployees AS ( SELECT  ROW_NUMBER() OVER(ORDER BY ActivityId) as SLNO,* FROM dbo.Activity where 1=1'
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.Activity.ActivityId = ' + CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @ActivityName is not null
       BEGIN
              SET @SQL = @SQL + ' and dbo.Activity.ActivityName = ''' + @ActivityName + ''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.Activity.IsActive = 1' 
       END
	    SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)

		print @SQL;
       EXEC(@SQL);    
END
GO
