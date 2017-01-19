using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Pizzeria
    {
        public double Profit { get; private set; }
        public double Revenue { get; private set; }
        public List<Order> PreparingOrders { get; private set; } = new List<Order>();
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
        public void ExportOrder(string path)
        {
            if(CurrentOrder != null)
            {
                CurrentOrder.CompleteOrder();
                Revenue += CurrentOrder.FinalSellPrice;
                Profit += CurrentOrder.FinalSellPrice - CurrentOrder.FinalCostPrice;
                double BTW = CurrentOrder.FinalSellPrice - CurrentOrder.CostWOTaxes;

                FileStream file;
                StreamWriter writer;
                try
                {
                    file = new FileStream(path, FileMode.Create,
                                                      FileAccess.Write);
                    writer = new StreamWriter(file);
                    writer.WriteLine("Pizzeria La Crosta Insapore");
                    foreach (Pizza pizza in CurrentOrder.Pizzas)
                    {
                        writer.WriteLine(pizza.ToString() +":\t €"+ Convert.ToString(pizza.GetSellPrice()));
                    }
                    foreach (Byproduct byproduct in CurrentOrder.Byproducts)
                    {
                        writer.WriteLine(byproduct.ToString() + "\t €" + Convert.ToString(byproduct.SellPrice));
                    }
                    writer.WriteLine("");
                    writer.WriteLine("Prijs exclusief BTW: \t €" + Convert.ToString(BTW));
                    writer.WriteLine("BTW bedrag: \t €" + Convert.ToString(CurrentOrder.FinalSellPrice - BTW));
                    writer.WriteLine("Te betalen bedrag: \t €" + Convert.ToString(CurrentOrder.FinalSellPrice));
                    writer.Close();
                    file.Close();
                }
                catch (IOException ex)
                {
                    throw ex;
                }

                PreparingOrders.Add(CurrentOrder);
                CurrentOrder = null;
            }
        }
    }
}
