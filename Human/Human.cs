namespace Human{
    public class Human{
        public int strength = 3;
        public string name;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public Human(string val){
            name = val;
        }
        public Human(string n, int str, int intel, int dex, int hlth){
            name = n;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hlth;
        }
        public int Attack(object Human){
            if (Human is Human){
                health -= 5 * strength;
            }
            return health;
        }
    }
}