using System;

public class Program
{
    static int SumSquares(int n, int depth = 0)
{
    string indent = new string(' ', depth * 2);
    Console.WriteLine($"{indent}Calling SumSquares({n})");
    Thread.Sleep(500);  // slow down for animation effect

    if (n <= 0)
    {
        Console.WriteLine($"{indent}Base case: return 0");
        Thread.Sleep(500);
        return 0;
    }

    int result = n * n + SumSquares(n - 1, depth + 1);

    Console.WriteLine($"{indent}SumSquares({n}) = {n}^2 + result from below = {n * n} + {result - n * n} = {result}");
    Thread.Sleep(500);
    return result;
}


    public static void Main()
    {
        int finalResult = SumSquares(5);
        Console.WriteLine($"\nFinal Result: {finalResult}");
    }
}
