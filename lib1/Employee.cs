using System;

namespace lib1
{
    public class Employee
    {
        public int publicMemeberLib1 = 1;
        private int privateMemeberLib1 = 2;
        protected int protectedMemeberLib1 = 3;
        internal int internalMemebrLib1 = 4;
        protected internal int protectedInternalLib1 = 5;
        private protected int privateProtectedMemeberLib1 = 6;


        public void Info()
        {
            Console.WriteLine(publicMemeberLib1);
            Console.WriteLine(privateMemeberLib1);
            Console.WriteLine(protectedMemeberLib1);
            Console.WriteLine(privateProtectedMemeberLib1);
        }
    }
}
