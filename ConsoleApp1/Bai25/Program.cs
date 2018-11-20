using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai25
{
    // Viết chương trình In ra tất cả các số lẻ nhỏ hơn 100 trừ các số 15, 47, 29.

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH TÍNH: S(x, n) = 1 + x + x^3/3! + x^5/5! + ... + x^(2n + 1)/(2n + 1)!");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            // In ra kết quả
            Console.WriteLine("Danh sách các số lẻ nhỏ hơn 100, trừ các số 15, 47, 29 là: ");
            DisplayResult();

            Console.ReadLine();
        }

        // Hàm in kết quả
        static void DisplayResult()
        {
            for (int i = 1; i < 100; i++)
            {
                if ((i%2 != 0) && (i != 15) && (i != 47) && (i != 29))
                {
                    Console.Write(" {0}", i);
                }
            }
        }
    }
}
