using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Unesite broj n:");
        int n = int.Parse(Console.ReadLine());

        int fibN = Fibonacci(n);

        Console.WriteLine("n-ti član Fibonaccijevog niza je: " + fibN);
    }

    static int Fibonacci(int n)
    {
        if (n <= 0)
            return 0;
        else if (n == 1)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
	}
}