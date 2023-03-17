using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;

namespace TMS.BusinessLogicLayer
{
    public class WorkItemManagement
    {
        DbConnection dbConnection = new DbConnection();

        // Returns the Workitems based on the criteria supplied for Activity and/or Task and/or SubTask Values
        public DataTable GetWorkItemsUsingPaging(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, int activityId = -1, int taskId = -1, int subTaskId = -1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetWorkItems";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = subTaskId;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Retrieving WorkItems!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetWorkItems(int activityId = -1, int taskId = -1, int subTaskId = -1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetWorkItems";
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = subTaskId;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Retrieving WorkItems!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        // Returns the WorkitemAssignments based on the criteria whether to return all records or only active assignments (excluding completed/handedover
        public DataTable GetWorkItemAssignmentsUsingPaging(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, bool filterFlag = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetWorkItemAssignments";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                if (filterFlag)
                {
                    sqlCommand.Parameters.Add("@FilterFlag", SqlDbType.Int).Value = 1;
                }
                else
                {
                    sqlCommand.Parameters.Add("@FilterFlag", SqlDbType.Int).Value = 0;
                }
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Retrieving WorkItems Assignments!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetWorkItemAssignments(bool filterFlag = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetWorkItemAssignments";
                if (filterFlag)
                {
                    sqlCommand.Parameters.Add("@FilterFlag", SqlDbType.Int).Value = 1;
                }
                else
                {
                    sqlCommand.Parameters.Add("@FilterFlag", SqlDbType.Int).Value = 0;
                }
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Retrieving WorkItems Assignments!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Add a new Workitem in the WorkItem Table along with its entry in WorkItemAssignment Table (with status as Open) based on updateFlag value
        //OR
        //Update an existing WorkItem in the WorkItem table only based on updateFlag value
        public int AddUpdateWorkItem(WorkItem workItem, Boolean updateFlag = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateWorkItem";
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = workItem.ActivityId;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = workItem.TaskId;
                sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = workItem.SubTaskId;
                sqlCommand.Parameters.Add("@WorkItemDescription", SqlDbType.NVarChar).Value = workItem.WorkItemDescription;
                sqlCommand.Parameters.Add("@WorkItemId", SqlDbType.Int).Value = workItem.WorkItemId;
                if (updateFlag == true)
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Bit).Value = 1;

                }
                else
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Bit).Value = 0;
                }
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating WorkItems!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }

        }
        
        //Assign a user to an unassigned WorkItem or Handover a workitem to other user
        //Update the Status of WorkItem Assignment to "InProgress, Pending" etc 
        //Update any Remarks against WorkItem Assignment
        public int AddUpdateWorkassignmentItem(int workItemAssignmentId, int workItemId, string userId, int status, string remarks)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateWorkItemAssignment";
                sqlCommand.Parameters.Add("@WorkItemAssignmentId", SqlDbType.Int).Value = workItemAssignmentId;
                sqlCommand.Parameters.Add("@WorkItemId", SqlDbType.Int).Value = workItemId;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = status;
                sqlCommand.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = remarks;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating WorkItems Assignments!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
    }
}
