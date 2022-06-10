
namespace HRProject.BLL.OutputModels
{
    public class Employee_SkillModel
    {
        public int id { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int LevelOfSkill { get; set; }
    }
}
