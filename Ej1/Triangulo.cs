using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Triangulo
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            Punto1 = pPunto1;
            Punto2 = pPunto2;
            Punto3 = pPunto3;
        }
        public Punto Punto1
        {
            set { iPunto1 = value; }
            get { return iPunto1; }
        }
        public Punto Punto2
        {
            set { iPunto2 = value; }
            get { return iPunto2; }
        }
        public Punto Punto3
        {
            set { iPunto3 = value; }
            get { return iPunto3; }
        }
        public double Area
        {
            get
            {
                double ladoA = Punto.CalcularDistanciaEntre(Punto1, Punto2);
                double ladoB = Punto.CalcularDistanciaEntre(Punto1, Punto3);
                double ladoC = Punto.CalcularDistanciaEntre(Punto2, Punto3);
                double semiPerimetro = Perimetro / 2;
                // Se utiliza la fórmula de Herón de Alejandría para
                // calcular el área del triángulo.
                return Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
            }
        }
        public double Perimetro
        {
            get
            {
                double ladoA = Punto.CalcularDistanciaEntre(Punto1, Punto2);
                double ladoB = Punto.CalcularDistanciaEntre(Punto1, Punto3);
                double ladoC = Punto.CalcularDistanciaEntre(Punto2, Punto3);
                return ladoA + ladoB + ladoC;
            }
        }
    }
}
