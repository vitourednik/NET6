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
            //Console.WriteLine($"Obsah je: {Math.Abs(x * y)}");
            return Math.Abs(x * y);
        }
        public Kvadrant Kvadrant()
            {
            if (x < 0 && y < 0)
                return Model.Kvadrant.Kvadrant3;
            else if (y < 0 && x > 0)
                return Model.Kvadrant.Kvadrant4;
            else if (x >= 0 && y >= 0)
                return Model.Kvadrant.Kvadrant2;
            else if (y > 0 && x < 0)
                return Model.Kvadrant.Kvadrant1;
            else return Model.Kvadrant.Error;
            }

        public override string ToString()
        {
            return $"Hodnota obj 1 x: {x} a hodnota y: {y}";
        }
    }
}
    
