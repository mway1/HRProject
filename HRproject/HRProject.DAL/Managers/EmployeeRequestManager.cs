//using HRProject.DAL.Managers;
//using HRProject.DAL.StoredProcedureStorage;
//using Dapper;
//using HRProject.DAL.DTOs;
//using System.Data.SqlClient;
//using HRProject.BLL.InputModels;

//namespace HRProject.DAL.Managers
//{
//    public class EmployeeRequestManager
//    {
//        public string _connectionString = @"Server=.\SQLEXPRESS;Database=....;Trusted_Connection=True;";

//        public List<EmplooyeeRequestAllInfoDTO> GetEmployeeRequestAllInfo()
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                Dictionary<int, EmplooyeeRequestAllInfoDTO> result = new Dictionary<int, EmplooyeeRequestAllInfoDTO>();

//                connection.Query<EmplooyeeRequestAllInfoDTO, string, string, string, int?, EmplooyeeRequestAllInfoDTO>(
//                    EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
//                    (EmployeeRequest, PositionName, PositionLevel, SkillName, SkillLevel) =>
//                    {
//                        if (!result.ContainsKey(EmployeeRequest.id))
//                        {
//                            result.Add(EmployeeRequest.id, EmployeeRequest);
//                        }

//                        EmplooyeeRequestAllInfoDTO crnt = result[EmployeeRequest.id];

//                        if (PositionLevel is not null)
//                        {
//                            crnt.PositionLevel.Add(PositionLevel);
//                        }
//                        if (SkillLevel is not null)
//                        {
//                            crnt.LevelOfSkill.Add(SkillLevel);
//                        }

//                        crnt.PositionName.Add(SkillName);
//                        crnt.SkillName.Add(PositionName);

//                        return crnt;
//                    },
//                    commandType: System.Data.CommandType.StoredProcedure,
//                    splitOn: "id PositionName PositionLevel SkillName LevelOfSkill");

//                return result.Values.ToList();
//            }
//        }

//        public EmplooyeeRequestAllInfoDTO GetEmployeeRequestAllInfoById(int employeeRequestId)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                EmplooyeeRequestAllInfoDTO result = new EmplooyeeRequestAllInfoDTO();

//                connection.Query<EmplooyeeRequestAllInfoDTO, string, string, string, int?, EmplooyeeRequestAllInfoDTO>(
//                    EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
//                    (EmployeeRequest, PositionName, PositionLevel, SkillName, SkillLevel) =>
//                    {
//                        EmplooyeeRequestAllInfoDTO crnt = result;

//                        if (PositionLevel is not null)
//                        {
//                            crnt.PositionLevel.Add(PositionLevel);
//                        }
//                        if (SkillLevel is not null)
//                        {
//                            crnt.LevelOfSkill.Add(SkillLevel);
//                        }

//                        crnt.PositionName.Add(SkillName);
//                        crnt.SkillName.Add(PositionName);

//                        return crnt;
//                    },
//                    commandType: System.Data.CommandType.StoredProcedure,
//                    splitOn: "id PositionName PositionLevel SkillName LevelOfSkill");

//                return result;
//            }
//        }

//        public void UpdateEmployeeRequest(EmployeeRequestInputUpdateModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                connection.QuerySingle(EmployeeRequestStoredProcedures.UpdateEmployeeRequestById,
//                    param: new
//                    {
//                        input.Id,
//                        input.ProjectId,
//                        input.Quantity,
//                        input.IsDeleted
//                    },
//                commandType: System.Data.CommandType.StoredProcedure);
//            }
//        }

//        public void DeleteEmployeeRequestById(DeleteEmployeeRequestByIdInputModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                connection.QuerySingle(EmployeeRequestStoredProcedures.DeleteEmployeeRequestById,
//                    param: new
//                    {
//                        input.Id,
//                        input.ProjectId,
//                        input.Quantity
//                    },
//                commandType: System.Data.CommandType.StoredProcedure);
//            }
//        }

//        public void CreateEmployeeRequest(EmployeeRequestCreateInputModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                connection.QuerySingle(EmployeeRequestStoredProcedures.CreateEmployeeRequest,
//                    param: new
//                    {
//                        input.ProjectId,
//                        input.Quantity
//                    },
//                commandType: System.Data.CommandType.StoredProcedure);
//            }
//        }
//    }
//}