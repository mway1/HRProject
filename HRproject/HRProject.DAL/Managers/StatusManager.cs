using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class StatusManager
    {
        public List<StatusDTO> GetAllStatuses()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<StatusDTO> status = connection.Query<StatusDTO>(
                    StatusStoredProcedures.Status_getAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
                return status;
            }
        }
        public StatusDTO? GetStatus(int id)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<StatusDTO> status = connection.Query<StatusDTO>(
                    StatusStoredProcedures.Status_get,
                    param: new { id = id },
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();

                if (status.Count == 0)
                {
                    return null;
                }
                return status[0];
            }
        }
    }
}
