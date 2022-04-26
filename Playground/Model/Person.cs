using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    internal class Person
    {
        public Person(string _firstname,string _lastname)
        {
            FirstName = _firstname;
            LastName = _lastname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {

            return $"{FirstName} {LastName}";
        }
    }
}
