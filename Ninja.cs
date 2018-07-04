using System;

namespace Human
{
    public class Ninja : Homosapien
    {
        public Ninja(string person = "", int dex = 175) : base(person)
        {
            name = person;
            dexterity = dex;
        }
        public void steal(object obj)
        {
            Homosapien enemy = obj as Homosapien;
            if (enemy == null)
            {
                System.Console.WriteLine("Nothing to steal");
            }
            else
            {
                enemy.intelligence -= 1;
                health += 1;
            }
        }
        public void get_away(object obj)
        {
            Homosapien enemy = obj as Homosapien;
            if (enemy == null)
            {
                System.Console.WriteLine("Noone to get away from");
            }
            else
            {
                enemy.health -= 1;
            }
        }
    }
}