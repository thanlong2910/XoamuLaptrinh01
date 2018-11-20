using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai27
{
    // Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + ... + n > 10000

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Tìm số nguyên dương n nhỏ nhất sao cho 1 + 2 + ... + n > 10000");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            // Hiển thị kết quả
            Console.WriteLine("Số nguyên dương n nhỏ nhất thỏa mãn là: {0}", MinRoot());
            Console.ReadLine();
        }

        // Hàm tìm nghiệm n nhỏ nhất
       static int MinRoot()
        {
            int root = 1;

            while (SumOfArray(root) < 10000)
            {
                root++;
            }
            
            return root;
        }

        // Hàm tính tổng dãy
        static int SumOfArray(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

    }
}
