using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai21
{
    // Viết chương trình in ra tam giác cân có độ cao h. Và in ra tam giác.

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // In đề bài
            Console.WriteLine("Viết chương trình in ra tam giác cân có độ cao h. Và in ra tam giác");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("");

            // Nhập số nguyên - chiều cao h
            int trigonalHeight;
            Console.Write("Nhập chiều cao h (số nguyên): ");
            trigonalHeight = SetIntegerNumber();

            // In tam giac
            DrawTrigonal(trigonalHeight);

            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Vẽ tam giác cân, chiều cao h
        static void DrawTrigonal(int tempHeight)
        {
            for (int i = 1; i <= tempHeight; i++)
            {
                for (int j = 1; j < 2*tempHeight; j++)
                {
                    if (i == tempHeight)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if ((j == (tempHeight - i + 1)) || (j == (tempHeight + i - 1)))
                        {
                            Console.Write("*");
                        }
                        else Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
