using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace FS22Companion
{
    public partial class GameSettingsManager : Form
    {
        public Dictionary<string,GameSetting> gameSettingsCollection;
        GameSetting selectedSetting;
        string modFolder;

        public GameSettingsManager()
        {
            InitializeComponent();
        }

        private void GameSettingsManager_Load(object sender, EventArgs e)
        {
            gameSettingsCollection = JsonConvert.DeserializeObject<Dictionary<string, GameSetting>>(Properties.Settings.Default.GameSettingsDictionary);

            if (gameSettingsCollection == null)
                gameSettingsCollection = new Dictionary<string, GameSetting>();

            XmlSerializer serializer = new XmlSerializer(typeof(GameSetting));
            var gameSetting = new GameSetting();
            using (Stream stream = new FileStream(Properties.Settings.Default.GameSettingsPath + "\\gameSettings.xml", FileMode.Open))
            {
                gameSetting = (GameSetting)serializer.Deserialize(stream);
                gameSetting.Name = "Current Setting";
            }
            gameSettingsCollection["Current Setting"] = gameSetting;
            //MessageBox.Show(JsonConvert.SerializeObject(i));

            UpdateDictionaryEntries();
        }

        public void UpdateDictionaryEntries()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (var entry in gameSettingsCollection)
            {
                GameSetting gameSetting = entry.Value;

                Guna2Button entryLabel = new Guna2Button();
                entryLabel.Text = gameSetting.Name;
                entryLabel.Name = gameSetting.Name;
                entryLabel.Font = new Font("Segoe UI", 12F);
                entryLabel.ForeColor = Color.FromArgb(57, 187, 223);
                entryLabel.FillColor = Color.FromArgb(31, 42, 48);
                entryLabel.AutoSize = false;
                entryLabel.Size = new Size(195, 35);
                entryLabel.HoverState.FillColor = Color.FromArgb(57, 187, 223);
                entryLabel.HoverState.ForeColor = Color.FromArgb(31, 42, 48);

                entryLabel.Click += (sender, e) =>
                {
                    selectedSetting = gameSetting;
                    ShowSettingPanel(gameSetting);
                };

                flowLayoutPanel.Controls.Add(entryLabel);
            }
        }

        public void ShowSettingPanel(GameSetting setting)
        {
            settingNameTextBox.Text = setting.Name;
            modDirectoryOverrideCheckBox.Checked = setting.modsDirectoryOverride.active;
            modFolderTextBox.Text = setting.modsDirectoryOverride.directory;
            usernameTextBox.Text = setting.onlinePresenceName;
            serverNameTextBox.Text = setting.joinGame.serverName;
            serverPasswordTextBox.Text = setting.joinGame.password;
            settingPanel.Show();
        }

        private void addGameSettingsButton_Click(object sender, EventArgs e)
        {
            if(gameSettingsCollection.ContainsKey("New Setting"))
            {
                CustomMessageBox.Show("\"New Setting\" already exists!", MessageBoxButtons.OK);
            }
            else
            {
                var gameSetting = new GameSetting("New Setting", true, "", "", "", "");
                gameSettingsCollection.Add("New Setting", gameSetting);
                Properties.Settings.Default.GameSettingsDictionary = JsonConvert.SerializeObject(gameSettingsCollection);
                Properties.Settings.Default.Save();
                UpdateDictionaryEntries();
            }
        }

        private void saveSettingButton_Click(object sender, EventArgs e)
        {
            if (CustomMessageBox.Show("Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var oldName = selectedSetting.Name;
                gameSettingsCollection.Remove(oldName);
                selectedSetting = new GameSetting(settingNameTextBox.Text, modDirectoryOverrideCheckBox.Checked, modFolderTextBox.Text, usernameTextBox.Text, serverNameTextBox.Text, serverPasswordTextBox.Text);
                gameSettingsCollection[selectedSetting.Name] = selectedSetting;
                Properties.Settings.Default.GameSettingsDictionary = JsonConvert.SerializeObject(gameSettingsCollection);
                Properties.Settings.Default.Save();
                settingPanel.Hide();

                XDocument doc = new XDocument();
                using (Stream stream = new FileStream(Properties.Settings.Default.GameSettingsPath + "\\gameSettings.xml", FileMode.Open))
                {
                    doc = XDocument.Load(stream);
                    doc.Root.Element((XName)"modsDirectoryOverride").Attribute((XName)"active").SetValue(modDirectoryOverrideCheckBox.Checked);
                    doc.Root.Element((XName)"modsDirectoryOverride").Attribute((XName)"directory").Value = modFolderTextBox.Text;
                    doc.Root.Element((XName)"onlinePresenceName").Value = usernameTextBox.Text;
                    doc.Root.Element((XName)"joinGame").Attribute((XName)"serverName").Value = serverNameTextBox.Text;
                    doc.Root.Element((XName)"joinGame").Attribute((XName)"password").Value = serverPasswordTextBox.Text;
                }
                doc.Save(Properties.Settings.Default.GameSettingsPath + "\\gameSettings.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(GameSetting));
                var gameSetting = new GameSetting();
                using (Stream stream = new FileStream(Properties.Settings.Default.GameSettingsPath + "\\gameSettings.xml", FileMode.Open))
                {
                    gameSetting = (GameSetting)serializer.Deserialize(stream);
                    gameSetting.Name = "Current Setting";
                }
                gameSettingsCollection["Current Setting"] = gameSetting;

                UpdateDictionaryEntries();
            }
        }

        private void modFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(modFolder))
                browserDialog.SelectedPath = modFolder;
            if(browserDialog.ShowDialog() == DialogResult.OK)
            {
                modFolder = browserDialog.SelectedPath;
                modFolderTextBox.Text = modFolder;
                modFolderTextBox.Select(modFolderTextBox.Text.Length, 0);
            }
        }

        private void deleteGameSettingButton_Click(object sender, EventArgs e)
        {
            if(selectedSetting.Name == "Current Setting")
            {
                CustomMessageBox.Show("Current Setting can't be deleted", MessageBoxButtons.OK);
            }
            else if (CustomMessageBox.Show("Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gameSettingsCollection.Remove(selectedSetting.Name);
                Properties.Settings.Default.GameSettingsDictionary = JsonConvert.SerializeObject(gameSettingsCollection);
                Properties.Settings.Default.Save();
                settingPanel.Hide();
                UpdateDictionaryEntries();
            }
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            settingPanel.Hide();
        }
    }

    [XmlRoot("gameSettings"), XmlType("gameSettings")]
    public class GameSetting
    {
        public modsDirectoryOverride modsDirectoryOverride { get; set; }
        public string onlinePresenceName { get; set; }
        public joinGame joinGame { get; set; }
        public string Name { get; set; }

        public GameSetting(string name, bool modDirectoryOverride, string modFolderPath, string username, string serverName, string serverPassword)
        {
            Name = name;
            modsDirectoryOverride = new modsDirectoryOverride();
            modsDirectoryOverride.active = modDirectoryOverride;
            modsDirectoryOverride.directory = modFolderPath;
            onlinePresenceName = username;
            joinGame = new joinGame();
            joinGame.serverName = serverName;
            joinGame.password = serverPassword;
        }
        public GameSetting()
        {

        }
    }

    public class joinGame
    {
        [XmlAttribute]
        public string serverName { get; set; }
        [XmlAttribute]
        public string password { get; set; }
    }

    public class modsDirectoryOverride
    {
        [XmlAttribute]
        public bool active { get; set; }
        [XmlAttribute]
        public string directory { get; set; }
    }
}
