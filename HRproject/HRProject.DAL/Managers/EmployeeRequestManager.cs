using HRProject.DAL.StoredProcedureStorage;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;
using Dapper;

namespace HRProject.DAL.Managers
{
    public class EmployeeRequestManager
    {
        public string _connectionString = ServerSettings._connectionString;

        public List<EmplooyeeRequestAllInfoDTO> GetEmployeeRequestAllInfo()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                Dictionary<int, EmplooyeeRequestAllInfoDTO> result = new Dictionary<int, EmplooyeeRequestAllInfoDTO>();

                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    RequestProjectDTO,
                    RequestPositionDTO,
                    RequestLevelOfPositionDTO,
                    RequestSkillDTO,
                    RequestEmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        if (!result.ContainsKey(EmployeeRequest.Id))
                        {
                            result.Add(EmployeeRequest.Id, EmployeeRequest);
                        }

                        EmplooyeeRequestAllInfoDTO crnt = result[EmployeeRequest.Id];

                        if (Project is not null)
                        {
                            crnt.Project = Project;
                        }

                        if (crnt.Positions is null && Position is not null)
                        {
                            crnt.Positions = new List<RequestPositionDTO>();
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions.Add(Position);
                        }
                        else if (Position is not null)
                        {
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions!.Add(Position);
                        }

                        if (crnt.Skills is null && Skill is not null)
                        {
                            crnt.Skills = new List<RequestSkillDTO>();
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills.Add(Skill);
                        }
                        else if (Skill is not null)
                        {
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills!.Add(Skill);
                        }

                        return crnt;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id");

                return result.Values.ToList();
            }
        }

        public List<EmplooyeeRequestAllInfoDTO> GetEmployeeRequestAllInfoByProjectId(int projectId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                Dictionary<int, EmplooyeeRequestAllInfoDTO> result = new Dictionary<int, EmplooyeeRequestAllInfoDTO>();
                var checkPosition = new List<int>();
                var checkSkill = new List<int>();

                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    RequestProjectDTO,
                    RequestPositionDTO,
                    RequestLevelOfPositionDTO,
                    RequestSkillDTO,
                    RequestEmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfoByProjectId,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        if (!result.ContainsKey(EmployeeRequest.Id))
                        {
                            result.Add(EmployeeRequest.Id, EmployeeRequest);
                        }

                        EmplooyeeRequestAllInfoDTO crnt = result[EmployeeRequest.Id];

                        if (Project is not null)
                        {
                            crnt.Project = Project;
                        }

                        if (crnt.Positions is null && Position is not null)
                        {
                            checkPosition.Add(Position.id);
                            crnt.Positions = new List<RequestPositionDTO>();
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions.Add(Position);
                        }
                        else if (Position is not null && !checkPosition.Contains(Position.id))
                        {
                            checkPosition.Add(Position.id);
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions!.Add(Position);
                        }

                        if (crnt.Skills is null && Skill is not null)
                        {
                            checkSkill.Add(Skill.Id);
                            crnt.Skills = new List<RequestSkillDTO>();
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills.Add(Skill);
                        }
                        else if (Skill is not null && !checkSkill.Contains(Skill.Id))
                        {
                            checkSkill.Add(Skill.Id);
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills!.Add(Skill);
                        }

                        return crnt;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    param: new {projectId},
                    splitOn: "id");

                return result.Values.ToList();
            }
        }

        public EmplooyeeRequestAllInfoDTO GetEmployeeRequestAllInfoById(int employeeRequestId)
        {
            EmplooyeeRequestAllInfoDTO result = new EmplooyeeRequestAllInfoDTO();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    RequestProjectDTO,
                    RequestPositionDTO,
                    RequestLevelOfPositionDTO,
                    RequestSkillDTO,
                    RequestEmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfoById,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        result = EmployeeRequest;

                        if (Project is not null)
                        {
                            result.Project = Project;
                        }

                        if (result.Positions is null && Position is not null)
                        {
                            result.Positions = new List<RequestPositionDTO>();
                            Position.PositionLevel = PositionLevel;
                            result.Positions.Add(Position);
                        }
                        else if (Position is not null)
                        {
                            Position.PositionLevel = PositionLevel;
                            result.Positions!.Add(Position);
                        }

                        if (EmployeeRequest.Skills is null && Skill is not null)
                        {
                            result.Skills = new List<RequestSkillDTO>();
                            Skill.SkillLevel = SkillLevel;
                            result.Skills.Add(Skill);
                        }
                        else if (Skill is not null)
                        {
                            Skill.SkillLevel = SkillLevel;
                            result.Skills!.Add(Skill);
                        }

                        return EmployeeRequest;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id",
                    param: new { employeeRequestId });

                return result;
            }
        }

        public void UpdateEmployeeRequest(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(EmployeeRequestStoredProcedures.UpdateEmployeeRequestById,
                    param: new
                    {
                        input.Id,
                        input.ProjectId,
                        input.Quantity,
                        input.IsDeleted
                    },
                commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void DeleteEmployeeRequestById(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(EmployeeRequestStoredProcedures.DeleteEmployeeRequestById,
                    param: new
                    {
                        input.Id,
                        input.ProjectId,
                        input.Quantity
                    },
                commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public void CreateEmployeeRequest(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                connection.QuerySingle(EmployeeRequestStoredProcedures.CreateEmployeeRequest,
                    param: new
                    {
                        input.ProjectId,
                        input.Quantity
                    },
                commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}