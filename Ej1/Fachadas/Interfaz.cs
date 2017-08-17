using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Fachadas
{
    class Interfaz
    {
        static private bool EsFiguraValida(String pNombreFigura)
        {
            return (pNombreFigura == "triangulo" || pNombreFigura == "circulo" || pNombreFigura == "punto");
        }
        static public String SeleccionarFigura ()
        {
            String figura;
            do {
                Console.Write("Elegir una figura (triangulo|circulo|punto): ");
                figura = Console.ReadLine();
            } while (!EsFiguraValida(figura));
            return figura;
        }
        static public Figuras.Punto PedirPunto()
        {
            double x;
            double y;
            do
            {
                Console.Write("Ingresar componente en X del punto: ");
            } while (!double.TryParse(Console.ReadLine(), out x));
            do
            {
                Console.Write("Ingresar componente en Y del punto: ");
            } while (!double.TryParse(Console.ReadLine(), out y));
            return new Figuras.Punto(x, y);
        }
        static public Figuras.Circulo PedirCirculo()
        {
            Figuras.Punto centro;
            double radio;
            Console.WriteLine("Ingresar datos del punto central del circulo: ");
            centro = PedirPunto();
            do
            {
                Console.Write("Ingresar radio del punto: ");
            } while (!double.TryParse(Console.ReadLine(), out radio));
            return new Figuras.Circulo(centro, radio);
        }
        static public Figuras.Triangulo PedirTriangulo()
        {
            Figuras.Punto punto1;
            Figuras.Punto punto2;
            Figuras.Punto punto3;
            Console.WriteLine("Ingresar datos del punto 1: ");
            punto1 = PedirPunto();
            Console.WriteLine("Ingresar datos del punto 2: ");
            punto2 = PedirPunto();
            Console.WriteLine("Ingresar datos del punto 3: ");
            punto3 = PedirPunto();
            return new Figuras.Triangulo(punto1, punto2, punto3);
        }
    }
}
