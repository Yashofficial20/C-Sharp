using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_1
    {
        private int myfield;
        public void Setvalue()
        {
            // int value;
            Console.WriteLine("enter the number :");
            int value = Convert.ToInt32(Console.ReadLine());
            myfield = value;
        }
        public void Disply()
        {
            Console.WriteLine("This is actual value of private field :" + myfield);
        }
    }

    class Program 
    {
        public static void Main()
        {
            Question_1 c = new Question_1();
            c.Setvalue();
            c.Disply();
            Console.ReadKey();

        }
    }
}

