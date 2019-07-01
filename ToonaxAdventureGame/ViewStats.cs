namespace ToonaxAdventureGame
{
    public class ViewStats
    {
        public static void PlayerStats() {
            System.Console.WriteLine("NAME: " + Program.player.characterName + " || SKILL: " + Program.player.characterSkill + " || STAMINA: " + Program.player.characterStamina + "\n");
        }
        public static void EnemyStats(Enemy currentEnemy)
        {
            System.Console.WriteLine("NAME: " + currentEnemy.EnemyName + " || SKILL: " + currentEnemy.EnemySKill + " || STAMINA: " + currentEnemy.EnemyStamina + "\n");
        }

    }
}    