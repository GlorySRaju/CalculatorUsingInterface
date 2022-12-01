using System;

namespace CalculatorUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.ADD 2.SUB 3.MUL 4.DIV 5.MOD 6.MATRIX_OPERTIONS 7.EXPONTETIAL 8.LOG_OPERATION\n");

            Console.WriteLine("Enter the Choice");
            int choice = int.Parse(Console.ReadLine());

            
            Calculator calculator = new Calculator();

            Console.Clear();

            switch (choice)
            {
                case 1:
                    calculator.Addition();
                    break;
                case 2:
                    calculator.Substration();
                    break;
                case 3:
                    calculator.Multiplication();
                    break;
                case 4:
                    calculator.Division();
                    break;
                case 5:
                    calculator.ModularDivision();
                    break;
                case 6:
                    calculator.MatrixOperations();
                    break;
                case 7:
                    calculator.Exponential();
                    break;
                case 8:
                    calculator.LogOperations();
                    break;

            }
          }
       }
   }
