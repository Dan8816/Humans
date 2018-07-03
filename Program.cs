using System;

namespace Human
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Homosapien firstMan = new Homosapien("Adam", 10, 10, 7, 100);
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstMan.name, firstMan.strength, firstMan.intelligence, firstMan.dexterity, firstMan.health);
            Homosapien firstWoman = new Homosapien("Eve", 8, 10, 9, 100);
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstWoman.name, firstWoman.strength, firstWoman.intelligence, firstWoman.dexterity, firstWoman.health);
            firstMan.Attack(firstWoman, firstMan.strength);
            System.Console.WriteLine("I am {0} and I have {1} health", firstWoman.name, firstWoman.health);
            firstWoman.Attack(firstMan, firstWoman.strength);
            System.Console.WriteLine("I am {0} and I have {1} health", firstMan.name,firstMan.health);
        }
    }
}
