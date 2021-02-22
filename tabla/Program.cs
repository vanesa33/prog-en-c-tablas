using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TABLAS_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESUL, T, I;
            string linea;
            Console.Write("CUANTAS TABLAS: "); linea = Console.ReadLine();
            NUM = int.Parse(linea);
            for (T = 1; T <= NUM; T++)
            {
                for (I = 10; I >= 1; I--)
                {
                    RESUL = T * I;
                }
                Console.Write("Pulse una Tecla:"); Console.ReadLine();
            }
        }
    }
}