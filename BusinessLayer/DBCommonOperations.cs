using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;

namespace TMS.BusinessLogicLayer
{
    public class DBCommonOperations
    {
        DbConnection dbConnection = new DbConnection();

        // Returns the status values from the Database.
        // if excludeHandedOver flag is true, it doesnt return HandedOver Status value
        // if excludeHandedOver flag is false, it returns all status values including HandedOver
        public DataTable GetStatus(Boolean excludeHandedOver = false)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetStatus";
                if (excludeHandedOver)
                {
                    sqlCommand.Parameters.Add("@ExcludeHandedOver", SqlDbType.Bit).Value = 1;

                }
                else
                {
                    sqlCommand.Parameters.Add("@ExcludeHandedOver", SqlDbType.Bit).Value = 0;
                }
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - there is a problem fetching the status values!!" + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
    }
}