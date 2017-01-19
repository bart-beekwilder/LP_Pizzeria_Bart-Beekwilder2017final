using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Customer
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Residence { get; private set; }
        public string Street { get; private set; }
        public int Housenumber { get; private set; }
        public Customer(int ID, string name, string residence, int housenumber)
        {
            this.ID = ID;
            Name = name;
            Residence = residence;
            Housenumber = housenumber;
        }
    }
}
