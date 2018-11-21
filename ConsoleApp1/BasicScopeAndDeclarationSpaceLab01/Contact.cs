using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicScopeAndDeclarationSpaceLab01
{
    public class Contact
    {
        public int age;

        public void FuncA()
        {
            age = 18;
            Console.WriteLine(age);
        }

        public void FuncB()
        {
            int age;
            age = 21;
            Console.WriteLine(age);
        }
    }
}
