using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using HRProject.DAL.DTOs;

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
                    StoredProcedures.Employee_GetAll,
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
                    StoredProcedures.Employee_Add,
                    param: new
                    {
                        newEmployee.FirstName,
                        newEmployee.SecondName,
                        newEmployee.LastName,
                        newEmployee.BirthDate,
                        newEmployee.Email,
                        newEmployee.PhonrNumber,
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
                    StoredProcedures.Employee_Delete,
                    param: new { id = employeeId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
