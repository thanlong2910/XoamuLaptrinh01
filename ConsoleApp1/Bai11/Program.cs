using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    // Viết chương trình tính T(n) = 1 * 2 * 3 * .. * n.

    class Program
    {
        static void Main(string[] args)
        {
            // Nhập số nguyên inputNumber
            int inputNumber;
            Console.WriteLine("Nhập số nguyên: ");
            inputNumber =  SetIntegerNumber();
            Console.WriteLine("Input Number: {0}", inputNumber);
            Console.WriteLine("Tích của dãy: 1*2*...*{0} = {1}", inputNumber,MultiplyOfArray(inputNumber));

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính tích
        static int MultiplyOfArray(int n)
        {
            int multiply = 1;

            for (int i = 1; i <= n; i++)
            {
                multiply = multiply * i;
            }

            return multiply;
        }
    }
}
