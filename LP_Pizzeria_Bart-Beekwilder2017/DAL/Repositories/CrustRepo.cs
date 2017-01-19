using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LP_Pizzeria_Bart_Beekwilder2017.DAL.Interfaces;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Repositories
{
    public class CrustRepo
    {
        private ICrust context;

        public CrustRepo(ICrust context)
        {
            this.context = context;
        }

        public void Insert(Crust crust)
        {
            context.Insert(crust);
        }

        public void Delete(Crust crust)
        {
            context.Delete(crust);
        }

        public List<Crust> GetAll()
        {
            return context.GetAll();
        } 
    }
}
