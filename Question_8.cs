using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_8
    {
        private void privat()
        {
            Console.WriteLine("This is private method ");
        }
        public void publi()
        {
            Console.WriteLine("This is public method");
            privat(); //call the method of private
        }
    }
  class pro8
    {
        static void Main()
        {
            Question_8 obj8 = new Question_8();
            obj8.publi();
            Console.ReadKey();
        }
    }
}
