using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Reference
    {
        public int ReferenceID { get; set; }
        public string NameSurname { get; set; }
        public string Job { get; set; }
        public string Comment { get; set; }
    }
}
