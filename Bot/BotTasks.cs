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
        public static string injectMainScript()
        {
            return "";
            //string script = System.IO.File.ReadAllText(@"D:\Pulpit\ArmadaBotV7.txt");
            //return (string)GetResultFromJS(@"function sleep(time){return new Promise((resolve)=>setTimeout(resolve,time))}");
            //return (string)GetResultFromJS(@"function sleep(time){return new Promise((resolve)=>setTimeout(resolve,time))}async function findNearest(array){var names=['Box'];var nearest_distance=999999;var nearest=null;for(var i=0;i<array.length;i++){if(names.indexOf(array[i].options.nickname)>-1&&ArmadaBot.banned.indexOf(array[i])==-1){var dist=await distance(ArmadaBattle.Game.myPlayer.GUI.group.x,ArmadaBattle.Game.myPlayer.GUI.group.y,array[i].GUI.group.x,array[i].GUI.group.y);if(dist<nearest_distance){nearest_distance=dist;nearest=array[i]}}}return nearest}async function distance(x1,y1,x2,y2){var x=Math.abs(x1-x2);var y=Math.abs(y1-y2);return Math.sqrt((x*x)+(y*y))}class ArmadaBot{static async main(){ArmadaBot.task='idle';ArmadaBot.lastpos_x;ArmadaBot.lastpos_y;ArmadaBot.banned=[];while(ArmadaBot.task!='off'){if(ArmadaBot.task=='need to repair')await ArmadaBot.repair();if(ArmadaBot.task=='idle'||ArmadaBot.task=='move coords'){if(ArmadaBot.task=='idle'&&(ArmadaBattle.Game.myPlayer.options.HP/ArmadaBattle.Game.myPlayer.options.maxHP)<1)ArmadaBot.task='need to repair';var found=await ArmadaBot.findItem();if(!found){if(ArmadaBot.task=='idle')ArmadaBot.moveCoords()}else{if(found.type=='glow')await ArmadaBot.collectGlitter(found);else{await ArmadaBot.goToItem(found);await ArmadaBot.killEntity(found)}}}await sleep(1000)}}static async moveCoords(){ArmadaBot.task='move coords';do{var _x=500+Math.floor((Math.random()*7000)+1);var _y=500+Math.floor((Math.random()*7000)+1)}while(await distance(ArmadaBattle.Game.myPlayer.GUI.group.x,ArmadaBattle.Game.myPlayer.GUI.group.y,_x,_y)<1500);var tilepos=ArmadaBattle.CustomHelper.getTilePosition(_x,_y);ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x,tilepos.y,ArmadaBattle.Game.game.layer));do{await sleep(1000)}while(ArmadaBot.currentMove());if(ArmadaBot.task=='move coords')ArmadaBot.task='idle';console.log('move coords - done');return true}static async goToItem(item){ArmadaBot.task='go to item';var tilepos=ArmadaBattle.CustomHelper.getTilePosition(item.GUI.group.x,item.GUI.group.y);ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x,tilepos.y,ArmadaBattle.Game.game.layer));do{await sleep(1000)}while(ArmadaBot.currentMove()!=0)console.log('go to item - done');return true}static async collectGlitter(item){ArmadaBot.task='collect glitter';var tilepos=ArmadaBattle.CustomHelper.getTilePosition(item.GUI.group.x,item.GUI.group.y);ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x,tilepos.y,ArmadaBattle.Game.game.layer));do{await sleep(1000)}while(ArmadaBot.currentMove()!=0)ArmadaBot.task='idle';console.log('collect glitter - done');return true}static async killEntity(entity){if(ArmadaBattle.Game[entity.type+'s'].indexOf(entity)==-1){ArmadaBot.deleteFromArray(entity);ArmadaBot.task='idle';return true}ArmadaBot.task='kill entity';ArmadaBattle.Player.sel(entity);if(await distance(ArmadaBattle.Game.myPlayer.GUI.group.x,ArmadaBattle.Game.myPlayer.GUI.group.y,entity.GUI.group.x,entity.GUI.group.y)>350){console.log('too far');ArmadaBot.task='idle';return true}else{ArmadaBattle.Control.shootEvent();await sleep(3000)}while(ArmadaBattle.Game.myPlayer.currentShoot!=null){if((ArmadaBattle.Game.myPlayer.options.HP/ArmadaBattle.Game.myPlayer.options.maxHP)<0.25){ArmadaBot.task='need to repair';return true}if(await distance(ArmadaBattle.Game.myPlayer.GUI.group.x,ArmadaBattle.Game.myPlayer.GUI.group.y,entity.GUI.group.x,entity.GUI.group.y)>200){var tilepos=ArmadaBattle.CustomHelper.getTilePosition(entity.GUI.group.x,entity.GUI.group.y);ArmadaBattle.Game.map.constructor.clickAnimation(ArmadaBattle.Game.game.map.getTile(tilepos.x,tilepos.y,ArmadaBattle.Game.game.layer));await sleep(1000)}var nowDate=new Date();var nowTime=nowDate.getTime();if(!ArmadaBattle.Game.myPlayer.lastShootDate)ArmadaBattle.Game.myPlayer.lastShootDate=new Date();if((nowTime-ArmadaBattle.Game.myPlayer.lastShootDate.getTime())>8000)break;await sleep(1000)}ArmadaBot.deleteFromArray(entity);ArmadaBot.task='idle';console.log('kill '+entity.options.nickname+' - done');return true}static async deleteFromArray(entity){console.log('Pushing '+entity.options.nickname+' to banned');ArmadaBot.banned.push(entity);return true}static async findItem(){var found=await findNearest(ArmadaBattle.Game.npcs);if(!found)found=await findNearest(ArmadaBattle.Game.glows);return found}static async repair(){ArmadaBot.task='repair';if(ArmadaBattle.Game.myPlayer.currentShoot!=null)ArmadaBattle.Control.cancelShootEvent(ArmadaBattle.Game.myPlayer.currentShoot);ArmadaBattle.Control.repairEvent();while(ArmadaBattle.Game.myPlayer.options.HP<ArmadaBattle.Game.myPlayer.options.maxHP){if(!ArmadaBattle.Game.myPlayer.currentRepair)return true;await sleep(1000)}if((ArmadaBattle.Game.myPlayer.options.HP==ArmadaBattle.Game.myPlayer.options.maxHP)&&ArmadaBattle.Game.myPlayer.currentRepair)ArmadaBattle.Game.myPlayer.cancelRepair(ArmadaBattle.Game.myPlayer.currentRepair);ArmadaBot.task='idle';console.log('repair - done');return true}static currentMove(){return(ArmadaBattle.Game.myPlayer.currentMove.currentPathGoIndex!=ArmadaBattle.Game.myPlayer.currentMove.goPositionPath.x.length)}static start(){ArmadaBot.task='idle';ArmadaBot.main();console.log('Starting bot...');return!0}static stop(){ArmadaBot.task='off';console.log('Stopping bot...');return!0}}");
        }

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
                BotSession.entities = await BotMethods.GetEntities();
                await Task.Delay(1000);
            }
        }
    }
}
