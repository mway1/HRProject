namespace HRProject.DAL.DTOs
{
    public class EmplooyeeRequestAllInfoDTO
    {
        public int id { get; set; }
        public int Quantity { get; set; }
        public string ProjectName { get; set; }
        public List<string> PositionName { get; set; }
        public List<string> PositionLevel { get; set; }
        public List<string> SkillName { get; set; }
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
