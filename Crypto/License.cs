using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Diagnostics;

namespace CSharpArmadaBot.Crypto
{
    public static class License
    {
        public static bool CheckLicense(string id)
        {
            using (var wc = new WebClient())
            {
                string response = wc.DownloadString(string.Format("http://armadabot.000webhostapp.com/get-license.php?id={0}&app={1}", id, Crypto.GetExecutingFileHash()));
                string[] array = response.Split('|');
                if (array[0] != id)
                {
                    if(array[0] == "Update")
                    {
                        DialogResult dialogResult = MessageBox.Show("New version is available! Download it now to continue.", "Update required", MessageBoxButtons.OKCancel);
                        if (dialogResult == DialogResult.OK)
                        {
                            Process.Start("http://armadabot.000webhostapp.com/download.php");
                        }
                    }
                    else if(array[0] == "Error")
                    {
                        MessageBox.Show("Error while getting license info.", "Error", MessageBoxButtons.OK);
                    }
                    Application.Exit();
                    return false;
                }
                if (array[1] == "None")
                {
                    MessageBox.Show("You are not allowed to use the bot.", "Error", MessageBoxButtons.OK);
                    Application.Exit();
                    return false;
                }
                else if (array[1] == "Expired")
                {
                    DialogResult dialogResult = MessageBox.Show("Your license has expired. Do you want to buy license now?", "License expired", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Process.Start(string.Format("http://armadabot.000webhostapp.com/buy-license.php?id={0}", id));
                    }
                    Application.Exit();
                    return false;
                }
                
                ASCIIEncoding ByteConverter = new ASCIIEncoding();
                byte[] dataToVerify = ByteConverter.GetBytes(string.Format("{0}|{1}|{2}", array[0], array[1], array[2]));
                byte[] signedData = System.Convert.FromBase64String(array[3]);

                if (Crypto.VerifySignedHash(dataToVerify, signedData))
                {
                    var expireTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                    var timestamp = (long)(Convert.ToInt64(array[2]) * TimeSpan.TicksPerSecond);
                    expireTime = new DateTime(expireTime.Ticks + timestamp, DateTimeKind.Utc);
                    MainForm.mainForm.Log($"License: {array[1]}, expires {expireTime.ToString("dd.MM.yyyy HH:mm")}");
                    return true;
                }
                else
                {
                    MessageBox.Show("Error while getting license info.", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }
        }
    }
}
