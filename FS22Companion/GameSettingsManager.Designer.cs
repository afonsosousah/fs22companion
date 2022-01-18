
namespace FS22Companion
{
    partial class GameSettingsManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addGameSettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.modDirectoryOverrideCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.deleteGameSettingButton = new Guna.UI2.WinForms.Guna2Button();
            this.modFolderButton = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveSettingButton = new Guna.UI2.WinForms.Guna2Button();
            this.serverPasswordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.serverNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.modFolderTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.backwardButton = new FontAwesome.Sharp.IconButton();
            this.settingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(411, 36);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(200, 434);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // addGameSettingsButton
            // 
            this.addGameSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.addGameSettingsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addGameSettingsButton.BorderThickness = 1;
            this.addGameSettingsButton.CheckedState.Parent = this.addGameSettingsButton;
            this.addGameSettingsButton.CustomImages.Parent = this.addGameSettingsButton;
            this.addGameSettingsButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addGameSettingsButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addGameSettingsButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addGameSettingsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addGameSettingsButton.DisabledState.Parent = this.addGameSettingsButton;
            this.addGameSettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.addGameSettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addGameSettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addGameSettingsButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addGameSettingsButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.addGameSettingsButton.HoverState.Parent = this.addGameSettingsButton;
            this.addGameSettingsButton.Location = new System.Drawing.Point(411, 1);
            this.addGameSettingsButton.Name = "addGameSettingsButton";
            this.addGameSettingsButton.ShadowDecoration.Parent = this.addGameSettingsButton;
            this.addGameSettingsButton.Size = new System.Drawing.Size(200, 35);
            this.addGameSettingsButton.TabIndex = 8;
            this.addGameSettingsButton.Text = "Add Game Setting";
            this.addGameSettingsButton.Click += new System.EventHandler(this.addGameSettingsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(43, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select or add a new Game Setting!\r\n\r\nJoin a MP server atleast once before using t" +
    "his.";
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.backwardButton);
            this.settingPanel.Controls.Add(this.modDirectoryOverrideCheckBox);
            this.settingPanel.Controls.Add(this.deleteGameSettingButton);
            this.settingPanel.Controls.Add(this.modFolderButton);
            this.settingPanel.Controls.Add(this.label6);
            this.settingPanel.Controls.Add(this.label5);
            this.settingPanel.Controls.Add(this.label4);
            this.settingPanel.Controls.Add(this.label3);
            this.settingPanel.Controls.Add(this.label2);
            this.settingPanel.Controls.Add(this.settingNameTextBox);
            this.settingPanel.Controls.Add(this.saveSettingButton);
            this.settingPanel.Controls.Add(this.serverPasswordTextBox);
            this.settingPanel.Controls.Add(this.serverNameTextBox);
            this.settingPanel.Controls.Add(this.usernameTextBox);
            this.settingPanel.Controls.Add(this.modFolderTextBox);
            this.settingPanel.Location = new System.Drawing.Point(12, 12);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(393, 446);
            this.settingPanel.TabIndex = 10;
            this.settingPanel.Visible = false;
            // 
            // modDirectoryOverrideCheckBox
            // 
            this.modDirectoryOverrideCheckBox.Animated = true;
            this.modDirectoryOverrideCheckBox.AutoSize = true;
            this.modDirectoryOverrideCheckBox.Checked = true;
            this.modDirectoryOverrideCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.modDirectoryOverrideCheckBox.CheckedState.BorderRadius = 0;
            this.modDirectoryOverrideCheckBox.CheckedState.BorderThickness = 0;
            this.modDirectoryOverrideCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.modDirectoryOverrideCheckBox.CheckMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.modDirectoryOverrideCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modDirectoryOverrideCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modDirectoryOverrideCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.modDirectoryOverrideCheckBox.Location = new System.Drawing.Point(76, 105);
            this.modDirectoryOverrideCheckBox.Name = "modDirectoryOverrideCheckBox";
            this.modDirectoryOverrideCheckBox.Size = new System.Drawing.Size(194, 25);
            this.modDirectoryOverrideCheckBox.TabIndex = 21;
            this.modDirectoryOverrideCheckBox.Text = "Mod Directory Override";
            this.modDirectoryOverrideCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.modDirectoryOverrideCheckBox.UncheckedState.BorderRadius = 0;
            this.modDirectoryOverrideCheckBox.UncheckedState.BorderThickness = 0;
            this.modDirectoryOverrideCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // deleteGameSettingButton
            // 
            this.deleteGameSettingButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deleteGameSettingButton.BorderRadius = 7;
            this.deleteGameSettingButton.BorderThickness = 1;
            this.deleteGameSettingButton.CheckedState.Parent = this.deleteGameSettingButton;
            this.deleteGameSettingButton.CustomImages.Parent = this.deleteGameSettingButton;
            this.deleteGameSettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteGameSettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteGameSettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteGameSettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteGameSettingButton.DisabledState.Parent = this.deleteGameSettingButton;
            this.deleteGameSettingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.deleteGameSettingButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteGameSettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deleteGameSettingButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deleteGameSettingButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.deleteGameSettingButton.HoverState.Parent = this.deleteGameSettingButton;
            this.deleteGameSettingButton.Location = new System.Drawing.Point(151, 372);
            this.deleteGameSettingButton.Name = "deleteGameSettingButton";
            this.deleteGameSettingButton.ShadowDecoration.Parent = this.deleteGameSettingButton;
            this.deleteGameSettingButton.Size = new System.Drawing.Size(76, 29);
            this.deleteGameSettingButton.TabIndex = 19;
            this.deleteGameSettingButton.Text = "Delete";
            this.deleteGameSettingButton.Click += new System.EventHandler(this.deleteGameSettingButton_Click);
            // 
            // modFolderButton
            // 
            this.modFolderButton.FlatAppearance.BorderSize = 0;
            this.modFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modFolderButton.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.modFolderButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.modFolderButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.modFolderButton.IconSize = 38;
            this.modFolderButton.Location = new System.Drawing.Point(317, 158);
            this.modFolderButton.Name = "modFolderButton";
            this.modFolderButton.Size = new System.Drawing.Size(34, 29);
            this.modFolderButton.TabIndex = 18;
            this.modFolderButton.UseVisualStyleBackColor = true;
            this.modFolderButton.Click += new System.EventHandler(this.modFolderButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label6.Location = new System.Drawing.Point(72, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Server Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label5.Location = new System.Drawing.Point(72, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Server Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label4.Location = new System.Drawing.Point(72, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label3.Location = new System.Drawing.Point(72, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mod Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(72, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Setting Name";
            // 
            // settingNameTextBox
            // 
            this.settingNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.settingNameTextBox.BorderRadius = 7;
            this.settingNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.settingNameTextBox.DefaultText = "";
            this.settingNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.settingNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.settingNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.settingNameTextBox.DisabledState.Parent = this.settingNameTextBox;
            this.settingNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.settingNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.settingNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.settingNameTextBox.FocusedState.Parent = this.settingNameTextBox;
            this.settingNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.settingNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.settingNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.settingNameTextBox.HoverState.Parent = this.settingNameTextBox;
            this.settingNameTextBox.Location = new System.Drawing.Point(69, 65);
            this.settingNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingNameTextBox.Name = "settingNameTextBox";
            this.settingNameTextBox.PasswordChar = '\0';
            this.settingNameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.settingNameTextBox.PlaceholderText = "Setting Name";
            this.settingNameTextBox.SelectedText = "";
            this.settingNameTextBox.ShadowDecoration.Parent = this.settingNameTextBox;
            this.settingNameTextBox.Size = new System.Drawing.Size(240, 29);
            this.settingNameTextBox.TabIndex = 12;
            // 
            // saveSettingButton
            // 
            this.saveSettingButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.saveSettingButton.BorderRadius = 7;
            this.saveSettingButton.BorderThickness = 1;
            this.saveSettingButton.CheckedState.Parent = this.saveSettingButton;
            this.saveSettingButton.CustomImages.Parent = this.saveSettingButton;
            this.saveSettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveSettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveSettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveSettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveSettingButton.DisabledState.Parent = this.saveSettingButton;
            this.saveSettingButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.saveSettingButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveSettingButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.saveSettingButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.saveSettingButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.saveSettingButton.HoverState.Parent = this.saveSettingButton;
            this.saveSettingButton.Location = new System.Drawing.Point(233, 372);
            this.saveSettingButton.Name = "saveSettingButton";
            this.saveSettingButton.ShadowDecoration.Parent = this.saveSettingButton;
            this.saveSettingButton.Size = new System.Drawing.Size(76, 29);
            this.saveSettingButton.TabIndex = 11;
            this.saveSettingButton.Text = "Apply";
            this.saveSettingButton.Click += new System.EventHandler(this.saveSettingButton_Click);
            // 
            // serverPasswordTextBox
            // 
            this.serverPasswordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.serverPasswordTextBox.BorderRadius = 7;
            this.serverPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serverPasswordTextBox.DefaultText = "";
            this.serverPasswordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.serverPasswordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.serverPasswordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverPasswordTextBox.DisabledState.Parent = this.serverPasswordTextBox;
            this.serverPasswordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverPasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.serverPasswordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.serverPasswordTextBox.FocusedState.Parent = this.serverPasswordTextBox;
            this.serverPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.serverPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.serverPasswordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.serverPasswordTextBox.HoverState.Parent = this.serverPasswordTextBox;
            this.serverPasswordTextBox.Location = new System.Drawing.Point(69, 336);
            this.serverPasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverPasswordTextBox.Name = "serverPasswordTextBox";
            this.serverPasswordTextBox.PasswordChar = '\0';
            this.serverPasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.serverPasswordTextBox.PlaceholderText = "Server Password";
            this.serverPasswordTextBox.SelectedText = "";
            this.serverPasswordTextBox.ShadowDecoration.Parent = this.serverPasswordTextBox;
            this.serverPasswordTextBox.Size = new System.Drawing.Size(240, 29);
            this.serverPasswordTextBox.TabIndex = 11;
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.serverNameTextBox.BorderRadius = 7;
            this.serverNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serverNameTextBox.DefaultText = "";
            this.serverNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.serverNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.serverNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverNameTextBox.DisabledState.Parent = this.serverNameTextBox;
            this.serverNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverNameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.serverNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.serverNameTextBox.FocusedState.Parent = this.serverNameTextBox;
            this.serverNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.serverNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.serverNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.serverNameTextBox.HoverState.Parent = this.serverNameTextBox;
            this.serverNameTextBox.Location = new System.Drawing.Point(69, 279);
            this.serverNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.PasswordChar = '\0';
            this.serverNameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.serverNameTextBox.PlaceholderText = "Server Name";
            this.serverNameTextBox.SelectedText = "";
            this.serverNameTextBox.ShadowDecoration.Parent = this.serverNameTextBox;
            this.serverNameTextBox.Size = new System.Drawing.Size(240, 29);
            this.serverNameTextBox.TabIndex = 10;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.usernameTextBox.BorderRadius = 7;
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTextBox.DefaultText = "";
            this.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.DisabledState.Parent = this.usernameTextBox;
            this.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.usernameTextBox.FocusedState.Parent = this.usernameTextBox;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.usernameTextBox.HoverState.Parent = this.usernameTextBox;
            this.usernameTextBox.Location = new System.Drawing.Point(69, 220);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameTextBox.PlaceholderText = "Username";
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.ShadowDecoration.Parent = this.usernameTextBox;
            this.usernameTextBox.Size = new System.Drawing.Size(240, 29);
            this.usernameTextBox.TabIndex = 9;
            // 
            // modFolderTextBox
            // 
            this.modFolderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.modFolderTextBox.BorderRadius = 7;
            this.modFolderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modFolderTextBox.DefaultText = "";
            this.modFolderTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.modFolderTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.modFolderTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modFolderTextBox.DisabledState.Parent = this.modFolderTextBox;
            this.modFolderTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modFolderTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.modFolderTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.modFolderTextBox.FocusedState.Parent = this.modFolderTextBox;
            this.modFolderTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.modFolderTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.modFolderTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.modFolderTextBox.HoverState.Parent = this.modFolderTextBox;
            this.modFolderTextBox.Location = new System.Drawing.Point(69, 158);
            this.modFolderTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modFolderTextBox.Name = "modFolderTextBox";
            this.modFolderTextBox.PasswordChar = '\0';
            this.modFolderTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.modFolderTextBox.PlaceholderText = "Mod Folder";
            this.modFolderTextBox.SelectedText = "";
            this.modFolderTextBox.ShadowDecoration.Parent = this.modFolderTextBox;
            this.modFolderTextBox.Size = new System.Drawing.Size(240, 29);
            this.modFolderTextBox.TabIndex = 8;
            // 
            // backwardButton
            // 
            this.backwardButton.FlatAppearance.BorderSize = 0;
            this.backwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardButton.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.backwardButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.backwardButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backwardButton.IconSize = 35;
            this.backwardButton.Location = new System.Drawing.Point(3, 3);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.backwardButton.Size = new System.Drawing.Size(37, 31);
            this.backwardButton.TabIndex = 22;
            this.backwardButton.UseVisualStyleBackColor = true;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // GameSettingsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(612, 470);
            this.Controls.Add(this.settingPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addGameSettingsButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameSettingsManager";
            this.Text = "GameSaveManager";
            this.Load += new System.EventHandler(this.GameSettingsManager_Load);
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button addGameSettingsButton;
        public System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button saveSettingButton;
        private Guna.UI2.WinForms.Guna2TextBox serverPasswordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox serverNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox usernameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox modFolderTextBox;
        private Guna.UI2.WinForms.Guna2TextBox settingNameTextBox;
        public System.Windows.Forms.Panel settingPanel;
        private FontAwesome.Sharp.IconButton modFolderButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button deleteGameSettingButton;
        private Guna.UI2.WinForms.Guna2CheckBox modDirectoryOverrideCheckBox;
        private FontAwesome.Sharp.IconButton backwardButton;
    }
}