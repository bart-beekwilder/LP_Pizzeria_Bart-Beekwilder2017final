using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces
{
    public interface IIngredient
    {
        void Insert(Ingredient ingredient);
        void Delete(Ingredient ingredient);
        List<Ingredient> GetAll();
        List<Ingredient> GetAllForPizza(int ID);
    }
}
