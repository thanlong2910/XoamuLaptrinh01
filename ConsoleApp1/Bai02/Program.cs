using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    // DE BAI:
    //Câu 2: Nhập a, b và c.Tìm số lớn nhất
    //******************************************

    class MaxNumberClass
    {
        private int firstNumber, secondNumber, thirdNumber;

        // Constructor method
        public MaxNumberClass(int tempFirstNumber, int tempSecondNumber, int tempThirdNumber)
        {
            this.firstNumber = tempFirstNumber;
            this.secondNumber = tempSecondNumber;
            this.thirdNumber = tempThirdNumber;
        }

        // Ham tim so lon nhat
        public void MaxNumber()
        {
            int maxNumber = firstNumber;

            if (maxNumber < secondNumber)
            {
                maxNumber = secondNumber;
            }
            else if (maxNumber < thirdNumber)
            {
                maxNumber = thirdNumber;
            }

            Console.WriteLine("So lon nhat la: {0}", maxNumber);
        }
    }

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

            // Khoi tao doi tuong cua Class Tim so lon nhat
            MaxNumberClass maxNumberClass = new MaxNumberClass(firstNumber, secondNumber, thirdNumber);
            maxNumberClass.MaxNumber();

            Console.ReadLine();

        }

        // Ham Nhap 1 so nguyen tu ban phim
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }
    }
}