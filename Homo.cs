namespace Human
{
    public class Homosapien
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public Homosapien(string GivenName, int Muscles, int Brain, int Control, int Fitness)
        {
            name = GivenName;
            strength = Muscles;
            intelligence = Brain;
            dexterity = Control;
            health = Fitness;
        }
        public void Attack(Homosapien Defender, int Attack)
        {
            if (Defender is Homosapien)
            {
                Defender.health -= (Attack*5);
            }
        }
    }
}