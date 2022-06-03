using AutoMapper;
using HRProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL.Service
{
    public class DepartmentService
    {
        private readonly Mapper _mapper;
        private readonly DepartmentManager _departmentManager;

        public DepartmentService(Mapper mapper, DepartmentManager departmentManager)
        {
            _mapper = MapperConfigStorage.GetInstance();
            _departmentManager = departmentManager;
        }

    }
}
