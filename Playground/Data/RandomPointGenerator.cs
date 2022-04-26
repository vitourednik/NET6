using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Data
{
    internal class RandomPointGenerator
    {
        private static int Counter;

        public static int GetCount()
        {
            return Counter;
        }
        public static Dimension GetRandomPoint()
        {
            Counter++;
            Random random = new Random();
            double x = random.Next(int.MinValue,int.MaxValue);
            double y = random.Next(int.MinValue,int.MaxValue);
            Dimension result = new Dimension(x,y);
            return result;
        }
    }
}
