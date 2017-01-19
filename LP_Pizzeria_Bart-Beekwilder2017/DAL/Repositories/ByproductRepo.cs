using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class ByproductRepo
    {
        private IByproduct context;

        public ByproductRepo(IByproduct context)
        {
            this.context = context;
        }
        void Delete(Byproduct byproduct)
        {
            context.Delete(byproduct);
        }
        List<Byproduct> GetAll()
        {
            return context.GetAll();
        }
        void Insert(Byproduct byproduct)
        {
            context.Insert(byproduct);
        }
    }
}
