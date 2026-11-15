using System;

class Bai4Runner
{
    public static void Chay()
    {
        Random rnd = new Random();
        int[] a = new int[1000];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(0, 10000);
        }

        Console.WriteLine("Mang ban dau:");
        Console.WriteLine(string.Join(" ", a));

        int n = a.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int viTriMin = i;
            for (int j = i + 1; j < n; j++)
            {
                if (a[j] < a[viTriMin])
                    viTriMin = j;
            }
            int tam = a[i];
            a[i] = a[viTriMin];
            a[viTriMin] = tam;
        }

        Console.WriteLine("Mang sau khi sap xep tang dan:");
        Console.WriteLine(string.Join(" ", a));
    }
}