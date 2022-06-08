namespace HRProject.BLL.OutputModels
{
    public class EmployeeRequestAllInfoModel
    {
        public int Id { get; private set; }
        public int? Quantity { get; private set; }
        public string Project { get; private set; }
        public List<string> Positions { get; private set; }
        public List<string> Skills { get; private set; }

        public void DelleteAllSkills()
        {
            Skills.Clear();
        }

        public void DelleteAllPositions()
        {
            Positions.Clear();  
        }

        public void DeleteProject()
        {
            Project = null;
        }

        public void DeleteSkillById(int id)
        {
            for (int i = 0; i < Skills.Count; i++)
            {
                var skill = Skills[i];

                if (skill.Id == id)
                {
                    Skills.RemoveAt(id);
                }            
            }
        }

        public void DeletePositionById(int id)
        {
            for (int i = 0; i < Positions.Count; i++)
            {
                var position = Positions[i];

                if (position.Id == id)
                {
                    Positions.RemoveAt(id);
                }
            }
        }
    }
}
