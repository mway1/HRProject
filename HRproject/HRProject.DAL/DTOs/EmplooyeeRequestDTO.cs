using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.DAL.DTOs
{
    public class EmplooyeeRequestAllInfoDTO
    {
        public string ProjectName { get; set; }
        public string PositionName { get; set; }
        public string LevelOfPositionName { get; set; }
        public string SkillName { get; set; }
        public int LevelOfSkill { get; set; }
        public int Quantity { get; set; }
    }
}
