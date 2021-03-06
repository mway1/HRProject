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

        public List<SkillModel> GetAllSkills()
        {
            List<SkillDTO> skills = _manager.SkillManager.GetAllSkills();
            List<SkillModel> viewSkills = new List<SkillModel>();

            return _mapper.Map(skills, viewSkills);
        }

        public int CreateEmployeeRequest(EmployeeRequestCreateInputModel input)
        {
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = _mapper.Map(input, employeeRequest);
            var newRequestId = _manager.EmployeeRequestManager.CreateEmployeeRequest(selectedRequest);
            return newRequestId;
        }

        public void CreateEmployeeRequestSkill(EmployeeRequestSkillInputModel input)
        {
            EmployeeRequestSkillDTO employeeRequest = new EmployeeRequestSkillDTO();
            var selectedRequest = _mapper.Map(input, employeeRequest);
            _manager.EmployeeRequestManager.CreateEmployeeRequestSkill(selectedRequest);
        }

        public void CreateEmployeeRequestPosition(EmployeeRequestPositionInputModel input)
        {
            EmployeeRequestPositionDTO employeeRequest = new EmployeeRequestPositionDTO();
            var selectedRequest = _mapper.Map(input, employeeRequest);
            _manager.EmployeeRequestManager.CreateEmployeeRequestPosition(selectedRequest);
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
            ProjectDTO project = _manager.ProjectManager.GetProjectById(id)!;
            return _mapper.Map<ProjectOutputModel>(project);
        }
        public StatusOutputModel GetStatus(int id)
        {
            StatusDTO status = _manager.StatusManager.GetStatus(id);
            return _mapper.Map<StatusOutputModel>(status);
        } 
        
        public List<StatusOutputModel> GetAllStatus()
        {
            List<StatusDTO> status = _manager.StatusManager.GetAllStatuses();
            return _mapper.Map<List<StatusOutputModel>>(status);
        }

        public List<ProjectOutputModel> SearchProjects(string name, int limit)
        {
            List<ProjectDTO> project = _manager.ProjectManager.SearchProjects(name, limit);
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }

        public List<ProjectOutputModel> GetAllProjects()
        {
            List<ProjectDTO> project = _manager.ProjectManager.GetAllProjects();
            return _mapper.Map<List<ProjectOutputModel>>(project);
        }

        public List<ProjectOutputModel> GetAllProjects(string type)
        {
            List<ProjectOutputModel> result = new List<ProjectOutputModel>();
            if (type == ProjectTypes.ВсеПроекты)
            {
                result = GetAllProjects();
            }
            else if (type == ProjectTypes.ЗаполненныеПроекты)
            {
                result = GetAllFullProjects();
            }
            else if (type == ProjectTypes.НеЗаполненныеПроекты)
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

        public List<EmployeeHistoryModel> GetAllEmployeeHistory(int employeeId)
        {
            List<EmployeeHistoryDTO> employeeHistories = _manager.EmployeeHistoryManager.GetAllEmployeeHistory(employeeId);
            List<EmployeeHistoryModel> viewEmployeeHistories = new List<EmployeeHistoryModel>();
            return _mapper.Map(employeeHistories, viewEmployeeHistories);
        }

        public EmployeeHistoryModel GetByIdEmployeeHistory(int id)
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

        public void AddEmployeeHistory(EmployeeHistoryModel input)
        {
            EmployeeHistoryDTO employeeHistory = new EmployeeHistoryDTO();
            var selectedHistory = _mapper.Map(input, employeeHistory);
            _manager.EmployeeHistoryManager.AddEmployeeHistory(selectedHistory);
        }

        public void UpdateEmployeeHistory(EmployeeHistoryModel input, int id)
        {
            EmployeeHistoryDTO employeeHistoryDTO = new EmployeeHistoryDTO();
            var selectedHistory = _mapper.Map(input, employeeHistoryDTO);
            _manager.EmployeeHistoryManager.UpdateEmployeeHistory(selectedHistory, id);
        }
        public List<DepartmentModel> GetAllDepartment()
        {
            List<DepartmentDTO> department = _manager.DepartmentManager.GetAllDepartment();
            return _mapper.Map<List<DepartmentModel>>(department);
            
        }

        public DepartmentModel GetByIdDepartment(int id)
        {
            DepartmentDTO department = _manager.DepartmentManager.GetByIdDpeartment(id);
            DepartmentModel viewDepartment = new DepartmentModel();

            return _mapper.Map(department, viewDepartment);
        }

        public void UpdateDepartment(int idDepartment, DepartmentModel input)
        {
            DepartmentDTO department = new DepartmentDTO();
            var selectedDepartment = _mapper.Map(input, department);
            _manager.DepartmentManager.UpdateDepartment(idDepartment, selectedDepartment);
        }

        public void AddDepartment(DepartmentInputModel input)
        {
            //DepartmentDTO department = new DepartmentDTO();
            //var selectedDepartment = _mapper.Map(input, department);
            //_manager.DepartmentManager.AddDepartment(selectedDepartment);
            DepartmentDTO department = _mapper.Map<DepartmentDTO>(input);
            _manager.DepartmentManager.AddDepartment(department);

        }

        public void DeleteDepartment(int id)
        {
            _manager.DepartmentManager.DeleteDepartment(id);
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

        public List<PositionOutputModel> GetAllPosition()
        {
            return _mapper.Map<List<PositionOutputModel>>(_manager.PositionManager.GetAllPositon());
        }

        public PositionModel GetPositionById(int id)
        {
            return _mapper.Map<PositionModel>(_manager.PositionManager.GetPositonById(id));
        }

        public void DeletePosition(int id)
        {
            _manager.PositionManager.DeletePosition(id);
        }

        public List<PositionOutputModel> SearchPosition(string name, int limit)
        {
            List<PositionDTO> position = _manager.PositionManager.SearchPositions(name, limit);
            return _mapper.Map<List<PositionOutputModel>>(position);
        }
        public List<LevelOfPositionOutputModel> LevelOfPositionSearch(string name, int limit)
        {
            List<LevelOfPositionDTO> levels = _manager.LevelOfPositionManager.SearchLevelOfPosition(name, limit);
            return _mapper.Map<List<LevelOfPositionOutputModel>>(levels);
        }

        public void AddEmployee(EmployeeInputModel input)
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

        public List<LevelOfPositionOutputModel> LevelOfPositions_GetAll()
        {
            return _mapper.Map<List<LevelOfPositionOutputModel>>(_manager.LevelOfPositionManager.GetAllLevelOfPosition());
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return _mapper.Map<EmployeeModel>(_manager.EmployeeManager.GetEmployeeById(id));
        }
        public List<EmployeeModel> GetEmployeeByDepartmentId(int id)
        {
            return _mapper.Map<List<EmployeeModel>>(_manager.EmployeeManager.GetEmployeeByDepartmentId(id));
        }
        public void UpdateEmployee(EmployeeModel input)
        {
            EmployeeDTO employee = _mapper.Map<EmployeeDTO>(input);
            _manager.EmployeeManager.UpdateEmployeeById(employee);
        }

        public void AddComment(CommentModel input)
        {
            CommentDTO comment = _mapper.Map<CommentDTO>(input);
            _manager.CommentManager.AddComment(comment);
        }

        public void DeleteComment(int id)
        {
            _manager.CommentManager.DeleteCommentById(id);
        }

        public List<CommentModel> GetAllComments()
        {
            return _mapper.Map<List<CommentModel>>(_manager.CommentManager.GetAllComment());
        }

        public List<CommentModel> GetCommentById(int id)
        {
            return _mapper.Map<List<CommentModel>>(_manager.CommentManager.GetCommentById(id));
        }

        public void UpdateComment(CommentModel input)
        {
            CommentDTO comment = _mapper.Map<CommentDTO>(input);
            _manager.CommentManager.UpdateComment(comment);
        }

        public void AddEmployee_Position(Employee_PostionModel input)
        {
            Employee_PositionDTO employee_Position = _mapper.Map<Employee_PositionDTO>(input);
            _manager.Employee_PositionManager.AddEmployee_Position(employee_Position);
        }
        public void DeleteEmployee_Position(Employee_PositionDTO input)
        {
            Employee_PositionDTO employee_Position = new Employee_PositionDTO();
            var selectedEmployee_Position = _mapper.Map(input, employee_Position);
            _manager.Employee_PositionManager.DeleteEmployee_Position(selectedEmployee_Position);
        }
        public Employee_PostionModel GetEmployee_PostionById(int employeeId)
        {
            return _mapper.Map<Employee_PostionModel>(_manager.Employee_PositionManager.GetEmployee_PositionById(employeeId));
        }
        public void AddEmployee_Skill(Employee_SkillModel input)
        {
            Employee_SkillDTO employee_skill = _mapper.Map<Employee_SkillDTO>(input);
            _manager.Employee_SkillManager.AddEmployee_Skill(employee_skill);
        }
        public void DeleteEmployee_Skill(Employee_SkillDTO input)
        {
            Employee_SkillDTO employee_skill = new Employee_SkillDTO();
            var selectedEmployee_Skill = _mapper.Map(input, employee_skill);
            _manager.Employee_SkillManager.DeleteEmployee_Skill(selectedEmployee_Skill);
        }
        public List<Employee_SkillModel> GetEmployee_SkillById(int employeeId)
        {
            return _mapper.Map<List<Employee_SkillModel>>(_manager.Employee_SkillManager.GetEmployee_SkillById(employeeId));
        }
    }
}