using System;
using System.Collections.Generic;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Human human1 = new Human("Blue", 150, 4);
            Console.WriteLine("------------");
            Console.WriteLine(human1.name);
            Console.WriteLine(human1.health);
            Console.WriteLine(human1.strength);
            Console.WriteLine(human1.intellegence);
            Console.WriteLine(human1.dexterity);

            Human human2 = new Human("Red");
            Console.WriteLine("------------");
            Console.WriteLine(human2.name);
            Console.WriteLine(human2.health);
            Console.WriteLine(human2.strength);
            Console.WriteLine(human2.intellegence);
            Console.WriteLine(human2.dexterity);

            human1.Attack(human2);
            Console.WriteLine("------------");
            Console.WriteLine(human2.health);

        }
    }
}
