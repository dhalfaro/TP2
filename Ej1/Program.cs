using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            String figuraElegida;
            double area = 0;
            double perimetro = 0;
            Figuras.Triangulo triangulo;
            Figuras.Circulo circulo;
            while (true) {
                figuraElegida = Fachadas.Interfaz.SeleccionarFigura();
                switch (figuraElegida)
                {
                    case "triangulo":
                        triangulo = Fachadas.Interfaz.PedirTriangulo();
                        area = triangulo.Area;
                        perimetro = triangulo.Perimetro;
                        break;
                    case "circulo":
                        circulo = Fachadas.Interfaz.PedirCirculo();
                        area = circulo.Area;
                        perimetro = circulo.Perimetro;
                        break;
                }
                Console.WriteLine("La figura elegida es un {0}. Su area es {1} y su perimetro {2}.", figuraElegida, area, perimetro);
            }
        }
    }
}
