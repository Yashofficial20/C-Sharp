using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_9
    {
        protected void myprotec()
        {
            Console.WriteLine("Enter the name ");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the Rollno ");
            int Rollno = Convert.ToInt32(Console.ReadLine());
        }
    }
    class drive : Question_9
    {
        public void AcessprotMethod()
        {
            Console.WriteLine("calling protected method from drive ");
            myprotec();
        }
    }

    class pro9
    {
        static void Main()
        {
            drive obj9 = new drive();
            obj9.AcessprotMethod();
            Console.ReadKey();
        }
    }
}
