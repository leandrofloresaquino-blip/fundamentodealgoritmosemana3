using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA3YORDAN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer3();
            Console.ReadKey(); //detenimiento de consola
        }
        
        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingresa su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingresa su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al curso de fundamentos de algoritmos de la {carrera}");
        }

        static void ejer2()
       
        {
            Console.WriteLine("\"Leandro\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese número 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese número 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double divi = (double)num1 / (double)num2;

            Console.WriteLine("Suma: "+(num1 + num2));
            Console.WriteLine("Resta: " + (num1 - num2));
            Console.WriteLine("Multiplicación: " + (num1 * num2));
            Console.WriteLine("División: " + divi);
        }

        static void ejer4()
            
        {

        }

        static void ejer5()
        {

        }

        static void ejer6()
        {

        }
    }
}
