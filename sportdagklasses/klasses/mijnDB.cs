using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace sportdagklasses.klasses
{
    class mijnDB
    {
        //velden
        static string _connectiePad = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\databanken\Access databanken\sportdag.accdb";
        OdbcConnection _conn = new OdbcConnection(_connectiePad);
        //properties

        //functies en methoden
        List<leerling> vraag
        //constructors
        public mijnDB()
        { }
    }
}
