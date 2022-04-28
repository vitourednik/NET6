using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    public class Person
    {
        private string order;
        public Person(string _firstname,string _lastname)
        {
            FirstName = _firstname;
            LastName = _lastname;
        }
        public Person()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; } = new Address();
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {

            return $"{FirstName} {LastName}";
        }
    }
}
