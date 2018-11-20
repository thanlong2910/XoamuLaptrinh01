using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    // Viết chương trình nhập n và tìm chữ số lớn nhất của n. Ví dụ: 4665789 => chữ số lớn nhất 9

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH NHẬP n VÀ TÌM CHỮ SỐ LỚN NHẤT CỦA n");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("");

            // Nhap so nguyên:
            int inputNumber;
            Console.WriteLine("Nhap so nguyên: ");
            inputNumber = SetIntegerNumber();
            Console.WriteLine("Input Number: n = {0}", inputNumber);

            // In ra chu so lon nhat
            Console.WriteLine("Chữ số lớn nhất của số {0} là: {1}", inputNumber, MaxElementOfNumber(inputNumber));

            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tìm chữ số lớn nhất
        static int MaxElementOfNumber(int tempInputNumber)
        {
            int max = -1;

            // 1234
            //
            do
            {
                if (max < (tempInputNumber%10))
                {
                    max = tempInputNumber % 10;
                }
                tempInputNumber = tempInputNumber / 10;
            }
            while (tempInputNumber != 0);

            return max;
        }
    }
}
