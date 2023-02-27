using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;

namespace TMS.BusinessLogicLayer
{
    public class TaskManagement
    {
        DbConnection dbConnection = new DbConnection();

        //Returns the Activities Data based on activityId/activityName and/Or isActive Flag
        //if activityId/activityName is supplied then it returns specific record only
        //if isActive flag is true, it returns active records only
        public DataTable GetActivities(out Int32 totalRecords, Int32 pageNum, Int32 pageSize,Boolean isActive = false, int activityId = -1, string activityName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetActivities";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Int).Value = isActive;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar).Value = activityName;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching Activities Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }

        }
        public DataTable GetActivities_1(Boolean isActive = false, int activityId = -1, string activityName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetActivities";
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Int).Value = isActive;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar).Value = activityName;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching Activities Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }

        }
        //Add or Update Activity Record
        public int AddUpdateActivity(Activity activity,Boolean updateFlag = false)
        {
            try
            {
                if (((updateFlag == true) && (GetActivities_1(false,activity.ActivityId, activity.ActivityName).Rows.Count > 0))
                    || ((updateFlag == false) && (GetActivities_1(false, activity.ActivityId, activity.ActivityName).Rows.Count <= 0)))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "uspAddUpdateActivity";
                    sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activity.ActivityId;
                    sqlCommand.Parameters.Add("@ActivityName", SqlDbType.NVarChar).Value = activity.ActivityName;
                    sqlCommand.Parameters.Add("@ActivityDescription", SqlDbType.NVarChar).Value = activity.ActivityDescription;
                    sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = activity.IsActive;
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Bit).Value = updateFlag;
                    return dbConnection.ExeNonQuery(sqlCommand);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in adding/updating activity record!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Returns the Tasks Data based on taskId/taskName and/Or isActive Flag
        //if taskId/taskName is supplied then it returns specific record only
        //if isActive flag is true, it returns active records only
        public DataTable GetTasks(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, Boolean isActive = false, int taskId = -1, int activityId = -1, string taskName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetTasks";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@TaskName", SqlDbType.NVarChar).Value = taskName;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching Tasks Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
                
            }
        }
        public DataTable GetTasks_1(Boolean isActive = false, int taskId = -1, int activityId = -1, string taskName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetTasks";
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@TaskName", SqlDbType.NVarChar).Value = taskName;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching Tasks Data!! " + "\n'" + ex.Message + "'", ex.InnerException);

            }
        }

        //Returns the SubTasks Data based on subTaskId/subTtaskName and/Or isActive Flag
        //if subTaskId/subTaskName is supplied then it returns specific record only
        //if isActive flag is true, it returns active records only
        public DataTable GetSubTasks(out Int32 totalRecords, Int32 pageNum, Int32 pageSize, Boolean isActive=false, int subTaskId = -1, int taskId = -1, int activityId = -1, string subTaskName=null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetSubTasks";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = subTaskId;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@SubTaskName", SqlDbType.NVarChar).Value = subTaskName;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching SubTasks Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetSubTasks_1(Boolean isActive = false, int subTaskId = -1, int taskId = -1, int activityId = -1, string subTaskName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetSubTasks";
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = isActive;
                sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = subTaskId;
                sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = taskId;
                sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = activityId;
                sqlCommand.Parameters.Add("@SubTaskName", SqlDbType.NVarChar).Value = subTaskName;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in fetching SubTasks Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }



        //Add or Update a Task Record
        public int AddUpdateTask(Task task, Boolean updateFlag = false)
        {
            try
            {
                if (((updateFlag==true) && (GetTasks_1(false, task.TaskId, task.ActivityId, task.TaskName).Rows.Count > 0))
                    || ((updateFlag==false) && (GetTasks_1(false, task.TaskId, task.ActivityId, task.TaskName).Rows.Count <= 0)))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "uspAddUpdateTask";
                    sqlCommand.Parameters.Add("@TaskName", SqlDbType.NVarChar).Value = task.TaskName;
                    sqlCommand.Parameters.Add("@TaskDescription", SqlDbType.NVarChar).Value = task.TaskDescription;
                    sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = task.ActivityId;
                    sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = task.IsActive;
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Bit).Value = updateFlag;
                    sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = task.TaskId;
                    return dbConnection.ExeNonQuery(sqlCommand);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in adding/updating Task record!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Add or Update a subtask Record
        public int AddUpdateSubtask(SubTask subTask, Boolean updateFlag = false)
        {
            try
            {
                if (((updateFlag == true) && (GetSubTasks_1(false, subTask.SubTaskId, subTask.TaskId, subTask.ActivityId, subTask.SubTaskName).Rows.Count > 0))
                    || ((updateFlag == false) && (GetSubTasks_1(false, subTask.SubTaskId, subTask.TaskId, subTask.ActivityId, subTask.SubTaskName).Rows.Count <= 0)))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.CommandText = "uspAddUpdateSubTask";
                    sqlCommand.Parameters.Add("@SubTaskId", SqlDbType.Int).Value = subTask.SubTaskId;
                    sqlCommand.Parameters.Add("@SubTaskName", SqlDbType.NVarChar).Value = subTask.SubTaskName;
                    sqlCommand.Parameters.Add("@SubTaskDescription", SqlDbType.NVarChar).Value = subTask.SubTaskDescription;
                    sqlCommand.Parameters.Add("@ActivityId", SqlDbType.Int).Value = subTask.ActivityId;
                    sqlCommand.Parameters.Add("@TaskId", SqlDbType.Int).Value = subTask.TaskId;
                    sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = subTask.IsActive;
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Bit).Value = updateFlag;
                    return dbConnection.ExeNonQuery(sqlCommand);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in adding/updating SubTask record!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

    }
}
