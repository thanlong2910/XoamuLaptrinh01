using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    // Câu 5: Tìm nghiệm ptrinh bậc 2
    // *******************************
    class GiaiPTBacNhat
    {
        public int b, c;

        public void DisplayResult()
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else if (b != 0)
            {
                // SE XU LY THEO DANG PHAN SO, PHAN SO TOI GIAN sau ....
                Console.WriteLine("Phuong trinh co nghiem duy nhat: x = {0}", (float)-c/b);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("GIAI PHUONG TRINH BAC 2: a*x^2 + b*x + c = 0");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");

            // Nhap 3 so:
            Console.WriteLine("Nhap so thu nhat: a = ");
            a = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: b = ");
            b = SetIntegerNumber();
            Console.WriteLine("Nhap so thu ba: c = ");
            c = SetIntegerNumber();

            if (a==0)
            {
                GiaiPTBacNhat giaiPTBacNhat = new GiaiPTBacNhat();
                giaiPTBacNhat.b = b;
                giaiPTBacNhat.c = c;
                giaiPTBacNhat.DisplayResult();
            }
            else if (a != 0)
            {
                int delta = b * b - 4 * a * c;

                // xet gia tri delta
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: x = {0}", (float)-b/(2*a));
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.WriteLine("x1 = {0}", -b + Math.Sqrt(delta)/2);
                    Console.WriteLine("x2 = {0}", -b - Math.Sqrt(delta)/2);
                }
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
