using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class EmplooyeeRequestAllInfoDTO
    {
        public int id { get; set; }
        public int? Quantity { get; set; }
        public ProjectDTO ProjectName { get; set; }
        public Dictionary<PositionDTO, LevelOfPositionDTO> PositionName { get; set; }
        public Dictionary<SkillDTO, EmployeeRequestSkillDTO> SkillName { get; set; }
    }
}
