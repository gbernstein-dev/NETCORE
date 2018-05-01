using System;

namespace basic13
{
    class Program
    {   
        public static void rangeFxn()
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void oddRangeFxn()
        {
            for (int i = 0; i <= 255; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void totalRangeFxn()
        {
            int total = 0;
            for (int i = 0; i <= 255; i++)
            {
                total += i;
                Console.WriteLine("Current Number: {0}, Current Total: {1}",i,total);
            }
        }
        public static void innerArrayFxn(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void minMaxAverage(int[] array)
        {
            int maxInt = array[0];
            int minInt = array[0];
            double total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxInt)
                {
                    maxInt = array[i];
                }
                if (array[i] < minInt)
                {
                    minInt = array[i];
                }
                total += array[i];
            }
            double average = total/array.Length;
            Console.WriteLine("The maximum is {0}, the minimum is {1} and the average is {2}.", maxInt, minInt, average);
        }
        public static void greaterThanY(int[] array, int y)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > y)
                {
                    Console.WriteLine("{0} is greater than {1}.",array[i],y);
                }
            }
        }
        public static void squareValues(int[] array)
        {
          for (int i = 0; i < array.Length; i++)
          {
              array[i] = array[i]*array[i];
              Console.WriteLine(array[i]);    
          }
        }
        public static void noNegatives(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
                Console.WriteLine(array[i]);
            }
        }
        public static void shift(int[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i+1];
            }
            array[array.Length-1] = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void numToStr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] < 0)
                {
                  Console.WriteLine(array[i]);   
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].GetType());
            }
        }
        public static void Main(string[] args)
        {
            rangeFxn();
            oddRangeFxn();
            totalRangeFxn();
            innerArrayFxn(new int[] {1,3,5,7,9});
            minMaxAverage(new int[] {6,3,4,9,2});
            greaterThanY(new int[] {8,1,5,2,4}, 3);
            squareValues(new int[] {1,3,5,7,9});
            noNegatives(new int[] {-1,3,-3,-4,5});
            shift(new int[] {1,3,5,7,9});
            numToStr(new int[] {-1,3,-3,-4,5});
        }
    }
}
