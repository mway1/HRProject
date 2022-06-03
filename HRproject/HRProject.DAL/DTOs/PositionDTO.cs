namespace HRProject.DAL.DTOs
{
    public class PositionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public LevelOfPositionDTO PositionLevel { get; set; }
    }
}
