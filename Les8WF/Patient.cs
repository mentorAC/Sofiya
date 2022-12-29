using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les8WF
{
    internal class Patient
    {
        public string Name { get; set; }
        public string Diagnoz { get; set; }
        public int Age { get=> DateTime.Now.Year - Year; }
        public int Year { get; set; }

    }
}
