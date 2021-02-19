using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            Console.WriteLine("Hello World!");
            List<int> numbers = new List<int> { 1, 3, 5, 7, 11 };
            int indexnb;
            Console.WriteLine($"la somme de {numbers[0]}+{numbers[1]}+{numbers[2]}+{numbers[3]}+{numbers[4]}");
            for (indexnb = 0; indexnb < numbers.Count; indexnb++)
                
            {
                result += numbers[indexnb];
                
               
            }
            Console.WriteLine($"est {result}");
        }
    }
}
