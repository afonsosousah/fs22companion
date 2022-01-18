using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS22Companion
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void topMostButton_Click(object sender, EventArgs e)
        {

        }

        private void gameSettingsFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.GameSettingsPath))
                browserDialog.SelectedPath = Properties.Settings.Default.GameSettingsPath;
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.GameSettingsPath = browserDialog.SelectedPath;
                gameSettingsFolderTextBox.Text = Properties.Settings.Default.GameSettingsPath;
                gameSettingsFolderTextBox.Select(gameSettingsFolderTextBox.Text.Length, 0);
                Properties.Settings.Default.Save();
            }
        }

        private void gameSettingsFolderTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GameSettingsPath = gameSettingsFolderTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
