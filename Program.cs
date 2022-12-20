using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter v");
            double v =double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number");
            for(double number = double.Parse(Console.ReadLine()); number <= v;number++)
            {
                double sum = 0;
                for(double i=1;i<number;i++)
                {
                    if(number % i == 0)
                    {
                        sum += i;
                    }
                }
                if(sum == number)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadKey();
        }
    }
}
