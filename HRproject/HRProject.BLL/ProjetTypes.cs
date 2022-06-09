using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL
{

    public class ProjectTypes
    {
        public const string AllProjects = "All projects";
        public const string FullProjects = "Full projects";
        public const string PartiallyFullProjects = "Partially full projects";

        public static List<string> Types
        {
            get
            {
                return new List<string> { AllProjects, FullProjects, PartiallyFullProjects };
            }
        }
    }
}
