using HRProject.DAL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class EmployeeHistoryManager
    {
        public string _connectionString = @"Server=.\DESKTOP-PMA057A;Database=HRproject.DB;Trusted_Connection=True;";
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
                    param: new { id=id },
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
        
        public void AddEmployeeHistory(int employeeId, string date, string statusId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                    StoredProcedures.EmployeeHistory_Add,
                    param: new { EmployeeId = employeeId, Date = date, StatusId = statusId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void UpdateEmployeeHistory(EmployeeHistoryDTO employeeHistory, int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QueryFirstOrDefault(
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
        public void DeleteEmployeeHistory(int id)

        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.QueryFirstOrDefault<EmployeeHistoryDTO>(
                    StoredProcedures.EmployeeHistory_Delete,
                    param: new { id = id },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
