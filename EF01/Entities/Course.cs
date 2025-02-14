using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    internal class Course  //-> By Convention
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
