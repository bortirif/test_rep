using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first number: " + num);
             
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second number: "+ num1);

            Console.WriteLine("first number + second number = " + num + num1);

            Console.WriteLine("first number - second number = " + num - num1);

            Console.WriteLine("first number * second number = " + num * num1);

            Console.WriteLine("first number / second number = " + num / num1);



            Console.ReadLine();


        }
    }
}
