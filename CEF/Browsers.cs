using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using System.Security.Cryptography.X509Certificates;
using CefSharp.WinForms;
using CSharpArmadaBot.Bot;

namespace CSharpArmadaBot.CEF
{
    public class Browsers
    {
        public readonly ChromiumWebBrowser SeaMapBrowser;
        public readonly ChromiumWebBrowser MainSiteBrowser;
        private static string MS_Adr = "";
        private static string SM_Adr = "";
        public Browsers()
        {
            InitCEF(new CefSettings(), browserProcessHandler: null);
            SeaMapBrowser = new ChromiumWebBrowser("")
            {
                RequestHandler = new RequestHandler()
            };
            MainSiteBrowser = new ChromiumWebBrowser("");
            MainSiteBrowser.AddressChanged += MainSiteBrowser_AddressChanged;
            SeaMapBrowser.AddressChanged += SeaMapBrowser_AddressChanged;
            SeaMapBrowser.ConsoleMessage += SeaMapBrowser_ConsoleMessage;
        }

        private void SeaMapBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            SM_Adr = e.Address;
            SeaMapBrowser.LoadingStateChanged += SeaMapBrowser_LoadingStateChanged;
        }

        private void SeaMapBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                if (SM_Adr == "http://www.armadabattle.com/play")
                {
                    JavascriptResponse response;
                    Task<JavascriptResponse> task = SeaMapBrowser.EvaluateScriptAsync("(function(){return myID;})();");
                    task.GetAwaiter().OnCompleted(delegate ()
                    {
                        response = task.Result;
                        string id = (response.Success && (string)response.Result != "null" ? (string)response.Result : "0");
                        MainForm.mainForm.FreezeAndCheckLicense(id);
                        Task<bool> t = BotMethods.InitMainFunctions();
                        t.GetAwaiter().OnCompleted(delegate ()
                        {
                            MainForm.mainForm.Log(t.Result ? "Succesfully loaded functions" : "Error while loading functions");
                            BotSession.isLoggedin = true;
                        });
                    });
                    
                }
                else if (SM_Adr == "http://www.armadabattle.com/homepage")
                {
                    SeaMapBrowser.Load("http://www.armadabattle.com/play");
                    MainForm.mainForm.Log("Loading sea map...");

                }
                SeaMapBrowser.LoadingStateChanged -= SeaMapBrowser_LoadingStateChanged;
            }
        }

        private void MainSiteBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                if (MS_Adr == "http://armadabattle.com/" || MS_Adr == "http://www.armadabattle.com/")
                {
                    if (BotSession.Login != "" && BotSession.Password != "")
                    {
                        MainSiteBrowser.EvaluateScriptAsync("$( \"input[name = 'username']\" ).val(\"" + BotSession.Login + "\"); $( \"input[name = 'password']\" ).val(\"" + BotSession.Password + "\"); $( \"input[name = 'username']\" ).change(); $( \"input[name = 'password']\" ).change(); $( \"button[class='nk-btn col-md-12 col-xs-12 bg-main-2']\" ).click();");
                        MainForm.mainForm.Log("Login in...");
                    }
                    else
                    {
                        MainForm.mainForm.Log("Type in login data to log in manually, or use automatic login next time");
                    }
                    
                }
                else if (MS_Adr == "http://www.armadabattle.com/homepage")
                {
                    if (!BotSession.isLoggedin)
                    {
                        MainForm.mainForm.Log("Loading sea map...");
                        SeaMapBrowser.Load("http://www.armadabattle.com/play");
                    }
                }
                MainSiteBrowser.LoadingStateChanged -= MainSiteBrowser_LoadingStateChanged;
            }
        }

        public static void InitCEF(AbstractCefSettings settings, IBrowserProcessHandler browserProcessHandler)
        {
            //settings.CachePath = "cache";
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36";
            settings.CefCommandLineArgs.Add("no-proxy-server", "1");
            settings.CefCommandLineArgs.Add("disable-extensions", "1");
            settings.CefCommandLineArgs.Add("disable-pdf-extension", "1");
            settings.CefCommandLineArgs.Add("disable-gpu-vsync", "1");
            CefSharpSettings.SubprocessExitIfParentProcessClosed = true;
            Cef.EnableHighDPISupport();
            if (!Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: browserProcessHandler))
            {
                throw new Exception("Unable to Initialize Cef");
            }
        }

        private void MainSiteBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            MS_Adr = e.Address;
            MainSiteBrowser.LoadingStateChanged += MainSiteBrowser_LoadingStateChanged;
        }

        public static void ClearCache()
        {
            Cef.GetGlobalCookieManager().DeleteCookies("", "");
        }

        private void SeaMapBrowser_ConsoleMessage(object sender, ConsoleMessageEventArgs e)
        {
            //if (e.Source.Contains("VM"))
            //{
                MainForm.mainForm.Log(e.Message + "|" + e.Source);
                /*if (e.Message.Contains("Error"))
                {
                    Refresh();
                }*/
            //}
        }

        public void Refresh()
        {
            SeaMapBrowser.Reload(true);
        }
    }
}
