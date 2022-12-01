using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUsingInterface
{
    class Calculator : IBasicCalculator, IScientificCalculaor
        
    {
        private double firstNumber;
        private double secondNumber;
        private double result;
        public Calculator()
        {
            Console.WriteLine("Enter the First Number");
            firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            secondNumber = double.Parse(Console.ReadLine());


        }
        public void Addition()
        {
            result = firstNumber + secondNumber;
            Console.WriteLine("Sum is " + result);
        }

        public void Division()
        {
            result = firstNumber / secondNumber;
            Console.WriteLine("Div is " + result);
        }

        public void Exponential()
        {
            Console.WriteLine("Exponential");
        }

        public void LogOperations()
        {
            Console.WriteLine("Logoperations");
        }

        public void MatrixOperations()
        {
            Console.WriteLine("MatrixOperations");
        }

        public void ModularDivision()
        {
            result = firstNumber % secondNumber;
            Console.WriteLine("Mod is " + result);
        }

        public void Multiplication()
        {
            result = firstNumber * secondNumber;
            Console.WriteLine("Mul is " + result);
        }

        public void Substration()
        {
            result = firstNumber - secondNumber;
            Console.WriteLine("Sub is " + result);
        }
    }
}
