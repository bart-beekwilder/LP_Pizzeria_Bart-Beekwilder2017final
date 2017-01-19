using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class OrderRepo
    {
        private IOrder context;
        public OrderRepo(IOrder context)
        {
            this.context = context;
        }
        public void Insert(Order order)
        {
            context.Insert(order);
        }
    }
}
