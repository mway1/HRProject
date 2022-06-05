namespace HRProject.DAL.DTOs
{
    public class LevelOfPositionDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }

        public override string ToString()
        {
            return $"id={id} Name={Name} isDeleted={isDeleted}";
        }
    }
}
