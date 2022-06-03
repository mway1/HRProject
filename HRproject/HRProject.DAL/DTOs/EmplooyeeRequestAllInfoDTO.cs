namespace HRProject.DAL.DTOs
{
    public class EmplooyeeRequestAllInfoDTO
    {
        public int id { get; set; }
        public int? Quantity { get; set; }
        public ProjectDTO Project { get; set; }
        public List<PositionDTO> Positions { get; set; }
        public List<SkillDTO> Skills { get; set; }
    }
}
