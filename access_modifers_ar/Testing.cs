using System;
using System.Collections.Generic;
using System.Text;
using lib1;

namespace access_modifers_ar
{
    class Testing : Employee
    {
        public void Tester()
        {
            Employee e1 = new Employee();
            //Console.WriteLine(e1.inte)
            Console.WriteLine(protectedInternalLib1);
            //Console.WriteLine(privateProtectedMemeberLib1);
        }
    }
}
