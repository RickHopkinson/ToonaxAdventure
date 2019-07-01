using System;


namespace ToonaxAdventureGame
{
    public class Chapter2
    {
        public static void beginChapter2()
        {
            Console.Clear();
            Design.ChapterTwo();
            Console.Clear();
            Design.GameUI();
            Console.WriteLine("Draco looks around to see if the coast is clear...\n'You're going to do well " + Program.player.characterName + " of " + Program.player.birthName + "\nnow go! Get out of here and don't look back!'");
            Console.WriteLine("You look out across the land and see a harbour to the South. Maybe you can travel somewhere.\nTo the North there is a Castle. Where will you go?");
            Console.WriteLine("type 'N' to go North or type 'S' to go South...");
            Program.nOrS = Console.ReadLine();
            if (Program.nOrS == "n" || Program.nOrS == "N")
            {
                Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " marches onwards towards the dark castle...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                castle();
            } else if (Program.nOrS == "s" || Program.nOrS == "S")
            {
                Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " marches onwards towards the harbour... ");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                harbour();
            }
        }

        public static void castle()
        {
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Marching towards the castle you notice a two highwaymen coming towards you. \nWill you stand and fight or flee?");
            Console.WriteLine("Type 'Fight' to face them or 'Flee' to try and avoid them...");
            Program.fightOrFlee = Console.ReadLine();
            if (Program.fightOrFlee == "Fight" || Program.fightOrFlee == "fight")
            {
                Console.WriteLine("Prepare for battle!!!!");
                Console.WriteLine("Press any key to continue...");
                Fight.FightSequence(Program.highwayMan);
            } else if (Program.fightOrFlee == "Flee" || Program.fightOrFlee == "flee")
            {
                Console.WriteLine("You try and flee but the Highwaymen were aware of your tactics...");
                Console.WriteLine("You lose 2 STAMINA for being such a coward...");
                Program.player.characterStamina = Program.player.characterStamina - 2;
                Console.WriteLine("Press any key to continue...");
                Fight.FightSequence(Program.highwayMan);
            }

            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Dick Turpin: 'You killed my best mate you bastard! You will pay for this!'");
            Console.WriteLine("Prepare for battle!");
            Console.ReadKey();
            Fight.FightSequence(Program.dickTurpin);
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Dick Turpin lays on the floor begging you to spare his life. What will you do?");
            Console.WriteLine("Press 'K' to finish off Dick Turpin or 'S' to spare him...");
            Program.killOrSpare = Console.ReadLine();
            if (Program.killOrSpare == "k" || Program.killOrSpare == "K")
            {
                Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " clenches his fist once more and \n sees Dick Turpin on his knees. The knuckes bust through his face...");
                Console.WriteLine("Dick Turpin is Dead...");
                Console.WriteLine("You lose 1 SKILL for being so Evil...");
                Program.player.characterSkill = Program.player.characterSkill - 1; 
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            } else if (Program.killOrSpare == "s" || Program.killOrSpare == "S")
            {
                Console.WriteLine("Dick Turpin is very thankful and gives you his sword...");
                Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " received Great Sword of Justice...");
                Console.WriteLine("You gain 2 SKILL...");
                Program.player.characterSkill = Program.player.characterSkill + 2;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }

            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("This was not a good route to take. Ahead you see multiple people coming from the castle.\nYou turn around.");
            Console.WriteLine("You sprint back the way you came and lose 1 STAMINA from over working yourself.");
            Program.player.characterStamina = Program.player.characterStamina - 1;
            Console.WriteLine("Press any key to continue....");
            Console.ReadLine();
            harbour();
        }

        public static void harbour()
        {
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine(
                "You arrive at the harbour. You need to get a ship out of here to really be a free man.\nLooks like you are going to have to commandeer one. ");
            Console.WriteLine(
                "You jump onto the first ship that you see. Infested with pirates you know you're going\nto have to fight your way through...");
            Console.WriteLine("Elon Musket of the ShipX approaches you...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine(
                "Elon Musket: 'I am Elon Musket! Captain of the Great ShipX!\nI can tell by that awful accent that you are from " +
                Program.player.birthName + "! You won't last on here!\nTake him down!!' ");
            Console.WriteLine("Two pirates surround you. Looks like we are fighting though this one...");
            Console.WriteLine("Pirate Jack: 'You're going down!'");
            Console.WriteLine("Prepare for battle...\nPress any key to continue...");
            Console.ReadKey();
            Fight.FightSequence(Program.pirate2);
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Now the first pirate is done and dusted the other charges...");
            Console.WriteLine("Pirate John: 'AAAARRRRRGGGGHHHHHHHHHHH!'");
            Console.WriteLine("Prepare for battle...\nPress any key to continue...");
            Console.ReadKey();
            Fight.FightSequence(Program.pirate1);
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Elon Musket: 'I can't believe you killed two my best men!! Looks like I am \ngoing to have to take you down myself!'");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Feeling weak you scurry around the dead bodies of the pirates...");
            Console.WriteLine("Luckily you find a potion to heal your wounds...");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Program.player.characterStamina = Program.player.characterStamina + 10;
            Console.WriteLine(Program.player.characterName + " of " + Program.player.birthName + " gained 10 STAMINA from drinking the potion...");
            Console.Clear();
            Design.GameUI();
            ViewStats.PlayerStats();
            Console.WriteLine("Prepare for battle!");
            Console.WriteLine("Press any key to continue and take down Elon Musket!...");
            Console.ReadKey();
            Fight.FightSequence(Program.elon);
            Console.Clear();
            Design.GameUI();
            Console.WriteLine("Elon Musket is dead. The other pirates bow down to you...");
            Console.WriteLine("You get behind the wheel and move the ship out of the harbour...\nYou are a free man and you've got a ship. Nice one. ");
            Console.WriteLine("Thank you for playing....");
            Environment.Exit(0);


        }
    }
}

