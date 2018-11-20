using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    // Tính S(n) = 1 / 1 * 2 + 1 / 2 * 3 + ... + 1 / n * (n + 1) (với n > 0)

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Nhập số nguyên inputNumber
            int inputNumber;
            Console.WriteLine("Nhập số nguyên: ");
            inputNumber = SetIntegerNumber();
            Console.WriteLine("Input Number: {0}", inputNumber);

            // In ra dòng: 1 / 1 * 2 + 1 / 2 * 3 + ... + 1 / n * (n + 1)
            string str = "Tổng của dãy:";
            for (int i = 1; i <= inputNumber; i++)
            {
                if (i == 1)
                {
                    str += "1/(1*2)";
                }
                else
                {
                    str += " + 1/(" + i + "*" + (i + 1) + ")";
                }

            }

            // In ra kết quả
            Console.WriteLine("{0}  = {1}", str, SumOfArray(inputNumber));

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính tổng
        static double SumOfArray(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (float)(i*(i+1));
            }

            return sum;
        }
    }
}
