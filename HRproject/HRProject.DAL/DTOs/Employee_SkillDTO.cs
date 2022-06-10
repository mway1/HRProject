using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class Employee_SkillDTO
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int LevelOfSkill { get; set; }
        public override string ToString()
        {
            return $"id={id} EmployeeId={EmployeeId} SkillId={SkillId} LevelOfSkill={LevelOfSkill}";
        }
    }
}