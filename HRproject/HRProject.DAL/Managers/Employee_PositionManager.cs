using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class Employee_PositionManager
    {
        public void AddEmployee_Position(Employee_PositionDTO newEmployee_Position)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<Employee_PositionDTO>(
                    Employee_PositionStoredProcedures.Employee_Position_Add,
                    param: new
                    {
                        newEmployee_Position.EmployeeId,
                        newEmployee_Position.PositionId,
                        newEmployee_Position.LevelOfPositionID
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void DeleteEmployee_Position(Employee_PositionDTO input)

        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                    Employee_PositionStoredProcedures.Employee_Position_Delete,
                    param: new
                    {
                        input.id,
                        input.EmployeeId,
                        input.PositionId,
                        input.LevelOfPositionID
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public Employee_PositionDTO GetEmployee_PositionById(int employeeId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.QuerySingle<Employee_PositionDTO>(
                    EmployeeStoredProcedures.Employee_GetById,
                    param: new { EmployeeId = employeeId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
