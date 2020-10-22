using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArmadaBot.Bot
{
    public static class BotSettings
    {
        public static StringCollection Login = new StringCollection() { };
        public static string LastLogin;
        public static string Password = "";
        public static object[][] NpcsDGV =
        {
            new object[] { "Admiral egyptian", false, 0 },
            new object[] { "Admiral viking", false, 0 },
            new object[] { "Admiral whydah", false, 0 },
            new object[] { "Admiral queen anne's revenge", false, 0 },
            new object[] { "Ballistic", false, 0 },
            new object[] { "Curse of egyptians", false, 0 },
            new object[] { "Viking ship", false, 0 },
            new object[] { "Faraday's ship", false, 0 },
            new object[] { "Fancy", false, 0 },
            new object[] { "Whydah", false, 0 },
            new object[] { "Queen anne's revenge", false, 0 }
        };
        public static object[][] AnimalsDGV =
        {
            new object[] { "Boss goliath", false, 0 },
            new object[] { "Boss octopus", false, 0 },
            new object[] { "Boss strong tentacle", false, 0 },
            new object[] { "Boss dragon", false, 0 },
            new object[] { "Boss strangazer", false, 0 },
            new object[] { "Goonch", false, 0 },
            new object[] { "Goonch", false, 0 },
            new object[] { "Cursed sea turtle", false, 0 },
            new object[] { "Stingray", false, 0 },
            new object[] { "Goliath", false, 0 },
            new object[] { "Octopus", false, 0 },
            new object[] { "Weak tentacle", false, 0 },
            new object[] { "Strong tentacle", false, 0 },
            new object[] { "Dragon", false, 0 },
            new object[] { "Stargazer", false, 0 }
        };
        public static bool CollectChests = false;
        public static bool CollectEventGlitters = false;
        public static bool ShootNpcs = false;
        public static bool ShootAnimals = false;
        public static bool AvoidIslands = false;
        public static int RepairWhen = 0;
        public static int StartFight = 0;
        public static int FightUntil = 0;
        public static bool ChangeMapLeftRight = false;
        public static bool ChangeMapUpDown = false;
        public static bool ChangeMapWhenNearBorder = false;
    }
}
