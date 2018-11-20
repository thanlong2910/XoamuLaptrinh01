using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai20
{
    // Viết chương trình nhập số nguyên dương n, liệt kê chữ số lẻ của n.
    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Viết chương trình nhập số nguyên dương n, liệt kê chữ số lẻ của n");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("");

            // Nhap so nguyên:
            int inputNumber;
            Console.WriteLine("Nhap so nguyên: ");
            inputNumber = SetIntegerNumber();
            Console.WriteLine("Input Number: n = {0}", inputNumber);

            //// Test Hàm Đảo chuỗi - ReverseString(string)
            //string str = "1234";
            //Console.WriteLine(str);
            //Console.WriteLine(ReverseString(str));

            // In ra danh sách các chữ số lẻ - Từ trái qua phải
            Console.WriteLine("Số {0} có các chữ số lẻ là: {1}", inputNumber, ListOddNumbers(inputNumber));

            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm liệt kê các chữ số lẻ - theo thứ tự trái qua phải
        static string ListOddNumbers(int tempInputNumber)
        {
            string str = "";

            // 1234
            //
            do
            {
                if ((tempInputNumber % 10) % 2 != 0)
                {
                    str = str + (tempInputNumber % 10) + " ";
                }
                tempInputNumber = tempInputNumber / 10;
            }
            while (tempInputNumber != 0);

            return ReverseString(str);
        }

        // Hàm đảo chuỗi
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
