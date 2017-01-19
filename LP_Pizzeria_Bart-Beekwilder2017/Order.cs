using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Order
    {
        public int ID { get; private set; }
        public int TotalTimeToPrepare { get; private set; }
        public double CostWOTaxes { get; private set; }
        public double FinalSellPrice { get; private set; }
        public double FinalCostPrice { get; private set; }
        public Customer Customer { get; private set; }
        public List<Pizza> Pizzas { get; private set; }
        public List<Byproduct> Byproducts { get; private set; }
        public Order(int ID)
        {
            this.ID = ID;
            Pizzas = new List<Pizza>();
            Byproducts = new List<Byproduct>();
        }
        public Order(int ID, Customer customer)
        {
            this.ID = ID;
            Pizzas = new List<Pizza>();
            Byproducts = new List<Byproduct>();
        }
        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
        }
        public void AddByproduct(Byproduct byproduct)
        {
            Byproducts.Add(byproduct);
        }
        public void CompleteOrder()
        {
            TotalTimeToPrepare = 0;
            int TotalSurfaceArea = 0;
            CostWOTaxes = 0;
            FinalSellPrice = 0;
            FinalCostPrice = 0;
            foreach(Pizza pizza in Pizzas)
            {
                FinalCostPrice += pizza.GetCostPrice();
                FinalSellPrice += pizza.GetSellPrice();
                CostWOTaxes += pizza.GetSellPrice() / 106 * 100;
                TotalSurfaceArea += (int)pizza.SurfaceArea;
            }
            TotalTimeToPrepare = TotalSurfaceArea / 2500 * 10;
            foreach(Byproduct byproduct in Byproducts)
            {
                FinalCostPrice += byproduct.CostPrice;
                FinalSellPrice += byproduct.SellPrice;
                CostWOTaxes += byproduct.SellPrice / (100 + byproduct.TaxPercentage) * 100;
            }
            CostWOTaxes = CostWOTaxes / 100;
            FinalSellPrice = FinalSellPrice / 100;
            FinalCostPrice = FinalCostPrice / 100;
        }
    }
}
