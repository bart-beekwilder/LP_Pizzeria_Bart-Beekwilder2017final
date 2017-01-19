using Microsoft.VisualStudio.TestTools.UnitTesting;
using LP_Pizzeria_Bart_Beekwilder2017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.Tests
{
    [TestClass()]
    public class PizzaTests
    {
        private Pizza GetPizza()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient(1, "Jalapeño pepers", 1, 2, true, true));
            ingredients.Add(new Ingredient(2, "Tabasco saus", 1.5, 2.5, true, true));
            Crust crust = new Crust(1, "Volkoren deeg", 1, 1.5);
            return new Pizza("Pittige pizza", false, 20, 40, ingredients, crust);
        }
        [TestMethod()]
        public void PizzaRectangleSurfaceAreaTest()
        {
            Pizza pizza = GetPizza();
            Assert.AreEqual(800, pizza.SurfaceArea);
        }
        [TestMethod()]
        public void CalcSellPrice()
        {
            Pizza pizza = GetPizza();
            Assert.AreEqual(48, pizza.GetSellPrice()/100);
        }

    }
}