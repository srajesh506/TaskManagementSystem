using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;

namespace TMS.BusinessLogicLayer
{
    public class Settings
    {
        DbConnection dbConnection = new DbConnection();

        //Login Validation Operation
        public bool CheckLogin(string userId, string password)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspCheckLogin";
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                if (dbConnection.ExeReader(sqlCommand).Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Login Validation!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }

        //Change Password Operation
        public int ChangePwd(string userId, string password)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspChangePassword";
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Password Change!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
    }
}
