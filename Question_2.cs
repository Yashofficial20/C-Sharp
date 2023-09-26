using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_2
    {
        private string Name;
        private int age;
        public void Privatefield()
        {
            Console.WriteLine("enter name :");
            string n = Console.ReadLine();
            this.Name = n;
            Console.WriteLine("Enter age : ");
            int a = Convert.ToInt32(Console.ReadLine());
            this.age = a;
        }

        public void Disply()
        {
            Console.WriteLine("Name is :" + Name + " age is :" + age);
        }
        class Prog
        {
            static void Main()
            {
                Question_2 c = new Question_2();
                c.Privatefield();
                c.Disply();

                Console.ReadKey();

            }
        }
    }
}

