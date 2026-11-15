using System;

class Bai5Runner
{
    public static void Chay()
    {
        Console.Write("Nhap n (nguyen duong): ");
        int n;


        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Khong hop le, nhap lai n (nguyen duong): ");
        }

        long ketQua;
        if (n == 1)
        {
            ketQua = 0;
        }
        else if (n == 2)
        {
            ketQua = 1;
        }
        else
        {
            long truoc = 0, sau = 1;
            for (int i = 3; i <= n; i++)
            {
                long tong = truoc + sau;
                truoc = sau;
                sau = tong;
            }
            ketQua = sau;
        }

        Console.WriteLine("So Fibonacci thu " + n + " la: " + ketQua);
    }
}