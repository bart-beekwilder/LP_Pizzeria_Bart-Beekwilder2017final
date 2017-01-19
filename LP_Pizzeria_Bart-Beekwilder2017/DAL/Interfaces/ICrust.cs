using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces
{
    public interface ICrust
    {
        void Insert(Crust crust);
        void Delete(Crust crust);
        List<Crust> GetAll();
        Crust GetByID(int ID);
    }
}
