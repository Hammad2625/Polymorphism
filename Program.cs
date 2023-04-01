using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammad_123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            animal A =new animal();
            A.MakeSound();
            Lion lion = new Lion();
            lion.MakeSound();
            Goat goat = new Goat(); 
            goat.MakeSound();
            


            Addition addition = new Addition();
             int result1 =addition.Add(8, 9);
            double result2 = addition.Add(9.1, 10.5);
            Console.WriteLine("Result 1: " + result1);
            Console.WriteLine("Result 2: " + result2);
            Console.ReadLine();
        }
    }
}
