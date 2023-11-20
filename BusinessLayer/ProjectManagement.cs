using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;

namespace TMS.BusinessLogicLayer
{
    public class ProjectManagement
    {
        DbConnection dbConnection = new DbConnection();

        //Adds or Updates Project in the database
        public int AddUpdateProject(Project projectData, Boolean updateFlag = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateProject";
                sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value= (updateFlag == false) ? 0 : 1;
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.NVarChar).Value = projectData.ProjectId;
                sqlCommand.Parameters.Add("@ProjectName", SqlDbType.NVarChar).Value = projectData.ProjectName;
                sqlCommand.Parameters.Add("@ProjectDescription", SqlDbType.NVarChar).Value = projectData.ProjectDescription;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = projectData.IsActive;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating Project Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetProjectDetails(out Int32 totalRecords, Int32 pageNum = 1, Int32 pageSize = 5)//Get All Project Using Pagination 
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetProject";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction = ParameterDirection.Output;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Project Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetAllProject()//Get All Project at a time
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetAllProject";
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Project Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
    }
}
