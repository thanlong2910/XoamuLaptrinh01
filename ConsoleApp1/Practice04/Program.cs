using System;
using System.Text;

namespace Practice04
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //========== Gõ tiếng Việt trong Console =========
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("======================== ĐỀ BÀI =======================");
            Console.WriteLine("||   Tìm chữ số thập phân thứ 70 của phép chia a/b   ||");
            Console.WriteLine("=======================================================");

            int a, b;

            // =========== Nhập 2 số a, b ====================
            Console.Write("Nhập số nguyên a = ");
            a = SetIntegerValue();
            Console.Write("Nhập số nguyên b = ");
            b = SetIntegerValue();

            Console.WriteLine("a = {0}, b = {1}", a, b);

            // ================ Thương a/b ===================
            double quotient;
            quotient = (double)a / b;
            Console.WriteLine("Thương số = {0}", quotient);

            // ============== Xuất ra kết quả =================
            DisplayResult(a, b);

            Console.ReadLine();
        }

        // =============== Hàm nhập số nguyên =================
        static int SetIntegerValue()
        {
            return int.Parse(Console.ReadLine());
        }

        //===== Hàm tìm chữ số thập phân thứ 70 của thương =====
        static void DisplayResult(int a, int b)
        {
            int temp = a % b; // Biến phần dư
            double result = -1; // Biến kết quả cuối cùng, chữ số thập phân thứ 70
            int count = 1; // Biến đếm

            // ======= Kết quả phép chia thông thường =========
            result = (double)a / b;
            Console.WriteLine("Result = {0}", result);
            
            // ===== In ra toàn bộ 70 chữ số thập phân ========
            while (count<= 70)
            {
                result = (temp * 10) / b;
                temp = (temp * 10) % b;
                
                Console.WriteLine("temp = {0}  count = {1} result = {2}", temp, count, result);
                count++;
            }

            // ========== In ra kết quả cuối cùng =============
            Console.WriteLine("=======================================================");
            Console.WriteLine("Chữ số thập phân thứ 70 của phép chia {0}/{1} = {2}", a, b, result);
        }
    }
}
