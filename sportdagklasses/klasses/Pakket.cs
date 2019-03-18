using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportdagklasses.klasses
{
    class Pakket
    {
        //velden
        int _id = 0;
        string _naam = "";
        List<leerling> _leerlingen = new List<leerling>();

        //properties
        public int propid
        {
            get { return _id; }
        }
        public string propnaam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public List<leerling> propleerling
        {
            get { return _leerlingen; }
            set { _leerlingen = value; }

        }
        //functies en methoden

        //constructors
        public Pakket   (int id, string naam, List<leerling> leerling)
        {
            id = _id;
            naam = _naam;
            leerling = _leerlingen;
        }
    }
}
