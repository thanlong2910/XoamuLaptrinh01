using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai24
{
    class Program
    {
        // Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày.

        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Viết chương trình nhập tháng, năm. Hãy cho biết tháng đó có bao nhiêu ngày");
            Console.WriteLine("************************************************");
            Console.WriteLine("");

            // Nhập số nguyên - tháng
            int inputMonth;
            Console.WriteLine("Nhập tháng (số nguyên): ");
            inputMonth = SetIntegerNumber();

            // Nhập số nguyên - năm
            int inputYear;
            Console.WriteLine("Nhập năm (số nguyên): ");
            inputYear = SetIntegerNumber();

            // In ra kết quả
            DisplayResult(inputMonth, inputYear);

            Console.ReadLine();
        }

        // Hàm in ra kết quả
        static void DisplayResult(int tempMonth, int tempYear)
        {
            switch (tempMonth)
            {
                case 1: Console.WriteLine("Tháng 1 năm {0} có 31 ngày", tempYear);
                    break;
                case 2:
                    if (LeapYearStatus(tempYear) == true)
                    {
                        Console.WriteLine("Tháng 2 năm {0} có 28 ngày", tempYear);
                    }
                    else Console.WriteLine("Tháng 2 năm {0} có 29 ngày", tempYear);
                    break;

                case 3:
                    Console.WriteLine("Tháng 3 năm {0} có 31 ngày", tempYear);
                    break;
                case 4:
                    Console.WriteLine("Tháng 4 năm {0} có 30 ngày", tempYear);
                    break;
                case 5:
                    Console.WriteLine("Tháng 5 năm {0} có 31 ngày", tempYear);
                    break;
                case 6:
                    Console.WriteLine("Tháng 6 năm {0} có 30 ngày", tempYear);
                    break;
                case 7:
                    Console.WriteLine("Tháng 7 năm {0} có 31 ngày", tempYear);
                    break;
                case 8:
                    Console.WriteLine("Tháng 8 năm {0} có 31 ngày", tempYear);
                    break;
                case 9:
                    Console.WriteLine("Tháng 9 năm {0} có 30 ngày", tempYear);
                    break;
                case 10:
                    Console.WriteLine("Tháng 10 năm {0} có 31 ngày", tempYear);
                    break;
                case 11:
                    Console.WriteLine("Tháng 11 năm {0} có 30 ngày", tempYear);
                    break;
                case 12:
                    Console.WriteLine("Tháng 12 năm {0} có 31 ngày", tempYear);
                    break;
                default:
                    break;
            }

        }

        // Hàm kiểm tra năm nhuận
        static bool LeapYearStatus(int tempYear)
        {
            if (((tempYear % 4 == 0) && (tempYear%100 != 0)))
            {
                return true;
            }
            else if (tempYear % 400 == 0)
            {
                return true;
            }
            else return false;
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}
