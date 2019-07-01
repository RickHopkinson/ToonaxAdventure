using System;

namespace ToonaxAdventureGame
{
    
    class Program
    {
        public static Character player = new Character();


        public static Enemy rat1 = new Enemy("Giant Rat", 6, 8);
        public static Enemy highwayMan = new Enemy("Manchester Dan the Highwayman", 6, 8);
        public static Enemy dickTurpin = new Enemy("Dick Turpin", 10, 10);
        public static Enemy pirate1 = new Enemy("Pirate John", 9, 5);
        public static Enemy pirate2 = new Enemy("Pirate Jack", 10, 4);
        public static Enemy elon = new Enemy("Elon Musket", 12, 16);
        
        public static string yesOrNo;
        public static string nOrS;
        public static string fightOrFlee;
        public static string killOrSpare;
        
        /* The Captain of chapter 3 will be called Elon Musket but character will call him Musky and then
         he will get pissed off and then this will commence the final fight. Call the ship ShipX...
         Elon Musky can do what he wants...
        */
        static void Main(string[] args)
        { 
            Chapter1.Introduction();
            Console.ReadKey();
        }
    }
}
