using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfСompany
{
   public class Collaborator
    {
        public int Id { get; set; }
        public string Serame { get; set; }
        public string Name { get; set; }
        public long Salary { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
