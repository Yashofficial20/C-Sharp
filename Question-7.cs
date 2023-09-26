using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_7
    {
        private int oldvalue;
        public void myclass()
        {
            Console.WriteLine("Enter Value :");
            oldvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value is :"+oldvalue);
        }
        public void newvalu()
        {
            Console.WriteLine("Modify value :");
            int newvalue=Convert.ToInt32(Console.ReadLine());
            oldvalue = newvalue;
            Console.WriteLine("Modify value is :" +oldvalue);
        }
       /* public int getpro()
        {
            return oldvalue;
        }*/
    }

    class pro7
    {
        static void Main()
        {
            Question_7 obj7 = new Question_7();
            obj7.myclass();
            obj7.newvalu();
            Console.ReadKey();

        }
    }
}