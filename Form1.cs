using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpArmadaBot.CEF;
using CSharpArmadaBot.Bot;
using CSharpArmadaBot.Crypto;
using System.Configuration;

namespace CSharpArmadaBot
{
    public partial class MainForm : Form
    {
        public static MainForm mainForm;
        public Browsers br;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainForm = this;
            LoadSettings(Properties.Settings.Default);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.WindowState = FormWindowState.Normal;
                NotifyIcon.Visible = true;
                NotifyIcon.ShowBalloonTip(3000, "ArmadaBot is now here", "Click on icon to resume", ToolTipIcon.Info);
            }
            else
            {
                panel1.Location = new Point((mainForm.Width/2)-(panel1.Width/2), panel1.Location.Y);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (br == null) LoadBrowsers();
            if (BotSession.isLoggedin)
            {
                if (MessageBox.Show("Do you want to relog?", "Already logged in", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return; else Browsers.ClearCache();
            }
            CreateNewSession();
            if (LoginComboBox.Text != "" && !LoginComboBox.Items.Contains(LoginComboBox.Text)) LoginComboBox.Items.Add(LoginComboBox.Text);
            br.MainSiteBrowser.Load("armadabattle.com/");
            tabControl1.SelectTab(1);
            Log("Loading main site...");
        }

        public void CreateNewSession()
        {
            BotSession.isLoggedin = false;
            BotSession.Login = LoginComboBox.Text;
            BotSession.Password = PasswordTextBox.Text;
            if(CollectChestsCheckBox.Checked)
            {
                if (!Int32.TryParse(CollectChestsPriorityTextBox.Text, out BotSession.GlitterPriority)) BotSession.GlitterPriority = 0;
            }
            if (CollectChestsCheckBox.Checked)
            {
                if (!Int32.TryParse(CollectEventChestsPriorityTextBox.Text, out BotSession.EventGlitterPriority)) BotSession.EventGlitterPriority = 0;
            }
            BotSession.npcs = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < NpcsDataGridView.Rows.Count; i++)
            {
                if ((bool)NpcsDataGridView.Rows[i].Cells[1].Value)
                {
                    BotSession.npcs.Add(new KeyValuePair<string, int>((string)NpcsDataGridView.Rows[i].Cells[0].Value, (int)NpcsDataGridView.Rows[i].Cells[2].Value));
                }
            }
            BotSession.animals = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < AnimalsDataGridView.Rows.Count; i++)
            {
                if ((bool)AnimalsDataGridView.Rows[i].Cells[1].Value)
                {
                    BotSession.animals.Add(new KeyValuePair<string, int>((string)AnimalsDataGridView.Rows[i].Cells[0].Value, (int)AnimalsDataGridView.Rows[i].Cells[2].Value));
                }
            }
        }
        
        public void FreezeAndCheckLicense(string id)
        {
            if(InvokeRequired)
            {
                this.Invoke(new Action(() => Crypto.License.CheckLicense(id)));
                return;
            }
            Crypto.License.CheckLicense(id);
        }

