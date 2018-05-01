using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        public static void oneToNine()
        {
            int[] array;
            array = new int[] {1,2,3,4,5,6,7,8,9};
            for (int idx = 0; idx < array.Length; idx++)
            {
              Console.WriteLine(array[idx]);
            }
        }
        public static void strArray()
        {
          string[] array;
          array = new string[] {"Tim", "Martin", "Nikki", "Sara"};
          for (int idx = 0; idx < array.Length; idx++)
          {
            Console.WriteLine(array[idx]);
          }

        }
        public static void boolArray()
        {
          bool[] array;
          array = new bool[] {true, false, true, false, true, false, true, false, true, false};
          for (int idx = 0; idx < array.Length; idx++)
          {
            Console.WriteLine(array[idx]);
          } 
        }
        public static void multiTable()
        {
          int limit = 10;
          int[,] array = new int[limit,limit];
          for (int idxx=1; idxx <= limit; idxx++)
          {
            for (int idxy=1; idxy <= limit; idxy++)
            {
              array[idxx - 1, idxy - 1] = idxx*idxy;
            }
          }
        }

        public static void iceCream()
        {
          List<string> iceCream = new List<string>();
          iceCream.Add("Vanilla");
          iceCream.Add("Strawberry");
          iceCream.Add("Chocolate");
          iceCream.Add("Raspberry");
          Console.WriteLine(iceCream.Count);
          Console.WriteLine(iceCream[2]);
          iceCream.RemoveAt(2);
          Console.WriteLine(iceCream.Count);
          
        }

        public static void Main(string[] args)

        {
            oneToNine();
            strArray();
            boolArray();
            multiTable();
            iceCream();
        }
    }
}
