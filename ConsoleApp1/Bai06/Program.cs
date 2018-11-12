using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    //Câu 6: Viết chương trình xếp hạng học lực. 
    // < 5 ==> không đạt, 6,5 <= và <=7,9 ==> Khá, >=8 ==> Giỏi
    // *************************************************************

    class Program
    {
        static void Main(string[] args)
        {
            float diemso;

            Console.WriteLine("CHUONG TRINH XEP HANG HOC LUC");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");

            // Nhap diem so:
            Console.WriteLine("Nhap diem so:");
            diemso = SetFloatNumber();

            if (diemso < 5)
            {
                Console.WriteLine("KHONG DAT");
            }
            else if ((diemso >= 5) && (diemso < 6.5))
            {
                Console.WriteLine("TRUNG BINH");
            }
            else if ((diemso >= 6.5) && (diemso < 8))
            {
                Console.WriteLine("KHA");
            }
            else
            {
                Console.WriteLine("GIOI");
            }

            Console.ReadLine();
        }

        // Ham nhap so thuc
        static float SetFloatNumber()
        {
            float number;
            number = float.Parse(Console.ReadLine());
            return number;
        }
    }
}
