using AutoMapper;
using HRProject.BLL.OutputModels;
using HRProject.DAL.DTOs;
using HRProject.DAL.Managers;

namespace HRProject.BLL
{
    public class Controller
    {
        private Mapper mapper = MapperConfigStorage.GetInstance();

        public List<EmployeeRequestAllInfoModel> GetEmployeeRequestAllInfo()
        {            
            EmployeeRequestManager manager = new EmployeeRequestManager();
            List<EmplooyeeRequestAllInfoDTO> employeeRequests = manager.GetEmployeeRequestAllInfo();
            List<EmployeeRequestAllInfoModel> viewEmployeeRequests = new List<EmployeeRequestAllInfoModel>();

            return mapper.Map(employeeRequests, viewEmployeeRequests);
        }

        public List<EmployeeRequestAllInfoModel> GetEmployeeRequestAllInfoByProjectId(int projectId)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            List<EmplooyeeRequestAllInfoDTO> employeeRequests = manager.GetEmployeeRequestAllInfoByProjectId(projectId);
            List<EmployeeRequestAllInfoModel> viewEmployeeRequests = new List<EmployeeRequestAllInfoModel>();

            return mapper.Map(employeeRequests, viewEmployeeRequests);
        }

        public EmployeeRequestAllInfoModel GetEmployeeRequestAllInfoById(int id)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmplooyeeRequestAllInfoDTO employeeRequest = manager.GetEmployeeRequestAllInfoById(id);
            EmployeeRequestAllInfoModel viewEmployeeRequest = new EmployeeRequestAllInfoModel();

            return mapper.Map(employeeRequest, viewEmployeeRequest);
        }

        public void DeleteEmployeeRequestById(EmployeeRequestAllInfoModel input)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = mapper.Map(input, employeeRequest);
            manager.DeleteEmployeeRequestById(selectedRequest);
        }

        public void CreateEmployeeRequest(EmployeeRequestAllInfoModel input)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = mapper.Map(input, employeeRequest);
            manager.CreateEmployeeRequest(selectedRequest);
        }
    }
}