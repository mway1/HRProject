using HRProject.DAL.DTOs;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class PositionManager
    {
        public void AddPosition(PositionDTO positionDTO)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    PostionStoredProcedure.Position_Add,
                    param: new
                    {
                        Name = positionDTO.Name,
                        isDeleted = positionDTO.IsDeleted
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

    }
}
