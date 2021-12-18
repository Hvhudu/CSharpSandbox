using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    class Rectangle : Figure, IPrintable, IDrawable
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle()
        {
            A = B = 0;
        }
        public Rectangle(string name, double a, double b) : base(name)
        {
            A = a;
            B = b;
        }
        public override double P()
        {
            return A * 2 + B * 2;
        }
        public override double S()
        {
            return A * B;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
        public void Draw()
        {
            for(int i = 0; i < B; i++)
            {
                for (int j = 0; j < A; j++)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }
        public override string ToString()
        {
            return $"rec {Name}: A = {A}, B = {B}";
        }
    }
}
