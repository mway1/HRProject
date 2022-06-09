using Dapper;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class DepartmentManager
    {
        public string _connectionString = ServerSettings._connectionString;
        public DepartmentDTO GetByIdDpeartment(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.QuerySingle<DepartmentDTO>(
                    StoredProcedures.Department_GetById,
                    param: new { id = id },
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

        public void AddDepartment(DepartmentDTO departmentDTO)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle<DepartmentDTO>(
                    StoredProcedures.Department_Add,
                    param: new
                    {
                        departmentDTO.Name,
                        departmentDTO.Description,
                        departmentDTO.IsDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void UpdateDepartment(int idDepartment, DepartmentDTO departmentDTO)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    StoredProcedures.Department_Update,
                    param: new
                    {
                        id = idDepartment,
                        Name = departmentDTO.Name,
                        Description = departmentDTO.Description,
                        isDeleted = departmentDTO.IsDeleted
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
                    StoredProcedures.Department_Delete,
                    param: new { id = id },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
