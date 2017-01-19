using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017
{
    public interface IProduct
    {
        int ID { get; }
        string Name { get; }
        double CostPrice { get; }
        double SellPrice { get; }
    }
}
