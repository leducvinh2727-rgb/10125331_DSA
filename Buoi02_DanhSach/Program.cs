using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n========== BUỔI 02 ==========");
    Console.WriteLine(" 1. Chèn phần tử vào mảng");
    Console.WriteLine(" 2. Quản lý nhân viên");
    Console.WriteLine(" 3. Ma trận vuông");
    Console.WriteLine(" 4. Danh sách liên kết: đếm x, dương nhỏ nhất, xóa x");
    Console.WriteLine(" 5. Danh sách liên kết: max, tổng, số nguyên tố, âm/dương");
    Console.WriteLine(" 6. Thống kê nhiệt độ");
    Console.WriteLine(" 7. Thống kê nhiệt độ (bài 7)");
    Console.WriteLine(" 8. Đếm tần suất từ trong chuỗi");
    Console.WriteLine(" 9. Lọc số nguyên tố, chẵn, hoàn hảo");
    Console.WriteLine("10. Ma trận đơn vị, đối xứng");
    Console.WriteLine("11. Minesweeper");
    Console.WriteLine("12. Đảo ngược danh sách liên kết");
    Console.WriteLine("13. Gộp hai danh sách liên kết đã sắp xếp");
    Console.WriteLine("14. Kiểm tra chu trình trong danh sách liên kết");
    Console.WriteLine("16. Lịch sử trình duyệt (danh sách liên kết đôi)");
    Console.WriteLine(" 0. Thoát");
    Console.Write("Chọn bài: ");

    string chon = Console.ReadLine();
    Console.WriteLine();

    switch (chon)
    {
        case "1": Bai1Runner.Chay(); break;
        case "2": Bai2Runner.Chay(); break;
        case "3": Bai3Runner.Chay(); break;
        case "4": Bai4Runner.Chay(); break;
        case "5": Bai5Runner.Chay(); break;
        case "6": Bai6Runner.Chay(); break;
        case "7": Bai7Runner.Chay(); break;
        case "8": Bai8Runner.Chay(); break;
        case "9": Bai9Runner.Chay(); break;
        case "10": Bai10Runner.Chay(); break;
        case "11": Bai11Runner.Chay(); break;
        case "12": Bai12Runner.Chay(); break;
        case "13": Bai13Runner.Chay(); break;
        case "14": Bai14Runner.Chay(); break;
        case "15": Bai15Runner.Chay(); break;
        case "0": return;
        default: Console.WriteLine("Lựa chọn không hợp lệ."); break;
    }
}