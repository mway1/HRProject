using System.Collections.Generic;
using HRProject.DAL.StoredProcedureEnums;
using Dapper;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;
namespace HRProject.DAL
{
    public class EmployeeRequestManager
    {
        public string _connectionString = @"Server=.\SQLEXPRESS;Database=....;Trusted_Connection=True;";

        public List<EmplooyeeRequestAllInfoDTO> GetSummOfEveryOrders()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<EmplooyeeRequestAllInfoDTO>(
                    StoredProcedures.EmployeeRequestAllInfo,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
    }
}