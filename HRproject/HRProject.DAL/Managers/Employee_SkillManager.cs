using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL.Managers
{
    public class Employee_SkillManager
    {
        public void AddEmployee_Skill(Employee_SkillDTO newEmployee_Skill)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                connection.QuerySingle<Employee_SkillDTO>(
                    Employee_SkillStoredProcedures.Employee_Skill_Add,
                    param: new
                    {
                        newEmployee_Skill.EmployeeId,
                        newEmployee_Skill.SkillId,
                        newEmployee_Skill.LevelOfSkill
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public void DeleteEmployee_Skill(Employee_SkillDTO input)

        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                connection.QuerySingle(
                   Employee_SkillStoredProcedures.Employee_Skill_Delete,
                    param: new
                    {
                        input.id,
                        input.EmployeeId,
                        input.SkillId,
                        input.LevelOfSkill
                    },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
        public List<Employee_SkillDTO> GetEmployee_SkillById(int employeeId)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                return connection.Query<Employee_SkillDTO>(
                    Employee_SkillStoredProcedures.Employee_Skill_GetById,
                    param: new { EmployeeId = employeeId },
                    commandType: System.Data.CommandType.StoredProcedure).ToList();
            }
        }

    }
}
