using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
     abstract class Figure
    {
        // Base class Figue

        public string Name { get; set; }

        public Figure() { Name = "noname"; }
        public Figure(string name) { Name = name; }

        public abstract double P();
        public abstract double S();
        
        
    }
}
