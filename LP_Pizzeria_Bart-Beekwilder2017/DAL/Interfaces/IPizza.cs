using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces
{
    public interface IPizza
    {
        void Delete(Pizza pizza);
        Pizza GetByID(int ID);
        List<Pizza> GetAll(bool isStandard);
        List<Pizza> GetAll();
        void Insert(Pizza pizza);
    }
}
