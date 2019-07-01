using System;
using System.Threading;

namespace ToonaxAdventureGame
{
    
    public class Fight
    {
        public static void FightSequence(Enemy currentEnemy)
        {
         Start:
         Console.Clear();
         Design.GameUI();
         ViewStats.PlayerStats();
         ViewStats.EnemyStats(currentEnemy);
            if (currentEnemy.enemyStamina > 0 && Program.player.characterStamina > 0) 
            {
                Console.Clear();
                Design.GameUI();
                ViewStats.PlayerStats();
                ViewStats.EnemyStats(currentEnemy);
                int characterDice = Dice.Roll(12);
                int enemyDice = Dice.Roll(12);
                
                Console.WriteLine("Press space to roll...");
                Console.ReadKey();
                Console.WriteLine(Program.player.characterName + " rolled " + characterDice + " giving an ATTACK SKILL of " + (Program.player.characterSkill + characterDice) + "!");
                Console.WriteLine(currentEnemy.enemyName + " rolled " + enemyDice + " giving an ATTACK SKILL of " + (currentEnemy.EnemySKill + enemyDice) + "!");
                Program.player.battleCharacterSkill = Program.player.characterSkill;
                Program.player.battleCharacterSkill = Program.player.characterSkill + characterDice;
                    int battleEnemySkill = currentEnemy.EnemySKill + enemyDice;
                if (Program.player.battleCharacterSkill > battleEnemySkill)
                {
                    Console.WriteLine(Program.player.characterName + " smites the " + currentEnemy.EnemyName + " and inflicts 2 DAMAGE");
                    currentEnemy.EnemyStamina = currentEnemy.EnemyStamina - 2;
                    Console.WriteLine("Press space to continue...");
                    Console.ReadKey();
                    goto Start;

                }
                if (Program.player.battleCharacterSkill < battleEnemySkill)
                {
                    Console.WriteLine(currentEnemy.EnemyName + " attacks " + Program.player.characterName + " dealing 2 DAMAGE");
                    Program.player.characterStamina = Program.player.characterStamina - 2;
                    Console.WriteLine("Press space to continue...");
                    Console.ReadKey();
                    goto Start;
                }
                if (Program.player.battleCharacterSkill == battleEnemySkill)
                {
                    Console.WriteLine("You missed each others attacks!!!");
                    Console.WriteLine("Press space to continue...");
                    Console.ReadKey();
                    goto Start;
                }
            } else if (Program.player.characterStamina <= 0)
            {
                    Design.Dead();
                    Console.WriteLine("\nToo bad you died!");
                    Console.WriteLine("Press space to go back to the start...");
                    Console.ReadKey();
            } else if (currentEnemy.EnemyStamina <= 0)
            {
                    Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " slayed " + currentEnemy.enemyName + "!");
                    Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " replenishes 2 STAMINA!");
                    Program.player.characterStamina = Program.player.characterStamina + 2;
                    Console.WriteLine("Press space to continue...");
                    Console.ReadKey();
                    
            }

        }
    } 
    
}
