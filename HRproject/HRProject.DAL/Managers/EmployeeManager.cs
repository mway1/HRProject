using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class EmployeeManager
    {
        public List<EmployeeDTO> GetAllEmployee()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<EmployeeDTO>(
                    EmployeeStoredProcedures.Employee_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
        public void AddEmployee(EmployeeDTO newEmployee)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<EmployeeDTO>(
                    EmployeeStoredProcedures.Employee_Add,
                    param: new
                    {
                        newEmployee.FirstName,
                        newEmployee.SecondName,
                        newEmployee.LastName,
                        newEmployee.BirthDate,
                        newEmployee.Email,
                        newEmployee.PhoneNumber,
                        newEmployee.StatusId,
                        newEmployee.DepartmentId,
                        newEmployee.isDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void DeleteEmployeeById(int employeeId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<EmployeeDTO>(
                    EmployeeStoredProcedures.Employee_Delete,
                    param: new { id = employeeId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void UpdateEmployeeById(EmployeeDTO newEmployee)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                connection.QuerySingleOrDefault<EmployeeDTO>(
                    EmployeeStoredProcedures.Employee_Update,
                    param: new
                    {
                        newEmployee.id,
                        newEmployee.FirstName,
                        newEmployee.SecondName,
                        newEmployee.LastName,
                        newEmployee.BirthDate,
                        newEmployee.Email,
                        newEmployee.PhoneNumber,
                        newEmployee.StatusId,
                        newEmployee.DepartmentId,
                        newEmployee.isDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public EmployeeDTO GetEmployeeById(int employeeId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.QuerySingle<EmployeeDTO>(
                    EmployeeStoredProcedures.Employee_GetById,
                    param: new { id = employeeId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
