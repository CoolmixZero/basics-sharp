using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Is Prime:");
        Console.WriteLine(Tasks.IsPrime(9));
        Console.WriteLine(Tasks.IsPrime(17));
        Console.WriteLine();

        Console.WriteLine("Fibonacci:");
        Console.WriteLine(Tasks.Fibonacci(4));
        Console.WriteLine();

        Console.WriteLine("Is Triangle:");
        Console.WriteLine(Tasks.IsTriangle(7, 10, 5));
        Console.WriteLine(Tasks.IsTriangle(1, 10, 12));
        Console.WriteLine();

        Console.WriteLine("Is Right Triangle:");
        Console.WriteLine(Tasks.IsRightTriangle(5, 6, 7));
        Console.WriteLine(Tasks.IsRightTriangle(10, 10, 10));
        Console.WriteLine();

        Console.WriteLine("Write Multiples:");
        Tasks.WriteMultiples(2, 8);
        Console.WriteLine();    

        Console.WriteLine("Write Divisors:");
        Tasks.WriteDivisors(13);
        Console.WriteLine();

        Console.WriteLine("Digit Sum:");
        Console.WriteLine(Tasks.DigitSum(12345));
        Console.WriteLine();

        Console.WriteLine("Digit Difference:");
        Console.WriteLine(Tasks.DigitDiff(12));
        Console.WriteLine();

        Console.WriteLine("Factorial:");
        Console.WriteLine(Tasks.Factorial(4));
        Console.WriteLine();

        Console.WriteLine("Write Fibonacci:");
        Tasks.WriteFibonacci(3);
        Console.WriteLine();
    }
}
class Tasks
{
    public static bool IsPrime(int number)
    {
        if (number == 0)
            return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static int Fibonacci(int i)
    {
        if (i <= 2)
            return 1;

        return Fibonacci(i - 1) + Fibonacci(i - 2);
    }
    public static bool IsTriangle(int a, int b, int c)
    {
        bool sum_of_two_sides_greater_than_the_other = a + b > c && a + c > b && b + c > a;

        return sum_of_two_sides_greater_than_the_other ? true : false;
    }
    public static bool IsRightTriangle(int a, int b, int c)
    {
        double pow_a = Math.Pow(a, 2), pow_b = Math.Pow(b, 2), pow_c = Math.Pow(c, 2);
        bool Pythagorean_ab = (pow_a + pow_b == pow_c);
        bool Pythagorean_bc = (pow_b + pow_c == pow_a);
        bool Pythagorean_ac = (pow_a + pow_c == pow_b);

        return Pythagorean_ab || Pythagorean_bc || Pythagorean_ac ? true : false;
    }
    public static void WriteMultiples(int number, int limit)
    {
        for (int i = number; i <= limit; i++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
    public static void WriteDivisors(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    public static int DigitSum(int number)
    {
        int sum = 0;
        
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    public static int DigitDiff(int number)
    {
        int max = -1, min = 10;

        while (number > 0)
        {
            int temp = number % 10;  // 12 % 10 = 2

            if (min > temp)
                min = temp;

            if (max < temp)
                max = temp;

            number /= 10;  // 12 / 10 = 1
        }
        Console.WriteLine($"{max} - {min} = {max - min}");
        return max - min;
    }
    public static int Factorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }
    public static void WriteFibonacci(int n)
    {
        TempFibonacci(0, 1, 1, n);
    }
    protected static void TempFibonacci(int a, int b, int counter, int length)
    {
        if (counter <= length)
        {
            Console.Write("{0} ", a);
            TempFibonacci(b, a + b, counter + 1, length);
        }
    }
}
