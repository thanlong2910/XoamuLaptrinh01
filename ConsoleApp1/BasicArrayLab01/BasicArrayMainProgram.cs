using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicArrayLab01
{
    // Khai báo interface, với các hàm trừu tượng
    interface IBasicArrayInterface
    {
        // Hàm nhập số nguyên 
        int SetIntegerNumber();

        // Hàm nhập mảng 
        void GetArray(int[] array);

        // Hàm hiển thị mảng 
        void DisplayArray(int[] array);

        // Hàm sắp xếp mảng tăng dần theo giá trị tuyệt đối
        void BubbleSortAbsoluteValueOfArray(int[] array);

        // Hàm kiểm tra mảng lẻ - Bài tập 32 
        void OddArrayCheck(int[] array);

        // Hàm kiểm tra mảng chỉ tồn tại 2 phần tử 10 - Bài tập 33
        void TwoValue10Check(int[] array);

        // Hàm tính tổng các phần tử của mảng - Bài tập 34 
        void SumElementOfArray(int[] array);

        // Hàm tính tổng các phần tử lẻ của mảng - Bài tập 35
        void SumOddElementOfArray(int[] array);

        // Hàm tìm giá trị nhỏ nhất của mảng - Bài tập 36
        void MinValueOfArray(int[] array);

        // Hàm đảo ngược vị trí của max, min - Bài tập 37
        void SwapMaxMinValuesOfArray(int[] array);

        // Hàm sắp xếp mảng tăng dần - Bài tập 38
        void BubbleSortValueOfArray(int[] array);

        // Hàm sắp xếp các phần tử ở vị trí chẵn - Bài tập 39
        void BubbleSortEvenIndexOfArray(int[] array);

        // Hàm sắp xếp tăng dần các phần tử có giá trị là lẻ - Bài tập 40 
        void BubleSortOddValueOfArray(int[] array);

        // Hàm tìm phần tử chẵn lớn nhất nhỏ hơn mọi phần tử lẻ - Bài tập 41
        void BestMatchEvenElementOfArray(int[] array);
    }

    // Class BasicArray implement interface IBasicArrayInterface 
    class BasicArray : IBasicArrayInterface
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
        public void BubbleSortAbsoluteValueOfArray(int[] array)
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

        // Hàm kiểm tra mảng lẻ - Bài tập 32
        public void OddArrayCheck(int[] array)
        {
            bool status = true;
            foreach (var arrayElement in array)
            {
                if (arrayElement % 2 == 0)
                {
                    status = false;
                    break;
                }
            }

            if (status == false)
            {
                Console.WriteLine("Không phải mảng các số lẻ");
            }
            else
            {
                Console.WriteLine("Mảng chỉ gồm các số lẻ");
            }

        }

        // Hàm kiểm tra mảng chỉ tồn tại 2 phần tử 10 - Bài tập 33 
        public void TwoValue10Check(int[] array)
        {
            int count = 0;
            foreach (var arrayElement in array)
            {
                if (arrayElement == 10)
                {
                    count++;
                }
                if (count > 2)
                {
                    break;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Mảng chỉ có 2 giá trị 10");
            }
            else
            {
                Console.WriteLine("Mảng chứa nhiều hơn hoặc ít hơn 2 giá trị 10");
            }
        }

        // Hàm tính tổng các phần tử của mảng - Bài tập 34 
        public void SumElementOfArray(int[] array)
        {
            int sum = 0;
            foreach (var arrayElement in array)
            {
                sum += arrayElement;
            }
            Console.WriteLine("Tổng các phần tử của mảng = {0}", sum);
        }

        // Hàm tính tổng các phần tử lẻ của mảng - Bài tập 35
        public void SumOddElementOfArray(int[] array)
        {
            int sum = 0;
            foreach (var arrayElement in array)
            {
                // Nếu là số lẻ thì tính tổng
                if (arrayElement % 2 != 0)
                {
                    sum += arrayElement;
                }

            }
            Console.WriteLine("Tổng các phần tử của mảng = {0}", sum);
        }

        // Hàm tìm giá trị nhỏ nhất của mảng - Bài tập 36 
        public void MinValueOfArray(int[] array)
        {
            int minValueOfArray = array[0];

            // Nếu phần tử của mảng còn < minValueOfArray, thì gán minValueOfArray cho giá trị nhỏ hơn đó  
            foreach (var elementOfArray in array)
            {
                if (elementOfArray < minValueOfArray)
                {
                    minValueOfArray = elementOfArray;
                }
            }
            Console.WriteLine("Giá trị nhỏ nhất của mảng: {0}", minValueOfArray);
        }

        // Hàm đảo ngược vị trí của max, min - Bài tập 37 
        public void SwapMaxMinValuesOfArray(int[] array)
        {
            int maxValue, minValue;
            int indexMax, indexMin;

            // ===== Tìm giá trị nhỏ nhất của mảng và chỉ số của GTNN =====
            minValue = array[0];
            indexMin = 0;

            // Nếu phần tử của mảng còn < minValueOfArray, thì gán minValueOfArray cho giá trị nhỏ hơn đó  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    indexMin = i;
                }
            }

            maxValue = array[0];
            indexMax = 0;

            // Nếu phần tử của mảng còn > maxValueOfArray, thì gán maxValueOfArray cho giá trị lớn hơn đó  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    indexMax = i;
                }
            }

            SwapTwoIntegerNumbers(ref array[indexMin], ref array[indexMax]);
        }

        // Hàm sắp xếp mảng tăng dần - Bài tập 38
        public void BubbleSortValueOfArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                bool completeStatus = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] > array[j + 1])
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

        // Hàm sắp xếp các phần tử ở vị trí chẵn - Bài tập 39 
        public void BubbleSortEvenIndexOfArray(int[] array)
        {
            // Đếm số phần tử ở vị trí chẵn
            int countEvenIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    countEvenIndex++;
                }
            }
            
            // Lấy giá trị các phần tử vị trí chẵn vào 1 mảng tạm mới
            int[] tempEvenIndexArray = new int[countEvenIndex];

            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tempEvenIndexArray[j] = array[i];
                    j++;
                }
            }

            // Hiển thị mảng các phần tử ở vị trí chẵn
            Console.Write("Hiển thị mảng các số vị trí chẵn: ");
            foreach (var elementOfArray in tempEvenIndexArray)
            {
                Console.Write("{0} ", elementOfArray);
            }
            Console.WriteLine("");

            // Sắp xếp mảng các phần tử ở vị trí chẵn
            BubbleSortValueOfArray(tempEvenIndexArray);

            // Hiển thị mảng sau khi sắp xếp
            Console.Write("Hiển thị mảng các số vị trí chẵn sau khi sắp xếp: ");
            foreach (var elementOfArray in tempEvenIndexArray)
            {
                Console.Write("{0} ", elementOfArray);
            }
            Console.WriteLine("");

            // Gán lại các giá trị mảng tạm vào mảng ban đầu
            j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = tempEvenIndexArray[j];
                    j++;
                }
            }
        }

        // Hàm sắp xếp tăng dần các phần tử có giá trị là lẻ - Bài tập 40
        public void BubleSortOddValueOfArray(int[] array)
        {
            // Đếm số phần tử lẻ
            int countOddElement = 0;

            foreach (var elementOfArray in array)
            {
                if (elementOfArray % 2 != 0)
                {
                    countOddElement++;
                }
            }
            
            // Lấy giá trị các phần tử lẻ vào 1 mảng tạm mới
            int[] tempOddValueArray = new int[countOddElement];

            int j = 0;

            foreach (var elementOfArray in array)
            {
                if (elementOfArray % 2 != 0)
                {
                    tempOddValueArray[j] = elementOfArray;
                    j++;
                }
            }
            
            // Hiển thị mảng các phần tử lẻ
            Console.Write("Hiển thị mảng các phần tử lẻ: ");
            foreach (var elementOfArray in tempOddValueArray)
            {
                Console.Write("{0} ", elementOfArray);
            }
            Console.WriteLine("");

            // Sắp xếp mảng các phần tử lẻ
            BubbleSortValueOfArray(tempOddValueArray);

            // Hiển thị mảng sau khi sắp xếp
            Console.Write("Hiển thị mảng các phần tử lẻ sau khi sắp xếp: ");
            foreach (var elementOfArray in tempOddValueArray)
            {
                Console.Write("{0} ", elementOfArray);
            }
            Console.WriteLine("");

            // Gán lại các giá trị mảng tạm vào mảng ban đầu
            j = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] = tempOddValueArray[j];
                    j++;
                }
            }
        }

        // Hàm tìm phần tử chẵn lớn nhất nhỏ hơn mọi phần tử lẻ - Bài tập 41 
        public void BestMatchEvenElementOfArray(int[] array)
        {
            int minOddElement = 32765;
            int indexMinOddElement = -1;
            int countOddElement = 0;

            // Tìm phần tử lẻ bé nhất
            // Nếu có phần tử lẻ, thì tìm phần tử lẻ bé nhất
            // Đếm số phần tử lẻ
            foreach (var elementOfArray in array)
            {
                if (elementOfArray % 2 != 0)
                {
                    countOddElement++;
                }
            }

            if (countOddElement > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if ((array[i] % 2 != 0) && (minOddElement > array[i]))
                    {
                        minOddElement = array[i];
                    }
                }
                Console.WriteLine("Phần tử lẻ nhỏ nhất: {0}", minOddElement);

                // Tìm phần tử chẵn thỏa mãn đề bài
                int bestMatchEvenElement = -32766;
                for (int i = 0; i < array.Length; i++)
                {
                    if ((array[i] % 2 == 0) && (array[i] < minOddElement) && (bestMatchEvenElement < array[i]))
                    {
                        bestMatchEvenElement = array[i];
                    }
                }
                Console.WriteLine("Phần tử chẵn lớn nhất nhỏ hơn {0} là: {1}", minOddElement, bestMatchEvenElement);
            }
            else
            {
                Console.WriteLine("Mảng không có phần tử lẻ !");
            }
        }

        // Main Program - Basic Array 
        class BasicArrayMainProgram
        {
            static void Main(string[] args)
            {
                // Hiển thị tiếng Việt trong Console
                Console.OutputEncoding = Encoding.UTF8;

                // Khai báo đối tượng của class BasicArray
                IBasicArrayInterface basicArray = new BasicArray();
                int size;

                // Nhập kích thước mảng
                Console.Write("Nhập kích thước mảng: ");
                size = basicArray.SetIntegerNumber();
                // In kích thước mảng
                Console.WriteLine("Array Size = {0}", size);

                // Nhập mảng
                int[] arrayInteger = new int[size];
                basicArray.GetArray(arrayInteger);

                //// Test
                //arrayInteger = new int[]{9, 7, 11, 33, 10, 6, 4, 13};

                // Hiển thị mảng ban đầu
                Console.Write("=== Mảng ban đầu === ");
                basicArray.DisplayArray(arrayInteger);
                Console.WriteLine("******************************");
                Console.WriteLine("");

                // MENU:
                int menuItem = -1;
                MENU:
                Console.WriteLine("========== CHỌN BÀI TẬP ==========");
                Console.WriteLine("1. Bài tập 32");
                Console.WriteLine("2. Bài tập 33");
                Console.WriteLine("3. Bài tập 34");
                Console.WriteLine("4. Bài tập 35");
                Console.WriteLine("5. Bài tập 36");
                Console.WriteLine("6. Bài tập 37");
                Console.WriteLine("7. Bài tập 38");
                Console.WriteLine("8. Bài tập 39");
                Console.WriteLine("9. Bài tập 40");
                Console.WriteLine("10. Bài tập 41");
                Console.WriteLine("0. Bấm 0 để thoát");

                menuItem = basicArray.SetIntegerNumber();
                if (menuItem >= 0 && menuItem <= 10)
                {
                    switch (menuItem)
                    {
                        case 1:
                            {
                                //// Kiểm tra mảng lẻ - Bài tập 32
                                Console.WriteLine("=== Kiểm tra mảng lẻ - Bài tập 32 === ");
                                basicArray.OddArrayCheck(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 2:
                            {
                                // Kiểm tra mảng chỉ tồn tại 2 phần tử 10 - Bài tập 33
                                Console.WriteLine("=== Kiểm tra mảng tồn tại chỉ 2 phần tử 10 - Bài tập 33 === ");
                                basicArray.TwoValue10Check(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 3:
                            {
                                // Tính tổng các phần tử của mảng - Bài tập 34
                                Console.WriteLine("=== Tính tổng các phần tử của mảng - Bài tập 34 === ");
                                basicArray.SumElementOfArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 4:
                            {
                                // Tính tổng các phần tử lẻ của mảng - Bài tập 35
                                Console.WriteLine("=== Tính tổng các phần tử lẻ của mảng - Bài tập 35 === ");
                                basicArray.SumOddElementOfArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 5:
                            {
                                // Tìm giá trị nhỏ nhất của mảng - Bài tập 36
                                Console.WriteLine("=== Tìm giá trị nhỏ nhất của mảng - Bài tập 36 === ");
                                basicArray.MinValueOfArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 6:
                            {
                                // Đảo ngược vị trí của max, min - Bài tập 37
                                Console.WriteLine("=== Tìm giá trị nhỏ nhất của mảng - Bài tập 37 === ");
                                basicArray.SwapMaxMinValuesOfArray(arrayInteger);
                                Console.Write("Mảng sau khi đảo vị trí: ");
                                basicArray.DisplayArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 7:
                            {
                                // Sắp xếp mảng tăng dần - Bài tập 38 
                                Console.WriteLine("=== Sắp xếp mảng tăng dần - Bài tập 38 === ");
                                basicArray.BubbleSortValueOfArray(arrayInteger);
                                Console.Write("Mảng sau khi sắp xếp: ");
                                basicArray.DisplayArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 8:
                            {
                                // Sắp xếp các phần tử ở vị trí chẵn - Bài tập 39
                                Console.WriteLine("=== Sắp xếp các phần tử ở vị trí chẵn - Bài tập 39 === ");
                                basicArray.BubbleSortEvenIndexOfArray(arrayInteger);
                                Console.Write("Mảng kết quả cuối cùng: ");
                                basicArray.DisplayArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 9:
                            {
                                // Hàm sắp xếp tăng dần các phần tử có giá trị là lẻ - Bài tập 40 
                                Console.WriteLine("=== Sắp xếp các phần tử có giá trị là lẻ - Bài tập 40 === ");
                                basicArray.BubleSortOddValueOfArray(arrayInteger);
                                Console.Write("Mảng kết quả cuối cùng: ");
                                basicArray.DisplayArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        case 10:
                            {
                                // Hàm tìm phần tử chẵn lớn nhất nhỏ hơn mọi phần tử lẻ - Bài tập 41
                                Console.WriteLine("=== tìm phần tử chẵn lớn nhất nhỏ hơn mọi phần tử lẻ - Bài tập 41 === ");
                                basicArray.BestMatchEvenElementOfArray(arrayInteger);
                                Console.WriteLine("******************************");
                                Console.WriteLine("");
                                break;
                            }
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Nhập không đúng, mời nhập lại.");
                    Console.WriteLine("");
                    goto MENU;
                }
                
                Console.ReadLine();
            }
        }
    }
}
