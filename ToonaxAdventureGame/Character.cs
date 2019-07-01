namespace ToonaxAdventureGame
{
    public class Character
    {
        public string birthName;
        public string characterName;
        public int characterSkill = 6;
        public int characterStamina = 10;
        public int battleCharacterSkill;
        public static int battleEnemySkill;

        public Character()
        {
        }

        public string BirthName
        {
            get => birthName;
            set => birthName = value;
        }

        public string CharacterName
        {
            get => characterName;
            set => characterName = value;
        }

        public int CharacterSkill
        {
            get => characterSkill;
            set => characterSkill = value;
        }

        public int CharacterStamina
        {
            get => characterStamina;
            set => characterStamina = value;
        }

        public int BattleCharacterSkill
        {
            get => battleCharacterSkill;
            set => battleCharacterSkill = value;
        }

        public static int BattleEnemySkill
        {
            get => battleEnemySkill;
            set => battleEnemySkill = value;
        }
    }
}

