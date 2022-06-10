namespace HRProject.DAL.DTOs
{
    public class RequestSkillDTO
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public bool IsDeleted { get; set; }
        public RequestEmployeeRequestSkillDTO SkillLevel { get; set; }
    }
}
