using System;

namespace Ejercicio1_recursivo
{

    internal class Program
    {
        static public int Fibonacci(int termino)
        {
            if (termino <= 1)
                return termino;
            return Fibonacci(termino-1) + Fibonacci(termino - 2);
        }

        static void Main(string[] args)
        {
            int valor = 0;

            Console.WriteLine("Ingrese hasta donde quiere generar la serie de Fibonacci");
            int cantidadTerminos = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidadTerminos; n++)
            {
                valor=Fibonacci(n);
                Console.WriteLine(valor);
            }

            Console.WriteLine();
        }
    }
}
