
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Runtime.ConstrainedExecution;
using System.Reflection.Emit;
using System.Data;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            string symbol = "";

           Console.WriteLine("Welcome to the General Arithmetic Calculator");
           Console.WriteLine();

           Console.Write("Enter first number:");
           firstNumber = int.Parse(Console.ReadLine());

           Console.Write("Enter n operation symbol:");
           symbol=Console.ReadLine();

           Console.Write("Enter second number:");
           secondNumber= int.Parse(Console.ReadLine());

           if(symbol =="+")
           {
               result= firstNumber + secondNumber;
           }
           else if(symbol =="-")
           {
               result= firstNumber - secondNumber;
           }
           else if(symbol =="*")
           {
               result= firstNumber * secondNumber;
           }
           else if(symbol =="/")
           {
               result= firstNumber / secondNumber;
           }

         Console.WriteLine("The result is:" + result);
        }
    }
}
