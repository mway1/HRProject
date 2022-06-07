using Dapper;
using HRProject.DAL.DTOs;
using HRProject.DAL.StoredProcedureStorage;
using System.Data.SqlClient;

namespace HRProject.DAL
{
    public class ProjectManager
    {
        public ProjectDTO? GetProjectById(int id)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                    ProjectStoredProcedures.Project_Get,
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

        public List<ProjectDTO> GetAllProjects()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                    ProjectStoredProcedures.Project_GetAll,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
                return projects;
            }
        }

        public ProjectDTO GetAllProjectById()
        {
            throw new NotImplementedException();
        }

        public ProjectDTO? UpdateProject(int id, ProjectDTO project)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                                 ProjectStoredProcedures.Project_Update,
                                  param: new { id = project.Id, name = project.Name, description = project.Description},
                                  commandType: System.Data.CommandType.StoredProcedure)
                                  .ToList();

                if (projects.Count == 0)
                {
                    return null;
                }
                return projects[0];
            }
        }

        public ProjectDTO? AddProject(ProjectDTO project)
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();
                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                                  ProjectStoredProcedures.Project_Add,
                                  param: new { id = project.Id, name = project.Name, description = project.Description },
                                  commandType: System.Data.CommandType.StoredProcedure)
                                  .ToList();

                if (projects.Count == 0)
                {
                    return null;
                }
                return projects[0];
            }
        }

        public List<ProjectDTO> GetAllFullProjects()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                    ProjectStoredProcedures.Project_GetAllFull,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
                return projects;
            }
        }

        public List<ProjectDTO> GetAllNotFullProjects()
        {
            using (var connection = new SqlConnection(ServerSettings._connectionString))
            {
                connection.Open();

                List<ProjectDTO> projects = connection.Query<ProjectDTO>(
                    ProjectStoredProcedures.Project_GetAllNotFull,
                    commandType: System.Data.CommandType.StoredProcedure)
                    .ToList();
                return projects;
            }
        }
    }
}
