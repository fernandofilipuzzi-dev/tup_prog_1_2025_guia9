using System;
namespace Ejercicio1_iterativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1=0;
            int x2=0;

            Console.WriteLine("Ingrese hasta donde quiere generar la serie de Fibonacci");
            int cantidadTerminos= Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidadTerminos; n++)
            {
                #region determina el valor
                switch (n)
                {
                    case 0:
                    case 1: x1 = 0; x2 = n;
                        break;
                    default:
                        int x3 = x2 + x1;
                        x1 = x2;
                        x2 = x3;
                        break;
                }
                #endregion
                Console.WriteLine(x2);
            }

            Console.WriteLine();
        }
    }
}
