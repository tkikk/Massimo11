using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaLibrary
{
    public static class Calcolatrice
    {
        public static double Minimo(double a, double b)
        {
            double risultato = 0;
            if (a <= b)
            {
                risultato = a;
            }
            else
            {
                risultato = b;
            }
            return risultato;
        }
        public static double Massimo(double a, double b)
        {
            double risultato = 0;
            if (a >= b)
            {
                risultato = a;
            }
            else
            {
                risultato = b;
            }
            return risultato;
        }
        public static double Media(double a, double b)
        {
            double risultato = 0;
            risultato = (a + b) / 2;
            return risultato;
        }




        public static double Mediatre(double a, double b, double c)
        {
            double risultato = 0;
            risultato = (a + b + c) / 3;
            return risultato;
        }
        public static double Massimotre(double a, double b, double c)
        {
            double risultato = 0;
            if (a >= b && a >= c)
            {
                risultato = a;
            }
            if (c >= a && c >= b)
            {
                risultato = c;
            }
            if (b >= c && b >= a)
            {
                risultato = b;
            }
            return risultato;

        }
        public static double Minimotre(double a, double b, double c)
        {
            double risultato = 0;
            if (a <= b && a <= c)
            {
                risultato = a;
            }
            if (c <= a && c <= b)
            {
                risultato = c;
            }
            if (b <= c && b <= a)
            {
                risultato = b;
            }
            return risultato;
        }
    }
}
