using HRProject.DAL.DTOs;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class DepartmentManager
    {
        public string _connectionString = @"Server=.\SQLEXPRESS;Database=HRProject.DB;Trusted_Connection=True;";
        public DepartmentDTO GetByIdDpeartment(int id) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.QuerySingle<DepartmentDTO>(
                    StoredProcedures.Department_GetById, 
                    param: new {id=id},
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public List<DepartmentDTO> GetAllDepartment()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<DepartmentDTO>(
                    StoredProcedures.Department_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }

        public void AddDepartment(string name, string description, bool isDeleted)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    StoredProcedures.Department_Add,
                    param: new
                    {
                        Name=name,
                        Description=description,
                        isDeleted=isDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void UpdateDepartment(int id, string name, string description, bool isDeleted)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    StoredProcedures.Department_Update,
                    param: new
                    {
                        Id=id,
                        Name = name,
                        Description = description,
                        isDeleted = isDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void DeleteDepartment(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    StoredProcedures.Department_Update,
                    param: new {Id = id},
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
