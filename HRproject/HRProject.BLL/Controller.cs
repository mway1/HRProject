using AutoMapper;
using HRProject.BLL.OutputModels;
using HRProject.DAL.DTOs;
using HRProject.DAL.Managers;

namespace HRProject.BLL
{
    public class Controller
    {
        private Mapper mapper = MapperConfigStorage.GetInstance();

        public List<EmployeeRequestModel> GetEmployeeRequestAllInfo()
        {            
            EmployeeRequestManager manager = new EmployeeRequestManager();
            List<EmplooyeeRequestAllInfoDTO> employeeRequests = manager.GetEmployeeRequestAllInfo();
            List<EmployeeRequestModel> viewEmployeeRequests = new List<EmployeeRequestModel>();

            return mapper.Map(employeeRequests, viewEmployeeRequests);
        }

        public EmployeeRequestModel GetEmployeeRequestAllInfoById(int id)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmplooyeeRequestAllInfoDTO employeeRequest = manager.GetEmployeeRequestAllInfoById(id);
            EmployeeRequestModel viewEmployeeRequest = new EmployeeRequestModel();

            return mapper.Map(employeeRequest, viewEmployeeRequest);
        }

        public void DeleteEmployeeRequestById(EmployeeRequestModel input)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = mapper.Map(input, employeeRequest);
            manager.DeleteEmployeeRequestById(selectedRequest);
        }

        public void CreateEmployeeRequest(EmployeeRequestModel input)
        {
            EmployeeRequestManager manager = new EmployeeRequestManager();
            EmployeeRequestDTO employeeRequest = new EmployeeRequestDTO();
            var selectedRequest = mapper.Map(input, employeeRequest);
            manager.CreateEmployeeRequest(selectedRequest);
        }
    }
}