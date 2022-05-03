namespace ClassLibrary1;

public class Calculator
{
    public int Echo(int value)
    {
        if (value < 0)
        {
            return Multiply(value, -1);
        }
        
        return value;
    }
    
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        return a / b;
    }

    public int Power(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }

    public int Factorial(int a)
    {
        var result = 1;
        for (var i = 1; i <= a; i++)
        {
            result *= i;
        }
        return result;
    }

    public int Fibonacci(int a)
    {
        var result = 0;
        var prev = 0;
        var current = 1;
        for (var i = 0; i < a; i++)
        {
            result = prev + current;
            prev = current;
            current = result;
        }
        return result;
    }
}
