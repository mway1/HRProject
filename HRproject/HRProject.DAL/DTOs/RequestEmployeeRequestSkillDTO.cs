namespace HRProject.DAL.DTOs
{
    public class RequestEmployeeRequestSkillDTO
    {
        public int Id { get; set; }
        public int? EmployeeRequestId { get; set; }
        public int? SkillId { get; set; }
        public int? LevelOfSkill { get; set; }
    }
}
