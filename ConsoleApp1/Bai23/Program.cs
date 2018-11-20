using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai23
{
    // Cần có tổng 200.000đ từ 3 loại giấy bạc 1000đ, 2000đ, và 5000đ. 
    // Lập chương trình để tìm tất cả các phương án có thể.
    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Cần có tổng 200.000đ từ 3 loại giấy bạc 1000đ, 2000đ, và 5000đ.");
            Console.WriteLine("Lập chương trình để tìm tất cả các phương án có thể.");
            Console.WriteLine("************************************************");
            Console.WriteLine("");

            // In ra kết quả
            DisplayResult();

            Console.ReadLine();
        }

        // Hàm In ra ket qua
        static void DisplayResult()
        {
            // 1000*i + 2000*j + 5000*k = 200000

            // Số nghiệm
            int numberRoots = 0;
            for (int i = 0; i <= 200; i++)
            {
                for (int j = 0; j <= 100; j++)
                {
                    for (int k = 0; k <= 40; k++)
                    {
                        int sum;
                        sum = 1000*i + 2000*j + 5000*k;
                        if (sum==200000)
                        {
                            numberRoots ++;
                            Console.WriteLine("Phương án {0}: {1} tờ 1000đ, {2} tờ 2000đ, {3} tờ 5000đ", numberRoots, i, j, k);
                        }
                    }
                }
            }
        }
    }
}
