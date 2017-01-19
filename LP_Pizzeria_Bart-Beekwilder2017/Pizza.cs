using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public class Pizza
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public bool IsStandard { get; private set; }
        public Shape Shape { get; private set; }
        public double SurfaceArea { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public Crust Crust { get; private set; }
        public Pizza(string name, bool isStandard, int diameter, List<Ingredient> ingredients, Crust crust)
        {
            Name = name;
            IsStandard = isStandard;
            SurfaceArea = 0.25 * Math.PI * Math.Pow(diameter, 2);
            Shape = Shape.Circle;
            Ingredients = ingredients;
            Crust = crust;
        }
        public Pizza(string name, bool isStandard, int width, int height, List<Ingredient> ingredients, Crust crust)
        {
            Name = name;
            IsStandard = isStandard;
            SurfaceArea = width * height;
            Shape = Shape.Rectangle;
            Ingredients = ingredients;
            Crust = crust;
        }
        public Pizza(string name, bool isStandard, int a, int b, int c, List<Ingredient> ingredients, Crust crust)
        {
            Name = name;
            IsStandard = isStandard;
            double x = (a + b + c)/2.00;
            SurfaceArea = Math.Sqrt(x * (x - a) * (x - b) * (x - c));
            Shape = Shape.Triangle;
            Ingredients = ingredients;
            Crust = crust;
        }
        public Pizza(int ID, string name, int surfaceArea, Shape shape, List<int> ingredientIDs, int crustID)
        {
            this.ID = ID;
            Name = name;
            SurfaceArea = surfaceArea;
            Shape = shape;
        }
        public double GetCostPrice()
        {
            double costPrice = SurfaceArea * Crust.CostPrice;
            foreach(Ingredient ingredient in Ingredients)
            {
                costPrice += SurfaceArea * ingredient.CostPrice;
            }
            return costPrice;
        }
        public double GetSellPrice()
        {
            //Om de verkoopprijs te berekenen
            double sellPrice = SurfaceArea * Crust.SellPrice;
            foreach (Ingredient ingredient in Ingredients)
            {
                if(IsStandard)
                {
                    sellPrice += 0.75*(SurfaceArea * ingredient.SellPrice);
                }
                else
                {
                    sellPrice += SurfaceArea * ingredient.SellPrice;
                }
            }
            return sellPrice;
        }
    }
}
