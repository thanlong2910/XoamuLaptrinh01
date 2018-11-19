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
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH TÍNH: T(x,n) = x^n");
            Console.WriteLine("************************************");
            Console.WriteLine("");

            // Nhập số thực - cơ số
            double inputNumberBase;
            Console.WriteLine("Nhập số thực cơ số: ");
            inputNumberBase = SetDoubleNumber();

            // Nhập số thực - lũy thừa
            double inputNumberExponent;
            Console.WriteLine("Nhập số thực mũ: ");
            inputNumberExponent = SetDoubleNumber();
            
            Console.WriteLine("Input Base: x = {0}", inputNumberBase);
            Console.WriteLine("Input Exponent: n = {0}", inputNumberExponent);

            // In ra dòng: x ^ n
            double result;
            result = CountExponent(inputNumberBase, inputNumberExponent);
            Console.WriteLine("{0}^{1} = {2}", inputNumberBase, inputNumberExponent, result);
            
            Console.ReadLine();
        }

        //// Hàm nhập số nguyên
        //static int SetIntegerNumber()
        //{
        //    int number;
        //    number = int.Parse(Console.ReadLine());
        //    return number;
        //}

        // Hàm nhập số thực
        static double SetDoubleNumber()
        {
            double number;
            number = double.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính lũy thừa
        static double CountExponent(double x, double n)
        {
            double result;

            result = Math.Pow(x, n);

            return result;
        }
    }
}
