using HRProject.DAL.DTOs;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class PositionManager
    {
        public PositionDTO GetPositonById(int positionId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.QuerySingle<PositionDTO>(
                    PostionStoredProcedure.Position_GetById,
                    param: new { id = positionId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public List<PositionDTO> GetAllPositon(int positionId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<PositionDTO>(
                    PostionStoredProcedure.Position_GetAll,
                    param: new { id = positionId },
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
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
                        LevelOfPositionId = positionDTO.PositionLevel.id

                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void UpdatePosition(PositionDTO positionDTO)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    PostionStoredProcedure.Position_Update,
                    param: new
                    {
                        Id = positionDTO.id,
                        Name = positionDTO.Name,
                        LevelOfPositionId = positionDTO.PositionLevel.id

                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void DeletePosition(int positionId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle(
                    PostionStoredProcedure.Position_Delete,
                    param: new
                    {  Id = positionId  },
                    commandType: System.Data.CommandType.StoredProcedure);
            }

        }

    }
}