        public void Log(string text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { text });
                return;
            }
            LogBox.Text += string.Format("[{0}] {1}\r\n", DateTime.Now, text);
            LogBox.SelectionStart = LogBox.TextLength;
            LogBox.ScrollToCaret();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            BotTasks.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            BotTasks.Stop();
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        private void LoadBrowsers()
        {
            br = new Browsers();
            this.seaMapPanel.Controls.Add(br.SeaMapBrowser);
            seaMapPanel.Visible = true;
            seaMapPanel.Visible = false;
            this.tabControl1.TabPages[1].Controls.Add(br.MainSiteBrowser);
            br.SeaMapBrowser.Dock = DockStyle.Fill;
            br.MainSiteBrowser.Dock = DockStyle.Fill;
        }

        private void LoadNpcsDGV(Properties.Settings settings)
        {
            if(settings.Npcs != null)
            {
                for (int i = 0; i < settings.Npcs.Count; i++)
                {
                    NpcsDataGridView.Rows.Add(new object[] { settings.Npcs[i][0], (settings.Npcs[i][1] == "True"), Convert.ToInt32(settings.Npcs[i][2]) });
                }
            }
            else
            {
                LoadDefaultNpcsDGV();
            }
        }

        private void LoadAnimalsDGV(Properties.Settings settings)
        {
            if (settings.Animals != null)
            {
                for (int i = 0; i < settings.Animals.Count; i++)
                {
                    AnimalsDataGridView.Rows.Add(new object[] { settings.Animals[i][0], (settings.Animals[i][1] == "True"), Convert.ToInt32(settings.Animals[i][2]) });
                }
            }
            else
            {
                LoadDefaultAnimalsDGV();
            }
        }

        private void LoadDefaultNpcsDGV()
        {
            NpcsDataGridView.Rows.Add(new object[] { "Admiral Egyptian", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Admiral Viking", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Admiral Whydah", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Admiral Queen Anne's Revenge", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Ballistic", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Curse of Egyptians", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Viking Ship", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Faraday's Ship", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Fancy", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Whydah", false, 0 });
            NpcsDataGridView.Rows.Add(new object[] { "Queen Anne's Revenge", false, 0 });
        }

        private void LoadDefaultAnimalsDGV()
        {
            AnimalsDataGridView.Rows.Add(new object[] { "Boss Goliath", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Boss Octopus", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Boss Strong tentacle", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Boss Dragon", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Boss Strangazer", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Goonch", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Cursed Sea Turtle", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Stingray", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Goliath", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Octopus", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Weak Tentacle", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Strong Tentacle", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Dragon", false, 0 });
            AnimalsDataGridView.Rows.Add(new object[] { "Stargazer", false, 0 });
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveSettings(Properties.Settings.Default);
            Log("Saved settings");
        }

        private void SaveSettings(Properties.Settings settings)
        {
            if (settings.LoginList == null) settings.LoginList = new List<string>();
            for (int i = 0; i < LoginComboBox.Items.Count; i++)
            {
                if (!settings.LoginList.Contains(LoginComboBox.Items[i].ToString())) settings.LoginList.Add(LoginComboBox.Items[i].ToString());
            }
            settings.Npcs = new List<string[]>();
            for (int i = 0; i < NpcsDataGridView.Rows.Count; i++)
            {
                settings.Npcs.Add( new string[] { (string)NpcsDataGridView.Rows[i].Cells[0].Value, NpcsDataGridView.Rows[i].Cells[1].Value.ToString(), NpcsDataGridView.Rows[i].Cells[2].Value.ToString() });
            }
            settings.Animals = new List<string[]>();
            for (int i = 0; i < AnimalsDataGridView.Rows.Count; i++)
            {
                settings.Animals.Add(new string[] { (string)AnimalsDataGridView.Rows[i].Cells[0].Value, AnimalsDataGridView.Rows[i].Cells[1].Value.ToString(), AnimalsDataGridView.Rows[i].Cells[2].Value.ToString() });
            }
            settings.LastLogin = LoginComboBox.Text;
            settings.Password = PasswordTextBox.Text;
            settings.CollectChests = CollectChestsCheckBox.Checked;

            settings.CollectEventChests = CollectEventChestsCheckBox.Checked;
            settings.ShootNpcs = ShootNpcsCheckBox.Checked;
            settings.ShootAnimals = ShootAnimalsCheckBox.Checked;
            settings.AvoidIslands = AvoidIslandsCheckBox.Checked;
            settings.RepairingWhen = RepairingWhenTextBox.Text;
            settings.StartFightWhen = StartFightWhenTextBox.Text;
            settings.FightUntil = FightUntilTextBox.Text;
            settings.LeftRight = LeftRightCheckBox.Checked;
            settings.UpDown = UpDownCheckBox.Checked;
            settings.WhenNearBorderOrEveryXMinutes = WhenNearBorderRadioButton.Checked;
            settings.XMinutes = XMinutesTextBox.Text;
            settings.Save();
        }

        private void LoadSettings(Properties.Settings settings)
        { 
            LoginComboBox.Text = settings.LastLogin;
            PasswordTextBox.Text = settings.Password;
            CollectChestsCheckBox.Checked = settings.CollectChests;
            CollectEventChestsCheckBox.Checked = settings.CollectEventChests;
            ShootNpcsCheckBox.Checked = settings.ShootNpcs;
            ShootAnimalsCheckBox.Checked = settings.ShootAnimals;
            AvoidIslandsCheckBox.Checked = settings.AvoidIslands;
            RepairingWhenTextBox.Text = settings.RepairingWhen;
            StartFightWhenTextBox.Text = settings.StartFightWhen;
            FightUntilTextBox.Text = settings.FightUntil;
            LeftRightCheckBox.Checked = settings.LeftRight;
            UpDownCheckBox.Checked = settings.UpDown;
            if(settings.WhenNearBorderOrEveryXMinutes)
            {
                WhenNearBorderRadioButton.Checked = true;
                EveryXMinutesRadioButton.Checked = false;
            }
            else
            {
                WhenNearBorderRadioButton.Checked = false;
                EveryXMinutesRadioButton.Checked = true;
            }
            WhenNearBorderRadioButton.Checked = settings.WhenNearBorderOrEveryXMinutes;
            XMinutesTextBox.Text = settings.XMinutes;

            if (settings.LoginList != null)
            {
                foreach (string item in settings.LoginList)
                {
                    if (item != "") LoginComboBox.Items.Add(item);
                }
            }
            LoadNpcsDGV(Properties.Settings.Default);
            LoadAnimalsDGV(Properties.Settings.Default);
        }

        private void AddNpcsButton_Click(object sender, EventArgs e)
        {
            if(AddNpcTextBox.Text != "") NpcsDataGridView.Rows.Add(new object[] { AddNpcTextBox.Text, false, 0 });
            AddNpcTextBox.Text = "";
        }

        private void ResetNpcsButton_Click(object sender, EventArgs e)
        {
            NpcsDataGridView.Rows.Clear();
            LoadDefaultNpcsDGV();
            Log("Npcs table has been reset");
        }
         
        private void AddAnimalsButton_Click(object sender, EventArgs e)
        {
            if(AddAnimalTextBox.Text != "") AnimalsDataGridView.Rows.Add(new object[] { AddAnimalTextBox.Text, false, 0 });
            AddAnimalTextBox.Text = "";
        }

        private void ResetAnimalsButton_Click(object sender, EventArgs e)
        {
            AnimalsDataGridView.Rows.Clear();
            LoadDefaultAnimalsDGV();
            Log("Animals table has been reset");
        }

        private void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seaMapPanel.Visible = (tabControl1.SelectedIndex == 0);
        }
    }
}
