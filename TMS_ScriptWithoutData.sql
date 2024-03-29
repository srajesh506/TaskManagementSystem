USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 3/17/2023 4:32:46 PM ******/
CREATE DATABASE [TMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\TMS_log.ldf' , SIZE = 4288KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TMS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TMS] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TMS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TMS] SET RECOVERY FULL 
GO
ALTER DATABASE [TMS] SET  MULTI_USER 
GO
ALTER DATABASE [TMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TMS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TMS', N'ON'
GO
USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspAddRole]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ===========================================
-- Description: Adds a new role in Database 
-- ===========================================
CREATE PROCEDURE [dbo].[uspAddRole]
       @RoleName nvarchar(50),
       @IsAdmin bit
       AS
BEGIN
       SET NOCOUNT OFF;
       Insert into [TMS].[dbo].[Role] ([RoleName],[IsAdmin],[CreatedDate],[ModifyDate]) values (@RoleName,@IsAdmin,Format(GETDATE(),'dd-MMM-yy hh:mm:ss'),null)
END

GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateActivity]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[uspAddUpdateActivity] 
       -- Add the parameters for the stored procedure here
       @ActivityId int,
       @ActivityName nvarchar(500), 
       @ActivityDescription nvarchar(2000),
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[Activity]
              ([ActivityName]
                ,[ActivityDescription]
                ,[IsActive]
                ,[CreatedDate])
                values (@ActivityName,@ActivityDescription,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[Activity] set [ActivityName] = @ActivityName, [ActivityDescription] = @ActivityDescription,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [ActivityId] = @ActivityId
       END
END


GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateEmployee]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddUpdateEmployee]
       @EmpName nvarchar(500),
       @RoleID int,
       @Password nvarchar(500),
       @IsActive bit,
       @UserId nvarchar(50),
       @Remark nvarchar(500),
       @Email nvarchar(500),
       @Pic nvarchar(50),

       @UpdateFlag int
       AS
BEGIN
       SET NOCOUNT OFF;
       IF @UpdateFlag = 0
       BEGIN
              INSERT into [TMS].[dbo].[Employee]
              ([EmpName]
              ,[RoleId]
              ,[Password]
              ,[CreatedDate]
              ,[IsActive]
              ,[UserId]
              ,[Remark]
              ,[Email]
              ,[Pic])
              Values (@EmpName, @RoleId, @Password,Format(GETDATE(),'dd-MMM-yy hh:mm:ss'),@IsActive,@UserId,@Remark,@Email,@Pic)
       END
       ELSE IF @UpdateFlag = 1
       BEGIN
              UPDATE [TMS].[dbo].[Employee] 
              SET [EmpName] = @EmpName
              ,[RoleId] = @RoleId
              ,[Password]= @Password
              ,[ModifyDate] = Format(GETDATE(),'dd-MMM-yy hh:mm:ss')
              ,[IsActive] = @IsActive
              ,[Remark] = @Remark
              ,[Email] = @Email
              ,[Pic] = @Pic
              WHERE [UserId] = @UserId
       END
END


GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateSubTask]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[uspAddUpdateSubTask] 
       -- Add the parameters for the stored procedure here
       @SubTaskId int,
       @SubTaskName nvarchar(50), 
       @SubTaskDescription nvarchar(50),
       @ActivityId int,
       @TaskId int,
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[SubTask]
              ([SubTaskName]
                ,[SubTaskDescription]
                ,[ActivityId]
                ,[TaskId]
                ,[IsActive]
                ,[CreatedDate])
                values (@SubTaskName,@SubTaskDescription,@ActivityId,@TaskId,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[SubTask] set [SubTaskName] = @SubTaskName, [SubTaskDescription] = @SubTaskDescription,[ActivityId]=@ActivityId,[TaskId]=@TaskId,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [SubTaskId] = @SubTaskId
       END
END

GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateTask]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[uspAddUpdateTask] 
       @TaskId int,
       @TaskName nvarchar(50), 
       @TaskDescription nvarchar(50),
       @ActivityId int,
       @IsActive bit,
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       Declare @tempDate datetime;
       Select @tempDate = Format(GETDATE(),'dd-MMM-yy hh:mm:ss');
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[Task]
              ([TaskName]
                ,[TaskDescription]
                ,[ActivityId]
                ,[IsActive]
                ,[CreatedDate])
                values (@TaskName,@TaskDescription,@ActivityId,@IsActive,@tempDate)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[Task] set [TaskName] = @TaskName, [TaskDescription] = @TaskDescription,[ActivityId]=@ActivityId,[IsActive]=@IsActive,[ModifyDate]= @tempDate where [TaskId] = @TaskId
       END
