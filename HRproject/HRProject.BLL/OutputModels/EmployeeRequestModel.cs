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
