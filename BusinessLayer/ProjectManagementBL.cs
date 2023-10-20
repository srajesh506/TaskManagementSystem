using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;

namespace TMS.BusinessLogicLayer
{
    public class ProjectManagementBL
    {
        DbConnection dbConnection = new DbConnection();


        public DataTable GetProjectManager()
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "GetProjectManager";
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Roles Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        //Adds or Updates Project in the database
        public int AddUpdateProject(Project projectData, Boolean updateflag = false)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateProject";
                if (updateflag == false)
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value = 0;
                }
                else
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value = 1;
                }
                sqlCommand.Parameters.Add("@projectid", SqlDbType.NVarChar).Value = projectData.ProjectId;
                //sqlCommand.Parameters.Add("@projectmanager", SqlDbType.NVarChar).Value = projectData.ProjectManagerId;
                sqlCommand.Parameters.Add("@projectname", SqlDbType.NVarChar).Value = projectData.ProjectName;
                sqlCommand.Parameters.Add("@projectdescription", SqlDbType.NVarChar).Value = projectData.ProjectDescription;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = projectData.IsActive;
              
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating Project Data!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetProjectDetails(out Int32 totalRecords, Int32 pageNum = 1, Int32 pageSize = 5)
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
        public DataTable GetALLProject()
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
