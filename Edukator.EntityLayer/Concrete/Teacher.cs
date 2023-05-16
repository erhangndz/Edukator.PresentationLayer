using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Twitter  { get; set; }
        public string Linkedin  { get; set; }
    }
}
