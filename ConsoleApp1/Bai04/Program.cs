using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    //Câu 4: Tìm nghiệm phtrinh bậc nhất.  a*x + b = 0
    // ********************************************

    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("GIAI PHUONG TRINH BAC NHAT");
            Console.WriteLine("****************************");
            Console.WriteLine("");

            // Nhap 2 so:
            Console.WriteLine("Nhap so thu nhat: a = ");
            a = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: b = ");
            b = SetIntegerNumber();

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else if (a != 0)
            {
                // SE XU LY THEO DANG PHAN SO, PHAN SO TOI GIAN sau ....
                Console.WriteLine("Phuong trinh co nghiem duy nhat: x = {0}", (float)-b/a);
            }

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
