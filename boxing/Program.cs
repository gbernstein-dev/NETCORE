using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void typing()
        {
            int total = 0;
            int a = 7;
            int b = 28;
            int c = -1; 
            List<object> empty = new List<object>();
            empty.Add(a);
            empty.Add(b);
            empty.Add(c);
            empty.Add(true);
            empty.Add("chair");
            foreach (object item in empty)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(total); 
        }
        static void Main(string[] args)
        {
            typing();
        }
    }
}
