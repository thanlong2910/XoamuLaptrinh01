using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayLab01
{
    class BasicArray
    {
        //int number;

        // Hàm nhập số nguyên
        public int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Hàm nhập mảng
        public void GetArray(int[] array)
        {
            Console.WriteLine("Nhập giá trị các phần tử của mảng: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("a{0} = ", i);
                array[i] = SetIntegerNumber();
            }
        }

        // Hàm hiển thị mảng
        public void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }

        // Hàm sắp xếp mảng tăng dần theo giá trị tuyệt đối
        public void BubbleSortArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
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
        public void SwapTwoIntegerNumbers(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

    }

    class BasicArrayMainProgram
    {
        static void Main(string[] args)
        {
            BasicArray basicArray = new BasicArray();
            int size;

            // Nhập kích thước mảng
            Console.Write("Nhập kích thước mảng: ");
            size = basicArray.SetIntegerNumber();

            // In kích thước mảng
            Console.WriteLine("Array Size = {0}", size);

            // Nhập mảng
            int[] arrayInteger = new int[size];
            basicArray.GetArray(arrayInteger);

            // Hiển thị mảng
            basicArray.DisplayArray(arrayInteger);

            Console.ReadLine();
        }
    }
}
