using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    // Tính S(x, n) = x + x^2 + x^3 + ... + x^n

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH TÍNH: S(x,n) = x + x^2 + x^3 + ... + x^n");
            Console.WriteLine("**********************************************************");
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

            // In ra dòng: x + x^2 + x^3 + ... + x^n
            string str = "Tổng của dãy: ";
            for (int i = 1; i <= inputNumberExponent; i++)
            {
                if (i == 1)
                {
                    str += inputNumberBase;
                }
                else
                {
                    str += " + " + inputNumberBase + "^" + i;
                }
            }

            //Console.WriteLine(str);
            
            // In ra kết quả
           Console.WriteLine("{0}  = {1}", str, SumOfArray(inputNumberBase, inputNumberExponent));

            Console.ReadLine();
        }

        // Hàm nhập số thực
        static double SetDoubleNumber()
        {
            double number;
            number = double.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính tổng của dãy
        static double SumOfArray(double tempBase, double tempExponent)
        {
            double sum = 0;

            for (int i = 1; i <= tempExponent; i++)
            {
                sum += Math.Pow(tempBase, i);
            }

            return sum;
        }
    }
}
