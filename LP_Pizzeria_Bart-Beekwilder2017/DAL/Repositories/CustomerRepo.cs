using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class CustomerRepo
    {
        private ICustomer context;
        public CustomerRepo(ICustomer context)
        {
            this.context = context;
        }
        Customer GetByID(int ID)
        {
            return context.GetByID(ID);
        }
        void Insert(Customer customer)
        {
            context.Insert(customer);
        }
    }
}
