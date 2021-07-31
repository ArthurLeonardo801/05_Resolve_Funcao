using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2) dado a seguinte expressão:
            x + y + d + 5 * 77 + 8 -10 *( 8/3)
            Qual é o resultado da operação feita em algorírimo*/ 

            Console.WriteLine("Informe o valor de X e Y e D: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            double resultado = x + y + d + 5 * 77 + 8 - (10 * (8 / 3));
            Console.WriteLine("O resultado é: " + resultado);



        }
    }
}
