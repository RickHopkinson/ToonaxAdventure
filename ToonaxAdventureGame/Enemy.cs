namespace ToonaxAdventureGame
{
    public class Enemy 

    {
        public string enemyName;
        public int enemySkill;
        public int enemyStamina;

        public Enemy(string enemyName, int enemySkill, int enemyStamina)
        {
            this.enemyName = enemyName;
            this.enemySkill = enemySkill;
            this.enemyStamina = enemyStamina;
        }
        public string EnemyName
        {
            get => enemyName;
            set => enemyName = value;
        }

        public int EnemySKill
        {
            get => enemySkill;
            set => enemySkill = value;
        }

        public int EnemyStamina
        {
            get => enemyStamina;
            set => enemyStamina = value;
        }
    }
}