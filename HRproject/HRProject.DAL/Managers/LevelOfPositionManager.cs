using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class LevelOfPositionManager
    {
        public List<LevelOfPositionDTO> GetAllLevelOfPosition()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<LevelOfPositionDTO>(
                    LevelOfPositionStoredProcedures.LevelOfPosition_Get,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
        public void AddLevelOfPosition(LevelOfPositionDTO newLevelOfPosition)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<LevelOfPositionDTO>(
                     LevelOfPositionStoredProcedures.LevelOfPosition_Add,
                     param: new
                     {
                         newLevelOfPosition.Name,
                         newLevelOfPosition.isDeleted
                     },
                     commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void DeleteLevelOfPosition (int LevelOfPositionId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                connection.QuerySingleOrDefault<LevelOfPositionDTO>(
                    LevelOfPositionStoredProcedures.LevelOfPosition_Delete,
                    param: new { id = LevelOfPositionId },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void UpdateLevelOfPosition(LevelOfPositionDTO newLevelOfPosition)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingleOrDefault<LevelOfPositionDTO>(
                     LevelOfPositionStoredProcedures.LevelOfPosition_Update,
                     param: new
                     {
                         newLevelOfPosition.Name,
                         newLevelOfPosition.isDeleted
                     },
                     commandType: System.Data.CommandType.StoredProcedure);
            }
        }

    }
}
