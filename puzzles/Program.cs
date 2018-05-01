using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static void randArray()
        {   
            Random rand = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                numbers.Add(rand.Next(5,26)); 
            }
            int maxNum = numbers[0];
            int minNum = numbers[0];
            int total = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
                else if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
                total += numbers[i];
            }
            Console.WriteLine("The minimum number is {0}, the maximum is {1}. The total is {2}.", minNum, maxNum, total);
        }
        public static void tossCoin(int tosses)
        {
            double ratio = 0;
            double headsCount = 0;
            double tailsCount = 0;
            for (int i = 0; i < tosses; i++)
            {
                Console.WriteLine("Tossing a coin...");
                bool result = true;
                Random rand = new Random();
                int number = rand.Next(1,3);
                Console.WriteLine(number);
                if (number == 2)
                {
                    result = false;
                }
                if (result == false)
                {
                    headsCount += 1;
                    Console.WriteLine("Tails"); 
                }
                else
                {
                    tailsCount += 1;
                    Console.WriteLine("Heads");
                }
            ratio = headsCount/tosses;
            Console.WriteLine("There were {0} heads, {1} tails. Ratio Heads/Total: {2}.", headsCount, tailsCount, ratio);
            }
        }
        // Fisher-Yates Shuffle
        public static List<string> shuffle(string[] nameArray)
        {
            Random rand = new Random();
            List<string> bigWords = new List<string>();
            for (int i = nameArray.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = nameArray[i];
                nameArray[i] = nameArray[j];
                nameArray[j] = temp;
                if (nameArray[i].Length > 6)
                {
                    Console.WriteLine("{0} is a big name.", nameArray[i]);
                    bigWords.Add(nameArray[i]);
                }
                else
                {
                    Console.WriteLine(nameArray[i]);
                }

            }
            return bigWords;         
        }
        static void Main(string[] args)
        {
            // randArray();
            // tossCoin(10);
          shuffle(new string[]{"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"});
        }
    }
}
