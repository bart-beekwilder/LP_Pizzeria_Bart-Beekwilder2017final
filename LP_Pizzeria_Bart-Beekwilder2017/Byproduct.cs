using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Byproduct : IProduct
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double CostPrice { get; private set; }
        public double SellPrice { get; private set; }
        public int TaxPercentage { get; private set; }
        public Byproduct(int ID, string name, double costPrice, double sellPrice, int taxPercentage)
        {
            this.ID = ID;
            Name = name;
            CostPrice = costPrice;
            SellPrice = sellPrice;
            TaxPercentage = taxPercentage;
        }
    }
}
