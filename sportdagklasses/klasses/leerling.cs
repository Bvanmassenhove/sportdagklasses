using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportdagklasses
{
    public class leerling
    {
        //velden
        int _id = 0;
        string _naam = "";
        int _idPakket = 0;

        //properties
        public int propid
        {
            get { return _id;}
        }
        public string propnaam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public int propidPakket
        {
            get { return _idPakket;}
            set { _idPakket = value; }

        }
        //functies en methoden

        //constructors
        public leerling (int id, string naam, int idPakket)
        {
            id = _id;
            naam = _naam;
            idPakket = _idPakket;
        }
    }
}
