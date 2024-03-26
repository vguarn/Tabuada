using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a tabuada que você quer saber: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Até qual número você quer ver?");
            int vez = int.Parse(Console.ReadLine());

            int cont = 0;

            while (cont != vez)
            {
                int resultado = num * cont;
                Console.WriteLine(num + " x " + cont + " = " + resultado);
                cont ++;
            }
             Console.ReadKey();
            
        }
    }
}
