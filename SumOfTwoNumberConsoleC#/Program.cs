using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            Console.WriteLine("Plz enter two number for addition :- ");
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToInt32(Console.ReadLine());
            k = i + j;

            Console.WriteLine("Sum of " + i + " and " + j + " = " + k);
            Console.ReadKey();

        }
    }
}
