using System;
using System.Collections.Generic;


namespace boxing
{
    class Program
    {
        static void typing()
        {
            
            List<int> numbers = new List<int>();
            int total = 0;
            List<object> empty = new List<object>();
            empty.Add((int) 7);
            empty.Add((int) 28);
            empty.Add((int) -1);
            empty.Add((bool) true);
            empty.Add((string) "chair");
            foreach (object item in empty)
            {
                if (item.GetType().Equals(typeof(int)))
                    {
                      numbers.Add((int) item);
                    }
                Console.WriteLine(item.GetType());
            }
            
            foreach (int item in numbers)
                {
                  total += item;
                }
            Console.WriteLine(total);
        }
        static void Main(string[] args)
        {
            typing();
        }
    }
}
