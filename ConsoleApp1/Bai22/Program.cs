using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai22
{
    // Viết chương trình in bảng cửu chương ra màn hình.
    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Viết chương trình in bảng cửu chương ra màn hình");
            Console.WriteLine("************************************************");
            Console.WriteLine("");

            // In ra bảng cửu chương
            DisplayMultiplicationTable();
            Console.ReadLine();
        }

        // Hàm in ra Bảng cửu chương
        static void DisplayMultiplicationTable()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i*j);
                }
                Console.WriteLine("---------------------");
            }
            
        }
    }
}
