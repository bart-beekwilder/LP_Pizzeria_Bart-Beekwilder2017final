using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Pizzeria
    {
        public double Profit { get; private set; }
        public double Revenue { get; private set; }
        public List<Order> PreparingOrders { get; private set; }
        public Order CurrentOrder { get; private set; }
        
        public void NewStandardPizza(Pizza pizza)
        {

        }
        public void NewIngredient(Ingredient ingredient)
        {

        }
        public void NewCrust(Crust crust)
        {

        }
        public void NewByproduct(Byproduct byproduct)
        {

        }
        public void NewOrder(Order order)
        {
            if (CurrentOrder == null)
            {
                CurrentOrder = order;
            }
        }
        public void ExportOrder()
        {
            if(CurrentOrder != null)
            {
                CurrentOrder.CompleteOrder();
                Revenue += CurrentOrder.FinalSellPrice;
                Profit += CurrentOrder.FinalSellPrice - CurrentOrder.FinalCostPrice;
                double BTW = CurrentOrder.FinalSellPrice - CurrentOrder.CostWOTaxes;


                CurrentOrder = null;
            }
        }
    }
}
