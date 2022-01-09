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

        public Form currentForm;
        Home home = new Home();
        Menu menu = null;
        PricesTable pricesTable = new PricesTable();
        Settings settings = new Settings();
        IconButton selectedButton;

        public MainForm()
        {
            InitializeComponent();
            sidePanel.MouseMove += dragabbleElement_MouseMove;
            pagePanel.MouseMove += dragabbleElement_MouseMove;
            //iconPictureBox.MouseMove += dragabbleElement_MouseMove;

            this.FormClosing += (sender, e) =>
            {
                if (menu != null && menu.newmem != 0) // checks if the script has been ran
                {
                    menu.DisableScript();
                }
            };

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

            LoadForm(home, pagePanel, homeButton);
            home.label1.MouseMove += dragabbleElement_MouseMove;

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
}
