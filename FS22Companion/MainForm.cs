using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Diagnostics;
using Octokit;

namespace FS22Companion
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public Form currentForm;
        Home home = new Home();
        Menu menu = null;
        GameSettingsManager gameSettingsManager = new GameSettingsManager();
        PricesTable pricesTable = new PricesTable();
        Settings settings = new Settings();
        IconButton selectedButton;

        string version = "1.1.0";

        public MainForm()
        {
            InitializeComponent();
            sidePanel.MouseMove += dragabbleElement_MouseMove;
            pagePanel.MouseMove += dragabbleElement_MouseMove;
            home.label1.MouseMove += dragabbleElement_MouseMove;
            gameSettingsManager.settingPanel.MouseMove += dragabbleElement_MouseMove;

            // Check for updates
            CheckVersion();

            this.FormClosing += (sender, e) =>
            {
                if (menu != null && menu.newmem != 0) // checks if the script has been ran
                {;
                    menu.DisableScript();
                }
            };

            // Game Settings Path
            if (Properties.Settings.Default.GameSettingsPath.Length == 0)
            {
                Properties.Settings.Default.GameSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents\\My Games\\FarmingSimulator2022";
            }
            settings.gameSettingsFolderTextBox.Text = Properties.Settings.Default.GameSettingsPath;
            settings.gameSettingsFolderTextBox.Select(settings.gameSettingsFolderTextBox.Text.Length, 0);

            RegisterHotKey(this.Handle, 1, Constants.NOMOD, (int)Keys.Insert);
            RegisterHotKey(this.Handle, 2, Constants.CTRL, (int)Keys.Q);

            if (Process.GetProcessesByName("FarmingSimulator2022Game").Length > 0)
            {
                home.gameStatusButton.Text = "Game Running";
                home.gameStatusButton.FillColor = Color.LimeGreen;
            }
            else
            {
                home.gameStatusButton.Text = "Game Closed";
                home.gameStatusButton.FillColor = Color.Red;
            }

            settings.topMostButton.Click += (sender, e) =>
            {
                if (this.TopMost)
                    this.TopMost = false;
                else if (!this.TopMost)
                    this.TopMost = true;
            };

            foreach (Control control in sidePanel.Controls)
            {
                if (control.GetType() == typeof(IconButton))
                {
                    var otherButton = control as IconButton;
                    otherButton.MouseEnter += (sender, e) =>
                    {
                        if (selectedButton.Name != control.Name)
                        {
                            otherButton.IconColor = Color.WhiteSmoke;
                        }
                    };
                    otherButton.MouseLeave += (sender, e) =>
                    {
                        if (selectedButton.Name != control.Name)
                        {
                            otherButton.IconColor = Color.FromArgb(38, 194, 243);
                        }
                    };
                }
            }

            MemoryFonts.AddMemoryFont(Properties.Resources.helvetica_light);

            LoadForm(home, pagePanel, homeButton);
        }

        private void HandleHotkey1()
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                switch (id)
                {
                    case 1:
                        if (this.Visible && this.TopMost)
                        {
                            this.TopMost = false;
                            this.SendToBack();
                            this.WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            this.TopMost = true;
                            this.Show();
                            this.WindowState = FormWindowState.Normal;
                            this.Focus();
                        }
                        break;
                    case 2:
                        menu.activateGPSButton.PerformClick();
                        break;
                }
            }

            base.WndProc(ref m);
        }

        private void LoadForm(Form form, Panel panel, IconButton button)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.StartPosition = FormStartPosition.CenterParent;
            panel.Controls.Add(form);
            form.Show();
            currentForm = form;
            form.MouseMove += dragabbleElement_MouseMove;
            SelectedButton(button);
        }

        public async void CheckVersion()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("afonsosousah"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("afonsosousah", "fs22companion");

            //Setup the versions
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(version);

            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                //The version on GitHub is more up to date than this local release.
                CustomMessageBox.Show("There is a newer version available on GitHub!", MessageBoxButtons.OK);
            }
            else if (versionComparison > 0)
            {
                //This local version is greater than the release version on GitHub.
                CustomMessageBox.Show("This is a beta build!", MessageBoxButtons.OK);
            }
            else
            {
                //This local Version and the Version on GitHub are equal.
            }
        }

        private void SelectedButton(IconButton button)
        {
            foreach(Control control in sidePanel.Controls)
            {
                if(control.GetType() == typeof(IconButton))
                {
                    var otherButton = control as IconButton;
                    otherButton.BackColor = Color.FromArgb(31, 42, 48);
                    otherButton.IconColor = Color.FromArgb(38, 194, 243);
                }
            }
            button.BackColor = Color.FromArgb(38, 194, 243);
            button.IconColor = Color.WhiteSmoke;
            selectedButton = button;
        }

        private void dragabbleElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Font = FontAwesome.Sharp.
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            LoadForm(home, pagePanel, homeButton);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if(menu != null)
            {
                LoadForm(menu, pagePanel, menuButton);
            }
            else if (Process.GetProcessesByName("FarmingSimulator2022Game").Length > 0)
            {
                if (CustomMessageBox.Show("Code is going to be injected in your game, making it more unstable and can lead to crashes. Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (menu == null)
                        menu = new Menu();
                    LoadForm(menu, pagePanel, menuButton);
                }
            }
            else
            {
                CustomMessageBox.Show("Game is not running", MessageBoxButtons.OK);
            }
        }

        private void gameSaveManagerButton_Click(object sender, EventArgs e)
        {
            LoadForm(gameSettingsManager, pagePanel, gameSaveManagerButton);
        }

        private void pricesTableButton_Click(object sender, EventArgs e)
        {
            LoadForm(pricesTable, pagePanel, pricesTableButton);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            LoadForm(settings, pagePanel, settingsButton);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    public static class Constants
    {
        //modifiers
        public const int NOMOD = 0x0000;
        public const int ALT = 0x0001;
        public const int CTRL = 0x0002;
        public const int SHIFT = 0x0004;
        public const int WIN = 0x0008;


        //windows message id for hotkey
        public const int WM_HOTKEY_MSG_ID = 0x0312;
    }

}
