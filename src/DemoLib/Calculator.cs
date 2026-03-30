namespace DemoLib;

public static class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;

    // BUG: divides instead of multiplying
    public static int Multiply(int a, int b) => a / (b == 0 ? 1 : b);

    public static double Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
        return (double)a / b;
    }

    public static double Average(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return numbers.Sum() / (double)numbers.Length;
    }
}
