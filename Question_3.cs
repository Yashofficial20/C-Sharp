using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3
{
    public class Question_3
    {

        internal string name;
        internal string course;
        public string Detail()
        {
            return $"{name} {course}";
        }
    }
    
    class Pro : Question_3
    {   
        public static void Main(String[]vs)
        {
            Pro e1 = new Pro();
            e1.name = "rohit";
            e1.course = "bca";
            Console.WriteLine(e1.Detail());
            Console.ReadKey();

        }
    }
}

