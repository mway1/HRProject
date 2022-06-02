using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL.OutputModels
{
    public class EmployeeRequestModel
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public string ProjectName { get; set; }
        public List<string> PositionName { get; set; }
        public List<string> PositionLevel { get; set; }
        public List<string> SkillName { get; set; }
        public List<int?> LevelOfSkill { get; set; }
    }
}
