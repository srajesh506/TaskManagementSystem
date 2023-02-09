using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;

namespace TMS.BusinessLogicLayer
{
    public class TeamManagement
    {
        DbConnection dbConnection = new DbConnection();

        //Returns the Employees UserId and Name from the Database
        //if isActive flag is true, it returns active users only
        //if userId is supplied then it returns specific record only
        public DataTable GetEmployees(string userId = null, Boolean isActive = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetEmployees";
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Int).Value = isActive;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Employees Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Returns the active employees records from the database along with role information
        public DataTable GetEmployeesRoles(out Int32 totalRecords,Int32 pageNum = 1, Int32 pageSize = 5)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetEmployeesRoles";
                sqlCommand.Parameters.Add("@PageNum", SqlDbType.Int).Value = pageNum;
                sqlCommand.Parameters.Add("@PageSize", SqlDbType.Int).Value = pageSize;
                sqlCommand.Parameters.Add("@TotalRecords", SqlDbType.Int).Direction= ParameterDirection.Output;
                DataTable dataTable = dbConnection.ExeReader(sqlCommand);
                totalRecords = Convert.ToInt32(sqlCommand.Parameters["@TotalRecords"].Value);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Employees and Roles Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Returns the Roles Data from the Database. if rolename is supplied then it returns specific record only
        public DataTable GetRoles(string roleName = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetRoles";
                sqlCommand.Parameters.Add("@RoleName", SqlDbType.NVarChar).Value = roleName;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Roles Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Adds a new role in Database 
        public int AddRole(Role role)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddRole";
                sqlCommand.Parameters.Add("@RoleName", SqlDbType.NVarChar).Value = role.RoleName;
                sqlCommand.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = role.IsAdmin;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding a new Role!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Adds or Updates employee in the database
        public int AddUpdateEmployee(Employee employee, Boolean updateflag = false)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateEmployee";
                dt = GetEmployees(employee.UserId);
                if ((dt.Rows.Count <= 0) && (updateflag == false))
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value = 0;
                }
                else if ((dt.Rows.Count > 0) && (updateflag == true))
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value = 1;
                }
                else
                {
                    return 0;
                }
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = employee.UserId;
                sqlCommand.Parameters.Add("@EmpName", SqlDbType.NVarChar).Value = employee.EmpName;
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = employee.IsActive;
                sqlCommand.Parameters.Add("@Remark", SqlDbType.NVarChar).Value = employee.Remark;
                sqlCommand.Parameters.Add("@RoleId", SqlDbType.Int).Value = employee.RoleId;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = employee.Password;
                sqlCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = employee.Email;
                sqlCommand.Parameters.Add("@Pic", SqlDbType.NVarChar).Value = employee.Pic;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating Employee Record!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
    }
}
