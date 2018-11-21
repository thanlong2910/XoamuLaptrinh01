using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice01
{
    //ĐỀ BÀI:
    //Có n người xếp hàng 1 để mua hàng, thời gian người bán hàng phục vụ khách thứ i là t[i] phút (i= 1,2,3...n)
    //Yêu cầu:
    //Dữ liệu vào nhập từ bàn phím: n (n<= 32000)
    //Các giá trị t[i] (t[i] <=3600) 
    //Số k(k<=n) thứ tự người khách cần xác định thời gian chờ
    //Kết quả:
    //Thời gian khách hàng được phục vụ nhanh nhất (t[i] nhỏ nhất, ghi rõ là khách hàng thứ mấy)
    //Thời gian khách hàng được phục vụ chậm nhất (t[i] lớn nhất, ghi rõ là khách hàng thứ mấy)

    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trên console
            Console.OutputEncoding = Encoding.UTF8;

            int inputNumber;
            
            // In đề bài
            
            // Nhập số nguyên
            Console.WriteLine("Nhập số khách hàng: ");
            inputNumber = SetIntegerNumber();
            // Nhập thời gian đợi
            int[] waitingTime = new int[inputNumber];
            GetArray(inputNumber, waitingTime);

            // Hiển thị thời gian đợi
            DisplayArray(inputNumber, waitingTime);
            Console.WriteLine("-----------------------");

            // Hien thi ket qua khach hàng doi lau nhat, bao lau
            MaxTime(inputNumber, waitingTime);
            // Hien thi ket qua khach hàng doi it nhat, bao lau
            MinTime(inputNumber, waitingTime);


            Console.ReadLine();
        }

        // Hàm nhập số nguyên
        static int SetIntegerNumber()
        {
            int number;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        // Ham Nhap mang Customer[i], thoi gian cho  waitingTime[i]
        static void GetArray(int n, int[] waitingTime)
        {
            Console.WriteLine("Nhap thoi gian cho: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Thoi gian khach hàng {0} cho: ", i + 1);
                waitingTime[i] = SetIntegerNumber();
            }
        }

        // Ham Hien thi thoi gian cho tuong ung
        static void DisplayArray(int n, int[] waitingTime)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Khach hàng {0} cho {1} (phut)", i + 1, waitingTime[i]);
            }
        }

        // Ham tim thoi gian lon nhat
        static void MaxTime(int n, int[] waitingTime)
        {
            int max = waitingTime[0];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (max < waitingTime[i])
                {
                    max = waitingTime[i];
                    index = i;
                }
            }

            Console.WriteLine("Khach hàng {0} doi lau nhat, tong cong {1} phut", index + 1, waitingTime[index]);
        }

        // Ham tim thoi gian nho nhat
        static void MinTime(int n, int[] waitingTime)
        {
            int min = waitingTime[0];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (min > waitingTime[i])
                {
                    min = waitingTime[i];
                    index = i;
                }
            }

            Console.WriteLine("Khach hàng {0} doi it nhat, tong cong {1} phut", index + 1, waitingTime[index]);
        }
    }
}
