using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIS_CLASS_THO
{
    class Utilities
    {
        public static String Stringify(String input)
        {
            return "'" + input + "'";
        }

        public static void UnitTest()
        {
            String input = "Test";
            input = Stringify(input);
            Console.WriteLine(input);
        }
       
    }
}
