using AutoMapper;
using HRProject.BLL.InputModels;
using HRProject.BLL.Models;
using HRProject.DAL;
using HRProject.DAL.DTOs;
using System.Collections.ObjectModel;


namespace HRProject.BLL.Services
{
    public class ProjectService
    {
        private readonly Mapper _mapper;
        private readonly ProjectManager _projectManager;

        public ProjectService(Mapper mapper, ProjectManager projectManager)
        {
            _mapper = MapperConfigStorage.GetInstance();
            _projectManager = projectManager;
        }

        public void AddProject(ProjectInputModel model)
        {
            ProjectDTO project = _mapper.Map<ProjectDTO>(model);
            _projectManager.AddProject(project);
        }

        public void UpdateProject(int id, ProjectInputModel model)
        {
            ProjectDTO project = _mapper.Map<ProjectDTO>(model);
            _projectManager.UpdateProject(id, project);
        }

        public ProjectOutputModel GetProjectById(int id)
        {
            ProjectDTO project = _projectManager.GetProjectById(id);
            return _mapper.Map<ProjectOutputModel>(project);
        }

        public List<ProjectOutputModel> GetAllProjects()
        {
            List<ProjectDTO> project = _projectManager.GetAllProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }

        public List<ProjectOutputModel> GetAllFullProjects()
        {
            List<ProjectDTO> project = _projectManager.GetAllFullProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }

        public List<ProjectOutputModel> GetAllNotFullProjects()
        {
            List<ProjectDTO> project = _projectManager.GetAllNotFullProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }


        private ObservableCollection<ProjectOutputModel> Projects;

        public static ProjectService GetInstance()
        {
            Mapper mapper = MapperConfigStorage.GetInstance();
            ProjectManager projectManager = new ProjectManager();
            return new ProjectService(mapper, projectManager);
        }

        public List<ProjectOutputModel> GetAllProjects(string type)
        {
            List<ProjectOutputModel> result= new List<ProjectOutputModel>();
            if (type == ProjectTypes.AllProjects)
            {
                result = GetAllProjects();
            }
            else if (type == ProjectTypes.FullProjects)
            {
                result = GetAllFullProjects();
            }
            else if (type == ProjectTypes.PartuallyFull)
            {
                result = GetAllNotFullProjects();
            }
            return result;
        }
    }

}
