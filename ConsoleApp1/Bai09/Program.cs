using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai09
{
    //Câu 9: Viết chương trình nhập 3 số a, b, c. Tính tổng các số lẻ và in ra màn hình.
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;
            int result = 0;

            // Nhap 3 so:
            Console.WriteLine("Nhap so thu nhat: ");
            firstNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: ");
            secondNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu ba: ");
            thirdNumber = SetIntegerNumber();

            // Tong cac so le
            result = OddNumber(firstNumber) + OddNumber(secondNumber) + OddNumber(thirdNumber);

            // In ra man hinh
            Console.WriteLine("Tong cac so le = {0}", result);

            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Tim so le
        static int OddNumber(int number)
        {
            if ((number % 2) != 0)
            {
                return number;
            }
            else return 0;
            
        }
    }
}
