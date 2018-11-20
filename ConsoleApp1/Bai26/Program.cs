using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai26
{
    // Tìm ước số chung lớn nhất của 2 số a, b.
    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("VIẾT CHƯƠNG TRÌNH TÍNH: S(x, n) = 1 + x + x^3/3! + x^5/5! + ... + x^(2n + 1)/(2n + 1)!");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            // Nhập số nguyên - a
            int inputFirstNumber;
            Console.WriteLine("Nhập số nguyên a: ");
            inputFirstNumber = SetIntegerNumber();

            // Nhập số nguyên - b
            int inputSecondNumber;
            Console.WriteLine("Nhập số nguyên b: ");
            inputSecondNumber = SetIntegerNumber();

            // In ra kết quả
            Console.WriteLine("USCLN của 2 số {0} và {1} là: ", inputFirstNumber, inputSecondNumber);
            Console.WriteLine(USCLN(inputFirstNumber, inputSecondNumber));

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm tính ước số chung lớn nhất
        static int USCLN(int tempFirstNumber, int tempSecondNumber)
        {
            if (tempFirstNumber > tempSecondNumber)
            {
                return USCLN(tempFirstNumber - tempSecondNumber, tempSecondNumber);
            }
            else if (tempSecondNumber > tempFirstNumber)
            {
                return USCLN(tempSecondNumber - tempFirstNumber, tempFirstNumber);
            }
            else return tempFirstNumber;
        }
    }
}
