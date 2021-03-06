namespace HRProject.DAL.DTOs
{
    public class DepartmentDTO
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isDeleted { get; set; }

        public override string ToString()
        {
            return $"id={id} Name={Name} Description={Description} IsDeleted={isDeleted}";
        }
    }

}
