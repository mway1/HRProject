using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRProject.BLL
{

    public class ProjectTypes
    {
        public const string ВсеПроекты = "Все проекты";
        public const string ЗаполненныеПроекты = "Заполненные проекты";
        public const string НеЗаполненныеПроекты = "Не заполненные проекты";

        public static List<string> Types
        {
            get
            {
                return new List<string> { ВсеПроекты, ЗаполненныеПроекты, НеЗаполненныеПроекты };
            }
        }
    }
}
