using AutoMapper;
using HRProject.BLL.OutputModels;
using HRProject.DAL;
using HRProject.DAL.DTOs;
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

        public void AddDepartment(DepartmentModel model)
        {
            DepartmentDTO department = _mapper.Map<DepartmentDTO>(model);
            _departmentManager.AddDepartment(department);
        }

        public void UpdateDepartment(int id, DepartmentModel model)
        {
            DepartmentDTO department = _mapper.Map<DepartmentDTO>(model);
            _departmentManager.UpdateDepartment(id, department);
        }

        public DepartmentModel GetDepartmentById(int id)
        {
            DepartmentDTO department = _departmentManager.GetByIdDpeartment(id);
            return _mapper.Map<DepartmentModel>(department);
        }

        public List<DepartmentModel> GetAllDepartments()
        {
            List<DepartmentDTO> department = _departmentManager.GetAllDepartments();
            return _mapper.Map<List<DepartmentModel>>(department);
        }

        public void DeleteDepartment(int id)
        {
            DepartmentDTO department = _mapper.Map<DepartmentDTO>(id);
            _departmentManager.DeleteDepartment(id);
        }

    }
}
