using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using System.Threading;

namespace CSharpArmadaBot.Bot
{
    public static class BotTasks
    {
        static CancellationTokenSource mainTokenSource;
        static CancellationToken mainToken;
        static Task entityUpdater;

        public async static void Start()
        {
            if(!BotSession.isLoggedin)
            {
                MainForm.mainForm.Log("Log in first");
                return;
            }

            if(entityUpdater!=null)
            {
                if (entityUpdater.Status == TaskStatus.WaitingForActivation)
                {
                    MainForm.mainForm.Log("Już odpalony");
                    return;
                }
            }
            mainTokenSource = new CancellationTokenSource();
            mainToken = mainTokenSource.Token;
            entityUpdater = Task.Run(() => EntityUpdater(), mainToken);
        }

        public static void Stop()
        {
            if(mainTokenSource!=null) mainTokenSource.Cancel();
        }

        public static async void MainTask()
        {
            MainForm.mainForm.Log("Starting...");
            while (!mainToken.IsCancellationRequested)
            {

            }
            mainToken.ThrowIfCancellationRequested();
        }

        public static async Task EntityUpdater()
        {
            try
            {
                while (!mainToken.IsCancellationRequested)
                {
                    BotSession.entities = await BotMethods.GetAllEntities();
                    BotSession.myPlayer = await BotMethods.GetMyPlayer();
                    await Task.Delay(250);
                    if (mainToken.IsCancellationRequested) break;
                    await Task.Delay(250);
                }
                mainToken.ThrowIfCancellationRequested();
            }
            catch(Exception ex)
            {
                MainForm.mainForm.Log(ex.Message);
            }
            
        }
    }
}
