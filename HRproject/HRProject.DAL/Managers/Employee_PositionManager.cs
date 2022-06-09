using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class Employee_PositionManager
    {
        public void AddEmployee(Employee_PositionDTO newEmployee_Position)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<EmployeeDTO>(
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
    }
}
