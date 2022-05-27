using System.Collections.Generic;
using HRProject.DAL.DTOs;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class DepartmentManager
    {
        public string _connectionString = @"Server=.\SQLEXPRESS;Database=HRProject.DB;Trusted_Connection=True;";
        public List<DepartmentDTO> DpeartmentGetById() 
        {
            using var connection = new SqlConnection(_connectionString); ;
        }
    }
}
