using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FizzBuzz
    {

        int upperBound = 10;


        public FizzBuzz(int upper)
        {
            upperBound = upper;
        }
        public void Dispaly()
        {
            for (int i = 1; i < upperBound; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 ==0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else { 
                    Console.WriteLine("Fizz");
                     }
                }
                else if (i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
