using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    class Question_6
    {
        public string properties { get; set; }
    }

    class derivedClass : Question_6
    {
        public void accesproperties()
        {
            Console.WriteLine("This is properties :" + properties);
        }
    }

    class prog6
    {
        static void Main()
        {
            derivedClass c1 = new derivedClass();
            c1.properties = "hello";
            c1.accesproperties();
            Console.ReadKey();
        }
    }
}