using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Punto
    {
        private double iX;
        private double iY;
        public Punto(double pX, double pY)
        {
            X = pX;
            Y = pY;
        }
        public double X
        {
            get { return iX; }
            set { iX = value; }
        }
        public double Y
        {
            get { return iY; }
            set { iY = value; }
        }
        static public double CalcularDistanciaEntre(Punto pPuntoA, Punto pPuntoB)
        {
            return Math.Sqrt(Math.Pow(pPuntoA.X - pPuntoB.X,2) + Math.Pow(pPuntoA.Y - pPuntoB.Y, 2));
        }
    }
}
