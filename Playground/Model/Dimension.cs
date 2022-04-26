using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    internal class Dimension
    {
        public Dimension(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public Dimension()
        {

        }
        public double x { get; set; }
        public double y { get; set; }

        public void Print()
        {
            Console.WriteLine($"Hodnota obj 1 x: {x} a hodnota y: {y}");
        }

        public double Obsah()
        {
            Console.WriteLine($"Obsah je: {x*y}");
            return x * y;
        }
    }
}
