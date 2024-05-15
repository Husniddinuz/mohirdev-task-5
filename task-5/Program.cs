using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.WriteLine("N musbat butun sonni kiriting:");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"1 dan {N} gacha bo'lgan sonlar yig'indisi: {sum}");
    }
}
