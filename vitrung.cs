/*
Một loại vi trùng cứ sau mỗi giờ lại nhân đôi. Hỏi ban đầu có n con vi trùng thì sau h giờ số lượng là bao nhiêu?

Input:
- Số lượng vi trùng ban đầu (con)
- Khoảng thời gian (giờ).

Output: Số lượng vi trùng sau khoảng thời gian đã cho.
*/
using System;
namespace Vitrung
{
    class Program
    {
        static void main(string[] args)
        {
            long n, h;
            //input
            Console.write("nhap so luong vi trung: ");
            n = long.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian (gio): ");
            h= long.parse(console.readline());
            //process
            long ketqua = n * (long)Math.Pow(2, h);
            //output
            console.writeline("Sau {0} gio,so luong vi trung la: {1}", h, ketqua);
        }
    }
}
