using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP_Pizzeria_Bart_Beekwilder2017.DAL.Contexts.MSSQL
{
    public class MSSQLConnection
    {
        public static string ConnectionStr { get; private set; } = @"Server=mssql.fhict.local;Database=dbi346087;User Id=dbi346087;Password=Auxilium;";
    }
}
