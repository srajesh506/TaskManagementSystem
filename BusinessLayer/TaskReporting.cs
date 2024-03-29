﻿using System;
using System.Data;
using System.Data.SqlClient;
using TMS.DataAccess;


namespace TMS.BusinessLogicLayer
{
    public class TaskReporting
    {
        DbConnection dbConnection = new DbConnection();

        //Description: Fetch the WorkItem Assignment report based on Assignee(optional condition to supply a Date Range with Assignee)
        public DataTable GetAssigneeBasedReportUsingPaging(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, DateTime dateFrom, DateTime dateTo, bool rangeFlagChecked = false, string userId = null,int projectId=-1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetAssigneeBasedReport";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@RangeFlagChecked", SqlDbType.Bit).Value = rangeFlagChecked;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = projectId;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Assignee Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetAssigneeBasedReport(DateTime dateFrom, DateTime dateTo, bool rangeFlagChecked = false, string userId = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetAssigneeBasedReport";
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@RangeFlagChecked", SqlDbType.Bit).Value = rangeFlagChecked;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Assignee Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Description: Fetch the WorkItem Assignment report based on a Date Range
        public DataTable GetTimeBasedReportUsingPaging(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, DateTime dateFrom, DateTime dateTo,int projectId)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetTimeBasedReport";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = projectId;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Time Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetTimeBasedReport(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetTimeBasedReport";
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Time Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Description: Fetch the WorkItem Assignment report based on Status(optional condition to supply a Date Range with Status)
        public DataTable GetStatusBasedReportusingPaging(out Int32 totalRecords, Int32 pageNum, Int32 pageSize,Int32 projectId, DateTime dateFrom, DateTime dateTo, bool rangeFlagChecked, int statusId = -1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetStatusBasedReport";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@RangeFlagChecked", SqlDbType.Bit).Value = rangeFlagChecked;
                sqlCommand.Parameters.Add("@StatusId", SqlDbType.Int).Value = statusId;
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = projectId;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Status Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetStatusBasedReport(DateTime dateFrom, DateTime dateTo, bool rangeFlagChecked, Int32  ProjectId, int statusId = -1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetStatusBasedReport";
                sqlCommand.Parameters.Add("@DateFrom", SqlDbType.DateTime).Value = dateFrom.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@DateTo", SqlDbType.DateTime).Value = dateTo.ToString("dd-MMM-yy");
                sqlCommand.Parameters.Add("@RangeFlagChecked", SqlDbType.Bit).Value = rangeFlagChecked;
                sqlCommand.Parameters.Add("@StatusId", SqlDbType.Int).Value = statusId;
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = ProjectId;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Status Based Report!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

    }
}