END

GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItem]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddUpdateWorkItem] 
       @WorkItemId int,
       @ActivityId int, 
       @TaskId int,
       @SubTaskId int,
       @WorkItemDescription nvarchar(500),
       @UpdateFlag bit
AS
BEGIN
       SET NOCOUNT OFF;
       IF @UpdateFlag = 0
       Begin
              Insert into [TMS].[dbo].[WorkItem]([ActivityId],[TaskId],[SubTaskId],[WorkItemDescription]) values (@ActivityId,@TaskId,@SubTaskId,@WorkItemDescription)
              DECLARE @Id INT = SCOPE_IDENTITY();
              Insert into [TMS].[dbo].[WorkItemAssignment]([WorkItemId],[Status]) values (@Id,1)
       END
       ELSE IF @UpdateFlag = 1
       Begin
              Update [TMS].[dbo].[WorkItem] set [ActivityId] = @ActivityId, [TaskId] = @TaskId,[SubTaskId]=@SubTaskId,[WorkItemDescription]=@WorkItemDescription where [WorkItemId] = @WorkItemId;
       END
END

GO
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItemAssignment]    Script Date: 3/17/2023 4:32:46 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddWorkItemAssignment]    Script Date: 3/17/2023 4:32:46 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspChangePassword]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspChangePassword]
       @UserId nvarchar(50),
       @Password nvarchar(500)
AS
BEGIN
       SET NOCOUNT ON;
       BEGIN
              UPDATE [TMS].[dbo].[Employee] SET [Password]= @Password, [ModifyDate] = Format(GETDATE(),'dd-MMM-yy hh:mm:ss') WHERE [UserId] = @UserId + ' [IsActive] = 1'
       END
