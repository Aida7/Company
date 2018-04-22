using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfСompany
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                var list = context.Companies.ToList();
            }
        }
    }
}
