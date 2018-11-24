using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice02
{
    //1.Nhập vào mảng một chiều các số nguyên gồm n phần tử
    //2.Kiem tra mảng có tồn tại số nguyên tố hay không.
    //3.Sắp xếp mảng tăng dần theo giá trị tuyệt đối của các phần tử.Xuất mảng sau khi sắp xếp ra màn hình.

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine(" 1. Nhập vào mảng 1 chiều các số nguyên gồm n phần tử.");
            Console.WriteLine(" 2. Kiểm tra mảng có tồn tại số nguyên tố hay không.");
            Console.WriteLine(" 3. Sắp xếp mảng tăng dần theo giá trị tuyệt đối của các phần tử.");
            Console.WriteLine(" 4. Hiển thị mảng sau khi sắp xếp");
            Console.WriteLine("********************************************************");
            Console.WriteLine("");

            // Nhập số nguyên - n
            int inputNumber;
            Console.Write("Nhập số nguyên n: ");
            inputNumber = SetIntegerNumber();

            // Nhập mảng
            int[] array = new int[inputNumber];
            GetArray(array);
            Console.WriteLine();

            // Hiển thị mảng
            DisplayArray(array);

            // Test tay
            //int[] array = new int[5] { 10, 12, 7, 4, 6 };
            //DisplayArray(array);

            // Kiểm tra số nguyên tố trong mảng
            CheckPrimeInArray(array);

            // Sắp xếp tăng dần theo giá trị tuyệt đối
            BubbleSortArray(array);

            // Hiển thị mảng sau khi sắp xếp
            DisplayArray(array);

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm nhập mảng
        static void GetArray(int[] array)
        {
            Console.WriteLine("Nhập giá trị các phần tử của mảng: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("a{0} = ", i);
                array[i] = SetIntegerNumber();
            }
        }

        // Hàm hiển thị mảng
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        // Hàm kiểm tra số nguyên tố
        static bool CheckPrimeNumber(int n)
        {
            int i = 2;
            bool primeStatus = true;
            while ((i < n) && (primeStatus == true))
            {
                if (n % i == 0)
                {
                    primeStatus = false;
                }
                i++;
            }
            return primeStatus;
        }

        // Hàm kiểm tra phần tử số nguyên tố trong dãy
        static void CheckPrimeInArray(int[] array)
        {
            // Kiểm tra tồn tại số nguyên tố
            bool primeExist = false;
            int i = 0;
            while ((i < array.Length) && (primeExist == false))
            {
                if (CheckPrimeNumber(array[i]) == true)
                {
                    primeExist = true;
                }
                i++;
            }
            if (primeExist == true)
            {
                Console.WriteLine("Trong dãy có số nguyên tố");
            }
            else
            {
                Console.WriteLine("Trong dãy không có số nguyên tố");
            }
        }

        // Hàm sắp xếp mảng tăng dần theo giá trị tuyệt đối
        static void BubbleSortArray(int[] array)
        {
            for (int i = array.Length-1; i >= 1; i--)
            {
                bool completeStatus = true;
                for (int j = 0; j < i; j++)
                {
                    if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
                    {
                        SwapTwoIntegerNumbers(ref array[j], ref array[j + 1]);
                        completeStatus = false;
                    }
                }
                if (completeStatus == true)
                {
                    break;
                }
            }
        }

        // Hàm đảo 2 số nguyên
        static void SwapTwoIntegerNumbers(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
