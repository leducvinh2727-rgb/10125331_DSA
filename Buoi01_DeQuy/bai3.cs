using System;
using System.Text;

class Bai3Runner
{
    public static void Chay()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? "";

        StringBuilder kq = new StringBuilder();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            kq.Append(s[i]);
        }

        Console.WriteLine("Chuoi dao nguoc: " + kq.ToString());
    }
}