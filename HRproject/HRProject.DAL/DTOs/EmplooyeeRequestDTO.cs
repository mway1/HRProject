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
        public List<string> PositionName { get; set; }
        public List<string> LevelOfPositionName { get; set; }
        public List<string> SkillName { get; set; }
        public List<int> LevelOfSkill { get; set; }
        public int Quantity { get; set; }
    }
}
