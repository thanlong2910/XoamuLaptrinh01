using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicScopeAndDeclarationSpaceLab01
{
    class Program
    {
        // Scope and Declaration Space
        /* http://www.informit.com/articles/article.aspx?p=1609145&seqNum=4&fbclid=IwAR1Qe14M6J3aL6o2GoLAGsB03t85Y4a88lQtIVN0nybobW8f0W8TN-9XXtc
        */

        static void Main(string[] args)
        {
            Contact ct = new Contact();
            ct.age = 20;
            Console.Write("Function A: ");
            ct.FuncA();

            Console.Write("Function B: ");
            ct.FuncB();

            Console.WriteLine("ct.age = {0}", ct.age);

            Console.ReadLine();
        }
    }
}
