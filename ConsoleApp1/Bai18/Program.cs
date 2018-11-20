using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai18
{
    // Viết chương trình nhập và đếm số lượng chữ số của số nguyên dương n.

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH NHẬP VÀ ĐẾM SỐ LƯỢNG CHỮ SỐ CỦA SỐ NGUYÊN DƯƠNG n");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("");

            // Nhap so nguyên:
            int inputNumber;
            Console.WriteLine("Nhap so nguyên: ");
            inputNumber = SetIntegerNumber();
            Console.WriteLine("Input Number: n = {0}", inputNumber);

            // In ra So chu so
            Console.WriteLine("Số {0} có {1} chữ số.", inputNumber, QuantityNumber(inputNumber));
            
            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm đếm số chữ số của số n
        static int QuantityNumber(int tempNumber)
        {
            double quantityNumber = -1;
            
            quantityNumber = Math.Log10(tempNumber) + 1;
            
            return (int)quantityNumber;

        }
    }
}
