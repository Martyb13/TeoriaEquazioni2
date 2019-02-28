using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        //Equazione Determinata
        static public bool isDetermined(double a, double b)
        {
            bool t = false;
            if (a != 0)
            {
                t = true;
            }
            return t;
        }
        //Equazione Indeterminata
        static public bool isIndetermined(double a, double b)
        {
            bool t = false;
            if (a == 0&& b==0)
            {
                t = true;
            }
            return t;
        }
        //Equazione Impossibile
        static public bool isInconsisted(double a, double b)
        {
            bool t = false;
            if (a == 0 && b != 0)
            {
                t = true;
            }
            return t;
        }
    }
}
