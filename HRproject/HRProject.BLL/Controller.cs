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





        public List <EmployeeHistoryModel> GetAllEmployeeHistory()
        { 
            List<EmployeeHistoryDTO> employeeHistories = _manager.EmployeeHistoryManager.GetAllEmployeeHistory();
            List<EmployeeHistoryModel> viewEmployeeHistories = new List<EmployeeHistoryModel>();
            return _mapper.Map(employeeHistories, viewEmployeeHistories);
        }

        public EmployeeHistoryModel GetByIdEmployeeHistory (int id)
        {
            EmployeeHistoryDTO employeeHistory = _manager.EmployeeHistoryManager.GetByIdEmployeeHistory(id);
            EmployeeHistoryModel viewEmployeeHistory = new EmployeeHistoryModel();
            return _mapper.Map(employeeHistory, viewEmployeeHistory);
        }

        public void DeleteEmployeeHistory(EmployeeHistoryModel input)
        {
            EmployeeHistoryDTO employeeHistory = new EmployeeHistoryDTO();
            var selectedHistory = _mapper.Map(input, employeeHistory);
            _manager.EmployeeHistoryManager.DeleteEmployeeHistory(selectedHistory);
        }
        //public void DeleteEmployeeHistory (int id)
        //{
        //    EmployeeHistoryDTO employeeHistory = _manager.EmployeeHistoryManager.DeleteEmployeeHistory(id);
        //    EmployeeHistoryModel viewEmployeeHistory = new EmployeeHistoryModel();
        //    _mapper.Map(employeeHistory, viewEmployeeHistory);
        //}

        public void AddEmployeeHistory (EmployeeHistoryModel input)
        {
            EmployeeHistoryDTO employeeHistory = new EmployeeHistoryDTO();
            var selectedHistory = _mapper.Map(input, employeeHistory);
            _manager.EmployeeHistoryManager.AddEmployeeHistory(selectedHistory);
        }

        public void UpdateEmployeeHistory (EmployeeHistoryModel input, int id)
        {
            EmployeeHistoryDTO employeeHistoryDTO = new EmployeeHistoryDTO();
            var selectedHistory = _mapper.Map(input, employeeHistoryDTO);
            _manager.EmployeeHistoryManager.UpdateEmployeeHistory(selectedHistory, id);
        }

        public void AddPosition(PositionModel input)
        {
            PositionDTO position = _mapper.Map<PositionDTO>(input);
            _manager.PositionManager.AddPosition(position);
        }
        public void UpdatePosition(PositionModel input)
        {
            PositionDTO position = _mapper.Map<PositionDTO>(input);
            _manager.PositionManager.UpdatePosition(position);

        }

        public List<PositionModel> GetAllPosition()
        {           
            return _mapper.Map<List<PositionModel>>(_manager.PositionManager.GetAllPositon());
        }
        public PositionModel GetAllPosition(int id)
        {
            return _mapper.Map<PositionModel>(_manager.PositionManager.GetPositonById(id));
        }
        public void DeletePosition(int id)
        {
            _manager.PositionManager.DeletePosition(id);
        }


        public void AddEmployee(EmployeeModel input)
        {
            EmployeeDTO employee = _mapper.Map<EmployeeDTO>(input);
            _manager.EmployeeManager.AddEmployee(employee);
        }
        public void DeleteEmployee(int id)
        {
            _manager.EmployeeManager.DeleteEmployeeById(id);
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            return _mapper.Map<List<EmployeeModel>>(_manager.EmployeeManager.GetAllEmployee());
        }
        public List<EmployeeModel> GetEmployeeById(int id)
        {
            return _mapper.Map<List<EmployeeModel>>(_manager.EmployeeManager.GetEmployeeById(id));
        }
        public void UpdateEmployee(EmployeeModel input)
        {
            EmployeeDTO employee = _mapper.Map<EmployeeDTO>(input);
            _manager.EmployeeManager.UpdateEmployeeById(employee);
        }
    }
}