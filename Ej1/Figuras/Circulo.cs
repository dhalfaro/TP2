using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Figuras
{
    class Circulo
    {
        private Punto iCentro;
        private double iRadio;
        public Circulo(Punto pCentro, double pRadio)
        {
            Centro = pCentro;
            Radio = pRadio;
        }
        public Punto Centro
        {
            set { iCentro = value; }
            get { return iCentro; }
        }
        public double Radio
        {
            set { iRadio = value; }
            get { return iRadio; }
        }
        public double Area
        {
            get { return 4; }
        }
        public double Perimetro
        {
            get { return 4; }
        }
    }
}
