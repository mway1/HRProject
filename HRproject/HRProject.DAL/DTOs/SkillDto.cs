namespace HRProject.DAL.DTOs
{
    public class SkillDTO
    { 
        public int  Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public EmployeeRequestSkillDTO SkillLevel { get; set; }
    }
}
