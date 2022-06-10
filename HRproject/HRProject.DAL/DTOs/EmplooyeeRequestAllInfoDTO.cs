namespace HRProject.DAL.DTOs
{
    public class EmplooyeeRequestAllInfoDTO
    {
        public int Id { get; set; }
        public int? Quantity { get; set; }
        public RequestProjectDTO? Project { get; set; }
        public List<RequestPositionDTO> Positions { get; set; }
        public List<RequestSkillDTO> Skills { get; set; }
    }
}
