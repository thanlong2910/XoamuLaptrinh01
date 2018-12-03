using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice05
{
    // === ĐỀ BÀI ===
    // Đếm số phần tử lớn nhất

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Mảng
            int[] array = {9, 3, 9, 5, 9, 6, 6, 9, 7, 1};

            // Khởi tạo biến max, biến đếm số lượng
            int max = array[0];
            int count = 1;

            // Code tính số lượng
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                }

                if (array[i] > max)
                {
                    max = array[i];
                    count = 1;
                }
            }

            // In kết quả
            Console.WriteLine("max = {0} count = {1}", max, count);

            Console.ReadLine();
        }
    }
}
