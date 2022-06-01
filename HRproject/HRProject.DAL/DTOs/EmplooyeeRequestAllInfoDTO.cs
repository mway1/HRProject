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
        public ProjectDTO Project { get; set; }
        public Dictionary<PositionDTO, List<LevelOfPositionDTO>> Positions { get; set; }
        public Dictionary<SkillDTO, List<EmployeeRequestSkillDTO>> Skills { get; set; }
    }
}
