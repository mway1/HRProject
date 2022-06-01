using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using HRProject.DAL.DTOs;
using HRProject.BLL.OutputModels;

namespace HRProject.BLL
{
    public class MapperConfigStorage
    {
        private static Mapper _instance;

        public static Mapper GetInstance()
        {
            if (_instance == null)
                InitializeInstance();
            return _instance;
        }

        private static void InitializeInstance()
        {
            _instance = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeDTO, EmployeeModel>();
                cfg.CreateMap<DepartmentDTO, DepartmentModel>();
                cfg.CreateMap<EmployeeHistoryDTO, EmployeeHistoryModel>();
                cfg.CreateMap<EmplooyeeRequestAllInfoDTO, EmployeeRequestModel>();
            }));
        }
    }
}
