using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;
using Playground.Data;

namespace WpfApp1
{
    internal static class PeopleDataset
    {
        public static List<Person> People = new List<Person>();
        
        public static void GeneratePeople(int cnt)
        {
            People = new List<Person>();
            for (int i = 0; i < cnt; i++)
            {
                People.Add(RandomPersonGenerator.GetRandomPerson());
            }
        }
    }
}
