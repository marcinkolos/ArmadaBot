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
            return javascriptResponse.Success;
        }

        public async static Task<object> GetJSValue(string expression)
        {
            JavascriptResponse response = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync($"(function() {{ return { expression }; }})();");
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
            string script = @"function ifLast(a, b){ if(a - b > 1) return ','; else return '';} function isPlayerMoving(){ if(typeof(ArmadaBattle.Game.myPlayer.currentMove)=='undefined') return !1; return (ArmadaBattle.Game.myPlayer.currentMove===null ? !0 : (ArmadaBattle.Game.myPlayer.currentMove.currentPathGoIndex != ArmadaBattle.Game.myPlayer.currentMove.goPositionPath.x.length));} 
            (function() { var button = $('#duplicateTabs > .modal-dialog > .modal-content > .modal-footer > button'); if($('#duplicateTabs').css('display')=='block') button.click(); })();";
            JavascriptResponse javascriptResponse = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(script);
            return javascriptResponse.Success;
        }

        public static async Task<List<Entity>> GetEntities(string group)
        {
            string command = "[]";
            switch (group)
            {
                case "animals":
                    command = @"(function(){ var out = '', g = ArmadaBattle.Game.animals;
                for(i=0; i<g.length; i++){
                    out +=`{ 'Id': '${g[i].id}', 'Nickname': '${g[i].options.nickname}', 'Hp': '${g[i].options.HP}', 'MaxHp': '${g[i].options.maxHP}', 'X': '${g[i].GUI.group.x}', 'Y': '${g[i].GUI.group.y}', 'Type': '${g[i].options.gameObjectType}'
                }${ ifLast(g.length, i) } ` 
                }
                out = `[ ${out} ]`; return out; })();";
                    break;
                case "npcs":
                    command = @"(function(){ var out = '', g = ArmadaBattle.Game.npcs;
                for(i=0; i<g.length; i++){
                    out +=`{ 'Id': '${g[i].id}', 'Nickname': '${g[i].options.nickname}', 'Hp': '${g[i].options.HP}', 'MaxHp': '${g[i].options.maxHP}', 'X': '${g[i].GUI.group.x}', 'Y': '${g[i].GUI.group.y}', 'Type': '${g[i].options.gameObjectType}'
                }${ ifLast(g.length, i) } ` 
                }
                out = `[ ${out} ]`; return out; })();";
                    break;
                case "players":
                    command = @"(function(){ var out = '', g = ArmadaBattle.Game.players;
                for(i=0; i<g.length; i++){
                    out +=`{ 'Id': '${g[i].id}', 'Nickname': '${g[i].options.nickname}', 'Hp': '${g[i].options.HP}', 'MaxHp': '${g[i].options.maxHP}', 'X': '${g[i].GUI.group.x}', 'Y': '${g[i].GUI.group.y}', 'Type': '${g[i].options.gameObjectType}'
                }${ ifLast(g.length, i) } ` 
                }
                out = `[ ${out} ]`; return out; })();";
                    break;
                case "glows":
                    command = @"(function(){ var out = '', g = ArmadaBattle.Game.glows;
                for(i=0; i<g.length; i++){
                    out +=`{ 'Id': '${g[i].id}', 'Nickname': '${g[i].options.nickname}', 'Hp': '${ 0 }', 'MaxHp': '${ 0 }', 'X': '${g[i].GUI.group.x}', 'Y': '${g[i].GUI.group.y}', 'Type': '${g[i].options.gameObjectType}'
                }${ ifLast(g.length, i) } ` 
                }
                out = `[ ${out} ]`; return out; })();";
                    break;
            }
            JavascriptResponse jsr = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(command);
            string jsonString = jsr.Result.ToString();
            if (jsr.Success)
            {
                try
                {
                    List<Entity> list = JsonConvert.DeserializeObject<List<Entity>>(jsonString);
                    foreach (Entity entity in list)
                    {
                        List<KeyValuePair<string, int>> odpowiednialista;
                        if (entity.Type == "animal") odpowiednialista = BotSession.animals;
                        else if (entity.Type == "npc") odpowiednialista = BotSession.npcs;
                        else odpowiednialista = new List<KeyValuePair<string, int>>();
                        if (entity.Type == "glow")
                        {
                            if (entity.Nickname == "Box") entity.priority = BotSession.GlitterPriority; else entity.priority = BotSession.EventGlitterPriority;
                        }
                        else
                        {
                            entity.priority = odpowiednialista.Find(key => key.Key == entity.Nickname).Value;
                        }
                        //MainForm.mainForm.Log(String.Format("ID {0}, Nickname {1}, HP {2}/{3}, X {4} | Y {5}, {6}", entity.Id, entity.Nickname, entity.Hp, entity.MaxHp, entity.X, entity.Y, entity.priority));
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

        public static async Task<Player> GetMyPlayer()
        {
            string command = @"(function(){ 
                        g = ArmadaBattle.Game.myPlayer;
                        var out =`{ 'Hp': '${g.options.HP}', 'MaxHp': '${g.options.maxHP}', 'X': '${g.GUI.group.x}', 'Y': '${g.GUI.group.y}', 'Shooting': '${(g.currentShoot!=null ? g.currentShoot.shooted.id : null)}', 'Repairing': '${g.currentRepair!=null}', 'Moving': '${isPlayerMoving()}' }`;
                        return out; })();";
            JavascriptResponse jsr = await MainForm.mainForm.br.SeaMapBrowser.EvaluateScriptAsync(command);
            string jsonString = jsr.Result.ToString();
            if (jsr.Success)
            {
                try
                {
                    Player player = JsonConvert.DeserializeObject<Player>(jsonString);
                    //MainForm.mainForm.Log(String.Format("HP {0}/{1}, X {2} | Y {3}, Moving {4}, Repairing {5}, Shooting {6}", player.Hp, player.MaxHp, player.X, player.Y, player.Moving, player.Repairing, player.Shooting));
                }
                catch (Exception ex)
                {
                    MainForm.mainForm.Log(string.Format(ex.Message));
                }
            }
            return new Player();
        }

        public static async Task<List<Entity>> GetAllEntities()
        {
            List<Entity> allEntities = new List<Entity>();
            string[] types = { "animals", "npcs", "players", "glows" };
            foreach(string type in types)
            {
                var list = await GetEntities(type);
                allEntities.AddRange(list);
            }
            return allEntities;
        }

        public Entity ChooseTarget()
        {
            int lowestPriority = BotSession.entities.Where(entity => entity.priority > 0).Min(entity => entity.priority);
            List<Entity> entitiesToChoose = BotSession.entities.FindAll(entity => entity.priority == lowestPriority);
            //Comparer comparer = new Comparer();
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
        /*
        class Comparer : IComparer<Entity>
        {
            public int Compare(Entity a, Entity b)
            {
                var x = Distance(BotSession.myPlayer.X, BotSession.myPlayer.Y, a.X, a.Y);
                var y = Distance(BotSession.myPlayer.X, BotSession.myPlayer.Y, b.X, b.Y);
                return x.CompareTo(y);
            }
        }*/
    }
}
