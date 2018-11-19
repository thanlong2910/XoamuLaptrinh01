using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai16
{
    // Viết S(x, n) = 1 + x^2/2! + x^4/4! + ... + x^2n/(2n)!

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH TÍNH: S(x, n) = 1 + x^2/2! + x^4/4! + ... + x^2n/(2n)");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            // Nhập số nguyên - cơ số
            int inputNumberBase;
            Console.WriteLine("Nhập số nguyên cơ số: ");
            inputNumberBase = SetIntegerNumber();

            // Nhập số nguyên - lũy thừa
            int inputNumberExponent;
            Console.WriteLine("Nhập số nguyên mũ: ");
            inputNumberExponent = SetIntegerNumber();

            Console.WriteLine("Input Base: x = {0}", inputNumberBase);
            Console.WriteLine("Input Exponent: n = {0}", inputNumberExponent);

            //Console.WriteLine("Lũy thừa của {0} = {1}", inputNumberExponent, Factorial(inputNumberExponent));

            // In ra dòng: 1 + x^2/2! + x^4/4! + ... + x^2n/(2n)
            string str = "Tổng của dãy: ";
            for (int i = 0; i <= inputNumberExponent; i++)
            {
                if (i == 0)
                {
                    str += 1;
                }
                else
                {
                    str += " + " + inputNumberBase + "^" + 2*i + "/" + 2*i + "!";
                }
            }

            Console.WriteLine(str);

            //// In ra kết quả
            Console.WriteLine("{0}  = {1}", str, SumOfArray(inputNumberBase, inputNumberExponent));

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính giai thừa
        static int Factorial(int tempNumber)
        {
            if (tempNumber == 0)
            {
                return 1;
            }
            else
            {
                return tempNumber * Factorial(tempNumber - 1);
            }
        }

        // Hàm tính tổng của dãy
        static double SumOfArray(int tempBase, int tempExponent)
        {
            double sum = 1;

            for (int i = 1; i <= tempExponent; i++)
            {
                sum += Math.Pow(tempBase, 2*i)/Factorial(2*i);
            }

            return sum;
        }
    }
}
