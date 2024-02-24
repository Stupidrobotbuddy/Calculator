using CalculatorOperations;

namespace Calculator
{
    public class CalculatorApp
    {
        private IOperation Strategy;
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

            

            CalculateResult();
            Console.Clear();
        }

        void setStrategy(IOperation Strategy)
        {
            this.Strategy = Strategy;
        }

        void executeStrategy(float x, float y)
        {
           
             float result = Strategy.execute(x, y);
             Console.WriteLine("The resullt is...");
            Console.WriteLine(result + "!");
            Console.ReadKey();
        }

        void CalculateResult()
        {
            switch (State)
            {
                case "A":
                    setStrategy(new AdditionStrategy());
                    break;
                case "B":
                    setStrategy(new SubtractionStrategy());
                    break;
                case "M":
                    setStrategy(new MultiplicationStrategy());
                    break;
                case "D":
                    setStrategy(new DivisionStrategy());
                    break;
                case "E":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    Console.ReadKey();
                    return;
            }


            Console.WriteLine("please input X value");
            string XInput = Console.ReadLine();
            Console.WriteLine("please input Y value");
            string YInput = Console.ReadLine();


            while (!float.TryParse(XInput, out this.x) || !float.TryParse(YInput, out this.y))
            {
                Console.WriteLine("Invalid Input Detected!");
                Console.ReadLine();

                Console.WriteLine("Please input A NUMERICAL X value");
                XInput = Console.ReadLine();
                Console.WriteLine("Please input A NUMERICAL Y value");
                YInput = Console.ReadLine();
            }

            Console.WriteLine();

            executeStrategy(x, y);
            
        }
        
        
    }
}
