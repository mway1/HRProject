using AutoMapper;
using HRProject.BLL.InputModels;
using HRProject.BLL.Models;
using HRProject.BLL.OutputModels;
using HRProject.DAL.DTOs;
using HRProject.DAL.Managers;

namespace HRProject.BLL
{
    public class Controller
    {
        private Mapper _mapper = MapperConfigStorage.GetInstance();
        private ManagerStorage _manager = new ManagerStorage();

        public List<EmployeeRequestAllInfoModel> GetEmployeeRequestAllInfo()
        {
            List<EmplooyeeRequestAllInfoDTO> employeeRequests = _manager.EmployeeRequestManager.GetEmployeeRequestAllInfo();
            List<EmployeeRequestAllInfoModel> viewEmployeeRequests = new List<EmployeeRequestAllInfoModel>();

            return _mapper.Map(employeeRequests, viewEmployeeRequests);
        }

        public List<EmployeeRequestAllInfoModel> GetEmployeeRequestAllInfoByProjectId(int projectId)
        {
            List<EmplooyeeRequestAllInfoDTO> employeeRequests = _manager.EmployeeRequestManager.GetEmployeeRequestAllInfoByProjectId(projectId);
            List<EmployeeRequestAllInfoModel> viewEmployeeRequests = new List<EmployeeRequestAllInfoModel>();

            return _mapper.Map(employeeRequests, viewEmployeeRequests);
        }

        public EmployeeRequestAllInfoModel GetEmployeeRequestAllInfoById(int id)
        {
            EmplooyeeRequestAllInfoDTO employeeRequest = _manager.EmployeeRequestManager.GetEmployeeRequestAllInfoById(id);
            EmployeeRequestAllInfoModel viewEmployeeRequest = new EmployeeRequestAllInfoModel();

            return _mapper.Map(employeeRequest, viewEmployeeRequest);
        }

        public void DeleteEmployeeRequestById(EmployeeRequestAllInfoModel input)
        {
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = _mapper.Map(input, employeeRequest);
            _manager.EmployeeRequestManager.DeleteEmployeeRequestById(selectedRequest);
        }

        public void CreateEmployeeRequest(EmployeeRequestAllInfoModel input)
        {
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = _mapper.Map(input, employeeRequest);
            _manager.EmployeeRequestManager.CreateEmployeeRequest(selectedRequest);
        }

        public void AddProject(ProjectInputModel model)
        {
            ProjectDTO project = _mapper.Map<ProjectDTO>(model);
            _manager.ProjectManager.AddProject(project);
        }

        public void UpdateProject(int id, ProjectInputModel model)
        {
            ProjectDTO project = _mapper.Map<ProjectDTO>(model);
            _manager.ProjectManager.UpdateProject(id, project);
        }

        public ProjectOutputModel GetProjectById(int id)
        {
            ProjectDTO project = _manager.ProjectManager.GetProjectById(id);
            return _mapper.Map<ProjectOutputModel>(project);
        }

        public List<ProjectOutputModel> GetAllProjects()
        {
            List<ProjectDTO> project = _manager.ProjectManager.GetAllProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }
        public List<ProjectOutputModel> GetAllProjects(string type)
        {
            List<ProjectOutputModel> result = new List<ProjectOutputModel>();
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

        public List<ProjectOutputModel> GetAllFullProjects()
        {
            List<ProjectDTO> project = _manager.ProjectManager.GetAllFullProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }

        public List<ProjectOutputModel> GetAllNotFullProjects()
        {
            List<ProjectDTO> project = _manager.ProjectManager.GetAllNotFullProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }
    }
}