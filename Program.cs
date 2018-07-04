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
            //firstMan.attack(firstWoman);
            System.Console.WriteLine("I am {0} and I have {1} health", firstWoman.name, firstWoman.health);
            //firstWoman.attack(firstMan);
            System.Console.WriteLine("I am {0} and I have {1} health", firstMan.name,firstMan.health);
            Wizard firstWiz = new Wizard("Merlin");
            System.Console.WriteLine("I am {0} and I have {1} intelligence, and {2} health", firstWiz.name, firstWiz.intelligence, firstWiz.health);
            firstWiz.fireball(firstMan);
            firstMan.attack(firstWiz);
            System.Console.WriteLine("I am {0} and I have {1} health", firstMan.name,firstMan.health);
            System.Console.WriteLine("I am {0} and I have {1} health", firstWiz.name, firstWiz.health);
            firstWiz.heal();        
            System.Console.WriteLine("I am {0} and I have {1} health", firstWiz.name, firstWiz.health);
            Ninja firstNinja = new Ninja("Ryoku");
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstNinja.name, firstNinja.strength, firstNinja.intelligence, firstNinja.dexterity, firstNinja.health);
            firstNinja.steal(firstWoman);
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstWoman.name, firstWoman.strength, firstWoman.intelligence, firstWoman.dexterity, firstWoman.health);
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstNinja.name, firstNinja.strength, firstNinja.intelligence, firstNinja.dexterity, firstNinja.health);
            firstNinja.get_away(firstMan);
            System.Console.WriteLine("I am {0} and I have {1} health", firstMan.name,firstMan.health);
            Samurai firstSam = new Samurai("Tom Cruise");
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstSam.name, firstSam.strength, firstSam.intelligence, firstSam.dexterity, firstSam.health);
            firstSam.deathblow(firstMan);
            System.Console.WriteLine("I am {0} and I have {1} health", firstMan.name,firstMan.health);
            firstMan.attack(firstSam);
            firstWoman.attack(firstSam);
            firstWiz.fireball(firstSam);
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstSam.name, firstSam.strength, firstSam.intelligence, firstSam.dexterity, firstSam.health);
            firstSam.meditate();
            System.Console.WriteLine("I am {0} and I have {1} strength, {2} intelligence, {3} dexterity, {4} health", firstSam.name, firstSam.strength, firstSam.intelligence, firstSam.dexterity, firstSam.health);
        }
    }
}
