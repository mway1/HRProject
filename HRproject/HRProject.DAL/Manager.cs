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

        public List<EmplooyeeRequestAllInfoDTO> GetEmployeeRequestAllInfo()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                Dictionary<int, EmplooyeeRequestAllInfoDTO> result = new Dictionary<int, EmplooyeeRequestAllInfoDTO>();

                connection.Query<EmplooyeeRequestAllInfoDTO, string, string, string, int?, EmplooyeeRequestAllInfoDTO>(
                    StoredProcedures.EmployeeRequestAllInfo,
                    (EmployeeRequest, PositionName, PositionLevel, SkillName, SkillLevel) =>
                    {
                        if (!result.ContainsKey(EmployeeRequest.id))
                        {
                            result.Add(EmployeeRequest.id, EmployeeRequest);
                        }

                        EmplooyeeRequestAllInfoDTO crnt = result[EmployeeRequest.id];

                        if (PositionLevel is not null)
                        {
                            crnt.PositionLevel.Add(PositionLevel);
                        }
                        if (SkillLevel is not null)
                        {
                            crnt.LevelOfSkill.Add(SkillLevel);
                        }

                        crnt.PositionName.Add(SkillName);
                        crnt.SkillName.Add(PositionName);

                        return crnt;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id PositionName PositionLevel SkillName LevelOfSkill");

                return result.Values.ToList();
            }
        }
    }
}