using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces
{
    public interface ICustomer
    {
        Customer GetByID(int ID);
        void Insert(Customer customer);
    }
}
