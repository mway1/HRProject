namespace HRProject.DAL.DTOs
{
    public class EmployeeRequestPositionDTO
    {
        public int Id { get; set; }
        public int? EmployeeRequestId { get; set; }
        public int? PositionId { get; set; }
        public int? LevelOfPositionId { get; set; }

    }
}