using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Data
{
    internal class PorovnaniObsahu
    {
        public static string Porovnani()
        {
            Dimension dim1 = RandomPointGenerator.GetRandomPoint();
            Dimension dim2 = RandomPointGenerator.GetRandomPoint();
            dim1.Obsah();
            Console.WriteLine($"Obsah 1: {dim1.Obsah()}");
            dim2.Obsah();
            Console.WriteLine($"Obsah 2: {dim2.Obsah()}");
            if (dim1.Obsah() > dim2.Obsah())
                return "Obsah 1 je větší než 2";
            else return "Obsah 2 je větší než 1"; 
        }
    }
}
