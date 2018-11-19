using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaceLab01
{
    // Interface

    public interface IShape
    {
        void Draw();
    }

    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }

    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IShape c = new Circle();
            c.Draw();

            Console.ReadLine();
        }
    }
}
