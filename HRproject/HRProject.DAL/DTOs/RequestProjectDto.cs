namespace HRProject.DAL.DTOs
{
    public class RequestProjectDTO
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
