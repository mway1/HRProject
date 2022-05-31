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
        public List<string> PositionLevel { get; set; }
        public Dictionary<SkillDTO> SkillName { get; set; }
        public List<int?> LevelOfSkill { get; set; }

        public EmplooyeeRequestAllInfoDTO()
        {
            PositionName = new List<string>();
            PositionLevel = new List<string>();
            SkillName = new List<string>();
            LevelOfSkill = new List<int?>();
        }
    }
}
