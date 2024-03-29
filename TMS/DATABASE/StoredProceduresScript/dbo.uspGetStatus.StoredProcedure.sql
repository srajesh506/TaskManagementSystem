USE [TMS]
GO
/****** Object:  StoredProcedure [dbo].[uspGetStatus]    Script Date: 9/1/2023 5:48:42 PM ******/
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
