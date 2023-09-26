
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    // Base class with protected members
    class MyBaseClass
    {
        protected int protectedInt;
        protected double protectedDouble;

        public MyBaseClass(int i, double d)
        {
            protectedInt = i;
            protectedDouble = d;
        }

        public void Display()
        {
            Console.WriteLine("Base class: " + protectedInt + " " + protectedDouble); ;
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        public MyDerivedClass(int i, double d) : base(i, d)
        {
        }

        public void DisplayDerived()
        {
            // Accessing protected members from the base class is allowed in the derived class
            Console.WriteLine("Derived class: " + protectedInt +" "+ protectedDouble);
        }
    }



    class Pr1
    {
        static void Main()
        {
            MyDerivedClass derivedObj = new MyDerivedClass(42, 3.14);

            // Access protected members of the base class through the derived class
            derivedObj.Display();
            derivedObj.DisplayDerived();
            Console.ReadKey();
        }
    }
}