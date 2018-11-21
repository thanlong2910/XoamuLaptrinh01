using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai28
{
    // Viết chương trình nhập n là số thập phân(n <= 255), n sang số nhị phân có 8 chữ số.
    // Ví dụ: 
    // 1 = 00000001
    // 10 = 00001010
    // 255 = 11111111

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Viết chương trình nhập n là số thập phân(n <= 255), n sang số nhị phân có 8 chữ số");
            Console.WriteLine(" Ví dụ: // 1 = 00000001 // 10 = 00001010 // 255 = 11111111");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");
            
            // Nhập số nguyên - n
            int inputNumber;
            Console.WriteLine("Nhập số nguyên n: ");
            inputNumber = SetIntegerNumber();

            // In ra số nhị phân
            ConvertToBinaryNumber(inputNumber);
            
            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm đổi thập phân sang nhị phân
        static void ConvertToBinaryNumber(int tempIntegerNumber)
        {
            string str = "";

            while ((tempIntegerNumber / 2) != 0)
            {
                str = str + (tempIntegerNumber % 2);
                tempIntegerNumber = tempIntegerNumber / 2;
            }
            // Cộng thêm chữ số cuối cùng của phép chia 2
            str = str + tempIntegerNumber;

            // Bổ sung thêm số 0 cho đủ nhị phân 8 bits
            int n = 8 - str.Length;
            for (int i = 0; i < n; i++)
            {
                str = str + "0";
            }

            // Đảo chuỗi str
            str = ReverseString(str);
            Console.WriteLine(str);
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

