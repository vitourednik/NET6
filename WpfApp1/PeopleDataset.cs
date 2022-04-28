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
        public static string PeopleAPIURL = "https://localhost:7193";

        public static void GeneratePeople(int cnt)
        {
            RandomPersonGenerator.GetPeople(cnt);
        }

        public static void LoadPeopleFromAPI(int cnt)
        {

        }

    }
}
