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
        public static MyPlayer myPlayer;
    }
}
