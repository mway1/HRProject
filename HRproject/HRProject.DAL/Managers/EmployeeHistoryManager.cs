using Dapper;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class EmployeeHistoryManager
    {
        public string _connectionString = @"Server=.\SQLEXPRESS01;Database=HRProject.DB;Trusted_Connection=True;";
        public List<EmployeeHistoryDTO> GetAllEmployeeHistory()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<EmployeeHistoryDTO>(
                    StoredProcedures.EmployeeHistory_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();

            }
        }
        public EmployeeHistoryDTO GetByIdEmployeeHistory(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                return connection.QuerySingle<EmployeeHistoryDTO>(
                    StoredProcedures.EmployeeHistory_GetById,
                    param: new { id = id },
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
        
        public void AddEmployeeHistory(EmployeeHistoryDTO employeeHistoryDTO)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                    StoredProcedures.EmployeeHistory_Add,
                    param: new { EmployeeId = employeeHistoryDTO.EmployeeId, Date = employeeHistoryDTO.Date, StatusId = employeeHistoryDTO.StatusId},
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void UpdateEmployeeHistory(EmployeeHistoryDTO employeeHistory, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                    StoredProcedures.EmployeeHistory_Update,
                    param: new
                    {
                        EmployeeId = employeeHistory.EmployeeId,
                        Date = employeeHistory.Date,
                        StatusId = employeeHistory.StatusId,
                        id = id
                    },
                    commandType: System.Data.CommandType.StoredProcedure

            );
            }
        }
        public void DeleteEmployeeHistory(EmployeeHistoryDTO input)

        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                    StoredProcedures.EmployeeHistory_Delete,
                    param: new { 
                        input.id, 
                        input.StatusId,
                        input.EmployeeId
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
