﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground.Model;

namespace Playground.Data
{
    public static class RandomPersonGenerator
    {
        public static Person GetRandomPerson()
        {
            List<Person> data = new List<Person>();
            var maleFirstNames = new[] { "Pavel", "Petr", "Adam", "Jakub", "Tomáš", "Viktor", "Martin", "Jan" };
            var maleLastNames = new[] { "Novák", "Krátký", "Klíč", "Novotný", "Vyskočil", "Kolomazník", "Janů" };
            var femaleFirstNames = new[] { "Pavla", "Petra", "Jana", "Jitka", "Tereza", "Anna", "Martina" };
            var femaleLastNames = new[] { "Nováková", "Stará", "Fialová", "Novotná", "Vyskočilová", "Kolomazníková", "Janů" };
            var streets = new[] { "Prušánecká", "Bzenecká", "Lipová", "Dubová", "Jasanová", "Pod Kaštany", "Olšová", "Dlouhá", "Kaštanová", "Třešňová", "Višňová", "Jedlého", "Horníkova", "Slavíkova", "Modřínová" };
            var cities = new[] { "Praha", "Brno", "Olomouc", "Ostrava", "Drážďany" };
            var years = new[] { 2000, 1998, 1995, 1991, 1980, 1981, 1982, 1983, 1984, 1985, 1972, 1976, 1991, 1990, 1995, 1999, 1961, 1958 };
            var months = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var days = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 20, 21, 22, 26, 27 };
            var rnd = new Random();

            var person = new Person()
            {
                Address = new Address() { City = cities.OrderBy(x => rnd.Next()).First(), Street = streets.OrderBy(x => rnd.Next()).First() },
                DateOfBirth = new DateTime(years.OrderBy(x => rnd.Next()).First(), months.OrderBy(x => rnd.Next()).First(), days.OrderBy(x => rnd.Next()).First()),
                FirstName = maleFirstNames.OrderBy(x => rnd.Next()).First(),
                LastName = maleLastNames.OrderBy(x => rnd.Next()).First(),
            };

            var person2 = new Person()
            {
                Address = new Address() { City = cities.OrderBy(x => rnd.Next()).First(), Street = streets.OrderBy(x => rnd.Next()).First() },
                DateOfBirth = new DateTime(years.OrderBy(x => rnd.Next()).First(), months.OrderBy(x => rnd.Next()).First(), days.OrderBy(x => rnd.Next()).First()),
                FirstName = femaleFirstNames.OrderBy(x => rnd.Next()).First(),
                LastName = femaleLastNames.OrderBy(x => rnd.Next()).First(),
            };

            if (rnd.Next(0, 2) == 1)
                return person;
            else
                return person2;
        }
    }
}
