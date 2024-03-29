USE [master]
GO
/****** Object:  Database [TMS]    Script Date: 3/17/2023 4:31:35 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddRole]    Script Date: 3/17/2023 4:31:35 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateActivity]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateEmployee]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateSubTask]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateTask]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItem]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddUpdateWorkItemAssignment]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspAddWorkItemAssignment]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspChangePassword]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspCheckLogin]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetActivities]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetAssigneeBasedReport]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetEmployees]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetEmployeesRoles_forpaging]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetRoles]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetStatus]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetStatusBasedReport]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetSubTasks]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetTasks]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetTimeBasedReport]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetWorkItemAssignments]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspGetWorkItems]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  StoredProcedure [dbo].[uspTimeBasedReport]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[Activity]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[Employee]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[Role]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[Status]    Script Date: 3/17/2023 4:31:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[StatusDescription] [nvarchar](150) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubTask]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[Task]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[temp]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[WorkItem]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  Table [dbo].[WorkItemAssignment]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  View [dbo].[View_SubtaskRelateTaskandActivity]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  View [dbo].[View_workitems]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  View [dbo].[View_taskrelateactivity]    Script Date: 3/17/2023 4:31:36 PM ******/
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
/****** Object:  View [dbo].[vwGetEmployeesRoles]    Script Date: 3/17/2023 4:31:36 PM ******/
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
SET IDENTITY_INSERT [dbo].[Activity] ON 

INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (1, N'ProjectBAU', N'Project BAU Activities', 1, CAST(0x0000AF9B00579450 AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (2, N'KnowledgeManagement', N'KM Activities - Trainings & POC', 1, CAST(0x0000AF9B00579450 AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (3, N'OrganizationalActivity', N'Organizational Activities - Interviews, Innovations, NKMP etc', 1, CAST(0x0000AF9B00579450 AS DateTime), CAST(0x0000AF9E00587EB0 AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (4, N'EmployeeEngagement', N'Employee Engagement Activities - CSR, Quiz etc', 1, CAST(0x0000AF9B00579450 AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (5, N'ITIssues', N'IT Issues related activities', 1, CAST(0x0000AF9B00579450 AS DateTime), CAST(0x0000AFAF006A6A94 AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (6, N'Testing', N'test', 0, CAST(0x0000AF9B00F77088 AS DateTime), CAST(0x0000AF9B00F77538 AS DateTime))
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (7, N'Test', N'Test_D', 1, CAST(0x0000AFA800342F60 AS DateTime), NULL)
INSERT [dbo].[Activity] ([ActivityId], [ActivityName], [ActivityDescription], [IsActive], [CreatedDate], [ModifyDate]) VALUES (8, N'test2', N'testsdasdsadsadadddddmm', 1, CAST(0x0000AFAF004ED02C AS DateTime), CAST(0x0000AFB3001723D4 AS DateTime))
SET IDENTITY_INSERT [dbo].[Activity] OFF
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Karan Gupta', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF55000F4C68 AS DateTime), CAST(0x0000AFA8004382D0 AS DateTime), 1, N'184873', N'Admin', N'184873@nttdata.com', N'184873.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Rajesh Shukla', 1, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF55000F4C68 AS DateTime), CAST(0x0000AFB3001F51F8 AS DateTime), 1, N'184877', N'Admin', N'184877@nttdata.com', N'184877.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Naman Singh', 3, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF55000F4C68 AS DateTime), CAST(0x0000AFA800406398 AS DateTime), 1, N'184878', N'Admin', N'184878@nttdata.com', N'184878.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Sachin Kumar', 3, N'yodXgNYCdvUm1YFnoosc9EtMZvifUFLV5rdrb23Xq9E=', CAST(0x0000AF9B0016B5AC AS DateTime), NULL, 0, N'184890', N'Team Member', N'184890@nttdata.com', N'184890.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Test', 1, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(0x0000AFA3003D69E0 AS DateTime), NULL, 1, N'198987', N'test', N'test@nttdata.com', N'198987.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Ashish', 2, N'+hDvpdNKNVn7AQ8ND/BMpM84pEw3x2UbkAveaoAA5qo=', CAST(0x0000AFA20010E564 AS DateTime), CAST(0x0000AFA80040671C AS DateTime), 1, N'Ashish123', N'ABC', N'Ashish.Tyagi@nttdata.com', N'Ashish123.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp1', 1, N'hRzVSy0umV3/J0Awi3UvPfM0iIva+H53AaUgSRLCDIc=', CAST(0x0000AFA40052B0C0 AS DateTime), NULL, 1, N'emp1', N'empremark1', N'emp@nttdata.com', N'emp1.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp2', 1, N'WcOMyG7a7olgKkxuwG4fsgGlViDAWQDlB4m9gH7PNW4=', CAST(0x0000AFA40052E900 AS DateTime), NULL, 1, N'emp2', N'empremark2', N'emp2@nttdata.com', N'emp2.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp3', 1, N'QikJ01rPD+2GJnXur4d+HS3DqThnBcRnJUqL4peLZGo=', CAST(0x0000AFA800313DDC AS DateTime), NULL, 1, N'emp3', N'emp3_Remark', N'emp3@nttdata.com', N'emp3.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'emp4', 3, N'Kl/zdRG578wIpfQUxkIe7nR8KCaetMGbTkhGg8WFwnA=', CAST(0x0000AFA80031D184 AS DateTime), CAST(0x0000AFA80040752C AS DateTime), 1, N'emp4', N'emp4_Remark', N'emp4@nttdata.com', N'emp4.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Sachin', 3, N'XjFWxI1p2x9RiGA6vGfvP+ehgJ863+cf1JY33YE9GT4=', CAST(0x0000AFA2001118F4 AS DateTime), CAST(0x0000AFA800406F50 AS DateTime), 1, N'Sachin123', N'kjkldsa', N'sachin@nttdata.com', N'Sachin123.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'Test', 3, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(0x0000AFA200113898 AS DateTime), NULL, 1, N'test', N'kjhkd', N'test@gmail.com', N'test.jpg')
INSERT [dbo].[Employee] ([EmpName], [RoleId], [Password], [CreatedDate], [ModifyDate], [IsActive], [UserId], [Remark], [Email], [Pic]) VALUES (N'test1', 3, N'OcZhQCheElTzD4tqFMPLJH3j3xNejuVxD9IreuHFbuo=', CAST(0x0000AFA20011664C AS DateTime), CAST(0x0000AFA800407D60 AS DateTime), 1, N'test1', N'dsad', N'test@gmail.com', N'test1.jpg')
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (1, N'Administrator', 1, CAST(0x0000AF9B005A0870 AS DateTime), CAST(0x0000AF9B00F44FE3 AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (2, N'ProjectManager', 1, CAST(0x0000AF9B005A0870 AS DateTime), CAST(0x0000AF9B00F44FE9 AS DateTime))
INSERT [dbo].[Role] ([RoleId], [RoleName], [IsAdmin], [CreatedDate], [ModifyDate]) VALUES (3, N'TeamMember', 0, CAST(0x0000AF9B005A0870 AS DateTime), CAST(0x0000AF9B00F44FEE AS DateTime))
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (1, N'Open')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (2, N'InProgress')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (3, N'Monitoring')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (4, N'Pending')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (5, N'Completed')
INSERT [dbo].[Status] ([StatusId], [StatusDescription]) VALUES (6, N'HandedOver')
SET IDENTITY_INSERT [dbo].[Status] OFF
SET IDENTITY_INSERT [dbo].[SubTask] ON 

INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (1, N'Analysis', N'Incident Analysis related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (2, N'InterimChecks', N'Incident Interim Check subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (3, N'Monitoring', N'Incident Monitoring subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (4, N'Review', N'Incident Review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (5, N'Meeting', N'Incident Meeting subtasksD', 1, CAST(0x0000AF9B00597AA4 AS DateTime), CAST(0x0000AFB30018441C AS DateTime), 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (6, N'Communication', N'Incident Communication subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (7, N'RCADraft', N'Incident RCA Draft subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (8, N'RCAReview', N'Incident RCA Review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (9, N'IncidentTracker', N'Incident tracker update/review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 1, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (10, N'Analysis', N'Request Analysis related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (11, N'Fulfillment', N'Request Fulfillment subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (12, N'Review', N'Request Review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (13, N'Meeting', N'Request Meeting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (14, N'Communication', N'Request Communication subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (15, N'RequestTracker', N'Request tracker update/review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (16, N'Analysis', N'Change Analysis related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (17, N'DraftChange', N'Change Draft subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (18, N'PeerReviewChange', N'Change peer review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (19, N'InternalCAB', N'Internal CAB subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (20, N'ClientCAB', N'Client CAB subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (21, N'ImplementationTask', N'Change Implementation subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (22, N'ValidationTask', N'Change Validation subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (23, N'Review', N'Change Review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (24, N'Meeting', N'Change Meeting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (25, N'Communication', N'Change Communication subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (26, N'RequestTracker', N'Request tracker update/review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (27, N'Analysis', N'Problem Analysis related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (28, N'PeerReviewAnalysis', N'Problem peer review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (29, N'Meeting', N'Problem Meeting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (30, N'Communication', N'Change Communication subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (31, N'ProblemTracker', N'Problem tracker update/review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (32, N'QMSDocuments', N'QMS Documents related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (33, N'DailyStatusReporting', N'Daily status reporting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (34, N'WeeklyReporting', N'Weekly status reporting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (35, N'MonthlyReporting', N'Weekly status reporting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (36, N'MMR', N'MMR Reporting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (37, N'DailySyncUp', N'Daily sync up meeting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (38, N'WeeklyCatchUp', N'Weekly sync up meeting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (39, N'Audit', N'Audit related subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (40, N'MOM', N'Meeting Minutes', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (41, N'DailyActivityTracker', N'Daily Activity Tracker review/update', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (42, N'TrainingTracker', N'Training Tracker review/update', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (43, N'HandoverTracker', N'Handover Tracker review/update', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (44, N'ArtifactCreation', N'Project Artifact creation subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (45, N'ArtifactUpdate', N'Project Artifact update subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (46, N'ArtifactReview', N'Project Artifact review subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (47, N'EnviornmentSetup', N'Squid Local Enviornment Setup', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (48, N'Analysis', N'Squid related analysis subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (49, N'ConfigurationChange', N'Squid configuration change subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (50, N'Testing', N'Squid change testing subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (51, N'Troubleshooting', N'Squid related troubleshooting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (52, N'Documentation', N'Squid related documentation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (53, N'Review', N'Squid actvities review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (54, N'EnviornmentSetup', N'IIS Local Enviornment Setup', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (55, N'Analysis', N'IIS related analysis subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (56, N'Scripting', N'IIS scripting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (57, N'ConfigurationChange', N'IIS configuration change subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (58, N'Testing', N'IIS change testing subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (59, N'Troubleshooting', N'IIS related troubleshooting subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (60, N'Documentation', N'IIS related documentation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (61, N'Review', N'IIS actvities review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (62, N'Analysis', N'Project adhoc analysis subtasks', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (63, N'Communication', N'Project adhoc communication', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (64, N'ProjectDataReporting', N'Project adhoc data reporting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (65, N'LMS', N'LMS trainings', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (66, N'Webinar', N'Webinars', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (67, N'Online', N'Online trainings', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (68, N'Documentation', N'Training Documentation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (69, N'Review', N'Training Review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (70, N'EnviornmentSetup', N'POC Enviornment Setup', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (71, N'Analysis', N'POC related analysis', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (72, N'Implementation', N'POC implementation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (73, N'Testing', N'POC testing', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (74, N'Troubleshooting', N'POC troubleshooting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (75, N'Documentation', N'POC Documentation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (76, N'Demo', N'POC Demo', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (77, N'Review', N'POC Review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (78, N'RnD', N'POC RnD', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (79, N'LessonsLearnt', N'N-KMP Lessons Learnt', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (80, N'BestPractices', N'N-KMP Best Practices', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (81, N'ReusableComponents', N'N-KMP Reusable Components', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (82, N'Review', N'N-KMP related review', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (83, N'Meeting', N'N-KMP related meeting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (84, N'Communication', N'N-KMP releted communication', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (85, N'ProjectLevel', N'Project Level Interview', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (86, N'AccountLevel', N'Account Level Interview', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (87, N'OrganizationLevel', N'Organization Level Interview', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (88, N'Meeting', N'Interviews related meeting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (89, N'Communication', N'Interviews releted communication', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (90, N'Documentation', N'Innovation related documentation', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (91, N'Meeting', N'Innovation related meeting', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (92, N'Communication', N'Innovation releted communication', 1, CAST(0x0000AF9B00597AA4 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (93, N'Nanolearning - New Year Security Reminders', N'Nanolearning - New Year Security Reminders', 1, CAST(0x0000AFA500234FD8 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (94, N'TASK5632138 || REQ3006442 || RITM3072372 ||  Tempo', N'TASK5632138 || REQ3006442 || RITM3072372 ||  Tempo', 1, CAST(0x0000AFA50023C760 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (95, N'TASK5632138 || REQ3006442 || RITM3072372 ||  Remov', N'TASK5632138 || REQ3006442 || RITM3072372 ||  Remov', 1, CAST(0x0000AFA50023F190 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (96, N'Markit Digital - CTC + PIM access test / Applicati', N'Markit Digital - CTC + PIM access test / Applicati', 1, CAST(0x0000AFA500240DB0 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (97, N'TASK5380737 || REQ2881852 || RITM2945565 || Squid ', N'TASK5380737 || REQ2881852 || RITM2945565 || Squid ', 1, CAST(0x0000AFA500242D54 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (98, N'TASK5451824|| REQ2917554 || RITM2981832 || CTC Squ', N'TASK5451824|| REQ2917554 || RITM2981832 || CTC Squ', 1, CAST(0x0000AFA500243C90 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (99, N'TASK5451568|| REQ2917437 || RITM2981715 || PTC Squ', N'TASK5451568|| REQ2917437 || RITM2981715 || PTC Squ', 1, CAST(0x0000AFA500245658 AS DateTime), NULL, 2, 1)
GO
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (100, N'MD INTERNAL QUALYS VS MAR - NTT PROXY - Update Squ', N'MD INTERNAL QUALYS VS MAR - NTT PROXY - Update Squ', 1, CAST(0x0000AFA50024ABE4 AS DateTime), NULL, 2, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (101, N'CHG0604986', N'TASK5294966 || REQ2839979 || RITM2902805 || Squid ', 1, CAST(0x0000AFA50024CF0C AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (102, N'CHG0613074', N'TASK5380737 || REQ2881852 || RITM2945565 || Squid ', 1, CAST(0x0000AFA500250044 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (103, N'CHG0619385', N'TASK5451824|| REQ2917554 || RITM2981832 || CTC Squ', 1, CAST(0x0000AFA500253E60 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (104, N'CHG0619374', N'TASK5451568|| REQ2917437 || RITM2981715 || PTC Squ', 1, CAST(0x0000AFA500255F30 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (105, N'CHG0620908', N'TASK5472650 || REQ2928283 || RITM2992784 || CTC Sq', 1, CAST(0x0000AFA5002599C8 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (106, N'CHG0620907', N'TASK5472646 || REQ2928281 || RITM2992782 || PTC Sq', 1, CAST(0x0000AFA50025B264 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (107, N'CHG0621383', N'TASK5477705 || REQ2930498 || RITM2995025 || PTC Sq', 1, CAST(0x0000AFA50025D7E4 AS DateTime), NULL, 3, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (108, N'MVC', N'INTRO', 1, CAST(0x0000AFA50026A9A8 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (109, N'T1', N'TTTTTT', 1, CAST(0x0000AFA50026C118 AS DateTime), NULL, 5, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (110, N'TMS1', N'TTTTTT', 1, CAST(0x0000AFA50026D2AC AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (111, N'TMS2', N'TMS2', 1, CAST(0x0000AFA50026E440 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (112, N'TMS3', N'TMS3', 1, CAST(0x0000AFA500270AEC AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (113, N'TMS4', N'TMS4', 1, CAST(0x0000AFA500271A28 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (114, N'TMS5', N'TMS5', 1, CAST(0x0000AFA500272838 AS DateTime), NULL, 6, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (115, N'Problem1', N'Problem1', 1, CAST(0x0000AFA5002F0B5C AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (116, N'Problem2', N'Problem2', 1, CAST(0x0000AFA5002F1840 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (117, N'Problem3', N'Problem3', 1, CAST(0x0000AFA5002F23F8 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (118, N'Problem4', N'Problem4', 1, CAST(0x0000AFA5002F3334 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (119, N'Problem5', N'Problem5', 1, CAST(0x0000AFA5002F5404 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (120, N'Problem6', N'Problem6', 1, CAST(0x0000AFA5002F6598 AS DateTime), NULL, 4, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (121, N'TASK5451568|| REQ2917437 || RITM2981715 || PTC Squ', N'TASK5451568|| REQ2917437 || RITM2981715 || PTC Squ', 1, CAST(0x0000AFA5002F96D0 AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (122, N'TASK5472650 || REQ2928283 || RITM2992784 || CTC Sq', N'TASK5472650 || REQ2928283 || RITM2992784 || CTC Sq', 1, CAST(0x0000AFA5002FA60C AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (123, N'TASK5472646 || REQ2928281 || RITM2992782 || PTC Sq', N'TASK5472646 || REQ2928281 || RITM2992782 || PTC Sq', 1, CAST(0x0000AFA5002FD99C AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (124, N'TASK5477705 || REQ2930498 || RITM2995025 || PTC Sq', N'TASK5477705 || REQ2930498 || RITM2995025 || PTC Sq', 1, CAST(0x0000AFA5002FE7AC AS DateTime), NULL, 7, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (125, N'IISRESET', N'IISRESET', 1, CAST(0x0000AFA5003002A0 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (126, N'IISRESET1', N'IISRESET1', 1, CAST(0x0000AFA500300D2C AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (127, N'IISRESET2', N'IISRESET2', 1, CAST(0x0000AFA500302118 AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (128, N'IISRESET3', N'IISRESET3', 1, CAST(0x0000AFA50030537C AS DateTime), NULL, 8, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (129, N'Monitoring1', N'Monitoring1', 1, CAST(0x0000AFA500306D44 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (130, N'Monitoring2', N'Monitoring2', 1, CAST(0x0000AFA50030825C AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (131, N'Monitoring3', N'Monitoring3', 1, CAST(0x0000AFA500309198 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (132, N'Monitoring4', N'Monitoring4', 1, CAST(0x0000AFA50030A0D4 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (133, N'Monitoring5', N'Monitoring5', 1, CAST(0x0000AFA50030AEE4 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (134, N'Monitoring6', N'Monitoring6', 1, CAST(0x0000AFA50030BCF4 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (135, N'Monitoring7', N'Monitoring7', 1, CAST(0x0000AFA50030C9D8 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (136, N'Monitoring8', N'Monitoring8', 1, CAST(0x0000AFA50030D7E8 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (137, N'Monitoring9', N'Monitoring9', 1, CAST(0x0000AFA50030E5F8 AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (138, N'Monitoring10', N'Monitoring10', 1, CAST(0x0000AFA50030F2DC AS DateTime), NULL, 9, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (139, N'PICheckinCheckout_1', N'PICheckinCheckout_1', 1, CAST(0x0000AFA5003113AC AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (140, N'PICheckinCheckout_2', N'PICheckinCheckout_2', 1, CAST(0x0000AFA5003121BC AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (141, N'PICheckinCheckout_3', N'PICheckinCheckout_3', 1, CAST(0x0000AFA500312EA0 AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (142, N'PICheckinCheckout_4', N'PICheckinCheckout_4', 1, CAST(0x0000AFA500313B84 AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (143, N'PICheckinCheckout_5', N'PICheckinCheckout_5', 1, CAST(0x0000AFA500314868 AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (144, N'PICheckinCheckout_6', N'PICheckinCheckout_6', 1, CAST(0x0000AFA50031554C AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (145, N'PICheckinCheckout_7', N'PICheckinCheckout_7', 1, CAST(0x0000AFA500316938 AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (146, N'PICheckinCheckout_8', N'PICheckinCheckout_8', 1, CAST(0x0000AFA5003188DC AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (147, N'PICheckinCheckout_9', N'PICheckinCheckout_9', 1, CAST(0x0000AFA50031A04C AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (148, N'PICheckinCheckout_10', N'PICheckinCheckout_10', 1, CAST(0x0000AFA50031AD30 AS DateTime), NULL, 10, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (149, N'AdhocTest1', N'AdhocTest1', 1, CAST(0x0000AFA50031CF2C AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (150, N'AdhocTest2', N'AdhocTest2', 1, CAST(0x0000AFA50031DAE4 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (151, N'AdhocTest3', N'AdhocTest3', 1, CAST(0x0000AFA5003216A8 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (152, N'AdhocTest4', N'AdhocTest4', 1, CAST(0x0000AFA5003225E4 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (153, N'AdhocTest5', N'AdhocTest5', 1, CAST(0x0000AFA50032607C AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (154, N'AdhocTest6', N'AdhocTest6', 1, CAST(0x0000AFA500327A44 AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (155, N'AdhocTest7', N'AdhocTest7', 1, CAST(0x0000AFA500328AAC AS DateTime), NULL, 11, 1)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (156, N'TownHall1', N'TownHall1', 1, CAST(0x0000AFA50032C418 AS DateTime), NULL, 17, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (157, N'TownHall2', N'TownHall2', 1, CAST(0x0000AFA50032D6D8 AS DateTime), NULL, 17, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (158, N'LMS_1', N'LMS_1', 1, CAST(0x0000AFA500343410 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (159, N'LMS_2', N'LMS_2', 1, CAST(0x0000AFA5003461C4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (160, N'LMS_3', N'LMS_3', 1, CAST(0x0000AFA500346EA8 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (161, N'LMS_4', N'LMS_4', 1, CAST(0x0000AFA500348294 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (162, N'LMS_5', N'LMS_5', 1, CAST(0x0000AFA500348F78 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (163, N'LMS_6', N'LMS_6', 1, CAST(0x0000AFA500349B30 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (164, N'LMS_7', N'LMS_7', 1, CAST(0x0000AFA50034A6E8 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (165, N'LMS_8', N'LMS_8', 1, CAST(0x0000AFA50034BAD4 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (166, N'LMS_9', N'LMS_9', 1, CAST(0x0000AFA50034D370 AS DateTime), NULL, 12, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (167, N'POC_1', N'POC_1', 1, CAST(0x0000AFA500358DC4 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (168, N'POC_2', N'POC_2', 1, CAST(0x0000AFA500359AA8 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (169, N'POC_3', N'POC_3', 1, CAST(0x0000AFA50035B59C AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (170, N'POC_4', N'POC_4', 1, CAST(0x0000AFA50035C85C AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (171, N'POC_5', N'POC_5', 1, CAST(0x0000AFA5003637B0 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (172, N'POC_6', N'POC_6', 1, CAST(0x0000AFA5003645C0 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (173, N'POC_7', N'POC_7', 1, CAST(0x0000AFA5003654FC AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (174, N'POC_8', N'POC_8', 1, CAST(0x0000AFA500366438 AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (175, N'POC_9', N'POC_9', 1, CAST(0x0000AFA50036888C AS DateTime), NULL, 13, 2)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (176, N'NKMP_1', N'NKMP_1', 1, CAST(0x0000AFA50036A128 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (177, N'NKMP_2', N'NKMP_2', 1, CAST(0x0000AFA50036B514 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (178, N'NKMP_3', N'NKMP_3', 1, CAST(0x0000AFA50036CA2C AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (179, N'NKMP_4', N'NKMP_4', 1, CAST(0x0000AFA50036DCEC AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (180, N'NKMP_5', N'NKMP_5', 1, CAST(0x0000AFA50036F0D8 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (181, N'NKMP_6', N'NKMP_6', 1, CAST(0x0000AFA50036FEE8 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (182, N'NKMP_7', N'NKMP_7', 1, CAST(0x0000AFA500370F50 AS DateTime), NULL, 14, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (183, N'Interview_1', N'Interview_1', 1, CAST(0x0000AFA500372EF4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (184, N'Interview_2', N'Interview_2', 1, CAST(0x0000AFA500374FC4 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (185, N'Interview_3', N'Interview_3', 1, CAST(0x0000AFA50037698C AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (186, N'Interview_4', N'Interview_4', 1, CAST(0x0000AFA5003778C8 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (187, N'Interview_5', N'Interview_5', 1, CAST(0x0000AFA5003786D8 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (188, N'Interview_6', N'Interview_6', 1, CAST(0x0000AFA5003793BC AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (189, N'Innovation_1', N'Innovation_1', 1, CAST(0x0000AFA50037B810 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (190, N'Innovation_2', N'Innovation_2', 1, CAST(0x0000AFA50037C620 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (191, N'Innovation_3', N'Innovation_3', 1, CAST(0x0000AFA50037D8E0 AS DateTime), NULL, 16, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (192, N'SUBTest_Task1', N'SUBTest_Task1', 1, CAST(0x0000AFA8003476DC AS DateTime), CAST(0x0000AFA800347F10 AS DateTime), 21, 7)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (193, N'VPN Issue', N'VPN NOT CONNECTION', 1, CAST(0x0000AFB300198D68 AS DateTime), NULL, 20, 5)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (194, N'Admin Access', N'Admin Access for IIS', 1, CAST(0x0000AFB300202290 AS DateTime), NULL, 19, 5)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (195, N'Admin Access for VS instalation', N'Visual Studio For POC', 1, CAST(0x0000AFB300205170 AS DateTime), NULL, 19, 5)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (196, N'Team Not Working', N'Team not opening due to Login Failed', 1, CAST(0x0000AFB3002075C4 AS DateTime), NULL, 19, 5)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (197, N'Laptop Heating Issue', N'Laptop working Slow', 1, CAST(0x0000AFB300209B44 AS DateTime), NULL, 20, 5)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (198, N'DOTNET DEVELOPER', N'having Skill MVC,.net,JS', 1, CAST(0x0000AFB30021BF10 AS DateTime), NULL, 15, 3)
INSERT [dbo].[SubTask] ([SubTaskId], [SubTaskName], [SubTaskDescription], [IsActive], [CreatedDate], [ModifyDate], [TaskId], [ActivityId]) VALUES (199, N'AI DEVELOPER', N'ChatGPT', 1, CAST(0x0000AFB30021D1D0 AS DateTime), NULL, 15, 3)
GO
SET IDENTITY_INSERT [dbo].[SubTask] OFF
SET IDENTITY_INSERT [dbo].[Task] ON 

INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (1, N'IncidentManagement', N'Incident Management related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (2, N'RequestManagement', N'Request Management related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (3, N'ChangeManagement', N'Change Management related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (4, N'ProblemManagement', N'Problem Management related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (5, N'ProjectMeetingAndDocumentation', N'Project Meeting & Documentation related tasksD', 1, CAST(0x0000AF9B005886E4 AS DateTime), CAST(0x0000AFB300185358 AS DateTime), 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (6, N'ProjectKM', N'Project Knowledge Management related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (7, N'SquidLocalEnvironment', N'Local Squid server related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (8, N'IISLocalEnvironment', N'Local IIS server related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (9, N'SOMQueueMonitoring', N'SOM Queue Monitoring', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (10, N'PICredentialsCheckout/In', N'PI Credentials Checkout/In', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (11, N'ProjectAdhoc', N'Project Adhoc tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 1)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (12, N'Training', N'Training related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 2)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (13, N'POC', N'POC related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 2)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (14, N'NKMPSubmission', N'N-KMP related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (15, N'Interview', N'Interviews related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (16, N'Innovation', N'Innovation related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (17, N'TownHall-GroupMeeting', N'TownHall-GroupMeeting related tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 3)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (18, N'CSR', N'CSR tasks', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 4)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (19, N'ITServiceDesk', N'IT Service Desk related issues', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 5)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (20, N'LocalIT', N'Local IT related issues', 1, CAST(0x0000AF9B005886E4 AS DateTime), NULL, 5)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (21, N'Test_Task1', N'Test_Task1', 1, CAST(0x0000AFA8003446D0 AS DateTime), NULL, 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (22, N'Test_AfterPaging', N'Test_AfterPaging_Description7', 1, CAST(0x0000AFB0003E187C AS DateTime), CAST(0x0000AFB0003E4F90 AS DateTime), 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (23, N'sdsd', N'sadas', 1, CAST(0x0000AFB0003E6F34 AS DateTime), NULL, 7)
INSERT [dbo].[Task] ([TaskId], [TaskName], [TaskDescription], [IsActive], [CreatedDate], [ModifyDate], [ActivityId]) VALUES (24, N'test2_taskname', N'test2_taskname_Description2m', 1, CAST(0x0000AFB00041E074 AS DateTime), CAST(0x0000AFB300174954 AS DateTime), 8)
SET IDENTITY_INSERT [dbo].[Task] OFF
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'Analysis', 1, 1, 1)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'InterimChecks', 1, 1, 2)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'Monitoring', 1, 1, 3)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'Review', 1, 1, 4)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'Meeting', 1, 1, 5)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'Communication', 1, 1, 6)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'RCADraft', 1, 1, 7)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'RCAReview', 1, 1, 8)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IncidentManagement', N'IncidentTracker', 1, 1, 9)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'Analysis', 2, 1, 10)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'Fulfillment', 2, 1, 11)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'Review', 2, 1, 12)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'Meeting', 2, 1, 13)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'Communication', 2, 1, 14)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'RequestManagement', N'RequestTracker', 2, 1, 15)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'Analysis', 3, 1, 16)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'DraftChange', 3, 1, 17)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'PeerReviewChange', 3, 1, 18)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'InternalCAB', 3, 1, 19)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'ClientCAB', 3, 1, 20)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'ImplementationTask', 3, 1, 21)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'ValidationTask', 3, 1, 22)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'Review', 3, 1, 23)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'Meeting', 3, 1, 24)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'Communication', 3, 1, 25)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ChangeManagement', N'RequestTracker', 3, 1, 26)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProblemManagement', N'Analysis', 4, 1, 27)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProblemManagement', N'PeerReviewAnalysis', 4, 1, 28)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProblemManagement', N'Meeting', 4, 1, 29)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProblemManagement', N'Communication', 4, 1, 30)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProblemManagement', N'ProblemTracker', 4, 1, 31)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'QMSDocuments', 5, 1, 32)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'DailyStatusReporting', 5, 1, 33)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'WeeklyReporting', 5, 1, 34)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'MonthlyReporting', 5, 1, 35)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'MMR', 5, 1, 36)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'DailySyncUp', 5, 1, 37)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'WeeklyCatchUp', 5, 1, 38)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'Audit', 5, 1, 39)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'MOM', 5, 1, 40)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'DailyActivityTracker', 5, 1, 41)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'TrainingTracker', 5, 1, 42)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectMeetingAndDocumentation', N'HandoverTracker', 5, 1, 43)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectKM', N'ArtifactCreation', 6, 1, 44)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectKM', N'ArtifactUpdate', 6, 1, 45)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectKM', N'ArtifactReview', 6, 1, 46)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'EnviornmentSetup', 7, 1, 47)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'Analysis', 7, 1, 48)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'ConfigurationChange', 7, 1, 49)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'Testing', 7, 1, 50)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'Troubleshooting', 7, 1, 51)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'Documentation', 7, 1, 52)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'SquidLocalEnvironment', N'Review', 7, 1, 53)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'EnviornmentSetup', 8, 1, 54)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Analysis', 8, 1, 55)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Scripting', 8, 1, 56)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'ConfigurationChange', 8, 1, 57)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Testing', 8, 1, 58)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Troubleshooting', 8, 1, 59)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Documentation', 8, 1, 60)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'IISLocalEnvironment', N'Review', 8, 1, 61)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectAdhoc', N'Analysis', 11, 1, 62)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectAdhoc', N'Communication', 11, 1, 63)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'ProjectBAU', N'ProjectAdhoc', N'ProjectDataReporting', 11, 1, 64)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'Training', N'LMS', 12, 2, 65)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'Training', N'Webinar', 12, 2, 66)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'Training', N'Online', 12, 2, 67)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'Training', N'Documentation', 12, 2, 68)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'Training', N'Review', 12, 2, 69)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'EnviornmentSetup', 13, 2, 70)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Analysis', 13, 2, 71)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Implementation', 13, 2, 72)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Testing', 13, 2, 73)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Troubleshooting', 13, 2, 74)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Documentation', 13, 2, 75)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Demo', 13, 2, 76)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'Review', 13, 2, 77)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'KnowledgeManagement', N'POC', N'RnD', 13, 2, 78)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'LessonsLearnt', 14, 3, 79)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'BestPractices', 14, 3, 80)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'ReusableComponents', 14, 3, 81)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'Review', 14, 3, 82)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'Meeting', 14, 3, 83)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'NKMPSubmission', N'Communication', 14, 3, 84)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Interview', N'ProjectLevel', 15, 3, 85)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Interview', N'AccountLevel', 15, 3, 86)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Interview', N'OrganizationLevel', 15, 3, 87)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Interview', N'Meeting', 15, 3, 88)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Interview', N'Communication', 15, 3, 89)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Innovation', N'Documentation', 16, 3, 90)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Innovation', N'Meeting', 16, 3, 91)
INSERT [dbo].[temp] ([Activity Name], [Task Name], [SubTask Name], [TaskId], [ActivityId], [SubTaskId]) VALUES (N'OrganizationalActivity', N'Innovation', N'Communication', 16, 3, 92)
SET IDENTITY_INSERT [dbo].[WorkItem] ON 

INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (1, 1, 1, 1, N'INC123456666')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (2, 2, 12, 65, N'JAVA')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (3, 2, 13, 70, N'TMS')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (4, 1, 3, 16, N'CHG123456')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (5, 1, 1, 1, N'Analysis_D11')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (6, 1, 1, 1, N'Analysis_D2')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (7, 1, 1, 1, N'Analysis_D3sdds')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (8, 1, 1, 1, N'Analysis_D4')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (9, 1, 1, 2, N'Visiting on Servers with Status')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (10, 7, 21, 192, N'Testing with Subtask2')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (11, 5, 20, 193, N'VPN Not Connecting')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (12, 5, 19, 194, N'Need for IIS')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (13, 5, 19, 194, N'Need for Software Installation')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (14, 5, 20, 193, N'VPN Sectity Not Scan Problem')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (15, 7, 21, 192, N'Testing for paging')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (16, 7, 22, 192, N'Testig Pagings works')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (17, 7, 23, 192, N'Normal Tetsing')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (18, 3, 16, 91, N'ChatGPT')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (19, 3, 15, 85, N'CHATGPT Devops')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (20, 4, 18, 86, N'TMS')
INSERT [dbo].[WorkItem] ([WorkItemId], [ActivityId], [TaskId], [SubTaskId], [WorkItemDescription]) VALUES (21, 3, 15, 85, N'IIS Admin')
SET IDENTITY_INSERT [dbo].[WorkItem] OFF
SET IDENTITY_INSERT [dbo].[WorkItemAssignment] ON 

INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (1, 1, N'184877', N'184873', CAST(0x0000AF9B006CA8CC AS DateTime), CAST(0x0000AFB30031680C AS DateTime), 6, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (2, 2, N'184873', NULL, CAST(0x0000AF9D003A3338 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (3, 3, N'184878', NULL, CAST(0x0000AF9D003A2FB4 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (4, 4, N'184873', NULL, CAST(0x0000AF9D003A2C30 AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (5, 5, N'184877', NULL, CAST(0x0000AFA8003F5160 AS DateTime), NULL, 3, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (6, 6, N'184873', NULL, CAST(0x0000AFA8003FC0B4 AS DateTime), CAST(0x0000AFA90032E038 AS DateTime), 5, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (7, 7, N'emp2', NULL, CAST(0x0000AFA8004EDD10 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (8, 8, N'emp4', NULL, CAST(0x0000AFA8004EE1C0 AS DateTime), NULL, 3, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (9, 9, N'emp1', NULL, CAST(0x0000AFA8004EE670 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (10, 10, N'198987', N'184878', CAST(0x0000AFA8004EEB20 AS DateTime), CAST(0x0000AFA800503B74 AS DateTime), 6, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (11, 10, N'184878', N'198987', CAST(0x0000AFA800503B74 AS DateTime), CAST(0x0000AFA800506478 AS DateTime), 6, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (12, 10, N'198987', N'184877', CAST(0x0000AFA800506478 AS DateTime), CAST(0x0000AFA80050E8E4 AS DateTime), 6, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (13, 10, N'184877', NULL, CAST(0x0000AFA80050E8E4 AS DateTime), NULL, 2, N'Handover to Naman aaaaaa')
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (14, 11, N'184873', NULL, CAST(0x0000AFB30021F3CC AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (15, 12, N'Ashish123', NULL, CAST(0x0000AFB3002201DC AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (16, 13, N'184878', NULL, CAST(0x0000AFB30021F87C AS DateTime), NULL, 3, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (17, 14, N'184878', NULL, CAST(0x0000AFB3002215C8 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (18, 15, N'emp1', NULL, CAST(0x0000AFB300220560 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (19, 16, N'184873', NULL, CAST(0x0000AFB30021FC00 AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (20, 17, N'184890', NULL, CAST(0x0000AFB30021FE58 AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (21, 18, N'184877', NULL, CAST(0x0000AFB300221118 AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (22, 19, N'emp3', N'Sachin123', CAST(0x0000AFB3002208E4 AS DateTime), CAST(0x0000AFB3002245D4 AS DateTime), 6, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (23, 20, N'184890', NULL, CAST(0x0000AFB300220EC0 AS DateTime), NULL, 2, N'fsdfsdfsdfd')
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (24, 21, N'Sachin123', NULL, CAST(0x0000AFB300220C68 AS DateTime), NULL, 4, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (25, 19, N'Sachin123', NULL, CAST(0x0000AFB3002245D4 AS DateTime), NULL, 2, NULL)
INSERT [dbo].[WorkItemAssignment] ([WorkItemAssignmentId], [WorkItemId], [UserIdAssigned], [UserIdHandedover], [StartDate], [HandOverOrClosedDate], [Status], [Remarks]) VALUES (26, 1, N'184873', NULL, CAST(0x0000AFB30031680C AS DateTime), NULL, 2, NULL)
SET IDENTITY_INSERT [dbo].[WorkItemAssignment] OFF
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
