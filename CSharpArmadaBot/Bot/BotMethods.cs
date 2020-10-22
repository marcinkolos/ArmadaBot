using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using Newtonsoft.Json;


namespace CSharpArmadaBot.Bot
{
    public class BotMethods
    {
        public async static void Repair()
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.repairEvent();");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void CancelRepair()
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Game.myPlayer.cancelRepair(ArmadaBattle.Game.myPlayer.currentRepair);");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void Shoot()
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.shootEvent();");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void CancelShoot()
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.cancelShootEvent(ArmadaBattle.Game.myPlayer.currentShoot);");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void Select(int ID)
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Player.select(entity);");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static Task<bool> Move(int x, int y)
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync("var tilepos = ArmadaBattle.CustomHelper.getTilePosition(item.GUI.group.x, item.GUI.group.y); ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x, tilepos.y, ArmadaBattle.Game.game.layer));");
            return response.Success;
        }

        public async static Task<object> GetJSValue(string expression)
        {
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync($"(function() {{ return { expression }; }})();");
            return response.Result;
        }

        public static int Distance(float x1, float y1, float x2, float y2)
        {
            var x = Math.Abs(x1 - x2);
            var y = Math.Abs(y1 - y2);
            return (int)Math.Sqrt(((x * x) + (y * y)));
        }

        public async static Task<bool> InitMainFunctions()
        {
            string script = System.IO.File.ReadAllText("script.js");
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(script);
            return response.Success;
        }

        public static async Task<List<Entity>> GetEntities(Bot.EntityType group)
        {
            string command = "[]";
            switch (group)
            {
                case EntityType.Animal:
                    command = @"(function(){ return JSON.stringify(ArmadaBattle.Game.animals); })();";
                    break;
                case EntityType.Npc:
                    command = @"(function(){ return JSON.stringify(ArmadaBattle.Game.npcs); })();";
                    break;
                case EntityType.Player:
                    command = @"(function(){ return JSON.stringify(ArmadaBattle.Game.players); })();";
                    break;
                case EntityType.Glow:
                    command = @"(function(){ return JSON.stringify(ArmadaBattle.Game.glows); })();";
                    break;
            }
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(command);
            string jsonString = response.Result.ToString();
            if (response.Success)
            {
                try
                {
                    List<Entity> list = JsonConvert.DeserializeObject<List<Entity>>(jsonString);
                    foreach (Entity entity in list)
                    {
                        List<KeyValuePair<string, int>> odpowiednialista;
                        switch (entity.Type)
                        {
                            case EntityType.Animal: odpowiednialista = BotSession.animals; break;
                            case EntityType.Npc: odpowiednialista = BotSession.npcs; break;
                            default: odpowiednialista = new List<KeyValuePair<string, int>>(); break;
                        }
                        if (entity.Type == EntityType.Glow)
                        {
                            if (entity.Nickname == "Box") 
                                entity.priority = BotSession.GlitterPriority; 
                            else 
                                entity.priority = BotSession.EventGlitterPriority;
                        }
                        else
                        {
                            entity.priority = odpowiednialista.Find(key => key.Key == entity.Nickname).Value;
                        }
                    }
                    return list;
                }
                catch (Exception ex)
                {
                    MainForm.mainForm.Log(string.Format(ex.Message));
                }
            }
            return new List<Entity>();
        }

        public static async Task<MyPlayer> GetMyPlayer()
        {
            string command = @"getMyPlayer();";
            JavascriptResponse response = await MainForm.mainForm.Browsers.SeaMapBrowser.EvaluateScriptAsync(command);
            string jsonString = response.Result.ToString();
            if (response.Success)
            {
                try
                {
                    MyPlayer player = JsonConvert.DeserializeObject<MyPlayer>(jsonString);
                }
                catch (Exception ex)
                {
                    MainForm.mainForm.Log(string.Format(ex.Message));
                }
            }
            return new MyPlayer();
        }

        public static async Task<List<Entity>> GetAllEntities()
        {
            List<Entity> allEntities = new List<Entity>();
            EntityType[] types = { EntityType.Animal, EntityType.Glow, EntityType.Npc, EntityType.Player };
            foreach(EntityType entityType in types)
            {
                var list = await GetEntities(entityType);
                allEntities.AddRange(list);
            }
            return allEntities;
        }

        public Entity ChooseTarget()
        {
            int lowestPriority = BotSession.entities.Where(entity => entity.priority > 0).Min(entity => entity.priority);
            List<Entity> entitiesToChoose = BotSession.entities.FindAll(entity => entity.priority == lowestPriority);
            var lowestDistance = 999999;
            var lowestIndex = 999999;
            for(var i = 0; i < entitiesToChoose.Count; i++)
            {
                int dist = Distance(BotSession.myPlayer.X, BotSession.myPlayer.Y, entitiesToChoose[i].X, entitiesToChoose[i].Y);
                if (dist < lowestDistance)
                {
                    lowestDistance = dist;
                    lowestIndex = i;
                }
            }
            return entitiesToChoose[lowestIndex];
        }
    }
}
