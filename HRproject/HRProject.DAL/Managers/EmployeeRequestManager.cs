using HRProject.DAL.StoredProcedureStorage;
using HRProject.DAL.DTOs;


namespace HRProject.DAL.Managers
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

                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    ProjectDTO,
                    PositionDTO,
                    LevelOfPositionDTO,
                    SkillDTO,
                    EmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        if (!result.ContainsKey(EmployeeRequest.id))
                        {
                            result.Add(EmployeeRequest.id, EmployeeRequest);
                        }

                        EmplooyeeRequestAllInfoDTO crnt = result[EmployeeRequest.id];

                        if (Project is not null)
                        {
                            crnt.Project = Project;
                        }

                        if (crnt.Positions is null && Position is not null)
                        {
                            crnt.Positions = new Dictionary<PositionDTO, List<LevelOfPositionDTO>>();
                            crnt.Positions.Add(Position, new List<LevelOfPositionDTO>());
                            crnt.Positions[Position].Add(PositionLevel);
                        }
                        if (crnt.Positions.ContainsKey(Position))
                        {
                            crnt.Positions[Position].Add(PositionLevel);
                        }
                        else
                        {
                            crnt.Positions.Add(Position, new List<LevelOfPositionDTO>());
                            crnt.Positions[Position].Add(PositionLevel);
                        }

                        if (crnt.Skills is null && Skill is not null)
                        {
                            crnt.Skills = new Dictionary<PositionDTO, List<LevelOfPositionDTO>>();
                            crnt.Skills.Add(Skill, new List<LevelOfPositionDTO>());
                            crnt.Skills[Skill].Add(SkillLevel);
                        }
                        if (crnt.Skills.ContainsKey(Skill))
                        {
                            crnt.Skills[Skill].Add(SkillLevel);
                        }
                        else
                        {
                            crnt.Skills.Add(Position, new List<LevelOfPositionDTO>());
                            crnt.Skills[Skill].Add(SkillLevel);
                        }

                        return crnt;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id");

                return result.Values.ToList();
            }
        }

        public EmplooyeeRequestAllInfoDTO GetEmployeeRequestAllInfoById(int employeeRequestId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {

                return connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    ProjectDTO,
                    PositionDTO,
                    LevelOfPositionDTO,
                    SkillDTO,
                    EmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        if (Project is not null)
                        {
                            EmployeeRequest.Project = Project;
                        }

                        if (EmployeeRequest.Positions is null && Position is not null)
                        {
                            EmployeeRequest.Positions = new Dictionary<PositionDTO, List<LevelOfPositionDTO>>();
                            EmployeeRequest.Positions.Add(Position, new List<LevelOfPositionDTO>());
                            EmployeeRequest.Positions[Position].Add(PositionLevel);
                        }
                        if (EmployeeRequest.Positions.ContainsKey(Position))
                        {
                            EmployeeRequest.Positions[Position].Add(PositionLevel);
                        }
                        else
                        {
                            EmployeeRequest.Positions.Add(Position, new List<LevelOfPositionDTO>());
                            EmployeeRequest.Positions[Position].Add(PositionLevel);
                        }

                        if (EmployeeRequest.Skills is null && Skill is not null)
                        {
                            EmployeeRequest.Skills = new Dictionary<PositionDTO, List<LevelOfPositionDTO>>();
                            EmployeeRequest.Skills.Add(Skill, new List<LevelOfPositionDTO>());
                            EmployeeRequest.Skills[Skill].Add(SkillLevel);
                        }
                        if (EmployeeRequest.Skills.ContainsKey(Skill))
                        {
                            EmployeeRequest.Skills[Skill].Add(SkillLevel);
                        }
                        else
                        {
                            EmployeeRequest.Skills.Add(Position, new List<LevelOfPositionDTO>());
                            EmployeeRequest.Skills[Skill].Add(SkillLevel);
                        }

                        return EmployeeRequest;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id");
            }
        }

        public void UpdateEmployeeRequest(EmployeeRequestInputUpdateModel input)
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

        public void DeleteEmployeeRequestById(DeleteEmployeeRequestByIdInputModel input)
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

        public void CreateEmployeeRequest(EmployeeRequestCreateInputModel input)
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