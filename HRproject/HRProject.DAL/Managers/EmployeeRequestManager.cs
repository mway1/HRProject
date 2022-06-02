﻿using HRProject.DAL.StoredProcedureStorage;
using HRProject.DAL.DTOs;
using System.Data.SqlClient;
using Dapper;


//namespace HRProject.DAL.Managers
//{
//    public class EmployeeRequestManager
//    {
//        public string _connectionString = @"Server=.\SQLEXPRESS;Database=....;Trusted_Connection=True;";

//        public List<EmplooyeeRequestAllInfoDTO> GetEmployeeRequestAllInfo()
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    ProjectDTO,
                    PositionDTO,
                    LevelOfPositionDTO,
                    SkillDTO,
                    EmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        if (!result.ContainsKey(EmployeeRequest.id))
                        {
                            result.Add(EmployeeRequest.id, EmployeeRequest);
                        }

//                connection.Query<EmplooyeeRequestAllInfoDTO, string, string, string, int?, EmplooyeeRequestAllInfoDTO>(
//                    EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfo,
//                    (EmployeeRequest, PositionName, PositionLevel, SkillName, SkillLevel) =>
//                    {
//                        if (!result.ContainsKey(EmployeeRequest.id))
//                        {
//                            result.Add(EmployeeRequest.id, EmployeeRequest);
//                        }

                        if (Project is not null)
                        {
                            crnt.Project = Project;
                        }

                        if (crnt.Positions is null && Position is not null)
                        {
                            crnt.Positions = new List<PositionDTO>();
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions.Add(Position);
                        }
                        else if (Position is not null)
                        {
                            Position.PositionLevel = PositionLevel;
                            crnt.Positions!.Add(Position);
                        }
                        
                        if (crnt.Skills is null && Skill is not null)
                        {
                            crnt.Skills = new List<SkillDTO>();
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills.Add(Skill);
                        }
                        else if (Skill is not null)
                        {
                            Skill.SkillLevel = SkillLevel;
                            crnt.Skills!.Add(Skill);
                        }

                        return crnt;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id");

//                        return crnt;
//                    },
//                    commandType: System.Data.CommandType.StoredProcedure,
//                    splitOn: "id PositionName PositionLevel SkillName LevelOfSkill");

        public EmplooyeeRequestAllInfoDTO GetEmployeeRequestAllInfoById(int employeeRequestId)
        {
            EmplooyeeRequestAllInfoDTO result = new EmplooyeeRequestAllInfoDTO();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Query<
                    EmplooyeeRequestAllInfoDTO,
                    ProjectDTO,
                    PositionDTO,
                    LevelOfPositionDTO,
                    SkillDTO,
                    EmployeeRequestSkillDTO,
                    EmplooyeeRequestAllInfoDTO
                    >
                    (EmployeeRequestStoredProcedures.GetEmployeeRequestAllInfoById,
                    (EmployeeRequest, Project, Position, PositionLevel, Skill, SkillLevel) =>
                    {
                        result = EmployeeRequest;

                        if (Project is not null)
                        {
                            result.Project = Project;
                        }

                        if (result.Positions is null && Position is not null)
                        {
                            result.Positions = new List<PositionDTO>();
                            Position.PositionLevel = PositionLevel;
                            result.Positions.Add(Position);
                        }
                        else if (Position is not null)
                        {
                            Position.PositionLevel = PositionLevel;
                            result.Positions!.Add(Position);
                        }

                        if (EmployeeRequest.Skills is null && Skill is not null)
                        {
                            result.Skills = new List<SkillDTO>();
                            Skill.SkillLevel = SkillLevel;
                            result.Skills.Add(Skill);
                        }
                        else if (Skill is not null)
                        {
                            Skill.SkillLevel = SkillLevel;
                            result.Skills!.Add(Skill);
                        }

                        return EmployeeRequest;
                    },
                    commandType: System.Data.CommandType.StoredProcedure,
                    splitOn: "id",
                    param: new {employeeRequestId});

//                        return crnt;
//                    },
//                    commandType: System.Data.CommandType.StoredProcedure,
//                    splitOn: "id PositionName PositionLevel SkillName LevelOfSkill");

        public void UpdateEmployeeRequest(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

//        public void UpdateEmployeeRequest(EmployeeRequestInputUpdateModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

        public void DeleteEmployeeRequestById(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

//        public void DeleteEmployeeRequestById(DeleteEmployeeRequestByIdInputModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

        public void CreateEmployeeRequest(EmployeeRequestDTO input)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

//        public void CreateEmployeeRequest(EmployeeRequestCreateInputModel input)
//        {
//            using (var connection = new SqlConnection(_connectionString))
//            {
//                connection.Open();

//                connection.QuerySingle(EmployeeRequestStoredProcedures.CreateEmployeeRequest,
//                    param: new
//                    {
//                        input.ProjectId,
//                        input.Quantity
//                    },
//                commandType: System.Data.CommandType.StoredProcedure);
//            }
//        }
//    }
//}