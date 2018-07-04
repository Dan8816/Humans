using System;

namespace Human
{
    public class Samurai : Homosapien
    {
        public Samurai(string person = "", int hp = 200) : base(person)
        {
            name = person;
            health = hp;
        }
        public void deathblow(object obj)
        {
            Homosapien enemy = obj as Homosapien;
            if (enemy == null)
            {
                System.Console.WriteLine("Failed Attack");
            }
            else
            {
                if (enemy.health < 50)
                {
                    enemy.health = 0;
                }
                if (enemy.health > 49)
                {
                    enemy.health -= 25;
                }
            }
        }
        public void meditate()
        {
            health = 200;
        }
    }
}