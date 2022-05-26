using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;



namespace HRProject.DAL
{
    public class ProjectRequestManager
    {
        public string _connectionString = @"Server=DESKTOP-THG88DI;Database=pets;Trusted_Connection=True;";

        public ProjectDTO? GetProjectById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                    sql: "Project_get",
                    param: new { id = id },
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();

                if (projects.Count == 0)
                {
                    return null;
                }
                return projects[0];
            }
        }
        public ProjectDTO? UpdateProject(int id, string name, string decsription, bool isDeleted)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                                  sql: "Project_update",
                                  param: new { id = id, name = name , description = decsription, isDeleted = isDeleted},
                                  commandType: System.Data.CommandType.StoredProcedure)
                                  .ToList();

                if (projects.Count == 0)
                {
                    return null;
                }
                return projects[0];
            }
        }
        public ProjectDTO? AddProject(int id, string name, string decsription, bool isDeleted)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                                  sql: "Project_Add",
                                  param: new { id = id, name = name , description = decsription, isDeleted = isDeleted},
                                  commandType: System.Data.CommandType.StoredProcedure)
                                  .ToList();

                if (projects.Count == 0)
                {
                    return null;
                }
                return projects[0];
            }
        }       
    }
}
