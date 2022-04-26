using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Model
{
    internal class Car
    {
        public Car(string _spz,string _barva, double _najetekm,string _znacka)
        {
            SPZ = _spz;
            Barva = _barva;
            NajeteKm = _najetekm;
            Znacka = _znacka;
        }
        public Car()
        {

        }

        public string SPZ { get; set; }

        public string Barva { get; set; }

        public double NajeteKm { get; set; }

        public string Znacka { get; set; }

    }
}
