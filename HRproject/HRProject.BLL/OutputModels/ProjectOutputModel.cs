

namespace HRProject.BLL.Models
{
    public class ProjectOutputModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFull { get; set; }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
