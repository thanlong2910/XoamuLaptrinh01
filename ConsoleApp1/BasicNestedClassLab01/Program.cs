using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicNestedClassLab01
{
    // Nested Class

    class Car
    {
        string name;

        public Car(string tempName)
        {
            name = tempName;
            Motor mt = new Motor();
        }

        public class Motor
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
