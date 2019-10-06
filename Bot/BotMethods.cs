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
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.repairEvent();");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void CancelRepair()
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Game.myPlayer.cancelRepair(ArmadaBattle.Game.myPlayer.currentRepair);");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void Shoot()
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.shootEvent();");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void CancelShoot()
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Control.cancelShootEvent(ArmadaBattle.Game.myPlayer.currentShoot);");
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static void Select(int ID)
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(@"ArmadaBattle.Player.select(entity);");//ToDo
            MainForm.mainForm.Log((string)response.Result);
        }

        public async static Task<bool> Move(int x, int y)
        {
            JavascriptResponse javascriptResponse = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync("var tilepos = ArmadaBattle.CustomHelper.getTilePosition(item.GUI.group.x, item.GUI.group.y); ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x, tilepos.y, ArmadaBattle.Game.game.layer));");
            return (bool)javascriptResponse.Result;
        }

        public async static Task<object> GetJSValue(string expression)
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync($"(function() {{ return { expression }; }})();");
            return response.Result;
        }

        public static int Distance(int x1, int y1, int x2, int y2)
        {
            var x = Math.Abs(x1 - x2);
            var y = Math.Abs(y1 - y2);
            return (int)Math.Sqrt(((x * x) + (y * y)));
        }

        public static async Task<List<Entity>> GetEntities()
        {
            string command = @"function ifLast(a, b){ if(a - b > 1 || a > 2) return ','; else return ''; } (function(){ var out = '', g = [ArmadaBattle.Game.animals, ArmadaBattle.Game.npcs, ArmadaBattle.Game.players];
                for(j=0; j<3; j++){
                for(i=0; i<g[j].length; i++){
                    out +=`{ 'Id': '${g[j][i].id}', 'Nickname': '${g[j][i].options.nickname}', 'Hp': '${g[j][i].options.HP}', 'MaxHp': '${g[j][i].options.maxHP}', 'X': '${g[j][i].GUI.group.x}', 'Y': '${g[j][i].GUI.group.y}', 'Type': '${g[j][i].options.gameObjectType}'
                }${ ifLast(g[j].length, i) } ` 
                }}
                out = `[ ${out} ]`; return out; })();";
            JavascriptResponse jsr = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(command);
            string jsonString = jsr.Result.ToString();
            if (jsr.Success)
            {
                try
                {
                    List<Entity> list = JsonConvert.DeserializeObject<List<Entity>>(jsonString);
                    foreach(Entity entity in list)
                    {
                        List<KeyValuePair<string, int>> odpowiednialista;
                        if (entity.Type == "animal") odpowiednialista = BotSession.animals;
                        else if (entity.Type == "npc") odpowiednialista = BotSession.npcs;
                        else odpowiednialista = new List<KeyValuePair<string, int>>();
                        if(entity.Type == "glow")
                        {
                            if (entity.Nickname == "Box") entity.priority = BotSession.GlitterPriority; else entity.priority = BotSession.EventGlitterPriority;
                        }
                        else
                        {
                            entity.priority = odpowiednialista.Find(key => key.Key == entity.Nickname).Value;
                        }
                        MainForm.mainForm.Log(String.Format("ID {0}, Nickname {1}, HP {2}/{3}, X {4} | Y {5}, {6}", entity.Id, entity.Nickname, entity.Hp, entity.MaxHp, entity.X, entity.Y, entity.priority));
                    }
                }
                catch(Exception ex)
                {
                    MainForm.mainForm.Log(string.Format(ex.Message));
                }
            }
            return new List<Entity>();
        }

        public Entity ChooseTarget()
        {
            int lowestPriority = BotSession.entities.Min(entity => entity.priority);
            List<Entity> entitiesToChoose = BotSession.entities.FindAll(entity => entity.priority == lowestPriority);
            Comparer comparer = new Comparer();
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

        class Comparer : IComparer<Entity>
        {
            public int Compare(Entity a, Entity b)
            {
                var x = Distance(BotSession.myPlayer.X, BotSession.myPlayer.Y, a.X, a.Y);
                var y = Distance(BotSession.myPlayer.X, BotSession.myPlayer.Y, b.X, b.Y);
                return x.CompareTo(y);
            }
        }
    }
}
