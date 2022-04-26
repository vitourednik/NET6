using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Data
{
    internal class OvereniSPZ
    {
        //public static string[] UkradenaAuta = { "ABC", "123", "1234", "12345", "ABCD", "ABCDE", "QQQQQ" };
        public static List<string> UkradenaAuta = new List<string> ();
        private static bool NactenySoubor = false;
        public const string CestaSouboru = @"C:\Users\Administrator\source\repos\vitourednik\NET6\Playground\SPZ\spz1.txt";
        public static bool LzeNacitat = true;
        public static bool OverSPZ(string spz)
        {
            if (!NactenySoubor)
            {
                NactiKradenaAuta(CestaSouboru);
            }
                foreach (string ukradena_spz in UkradenaAuta)
                {
                    if (spz == ukradena_spz)
                        return true;
                }
                return false;
        }

        public static void NactiKradenaAuta(string file)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(file);
            } catch (Exception ex) 
            { NactenySoubor = false; 
                LzeNacitat = false;
                Console.WriteLine(ex.Message);
                return; 
            }

            foreach (string line in lines)
            {
                UkradenaAuta.Add(line);
            }
            NactenySoubor = true;
        }
    }
}
