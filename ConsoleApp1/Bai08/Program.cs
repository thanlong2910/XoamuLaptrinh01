using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai08
{
    // Bai tap 08: 
    // Nhap 4 so
    // Sap xep theo thu tu giam dan

    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;

            // Nhập 4 số nguyên
            Console.WriteLine("Nhap so thu nhat: ");
            firstNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu hai: ");
            secondNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu ba: ");
            thirdNumber = SetIntegerNumber();
            Console.WriteLine("Nhap so thu tu: ");
            fourthNumber = SetIntegerNumber();

            Console.WriteLine("**************************** \n");
            Console.WriteLine("4 số đã nhập là: ");
            Console.WriteLine("{0}, {1}, {2}, {3}", firstNumber, secondNumber, thirdNumber, fourthNumber);
            // swap status: Nếu đổi chỗ 2 số, thì status sẽ +1
            int swapStatus = 0;

            int a0, a1, a2, a3;

            a0 = firstNumber;
            a1 = secondNumber;
            a2 = thirdNumber;
            a3 = fourthNumber;

            //Console.WriteLine("Start: ");
            //Console.WriteLine("{0}, {1}, {2}, {3}", a0, a1, a2, a3);

            #region LAN 1

            if (a0 < a1)
            {
                SwapNumber(ref a0, ref a1);
                swapStatus++;
            }
            if (a1 < a2)
            {
                SwapNumber(ref a1, ref a2);
                swapStatus++;
            }
            if (a2 < a3)
            {
                SwapNumber(ref a2, ref a3);
                swapStatus++;
            }

            //Console.WriteLine("Sau lan 1:");
            //Console.WriteLine("{0}, {1}, {2}, {3}", a0, a1, a2, a3);

            #endregion LAN 1

            #region LAN 2
            if (swapStatus > 0)
            {
                swapStatus = 0;

                if (a0 < a1)
                {
                    SwapNumber(ref a0, ref a1);
                    swapStatus++;
                }
                if (a1 < a2)
                {
                    SwapNumber(ref a1, ref a2);
                    swapStatus++;
                }
                if (a2 < a3)
                {
                    SwapNumber(ref a2, ref a3);
                    swapStatus++;
                }

                #region LAN 3
                if (swapStatus > 0)
                {
                    swapStatus = 0;

                    if (a0 < a1)
                    {
                        SwapNumber(ref a0, ref a1);
                        swapStatus++;
                    }
                    if (a1 < a2)
                    {
                        SwapNumber(ref a1, ref a2);
                        swapStatus++;
                    }
                    if (a2 < a3)
                    {
                        SwapNumber(ref a2, ref a3);
                        swapStatus++;
                    }

                    // 4 số: Nên nhiều nhất chỉ 3 lần là được
                    Console.WriteLine("Kết quả sau khi sắp xếp (3 lần)");
                    Console.WriteLine("{0}, {1}, {2}, {3}", a0, a1, a2, a3);

                }
                else
                {
                    Console.WriteLine("Kết quả sau khi sắp xếp (2 lần)");
                    Console.WriteLine("{0}, {1}, {2}, {3}", a0, a1, a2, a3);
                }

                #endregion
            }
            else
            {
                Console.WriteLine("Kết quả sau khi sắp xếp (0 hoặc 1 lần)");
                Console.WriteLine("{0}, {1}, {2}, {3}", a0, a1, a2, a3);
            }
            #endregion LAN 2

            Console.ReadLine();
        }

        // Ham nhap so nguyen
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Ham doi vi tri 2 so
        static void SwapNumber(ref int firstNum, ref int secondNum)
        {
            int temp;
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }

    }
}
