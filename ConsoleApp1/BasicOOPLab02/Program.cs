using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPLab02
{
    //Đầu tiên tạo một project mới.Sau đó, tạo 3 class: Person, Teacher, Student, 
    //    trong đó hai lớp Teacher và Student kế thừa lớp Person.

    //Bạn có thể tùy ý tạo các thuộc tính và các phương thức cho các lớp này.
    //    Chẳng hạn: lớp Person có phương thức setAge(int age), 
    //    lớp Student có phương thức GoToClass() để in ra thông báo I'm going to class., ...

    class Person
    {
        protected string name;
        protected int age;

        public void setAge(int a)
        {
            age = a;
        }
    }

    class Teacher : Person
    {
        string subject;
        string department;
    }

    class Student : Person
    {
        string classroom;
        string studentID;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person persion1 = new Teacher();

        }
    }
}
