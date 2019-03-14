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
        static public bool isDetermined(double a)
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
        //Equazione di secondo grado
        static public bool isDegree2(double a, double b, double c)
        {
            bool t = false;
            if (a !=0)
            {
                t = true;
            }
            return t;
        }
        //Delta di un'equazione di secondo grado
        static public double Delta(double a, double b, double c)
        {
            double delta = 0;
            delta = (b * b)- 4 * a * c;
            return delta;
        }
        //Soluzione equazione di primo grado
        static public string EquationDegree1(double a, double b)
        {
            string risposta = "";
            if(isIndetermined(a,b))
            {
                risposta = "L'equazione è indeterminata";
            }
            else if(isInconsisted(a,b))
            {
                risposta = "L'equazione è impossibile";
            }
            else if(isDetermined(a))
            {
                risposta = Convert.ToString(-b / a);
            }

            return risposta;
        }
    }
}
