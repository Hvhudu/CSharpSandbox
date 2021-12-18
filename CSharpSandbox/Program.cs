using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    internal class Program
    {
        //1. Base class Shape with abctract metods get area and perimeter
        //. 
      
        static void Main(string[] args)
        {
            //Rectangle figure = new Rectangle("ABCD", 5,6);
            // Console.WriteLine(figure);
            // Console.WriteLine(figure.P());
            //Circle circle = new Circle("OA", 5.1);
            // Console.WriteLine(circle);
            // Console.WriteLine(circle.P());
            IPrintable printable = new Rectangle();
            printable.Print();
            IDrawable drawable = new Rectangle("ABCD", 5, 5);
            drawable.Draw();
            IPrintable print = new Circle("OA",5);
            print.Print();
            //FiguresPool pool = new FiguresPool();
            //Console.WriteLine(pool);
            //pool.AddFigure(new Rectangle("ABCD", 1, 2));
            //pool.AddFigure(new Circle("OA", 1/Math.PI));
            //Console.WriteLine(pool);

            //Console.WriteLine($"Common P = {pool.getTotalP()}");
        }
    }
}
