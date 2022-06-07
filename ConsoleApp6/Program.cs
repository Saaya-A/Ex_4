using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] a = new int[10];
        Console.WriteLine("Массив:");
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = random.Next(0, 20);
            Console.WriteLine(a[i]);
        }
        for (int i = a.Length - 1; i >= 0; i--)
        {
            int j = random.Next(i);
            int d = a[i];
            a[i] = a[j];
            a[j] = d;
        }
        Console.WriteLine();
        Console.WriteLine("Преобразованный массив: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}