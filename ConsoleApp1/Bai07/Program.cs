using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    //Câu 7: Viết chương trình nhập 3 số a, b, c. 
    //In ra là DUNG nếu chỉ tồn tại 1 số trong 3 số có giá trị là 10. 
    //Ngược lại thì in ra SAI.

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber;

            // Nhap 3 so:
            Console.WriteLine("Nhap so thu nhat: ");
            firstNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: ");
            secondNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu ba: ");
            thirdNumber = SetIntegerNumber();

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
