using System;
using System.Collections.Generic;
using System.Text;

namespace lib1
{
    public class Manager : Employee
    {
        public void ManagerInfo()
        {
            Employee e1 = new Employee();
            //Console.WriteLine(e1.pri)
            //Console.WriteLine(protectedMemeberLib1);
            // Console.WriteLine(e1.internalMemebrLib1);
            Console.WriteLine(e1.protectedInternalLib1);
            Console.WriteLine(privateProtectedMemeberLib1);
        }
    }
}
