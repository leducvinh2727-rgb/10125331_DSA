using System;

class Bai1Runner
{
    public static void Chay()
    {
        Random rnd = new Random();
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 10000);
        }

        int max = a[0];
        int min = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
            if (a[i] < min) min = a[i];
        }

        Console.WriteLine("So lon nhat: " + max);
        Console.WriteLine("So nho nhat: " + min);
    }
}

