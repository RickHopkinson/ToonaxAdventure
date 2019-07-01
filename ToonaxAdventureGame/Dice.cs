using System;
namespace ToonaxAdventureGame
{
    public static class Dice
    {
        public static int Roll(int face)
        {
            Random r = new Random();
            return r.Next(1, face + 1);
        }
        
        public static int Roll()
        {
            Random r = new Random();
            return r.Next(1, 7);
        }
        
    }
}
