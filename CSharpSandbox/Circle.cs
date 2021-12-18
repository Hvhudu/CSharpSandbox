using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    internal class Circle : Figure , IPrintable
    {
        public double R;

        public Circle()
        {
            R = 0;
        }
        public Circle(string name, double r): base(name)
        {
            R = r;
        }
        public override double P()
        {
            return 2 * Math.PI * R;
        }
        public override double S()
        {
            return Math.PI * R * R;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Circle {Name}: R = {R}";
        }
    }
}
