using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandbox
{
    internal class FiguresPool : IPrintable, IDrawable
    {
        private List<Figure> figures;

        public FiguresPool()
        {
            figures = new List<Figure>();
        }
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

        public double getTotalP()
        {
            double sum = 0;
            foreach (Figure figure in figures)
                sum += figure.P();
            return sum;
        }
        public double getTotalS()
        {
            double sum = 0;
            foreach (Figure figure in figures)
                sum += figure.S();
            return sum;
        }
        public void Draw()
        {
            foreach (var figure in figures)
            {
                if (figure is IDrawable) // Если фигура реализует интерфейс
                {
                    ((IDrawable)figure).Draw();
                }
                else
                {
                    Console.WriteLine("Figure dosen't implimentation this interfase ");
                }
            }
        }
        public void Print()
        {
            foreach(var figure in figures)
            {
                if(figure is IPrintable) // Если фигура реализует интерфейс
                {
                    ((IPrintable)figure).Print();
                }else
                {
                    Console.WriteLine("Figure dosen't implimentation this interfase ");
                }
            }
        }
        public override string ToString()
        {
            string res = "FIGURES POOL: \n";
            foreach (Figure figure in figures)
                res += figure.ToString() + "\n";
            res += "_______________________\n";
            return res;
        }
    }
}
