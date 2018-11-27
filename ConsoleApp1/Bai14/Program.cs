using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    // Viết chương trình tính: T(x, n) = x ^ n

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("======================= ĐỀ BÀI ==============================");
            Console.WriteLine("|| SỬ DỤNG VÒNG LẶP, VIẾT CHƯƠNG TRÌNH TÍNH: T(x,n) = x^n  ||");
            Console.WriteLine("||               Với x, n nguyên                           ||");
            Console.WriteLine("=============================================================");
            Console.WriteLine("");

            // ============== Nhập số nguyên - cơ số ================
            int inputNumberBase;
            Console.WriteLine("Nhập số nguyên cơ số: ");
            inputNumberBase = SetIntegerNumber();

            // =============== Nhập số nguyên - lũy thừa ============
            int inputNumberExponent;
            Console.WriteLine("Nhập số nguyên mũ: ");
            inputNumberExponent = SetIntegerNumber();
            
            // ================ In ra các số đã nhập ==============
            Console.WriteLine("Input Base: x = {0}", inputNumberBase);
            Console.WriteLine("Input Exponent: n = {0}", inputNumberExponent);

            // ================= In ra kết quả: x ^ n =============
            int result;
            result = CountExponent(inputNumberBase, inputNumberExponent);
            Console.WriteLine("{0}^{1} = {2}", inputNumberBase, inputNumberExponent, result);
            
            Console.ReadLine();
        }

        // ========== Hàm nhập số nguyên ==========================
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // ============ Hàm tính lũy thừa =========================
        static int CountExponent(int x, int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * x;
            }

            return result;
        }
    }
}
