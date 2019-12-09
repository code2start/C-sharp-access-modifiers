using System;
using lib1;

namespace access_modifers_ar
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            //Console.WriteLine(e1.publicMemeberLib1);
            //e1.Info();
            Manager m1 = new Manager();
            m1.ManagerInfo();
        }
    }
}
