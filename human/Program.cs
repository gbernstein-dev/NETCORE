using System;

namespace human
{
    public class HumanBeing
    {
      public string name;
      public HumanBeing(string val)
      {
          name = val;
      }
      public int health = 100;
      public int strength = 3;
      public int intel = 3;
      public int dexterity = 3;
    }
    class Program
    {
        static void Main(string[] args)
        {
            HumanBeing human1 = new HumanBeing("Jake");
            Console.WriteLine(human1.name); 
        }
    }
}
