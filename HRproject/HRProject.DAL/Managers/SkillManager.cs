using HRProject.DAL.StoredProcedureStorage;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;
using Dapper;

namespace HRProject.DAL.Managers
{
    public class SkillManager
    {
        public string _connectionString = ServerSettings._connectionString;

        public List<SkillDTO> GetAllSkills()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<SkillDTO>(
                    SkillStoredProcedure.GetAllSkills,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
            }
        }
    }
}

