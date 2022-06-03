﻿using System;
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


                cfg.CreateMap<EmplooyeeRequestAllInfoDTO, EmployeeRequestModel>()
                .ForMember("Quantity", opt=> opt.MapFrom(c=> $"{c.Quantity}"))
                .ForMember("ProjectName", opt=> opt.MapFrom(c=> $"{c.ProjectName}"))
                .ForMember("PositionName", opt=> opt.MapFrom(c=> $"{c.PositionName}"))
                .ForMember("PositionLevel", opt=> opt.MapFrom(c=> $"{c.PositionLevel}"))
                .ForMember("SkillName", opt=> opt.MapFrom(c=> $"{c.SkillName}"))
                .ForMember("LevelOfSkill", opt=> opt.MapFrom(c=> $"{c.LevelOfSkill}"));
            }));
        }
    }
}