using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class PizzaRepo
    {
        private IPizza context;

        public PizzaRepo(IPizza context)
        {
            this.context = context;
        }
        public void Delete(Pizza pizza)
        {
            context.Delete(pizza);
        }
        public Pizza GetByID(int ID)
        {
            return context.GetByID(ID);
        }
        public List<Pizza> GetAll(bool isStandard)
        {
            return context.GetAll(isStandard);
        }
        public List<Pizza> GetAll()
        {
            return context.GetAll();
        }
        public void Insert(Pizza pizza)
        {
            context.Insert(pizza);
        }
    }
}
