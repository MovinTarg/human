namespace Human {
    public class Human {
        public string name;
        public int health;
        public int strength;
        public int intellegence;
        public int dexterity;

        public Human(string inputName = "Link", int inputHealth = 100, int inputStrength = 3, int inputIntellegence = 3, int inputDexterity = 3){
            name = inputName;
            health = inputHealth;
            strength = inputStrength;
            intellegence = inputIntellegence;
            dexterity = inputDexterity;
        }

        // public void Attack(Human target){
        //     target.health -= 5*strength;
        // }
        public void Attack(Human target){
            Human enemy = target as Human;
            if(enemy != null) {
                enemy.health -= 5*strength;
            }
        }
    }
}