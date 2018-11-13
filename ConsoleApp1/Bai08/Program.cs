using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    //Câu 8: Viết chương trình nhập 4 số a, b, c, d. 
    //In ra là DUNG nếu chỉ tồn tại 1 số trong 4 số có giá trị là 10. 
    //Ngược lại thì in ra SAI.

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;

            // Nhap 4 so:
            Console.WriteLine("Nhap so thu nhat: ");
            firstNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: ");
            secondNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu ba: ");
            thirdNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu tu: ");
            fourthNumber = SetIntegerNumber();

            // Tim trong do co may so 10
            int temp = 0;

            if (firstNumber == 10)
            {
                temp++;
            }

            if (secondNumber == 10)
            {
                temp++;
            }

            if (thirdNumber == 10)
            {
                temp++;
            }

            if (thirdNumber == 10)
            {
                temp++;
            }

            // Neu chi co 1 so 10 thi in ra DUNG
            // Nguoc lai in ra SAI
            if (temp == 1)
            {
                Console.WriteLine("DUNG");
            }
            else Console.WriteLine("SAI");

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
