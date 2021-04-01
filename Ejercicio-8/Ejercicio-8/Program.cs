using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabraBuscada = "FIN";
            string input = "";
            bool contienePalabraBuscada = false;

            do
            {
                Console.WriteLine("Ingrese una frase");
                input = Console.ReadLine().ToUpper();
                contienePalabraBuscada = input.Contains(palabraBuscada);
                if (!contienePalabraBuscada)
                {
                    Console.WriteLine("La frase ingresada no contiene la palabra 'fin'");
                }
            } while (!contienePalabraBuscada);
            Console.WriteLine("El proceso ha finalizado");
            Console.ReadKey();
        }
    }
}
