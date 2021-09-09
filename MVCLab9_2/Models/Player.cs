using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab9_2.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
    }
}
