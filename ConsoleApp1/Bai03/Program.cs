using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    //Câu 3: Nhập a, b và c.Tìm số lớn thứ nhì

    public class Cach1
    {
        public int firstNumber, secondNumber, thirdNumber;

        public void DisplayTheSecondMax()
        {
            // Truong hop 1: (firstNumber < secondNumber)
            if ((firstNumber < secondNumber) && (secondNumber < thirdNumber))
            {
                Console.WriteLine("So lon thu nhi: {0}", secondNumber);
            }
            else if ((firstNumber < secondNumber) && (secondNumber == thirdNumber))
            {
                Console.WriteLine("So lon thu nhi: {0}", firstNumber);
            }
            else if ((firstNumber < secondNumber) && (secondNumber > thirdNumber))
            {
                if (firstNumber <= thirdNumber)
                {
                    Console.WriteLine("So lon thu nhi: {0}", thirdNumber);
                }
                else if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("So lon thu nhi: {0}", firstNumber);
                }
            }

            // Truong hop 2: (firstNumber == secondNumber)
            else if ((firstNumber == secondNumber) && (secondNumber < thirdNumber))
            {
                Console.WriteLine("So lon thu nhi: {0}", secondNumber);
            }
            else if ((firstNumber == secondNumber) && (secondNumber > thirdNumber))
            {
                Console.WriteLine("So lon thu nhi: {0}", thirdNumber);
            }
            else if ((firstNumber == secondNumber) && (secondNumber == thirdNumber))
            {
                Console.WriteLine("Ba so bang nhau !");
            }

            // Truong hop 3: (firstNumber > secondNumber)
            if ((firstNumber > secondNumber) && (secondNumber >= thirdNumber))
            {
                Console.WriteLine("So lon thu nhi: {0}", secondNumber);
            }
            else if ((firstNumber > secondNumber) && (secondNumber < thirdNumber))
            {
                if (firstNumber <= thirdNumber)
                {
                    Console.WriteLine("So lon thu nhi: {0}", firstNumber);
                }
                else if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("So lon thu nhi: {0}", thirdNumber);
                }
            }
            
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

            #region Cach1

            Cach1 cach1 = new Cach1();
            cach1.firstNumber = firstNumber;
            cach1.secondNumber = secondNumber;
            cach1.thirdNumber = thirdNumber;

            cach1.DisplayTheSecondMax();

            #endregion

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
