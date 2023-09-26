using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_10
    {
        internal  Question_10()
        {
            Console.WriteLine("Internal constructor called");
        }
        public void publiMethod()
        {
            Console.WriteLine("call publiMethod ");
        }
    }

    /*class pro10
    {
        static void Main()
        {
            Question_10 instance = new Question_10();
            instance.publiMethod();
        }
    }*/
}
