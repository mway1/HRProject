using AutoMapper;
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
        public List<DepartmentModel> GetAllDepartment()
        {
            List<DepartmentDTO> department = _manager.DepartmentManager.GetAllDepartment();
            List<DepartmentModel> viewDepartment = new List<DepartmentModel>();
            return _mapper.Map(department, viewDepartment);
        }

        public DepartmentModel GetByIdDepartment (int id)
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

        public void AddDepartment(DepartmentModel input)
        {
            DepartmentDTO department = new DepartmentDTO();
            var selectedDepartment = _mapper.Map(input, department);
            _manager.DepartmentManager.AddDepartment(selectedDepartment);
        }

        public void DeleteDepartment(int id)
        {
            _manager.DepartmentManager.DeleteDepartment(id);
        }
    }
}