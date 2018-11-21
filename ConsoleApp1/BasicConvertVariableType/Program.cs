using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConvertVariableType
{
    class Program <T>
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            float floatNumber;
            double doubleNumber;
            string str;


            // Nhập số nguyên inputNumber
            int inputIntegerNumber;
            Console.WriteLine("Nhập số nguyên: ");
            inputIntegerNumber = SetIntegerNumber();
            Console.WriteLine("Input Number: {0}", inputIntegerNumber);

            // Convert int --> other types
            


            // Nhập số thực
            double inputDoubleNumber;
            Console.WriteLine("Nhập số thực: ");
            inputDoubleNumber = SetDoubleNumber();



        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm nhập số thực
        static double SetDoubleNumber()
        {
            double number;
            number = double.Parse(Console.ReadLine());
            return number;
        }
    }
}
