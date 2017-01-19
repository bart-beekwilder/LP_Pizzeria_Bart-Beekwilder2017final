using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Ingredient
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double CostPrice { get; private set; }
        public double SellPrice { get; private set; }
        public bool IsVegetarian { get; private set; }
        public bool IsHalal { get; private set; }
        public Ingredient(int ID, string name, double costPrice, double sellPrice, bool isVegetarian, bool isHalal)
        {
            this.ID = ID;
            Name = name;
            CostPrice = costPrice;
            SellPrice = sellPrice;
            IsVegetarian = isVegetarian;
            IsHalal = isHalal;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
