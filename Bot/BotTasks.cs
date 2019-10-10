using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;

namespace CSharpArmadaBot.Bot
{
    public static class BotTasks
    {
        

        public static bool Start()
        {
            return false;
            //if ((string)GetResultFromJS(@"ArmadaBot.start();") == "true") return true; else return false;
        }

        public static async Task<bool> MainTask()
        {
            MainForm.mainForm.Log("Starting...");
            var a = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync("");
            var b = BotMethods.Distance(1,2,3,4);
            return true;
        }

        public static async void EntityUpdater()
        {
            while (true)
            {
                BotSession.entities = await BotMethods.GetAllEntities();
                await Task.Delay(1000);
            }
        }
    }
}
