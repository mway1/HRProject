namespace HRProject.DAL.DTOs
{
    public class RequestPositionDTO
    {
        public int id { get; set; }
        public string PositionName { get; set; }
        public bool IsDeleted { get; set; }
        public RequestLevelOfPositionDTO? PositionLevel { get; set; }
    }
}
