using System;

namespace A133590.Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 13");
            Console.WriteLine("Dadas dos frases, determina si tienen la misma longitud.");
            Console.Write("Ingrese una frase: ");
            string unaFrase = Console.ReadLine();
            Console.Write("Ingrese otra frase: ");
            string otraFrase = Console.ReadLine();

            if (unaFrase.Length == otraFrase.Length)
            {
                Console.WriteLine("Las frases tienen la misma longitud.");
            }
            else
            {
                Console.WriteLine("Las frases tienen longitudes distintas.");
            }


            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
