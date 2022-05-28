using System.Collections.Generic;
using HRProject.DAL.DTOs;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class DepartmentManager
    {
        public string _connectionString = @"Server=.\SQLEXPRESS;Database=HRProject.DB;Trusted_Connection=True;";
        public DepartmentDTO DpeartmentGetById(int id) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.QuerySingle<DepartmentDTO>(
                    "Department_GetById", 
                    param: new {id=id},
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public List<DepartmentDTO> DepartmentGetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<DepartmentDTO>(
                    "Department_GetAll",
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public List<DepartmentDTO> DepartmentUpdate(int id )
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<DepartmentDTO>(
                    "Department_GetAll",
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
    }
}
