namespace FizzBuzz
{
    public class FizzBuzzConfig
    {
        public FizzBuzzConfig(int divisor, string printString)
        {
            Divisor = divisor;
            PrintString = printString;
        }

        public int Divisor { get; private set; }
        public string PrintString { get; private set; }
    }
}