using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class IngredientRepo
    {
        private IIngredient context;
        public IngredientRepo(IIngredient context)
        {
            this.context = context;
        }
        public void Insert(Ingredient ingredient)
        {
            context.Insert(ingredient);
        }
        public void Delete(Ingredient ingredient)
        {
            context.Delete(ingredient);
        }
        public List<Ingredient> GetAll()
        {
            return context.GetAll();
        }
        public List<Ingredient> GetAllForPizza(int ID)
        {
            return context.GetAllForPizza(ID);
        }
    }
}
