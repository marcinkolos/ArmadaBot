using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpArmadaBot.Bot
{
    public class BotSession
    {
        public static bool isLoggedin = false;
        public static string Login = "";
        public static string Password = "";
        public static List<KeyValuePair<string, int>> npcs;
        public static List<KeyValuePair<string, int>> animals;
        public static int GlitterPriority;
        public static int EventGlitterPriority;

        public static List<Entity> entities;
        public static Entity myPlayer;

        public BotSession()
        {

        }
    }
    /*
    class Comparer : IComparer<KeyValuePair<string, int>>
    {
        public int Compare(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }
            
            return x.CompareTo(y);
        }

        public int Compare(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            return x.Value.CompareTo(y.Value);
        }
    }*/
}
