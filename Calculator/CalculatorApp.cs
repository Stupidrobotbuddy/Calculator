using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorApp
    {
        private string? State;
        private float x, y;

        public void run()
        {
            Console.WriteLine("Input which operation to use");
            Console.WriteLine("/A - Addition");
            Console.WriteLine("/S - Subtraction");
            Console.WriteLine("/M - Multiplication");
            Console.WriteLine("/D - Division");
            Console.WriteLine("/E - Exit");

            string input = Console.ReadLine();
            State = input.ToUpper();
            
            Console.WriteLine();

            Console.WriteLine("Input X value:");
            x = float.Parse(Console.ReadLine());


            Console.WriteLine("Input Y value:");
            y = float.Parse(Console.ReadLine());

            CalculateResult();
            Console.Clear();
        }

        void CalculateResult()
        {
            float temp = 0;
            switch (State)
            {
                case "A":
                    temp = Addition(x, y);
                    break;
                case "B":
                    temp = Subtraction(x, y);
                    break;
                case "M":
                    temp = Multiplication(x, y);
                    break;
                case "D":
                    temp = Division(x, y);
                    break;
                case "E":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input, please try again");
                    Console.ReadKey();
                    return;
            }


            Console.WriteLine("the answer is..." + temp + "!");
            Console.ReadKey();
        }

        private float Addition(float X, float Y)
        {
            return X + Y;
        }

        private float Subtraction(float X, float Y)
        {
            return X - Y;
        }

        private float Multiplication(float X, float Y)
        {
            return X * Y;
        }

        private float Division(float X, float Y)
        {
            if (Y != 0)
            {
                return X / Y;
            }
            Y = 1;
            return X / Y;
        }
    }
}
