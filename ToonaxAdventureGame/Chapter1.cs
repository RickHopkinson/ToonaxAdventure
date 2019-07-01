namespace ToonaxAdventureGame
{
    public class Chapter1
    {
        
        public static void Introduction()
        {
            System.Console.Clear();
            Design.GameUI();
            System.Console.WriteLine("Welcome to the world of Toonax!\nThis is a word adventurer game that will test your luck, courage and determination!");
            System.Console.WriteLine("Let's begin!");
            System.Console.WriteLine("Press enter to continue...");
            System.Console.ReadKey();
            CharacterCreation();
        }
        public static void CharacterCreation()
        {
            System.Console.Clear();
            Design.GameUI();
            System.Console.WriteLine("You wake up in a prison, a mysterious figure walks down the hall towards your cell...");
            System.Console.WriteLine("'I've heard stories of you boy...Where were you born?'");
            Program.player.birthName = System.Console.ReadLine();
            if(Program.player.birthName == "rochdale" || Program.player.birthName == "Rochdale")
            {
                System.Console.WriteLine("'" + Program.player.birthName + "!?!?! You disgrace! I will smite you where you stand!");
                System.Console.WriteLine("Furious with where you a from the scary man fires an arrow through the bars.\nYou DIED...");
                System.Console.ReadKey();
                Introduction();
            } else
            {
                System.Console.WriteLine("'" + Program.player.birthName + "...Interesting. And what is your name?'");
                Program.player.characterName = System.Console.ReadLine();

                System.Console.WriteLine("'" + Program.player.characterName + " of " + Program.player.birthName + "! I knew I had heard that name before. I'm Draco of Newquay and I'm here to get you out of here.'");
                System.Console.WriteLine("He smashes the cell door open. You are free...");
                System.Console.WriteLine("Press enter to continue...");
                System.Console.ReadKey();
                CreateStats();
            }
           
        }
        public static void CreateStats()
        {
            int skillDice = Dice.Roll();
            int staminaDice1 = Dice.Roll();
            int staminaDice2 = Dice.Roll();
            System.Console.Clear();
            Design.GameUI();
            System.Console.WriteLine("So, " + Program.player.characterName + " of " + Program.player.birthName + " it is time to roll for your stats.");
            //Console.WriteLine("Would you like to know how it works?");
            System.Console.WriteLine("We will first roll for your SKILL. SKILL will be used in combat and will help you defeat your enemies!");
            System.Console.WriteLine("Press space to roll the dice...");
            System.Console.ReadKey();
            System.Console.WriteLine("You rolled a " + skillDice + " plus your base of 6 which means your SKILL is " + (skillDice + Program.player.characterSkill) + "!");
            Program.player.characterSkill = Program.player.characterSkill + skillDice;
            // Is there a better way of including dice1 + dice 2 + dice 3 in the string? Look at concatination in C#
            System.Console.WriteLine("Press enter to continue...");
            System.Console.ReadKey();
            System.Console.WriteLine("Now it is time to roll for your STAMINA! STAMINA will be used in combat to determine how much health you have!");
            System.Console.WriteLine("You will roll two dice for this...");
            System.Console.WriteLine("Press space to roll the dice...");
            System.Console.ReadKey();
            System.Console.WriteLine("You rolled a " + staminaDice1 + " and a " + staminaDice2 + " plus your base of 10 which means your STAMINA is " + (staminaDice1 + staminaDice2 + Program.player.characterStamina) + "!");
            Program.player.characterStamina = Program.player.characterStamina + staminaDice1 + staminaDice2;
            System.Console.WriteLine("Now you have your stats it's time to put them to practice!");
            System.Console.WriteLine("Press enter to continue...");
            System.Console.ReadKey();
            FirstFight();
            
        }
       
        public static void FirstFight()
        {
            System.Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            System.Console.WriteLine("A Giant Rat is blocking the cell door opening...");
            System.Console.WriteLine("It's time for your first fight!");
            System.Console.WriteLine("Press enter to continue...");
            System.Console.ReadKey();
            System.Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            System.Console.WriteLine("Would you like to know how fighting works in Toonax?");
            System.Console.WriteLine("Type 'Y' if you want to read them. Type 'N' if you already know what you are doing...");
            Program.yesOrNo = System.Console.ReadLine();
            if(Program.yesOrNo == "y" || Program.yesOrNo == "Y")
            {
                FightInstructions();
            } else
            {
                FirstEncounter();
                
                System.Console.Clear();
                Design.GameUI();
                ViewStats.PlayerStats(); 
                System.Console.WriteLine("Great job! " + Program.player.characterName + " You have proven you have what it takes to become a true Hero of Toonax!\nNow let us move onto the next chapter in your life!"); 
                System.Console.WriteLine("Press any key to continue onto CHAPTER 2..."); 
                System.Console.ReadKey();
                Chapter2.beginChapter2();
                
            }
        }
        public static void FirstEncounter()
        {
            System.Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            ViewStats.EnemyStats(Program.rat1);
            Fight.FightSequence(Program.rat1);
        }
        
        public static void FightInstructions()
        {
            System.Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            System.Console.WriteLine("You are rolling two dice against the enemy. The total of the two dice will \nbe added to your current SKILL stat and if it is greater \nthan the enemies SKILL total then you will inflict damage on their STAMINA.\n You will keep rolling until one of you has been killed. Good Luck " + Program.player.characterName);
            System.Console.WriteLine("Press enter to return to the battle...");
            System.Console.ReadKey();
            FirstEncounter();
        }
       
    }
}