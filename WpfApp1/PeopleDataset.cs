using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;
using Playground.Data;
using System.Net.Http;
using System.Net.Http.Json;

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

        public static async Task LoadPeopleFromAPI(int cnt)
        {
            HttpClient httpClient = new HttpClient();

            var result = await httpClient.GetAsync(PeopleAPIURL + "/people/" + cnt.ToString());
        
        if(result.IsSuccessStatusCode)
            {
                People = await result.Content.ReadFromJsonAsync<List<Person>>();
            }
        }

    }
}
