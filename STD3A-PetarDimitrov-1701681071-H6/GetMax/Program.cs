using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest number is:{0}", Max(firstNumber, secondNumber, thirdNumber));
        }
        public static int Max(int firstNumber, int secondNumber, int thirdNumber)
        {
            int max = firstNumber < secondNumber ? (secondNumber < thirdNumber ? thirdNumber : secondNumber) : (firstNumber < thirdNumber ? thirdNumber : firstNumber);
            return Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));


        }

    }
}
