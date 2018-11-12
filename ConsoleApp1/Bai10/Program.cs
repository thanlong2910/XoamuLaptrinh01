using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    // Câu 10: Viết chương trình nhập vào lương trước thuế của một nhân viên.

    // Cho biết lương sau thuế của nhân viên đó. Biết:
    //- 35% thuế thu nhập nếu lương là 15 triệu
    //- 21% thuế thu nhập nếu lương từ 7 đến 15 triệu
    //- 11% thuế thu nhập nếu lương dưới 7 triệu
    // *************************************************************************************************
        class Program
    {
        static void Main(string[] args)
        {
            double salaryBeforeTax;
            double salaryAfterTax;
            double tax;

            // Nhap luong truoc thue:
            Console.WriteLine("Nhap luong truoc thue (trieu): ");
            salaryBeforeTax = SetDoubleNumber();
            Console.WriteLine("Luong truoc thue la: {0} (trieu)", salaryBeforeTax);

            if (salaryBeforeTax >= 15)
            {
                tax = 0.35 * salaryBeforeTax;
                salaryAfterTax = salaryBeforeTax - tax;
                Console.WriteLine("Luong sau thue la: {0} (trieu)", salaryAfterTax);
                Console.WriteLine("Thue la: {0} (trieu)", tax);
            }
            else if ((7 <= salaryBeforeTax) && (salaryBeforeTax < 15))
            {
                tax = 0.21 * salaryBeforeTax;
                salaryAfterTax = salaryBeforeTax - tax;
                Console.WriteLine("Luong sau thue la: {0} (trieu)", salaryAfterTax);
                Console.WriteLine("Thue la: {0} (trieu)", tax);
            }
            else
            {
                tax = 0.11 * salaryBeforeTax;
                salaryAfterTax = salaryBeforeTax - tax;
                Console.WriteLine("Luong sau thue la: {0} (trieu)", salaryAfterTax);
                Console.WriteLine("Thue la: {0} (trieu)", tax);
            }

            Console.ReadLine();
        }

        // Ham nhap so thuc
        static double SetDoubleNumber()
        {
            double number;
            number = double.Parse(Console.ReadLine());
            return number;
        }
    }
}
