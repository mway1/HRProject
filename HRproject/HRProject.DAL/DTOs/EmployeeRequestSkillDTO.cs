namespace HRProject.DAL.DTOs
{
    public class EmployeeRequestSkillDTO
    {
        public int Id { get; set; }
        public int? EmployeeRequestId { get; set; }
        public int? SkillId { get; set; } 
        public int? SkillLevel { get; set; }
    }
}
