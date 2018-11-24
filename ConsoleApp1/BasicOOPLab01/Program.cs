using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPLab01
{
    class Rectangle
    {
        double height;
        double width;

        // Constructor
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }

        // Hàm tính chu vi
        public void RectanglePerimeter()
        {
            Console.Write("Chu vi Hình chữ nhật:");
            Console.WriteLine((height + width)*2);
        }

        // Hàm tính Diện tích
        public void RectangleSquare()
        {
            Console.Write("Diện tích Hình chữ nhật:");
            Console.WriteLine(height * width);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Hiển thị tiếng Việt trong console
            Console.OutputEncoding = Encoding.UTF8;

            double height;
            double width;

            START:
            Console.WriteLine("Tính chu vi và diện tích hình chữ nhật");
            Console.WriteLine("**************************************");

            // Nhập chiều dài - height
            Console.Write("Nhập chiều dài height: ");
            height = SetDoubleNumber();

            // Nhập chiều rộng - width
            Console.Write("Nhập chiều rộng width: ");
            width = SetDoubleNumber();

            Console.WriteLine("h {0} -- w {1}", height, width);

            Rectangle rec = new Rectangle(height, width);

            // Hiển thị chu vi Hình Chữ nhật
            rec.RectanglePerimeter();

            // Hiển thị diện tích Hình chữ nhật
            rec.RectangleSquare();

            // Tiếp tục hay thoát
            Console.WriteLine("Bạn muốn tiếp tục không (Y/N)? \n Nhấn Y để tiếp tục. Kí tự khác để thoát.");

            string str;
            str = Console.ReadLine();
            if (str == "Y" || str == "y")
            {
                goto START;
            }
            
            Console.ReadLine();
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
