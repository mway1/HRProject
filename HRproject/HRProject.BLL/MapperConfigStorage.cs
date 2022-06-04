﻿using AutoMapper;
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
                cfg.CreateMap<EmployeeDTO, EmployeeModel>()
                .ForMember("Name", opt => opt.MapFrom(c => $"{c.FirstName} {c.SecondName} {c.LastName} "))
                .ForMember("BirthDate", opt=> opt.MapFrom(c=> $"{c.BirthDate}"))
                .ForMember("Email", opt=> opt.MapFrom(c=> $"{c.Email}"))
                .ForMember("PhoneNumber", opt=> opt.MapFrom(c=> $"{c.PhoneNumber}"))
                .ForMember("StatusId", opt=> opt.MapFrom(c=> $"{c.StatusId}"))
                .ForMember("DepartmentId", opt=> opt.MapFrom(c=> $"{c.DepartmentId}"))
                .ForMember("isDeleted", opt=> opt.MapFrom(c=> $"{c.isDeleted}"));

                cfg.CreateMap<DepartmentDTO, DepartmentModel>()
                .ForMember("Name", opt=> opt.MapFrom(c=> $"{c.Name}" ))
                .ForMember("Description", opt=> opt.MapFrom(c=> $"{c.Description}"))
                .ForMember("IsDeleted", opt => opt.MapFrom(c => $"{c.IsDeleted}"));

                cfg.CreateMap<EmployeeHistoryDTO, EmployeeHistoryModel>()
                .ForMember("EmployeeId", opt => opt.MapFrom(c => $"{c.EmployeeId}"))
                .ForMember("Date", opt => opt.MapFrom(c => $"{c.Date}"))
                .ForMember("StatusId", opt => opt.MapFrom(c => $"{c.StatusId}"))
                .ForMember("IsDeleted", opt => opt.MapFrom(c => $"{c.IsDeleted}"));

                cfg.CreateMap<ProjectDTO, ProjectModel>()
                .ForMember("Id", opt => opt.MapFrom(c => c.Id))
                .ForMember("Name", opt => opt.MapFrom(c => c.Name));

                cfg.CreateMap<PositionDTO, PositionModel>()
                .ForMember("Id", opt => opt.MapFrom(c => c.Id))
                .ForMember("Name", opt => opt.MapFrom(c => c.Name))
                .ForMember("PositionLevel", opt => opt.MapFrom(c => c.PositionLevel.Name));

                cfg.CreateMap<SkillDTO, SkillModel>()
                .ForMember("Id", opt => opt.MapFrom(c => c.Id))
                .ForMember("Name", opt => opt.MapFrom(c => c.Name))
                .ForMember("SkillLevel", opt => opt.MapFrom(c => c.SkillLevel.LevelOfSkill));

                cfg.CreateMap<EmplooyeeRequestAllInfoDTO, EmployeeRequestAllInfoModel>()
                .ForMember("Id", opt => opt.MapFrom(c => c.id))
                .ForMember("Quantity", opt => opt.MapFrom(c => c.Quantity))
                .ForMember("Project", opt => opt.MapFrom(c => c.Project))
                .ForMember("Positions", opt => opt.MapFrom(c => c.Positions))
                .ForMember("Skills", opt => opt.MapFrom(c => c.Skills));

                cfg.CreateMap<EmployeeRequestDTO, EmployeeRequestAllInfoModel>()
                .ForMember("Id", opt => opt.MapFrom(c => c.Id))
                .ForMember("ProjectId", opt => opt.MapFrom(c => c.ProjectId))
                .ForMember("Quantity", opt => opt.MapFrom(c => c.Quantity))
                .ForMember("IsDeleted", opt => opt.MapFrom(c => c.IsDeleted));

            }));
        }
    }
}