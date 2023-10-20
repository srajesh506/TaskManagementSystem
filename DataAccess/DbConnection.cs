using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace TMS.DataAccess
{
    public class DbConnection
    {
        private SqlConnection _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());

        //Open and return the Sql Connection if it closed
        public SqlConnection GetCon()
        {
            try
            {
                if (_sqlConnection.State == ConnectionState.Closed)
                {
                    _sqlConnection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("DAError - please check Database Connection!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
            return _sqlConnection;
        }

        //Executes the SQL statement against the connection and returns the no of affected rows
        public int ExeNonQuery(SqlCommand sqlCommand)
        {
            int rowAffected = -1;
            try
            {
                sqlCommand.Connection = GetCon();
                rowAffected = sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
            }
            catch (Exception ex)
            {

                throw new Exception("DAError - Failure !!" + "\n'" + ex.Message + "'", ex.InnerException);
            }

            return rowAffected;
        }

        //Executes the SQL statement against the connection and returns the first column of first row from the query result set
        public object ExeScaler(SqlCommand sqlCommand)
        {
            object obj = -1;
            try
            {
                sqlCommand.Connection = GetCon();
                obj = sqlCommand.ExecuteScalar();
                _sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("DAError - Failure !!" + "\n'" + ex.Message + "'", ex.InnerException);
            }
            return obj;
        }

        //Executes the SQL statement against the connection to return the result set datatable
        public DataTable ExeReader(SqlCommand sqlCommand)
        {
            SqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            try
            {
                sqlCommand.Connection = GetCon();
                sqlDataReader = sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                _sqlConnection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("DAError - Failure !!" + "\n'" + ex.Message + "'", ex.InnerException);
            }
            return dataTable;
        }
        public DataSet ExeDataAdapter(SqlCommand sqlCommand)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            try
            {
                // Set the connection if it's not already set
                if (sqlCommand.Connection == null)
                {
                    sqlCommand.Connection = GetCon();
                }
                // Use the SqlDataAdapter to fill the DataTable
                dataAdapter.Fill(dataset);
            }
            catch (Exception ex)
            {
                throw new Exception("DAError Failure !!" + "\n" + ex.Message, ex.InnerException);
            }
            finally
            {
                // Close the connection if it was opened in this method
                if (sqlCommand.Connection != null && sqlCommand.Connection.State == ConnectionState.Open)
                {
                    sqlCommand.Connection.Close();
                }
            }
            return dataset;
        }
    }
}