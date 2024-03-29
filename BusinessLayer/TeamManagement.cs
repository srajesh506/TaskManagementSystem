﻿using System;
using System.Data;
using System.Data.SqlClient;

using TMS.DataAccess;
using TMS.BusinessEntities;
using System.Collections.Generic;

namespace TMS.BusinessLogicLayer
{
    public class TeamManagement
    {
        DbConnection dbConnection = new DbConnection();

        //Returns the Employees UserId and Name from the Database
        //if isActive flag is true, it returns active users only
        //if userId is supplied then it returns specific record only
        public DataTable GetEmployees(string userId = null, Boolean isActive = false,int projectId=-1)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetEmployees";
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = userId;
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = projectId;
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
        public DataTable GetProjectMemberByProjectId(string ProjectId = null, int flag=0)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetProjectMemberByProjectId";
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = ProjectId;
                sqlCommand.Parameters.Add("@flag", SqlDbType.Int).Value = flag;
                return dbConnection.ExeReader(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Fetching Roles Details!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
        public DataTable GetProjectbyUserId(string UserId = null)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspGetProjectbyUserId";
                sqlCommand.Parameters.Add("@userid", SqlDbType.NVarChar).Value = UserId;
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
        public int AssignedProjectMember(int Projectid, string UserID)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateProjectMember";
                sqlCommand.Parameters.Add("@ProjectId", SqlDbType.Int).Value = Projectid;
                sqlCommand.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = UserID;
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
                DataTable DtActiveEmployee = new DataTable();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = "uspAddUpdateEmployee";
                if (updateflag == false)
                {
                    sqlCommand.Parameters.Add("@UpdateFlag", SqlDbType.Int).Value = 0;
                }
                else if (updateflag == true)
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
                DataTable DtProject = new DataTable();
                DtProject.Columns.Add("ProjectId", typeof(int));
                foreach (var item in employee.ProjectID)
                {
                    DtProject.Rows.Add(item);
                }
                sqlCommand.Parameters.Add("@ProjectIdList", SqlDbType.Structured).Value = DtProject;
                return dbConnection.ExeNonQuery(sqlCommand);
            }
            catch (Exception ex)
            {
                throw new Exception("BLLError - Failure in Adding/Updating Employee Record!! " + "\n'" + ex.Message + "'", ex.InnerException);
            }
        }
       
    }
}
