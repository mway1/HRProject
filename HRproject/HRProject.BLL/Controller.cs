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
    }
}