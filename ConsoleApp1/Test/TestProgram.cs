using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            int minValue, maxValue;
            int indexMin, indexMax;
            int[] array = new int[8] {9, 7, 2, 4, 5, 8, 6, 3};

            // Tìm giá trị nhỏ nhất của mảng và chỉ số của GTNN 
            minValue = array[0];
            indexMin = 0;
            Console.WriteLine("min value initial: {0}", minValue);

            // Nếu phần tử của mảng còn < minValueOfArray, thì gán minValueOfArray cho giá trị nhỏ hơn đó  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    indexMin = i;
                    Console.WriteLine("minValue: {0}  index: {1}", minValue, indexMin);
                }
            }
            Console.WriteLine("minValue: {0}  index: {1}", minValue, indexMin);

            // Tìm maxValue và chỉ số của nó
            maxValue = array[0];
            indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    indexMax = i;
                }
            }
            Console.WriteLine("maxValue: {0}  index: {1}", maxValue, indexMax);

            // Hiển thị mảng trước khi thay đổi
            Console.WriteLine("Mảng sau khi thay đổi");
            foreach (var elementOfArray in array)
            {
                Console.Write("{0} ", elementOfArray);
            }

            // Đảo vị trí max và min
            SwapTwoIntegerNumbers(ref array[indexMax], ref array[indexMin]);

            // Hiển thị mảng sau khi thay đổi
            Console.WriteLine("Mảng sau khi thay đổi");
            foreach (var elementOfArray in array)
            {
                Console.Write("{0} ", elementOfArray);
            }

            Console.ReadLine();
        }
        static void SwapTwoIntegerNumbers(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
