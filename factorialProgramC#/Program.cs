using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i = 1;
            Console.WriteLine("plz enter a number to print factorial :- ");
            num = Convert.ToInt32(Console.ReadLine());
            if(num<0)
            { Console.WriteLine("factorial of negative number " +num+ "doesn't exit, try again"); }
            else
            {
                while (num > 0)
                {
                    i = i * num;
                    Console.Write(num + " * ");
                    num = num - 1;
                }
                    Console.Write("\b\b = {0}", i.ToString ());
            }
            Console.ReadKey();
        }
    }
}
