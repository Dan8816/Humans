using System;

namespace Human
{
    public class Wizard : Homosapien
    {
        public Wizard(string person = "", int intel = 25, int hp = 50) : base(person)
        {
            name = person;
            intelligence = intel;
            health = hp;
        }
        public void heal()
        {
            health += (intelligence * 2);
        }
        public void fireball(object obj)
        {
            Homosapien enemy = obj as Homosapien;
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Attack");
            }
            else
            {
                Random rand = new Random();
                int fireball = rand.Next(20,50);
                enemy.health -= fireball;
            }
        }
    }
}