using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    //Tính S(n) = 1 + 2 + 3 + ... + n. (n > 0)

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;

            // Nhap so:
            Console.WriteLine("Nhap so n: ");
            n = SetIntegerNumber();

            // In ra man hinh TONG CAN TINH
            string array = "";
            for (int i = 1; i < n; i++)
            {
                array += i + " " + "+" + " ";
            }
            Console.WriteLine();
            Console.WriteLine("**************************");
            Console.WriteLine("Tinh Tong:");
            Console.WriteLine(array + n);

            // TINH TONG
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Tong = {0}", sum);
            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

    }
}