END
GO
/****** Object:  StoredProcedure [dbo].[uspCheckLogin]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspCheckLogin]
       @UserId nvarchar(50),
       @Password nvarchar(500)
AS
BEGIN
       SET NOCOUNT ON;
       BEGIN
              SELECT r.RoleName, e.RoleId, r.IsAdmin FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.UserId = @UserId and e.Password=@Password and e.IsActive = 1
       END
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetActivities]    Script Date: 3/17/2023 4:32:46 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetAssigneeBasedReport]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetAssigneeBasedReport] 
       @PageNum INT=1,
       @PageSize INT=5,
       @DateFrom DateTime,
       @DateTo DateTime,
       @RangeFlagChecked bit = 0,
       @UserId nvarchar(50) = null,
	   @TotalRecords INT = 0 OUTPUT
AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords =Count( dbo.WorkItem.WorkItemDescription) FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY SubTaskId) as SLNO,dbo.WorkItem.WorkItemDescription AS WorkItem
                        ,FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate
                        ,FORMAT(dbo.WorkItemAssignment.[HandOverOrClosedDate],''dd-MMM-yy hh:mm:ss'') AS EndDate
                        ,ISNULL(Status.StatusDescription,''Open'') AS Status
                        ,ISNULL(EmployeeAssigned.EmpName, ''Not Assigned'') AS [Assiged To]
                        ,ISNULL(EmployeeHandedOver.EmpName,''NA'') AS [HandedOver To]
                        FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1'
       IF @UserID is not null
       BEGIN
              SET @SQL = @SQL + ' and dbo.WorkItemAssignment.UserIdAssigned=''' + @UserId + ''' '
       END
       IF @RangeFlagChecked = 1
       BEGIN
              SET @SQL = @SQL + ' and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) Between ''' + FORMAT(@DateFrom, 'dd-MMM-yy') + ''' and ''' + FORMAT(@DateTo, 'dd-MMM-yy') + ''''
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       print @SQL;
	   EXEC(@SQL); 
END



GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployees]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetEmployees]
       @UserId nvarchar(50) = null,
       @IsActive int 
       AS
BEGIN
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'SELECT UserId, EmpName FROM dbo.Employee where 1=1'
       IF @UserId is not null 
       BEGIN
              SET @SQL = @SQL + ' and dbo.Employee.UserId = '''+@UserId+''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.Employee.IsActive = 1'
       END
       EXEC(@SQL);   
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[uspGetEmployeesRoles] 
       @PageNum INT=1,
       @PageSize INT=5,
       @TotalRecords INT OUTPUT
AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
       SELECT @TotalRecords = COUNT(e.UserId) FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1;

       IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;

       With SortedEmployees AS 
       (
              SELECT ROW_NUMBER() OVER(ORDER BY e.UserId) as RowNum,
              e.UserId AS [User Id], 
              e.EmpName AS [Employee Name], 
              r.RoleName AS Role, 
              e.Email AS [Email ID], 
              e.Remark AS Remarks, 
              e.Password, 
              e.Pic, 
              e.RoleId, 
              e.IsActive
              FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId
              where e.IsActive = 1
       )
       SELECT Top(@RecordsToReturn) * FROM SortedEmployees 
              WHERE RowNum > (@PageNum-1) * @PageSize  

END


GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles_forpaging]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetEmployeesRoles_forpaging] 
      @page int,
	  @PageSize nvarchar(50)=2
AS
BEGIN
       SET NOCOUNT ON;
	    DECLARE @SQL VARCHAR(5000);
		 DECLARE @SQL_P VARCHAR(5000);
		DECLARE @PreviouspageLimit nvarchar(50);
		SET @PreviouspageLimit = (@page - 1) * @PageSize;

		 SET @SQL ='SELECT  TOP ' + @PageSize  + ' e.UserId AS [User Id], e.EmpName AS [Employee Name], r.RoleName AS Role, e.Email AS [Email ID], e.Remark AS Remarks, e.Password, e.Pic, e.RoleId, e.IsActive
                     FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1'
					  --print @SQL;

	   IF @page!=1
	   BEGIN
	        SET @SQL_P='SELECT  TOP ' + @PreviouspageLimit + ' e.UserId FROM dbo.Employee AS e INNER JOIN dbo.Role AS r ON e.RoleId = r.RoleId where e.IsActive = 1'
	        SET @SQL = @SQL + ' and e.UserId NOT IN   (' + @SQL_P  +')'
	   END
	   --print @SQL;
	    exec(@SQL);
	 
	 
	   
      
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetRoles]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetRoles]
       @RoleName nvarchar(50) = null
       AS
BEGIN
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(500);
       SET @SQL = 'SELECT * FROM dbo.Role'
       IF @RoleName is not null
       BEGIN
              SET @SQL = @SQL + ' Where dbo.Role.RoleName = '''+@RoleName+''''
       END
       SET @SQL = @SQL + ' order by dbo.Role.RoleId'
       EXEC(@SQL);   
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetStatus]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ========================================================================================================
-- Description: Returns the status values from the Database.
--                         if excludeHandedOver flag is true, it doesnt return HandedOver Status value
--                         if excludeHandedOver flag is false, it returns all status values including HandedOver
-- ========================================================================================================
CREATE PROCEDURE [dbo].[uspGetStatus]
       @ExcludeHandedOver bit = 0
AS
BEGIN
       SET NOCOUNT ON;
          DECLARE @SQL VARCHAR(5000);
          SET @SQL ='Select StatusId,StatusDescription from Status'
          if @ExcludeHandedOver = 1
          BEGIN
                     SET @SQL = @SQL + ' where Statusid <> 6'
          END
       EXEC(@SQL); 
END


GO
/****** Object:  StoredProcedure [dbo].[uspGetStatusBasedReport]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetStatusBasedReport] 
       @PageNum INT=1,
       @PageSize INT=5,
       @DateFrom DateTime,
       @DateTo DateTime,
       @RangeFlagChecked bit = 0,
       @StatusId int=-1,
	   @TotalRecords INT = 0 OUTPUT
AS
BEGIN
DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	     SELECT @TotalRecords =Count(dbo.WorkItem.WorkItemDescription)
                        FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL ='With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY dbo.WorkItemAssignment.WorkItemAssignmentId) as SLNO, dbo.WorkItem.WorkItemDescription AS WorkItem
                        ,FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate
                        ,FORMAT(dbo.WorkItemAssignment.[HandOverOrClosedDate],''dd-MMM-yy hh:mm:ss'') AS EndDate
                        ,ISNULL(Status.StatusDescription,''Open'') AS Status
                        ,ISNULL(EmployeeAssigned.EmpName, ''Not Assigned'') AS [Assiged To]
                        ,ISNULL(EmployeeHandedOver.EmpName,''NA'') AS [HandedOver To]
                        FROM dbo.WorkItemAssignment 
                        INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                        INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                        LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId where 1=1'
       IF @StatusId != -1
       BEGIN
              SET @SQL = @SQL + ' and dbo.WorkItemAssignment.Status=' + CAST(@StatusId AS nvarchar(50))
       END
       IF @RangeFlagChecked = 1
       BEGIN
              SET @SQL = @SQL + ' and DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) Between ''' + FORMAT(@DateFrom, 'dd-MMM-yy') + ''' and ''' + FORMAT(@DateTo, 'dd-MMM-yy') + ''''
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
	   print @SQL;
       EXEC(@SQL); 
END


GO
/****** Object:  StoredProcedure [dbo].[uspGetSubTasks]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetSubTasks]
       @PageNum INT=1,
       @PageSize INT=5,
       @IsActive bit=0,
       @SubTaskId int = -1,
       @TaskId int = -1,
       @ActivityId int = -1,
       @SubTaskName Nvarchar(50) = null,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords = Count(Activity.ActivityName) from SubTask INNER JOIN Task ON SubTask.TaskID = Task.TaskID INNER JOIN Activity On SubTask.ActivityId=Activity.ActivityId where 1=1;
	     IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL NVARCHAR(2000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY SubTaskId) as SLNO
                           ,ActivityName as [Activity Name]
                           ,TaskName as [Task Name]
                           ,SubTaskname as [SubTask Name]
                           ,SubTaskDescription as [SubTask Description]
                           ,SubTask.IsActive
                           ,SubTask.TaskId
                           ,SubTask.ActivityId
                           ,Subtaskid from SubTask
                           INNER JOIN Task ON SubTask.TaskID = Task.TaskID
                           INNER JOIN Activity On SubTask.ActivityId=Activity.ActivityId where 1=1'
       IF @SubTaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.SubTaskId = ' + +CAST(@SubTaskId AS NVARCHAR(10))
       END
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.TaskId = ' + +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.ActivityId = ' + +CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @SubTaskName is not null
       BEGIN  
              SET @SQL = @SQL + ' and dbo.SubTask.SubTaskName = ''' + @SubTaskName + ''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.SubTask.IsActive = 1'
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       EXEC(@SQL);   
END

GO
/****** Object:  StoredProcedure [dbo].[uspGetTasks]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetTasks]
       @PageNum INT=1,
       @PageSize INT=5,
       @IsActive bit = 0,
       @TaskId int = -1,
       @ActivityId int = -1,
       @TaskName Nvarchar(50) = null,
	    @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
 DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
       DECLARE @SQL VARCHAR(1000);
	    SELECT @TotalRecords = COUNT(TaskId) FROM dbo.Task where IsActive = 1;
	     IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;

      SET @SQL = 'With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY TaskId)SLNO
                           ,ActivityName as [Activity Name]
                           ,TaskName as [Task Name]
                           ,TaskDescription as [Task Description]
                           ,Task.IsActive
                           ,taskid
                           ,Task.ActivityId
                           FROM dbo.Task inner join dbo.Activity on dbo.Task.ActivityId = dbo.Activity.ActivityId
                           where 1=1'
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.TaskId = ' + +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.ActivityId = ' + +CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @TaskName is not null
       BEGIN  
              SET @SQL = @SQL + ' and dbo.Task.TaskName = ''' + @TaskName + ''' '
       END
       IF @IsActive = 1
       BEGIN
              SET @SQL = @SQL + ' and dbo.Task.IsActive =1'
       END
	    SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       EXEC(@SQL);   
	   --print @SQL;
END
GO
/****** Object:  StoredProcedure [dbo].[uspGetTimeBasedReport]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetTimeBasedReport] 
       @PageNum INT=1,
       @PageSize INT=5,
       @DateFrom DateTime,
       @DateTo DateTime,
	   @TotalRecords INT = 0 OUTPUT
AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;

	    SELECT @TotalRecords =COUNT(dbo.WorkItem.WorkItemDescription)
                           FROM dbo.WorkItemAssignment 
                           INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                           INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                           LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                           LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId 
                           where DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) BETWEEN '' + FORMAT(@DateFrom, 'dd-MMM-yy') + '' AND '' + FORMAT(@DateTo, 'dd-MMM-yy') + '' 
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY dbo.WorkItemAssignment.StartDate) as SLNO, dbo.WorkItem.WorkItemDescription AS WorkItem
                           ,FORMAT(dbo.WorkItemAssignment.StartDate, ''dd-MMM-yy hh:mm:ss'') AS StartDate
                           ,FORMAT(dbo.WorkItemAssignment.[HandOverOrClosedDate],''dd-MMM-yy hh:mm:ss'') AS EndDate
                           ,ISNULL(Status.StatusDescription,''Open'') AS Status
                           ,ISNULL(EmployeeAssigned.EmpName, ''Not Assigned'') AS [Assiged To]
                           ,ISNULL(EmployeeHandedOver.EmpName,''NA'') AS [HandedOver To]
                           FROM dbo.WorkItemAssignment 
                           INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId
                           INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = StatusId 
                           LEFT OUTER JOIN dbo.Employee AS EmployeeHandedOver ON dbo.WorkItemAssignment.UserIdHandedover = EmployeeHandedOver.UserId 
                           LEFT OUTER JOIN dbo.Employee AS EmployeeAssigned ON dbo.WorkItemAssignment.UserIdAssigned = EmployeeAssigned.UserId 
                           where DATEADD(dd, 0, DATEDIFF(dd, 0, dbo.WorkItemAssignment.StartDate)) Between ''' + FORMAT(@DateFrom, 'dd-MMM-yy') + ''' and ''' + FORMAT(@DateTo, 'dd-MMM-yy') + ''''
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
	   print @SQL;
       EXEC(@SQL); 
END


GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItemAssignments]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetWorkItemAssignments]
         @PageNum INT=1,
       @PageSize INT=5,
       @FilterFlag int,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	    SELECT @TotalRecords = Count(dbo.WorkItemAssignment.WorkItemAssignmentId) FROM dbo.WorkItemAssignment INNER JOIN dbo.WorkItem ON dbo.WorkItemAssignment.WorkItemId = dbo.WorkItem.WorkItemId 
                 INNER JOIN dbo.Status ON dbo.WorkItemAssignment.Status = dbo.Status.StatusId 
                 LEFT OUTER JOIN dbo.Employee as AssignedTo ON dbo.WorkItemAssignment.UserIdAssigned = AssignedTo.UserId
                 LEFT OUTER JOIN dbo.Employee as HandedOverFrom ON dbo.WorkItemAssignment.UserIdHandedover = HandedOverFrom.UserId
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (SELECT ROW_NUMBER()OVER(ORDER BY dbo.WorkItemAssignment.StartDate DESC)SLNO,dbo.WorkItemAssignment.WorkItemAssignmentId as Id, 
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
       IF @FilterFlag = 1
       BEGIN
              SET @SQL = @SQL + ' Where dbo.WorkItemAssignment.Status not in (5,6)'
       END
       --SET @SQL = @SQL + ' Order BY dbo.WorkItemAssignment.StartDate'
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
	   print @SQL;
       EXEC(@SQL);   
END



GO
/****** Object:  StoredProcedure [dbo].[uspGetWorkItems]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspGetWorkItems]
       -- Add the parameters for the stored procedure here
	   @PageNum INT=1,
       @PageSize INT=5,
       @ActivityId int = -1,
       @TaskId int = -1,
       @SubTaskId int = -1,
	   @TotalRecords INT = 0 OUTPUT
       AS
BEGIN
       DECLARE @RecordsToReturn INT = 10
       SET NOCOUNT ON;
	   SELECT @TotalRecords = Count(a.ActivityName) from WorkItem w inner join Activity a on w.ActivityId = a.ActivityId left outer join Task t on w.TaskId = t.TaskId left outer join SubTask s on w.SubTaskId = s.SubTaskId where 1=1;
	   IF @RecordsToReturn < @PageSize
       BEGIN
              SET @RecordsToReturn = @PageSize
       END;
       DECLARE @SQL VARCHAR(5000);
       SET @SQL = 'With SortedEmployees AS (Select ROW_NUMBER()OVER(ORDER BY w.WorkItemId)SLNO
                           ,a.ActivityName as [Activity Name]
                           ,t.TaskName as [Task Name]
                           ,s.SubTaskName as [SubTask Name]
                           ,w.WorkItemDescription
                           ,w.TaskId
                           ,w.ActivityId
                           ,w.SubTaskId
                           ,w.WorkItemId 
                           from WorkItem w inner join Activity a on w.ActivityId = a.ActivityId 
                           left outer join Task t on w.TaskId = t.TaskId 
                           left outer join SubTask s on w.SubTaskId = s.SubTaskId where 1=1'
       IF @ActivityId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.ActivityId=' + CAST(@ActivityId AS NVARCHAR(10))
       END
       IF @TaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.TaskId = ' +CAST(@TaskId AS NVARCHAR(10))
       END
       IF @SubTaskId > 0
       BEGIN
              SET @SQL = @SQL + ' and w.SubTaskId = ' +CAST(@SubTaskId AS NVARCHAR(10)) 
       END
	   SET @SQL = @SQL + ')' + ' SELECT Top('+ cast(@RecordsToReturn as nvarchar) + ') * FROM SortedEmployees WHERE SLNO > ('+ cast(@PageNum  as nvarchar) + ' -1) * ' + cast(@PageSize  as nvarchar)
       EXEC(@SQL);   
END
GO
/****** Object:  StoredProcedure [dbo].[uspTimeBasedReport]    Script Date: 3/17/2023 4:32:46 PM ******/
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
/****** Object:  Table [dbo].[Activity]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[ActivityName] [nvarchar](500) NOT NULL,
	[ActivityDescription] [nvarchar](2000) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_tbl_activity] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/17/2023 4:32:46 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](100) NULL,
	[IsAdmin] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Status]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDescription] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubTask]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubTask](
	[SubTaskId] [int] IDENTITY(1,1) NOT NULL,
	[SubTaskName] [nvarchar](50) NULL,
	[SubTaskDescription] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[TaskId] [int] NULL,
	[ActivityId] [int] NULL,
 CONSTRAINT [PK_SubTask] PRIMARY KEY CLUSTERED 
(
	[SubTaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Task]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Task](
	[TaskId] [int] IDENTITY(1,1) NOT NULL,
	[TaskName] [nvarchar](50) NULL,
	[TaskDescription] [nvarchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
	[ActivityId] [int] NULL,
 CONSTRAINT [PK_tbl_task] PRIMARY KEY CLUSTERED 
(
	[TaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[temp]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[temp](
	[Activity Name] [nvarchar](500) NOT NULL,
	[Task Name] [nvarchar](50) NULL,
	[SubTask Name] [nvarchar](50) NULL,
	[TaskId] [int] NULL,
	[ActivityId] [int] NULL,
	[SubTaskId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkItem]    Script Date: 3/17/2023 4:32:46 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkItemAssignment]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkItemAssignment](
	[WorkItemAssignmentId] [int] IDENTITY(1,1) NOT NULL,
	[WorkItemId] [int] NULL,
	[UserIdAssigned] [nvarchar](50) NULL,
	[UserIdHandedover] [nvarchar](50) NULL,
	[StartDate] [datetime] NULL,
	[HandOverOrClosedDate] [datetime] NULL,
	[Status] [int] NULL,
	[Remarks] [nvarchar](200) NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_SubtaskRelateTaskandActivity]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_SubtaskRelateTaskandActivity]
AS
SELECT        s.SubTaskId, a.ActivityName, t.TaskName, s.SubTaskName, s.SubTaskDescription, s.IsActive, s.TaskId, s.ActivityId
FROM            dbo.SubTask AS s INNER JOIN
                         dbo.Activity AS a ON s.ActivityId = a.ActivityId INNER JOIN
                         dbo.Task AS t ON a.ActivityId = t.ActivityId AND s.TaskId = t.TaskId
WHERE        (a.IsActive = 1)


GO
/****** Object:  View [dbo].[View_workitems]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_workitems]
AS
SELECT        dbo.View_SubtaskRelateTaskandActivity.activityid, dbo.WorkItem.WorkItemDescription, dbo.View_SubtaskRelateTaskandActivity.activityname, dbo.View_SubtaskRelateTaskandActivity.taskname, 
                         dbo.View_SubtaskRelateTaskandActivity.subtaskname, dbo.View_SubtaskRelateTaskandActivity.taskid, dbo.View_SubtaskRelateTaskandActivity.subtaskid, dbo.View_SubtaskRelateTaskandActivity.isactive, 
                         dbo.WorkItem.WorkItemId
FROM            dbo.View_SubtaskRelateTaskandActivity INNER JOIN
                         dbo.WorkItem ON dbo.View_SubtaskRelateTaskandActivity.activityid = dbo.WorkItem.ActivityId AND dbo.View_SubtaskRelateTaskandActivity.taskid = dbo.WorkItem.TaskId AND 
                         dbo.View_SubtaskRelateTaskandActivity.subtaskid = dbo.WorkItem.SubTaskId


GO
/****** Object:  View [dbo].[View_taskrelateactivity]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[View_taskrelateactivity]
AS
SELECT        t.TaskId, a.ActivityName, t.TaskName, t.TaskDescription, t.IsActive, a.ActivityId
FROM            dbo.Activity AS a INNER JOIN
                         dbo.Task AS t ON a.ActivityId = t.ActivityId
WHERE        (a.IsActive = 1)


GO
/****** Object:  View [dbo].[vwGetEmployeesRoles]    Script Date: 3/17/2023 4:32:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vwGetEmployeesRoles]
AS
SELECT        e.UserId AS [User Id], e.EmpName AS [Employee Name], r.RoleName AS Role, e.Email AS [Email ID], e.Remark AS Remarks, e.Password, e.Pic, e.RoleId, e.IsActive
FROM            dbo.Employee AS e INNER JOIN
                         dbo.Role AS r ON e.RoleId = r.RoleId


GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Rolemaster_createdate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Role] ADD  CONSTRAINT [DF_Rolemaster_modifydate]  DEFAULT (getdate()) FOR [ModifyDate]
GO
ALTER TABLE [dbo].[Task]  WITH CHECK ADD  CONSTRAINT [FK_tbl_task_tbl_activity] FOREIGN KEY([ActivityId])
REFERENCES [dbo].[Activity] ([ActivityId])
GO
ALTER TABLE [dbo].[Task] CHECK CONSTRAINT [FK_tbl_task_tbl_activity]
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
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[5] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 1
               Left = 84
               Bottom = 192
               Right = 273
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "s"
            Begin Extent = 
               Top = 124
               Left = 394
               Bottom = 341
               Right = 586
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 4
               Left = 864
               Bottom = 254
               Right = 1073
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubtaskRelateTaskandActivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_SubtaskRelateTaskandActivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[25] 4[21] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "t"
            Begin Extent = 
               Top = 6
               Left = 470
               Bottom = 194
               Right = 642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 680
               Bottom = 194
               Right = 869
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 2730
         Width = 2985
         Width = 4095
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 2850
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_taskrelateactivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_taskrelateactivity'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[26] 4[31] 2[11] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "View_SubtaskRelateTaskandActivity"
            Begin Extent = 
               Top = 6
               Left = 380
               Bottom = 252
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "WorkItem"
            Begin Extent = 
               Top = 6
               Left = 606
               Bottom = 249
               Right = 807
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 2025
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3450
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitems'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_workitems'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "e"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "r"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwGetEmployeesRoles'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwGetEmployeesRoles'
GO
USE [master]
GO
ALTER DATABASE [TMS] SET  READ_WRITE 
GO
