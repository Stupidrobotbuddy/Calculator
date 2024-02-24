namespace CalculatorOperations
{
    public class AdditionStrategy : IOperation
    {
        public float execute(float x, float y)
        {
            return x + y;
        }
    }
}
