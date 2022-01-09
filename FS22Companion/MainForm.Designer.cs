namespace FS22Companion
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.pricesTableButton = new FontAwesome.Sharp.IconButton();
            this.menuButton = new FontAwesome.Sharp.IconButton();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.pricesTableButton);
            this.sidePanel.Controls.Add(this.menuButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(74, 390);
            this.sidePanel.TabIndex = 0;
            // 
            // pagePanel
            // 
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel.Location = new System.Drawing.Point(74, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(612, 390);
            this.pagePanel.TabIndex = 1;
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.IconSize = 43;
            this.homeButton.Location = new System.Drawing.Point(-3, -1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(80, 80);
            this.homeButton.TabIndex = 7;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.IconSize = 43;
            this.exitButton.Location = new System.Drawing.Point(-3, 315);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 80);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 43;
            this.settingsButton.Location = new System.Drawing.Point(-3, 236);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 80);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pricesTableButton
            // 
            this.pricesTableButton.FlatAppearance.BorderSize = 0;
            this.pricesTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pricesTableButton.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.pricesTableButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.pricesTableButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pricesTableButton.IconSize = 43;
            this.pricesTableButton.Location = new System.Drawing.Point(-3, 157);
            this.pricesTableButton.Name = "pricesTableButton";
            this.pricesTableButton.Size = new System.Drawing.Size(80, 80);
            this.pricesTableButton.TabIndex = 4;
            this.pricesTableButton.UseVisualStyleBackColor = true;
            this.pricesTableButton.Click += new System.EventHandler(this.pricesTableButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.menuButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.menuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuButton.IconSize = 43;
            this.menuButton.Location = new System.Drawing.Point(-3, 78);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(80, 80);
            this.menuButton.TabIndex = 3;
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.pagePanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FS22Companion";
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private FontAwesome.Sharp.IconButton menuButton;
        private FontAwesome.Sharp.IconButton pricesTableButton;
        private System.Windows.Forms.Panel pagePanel;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton settingsButton;
        private FontAwesome.Sharp.IconButton homeButton;
    }
}

