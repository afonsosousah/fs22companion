
namespace FS22Companion
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.topMostButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topMostButton
            // 
            this.topMostButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.topMostButton.BorderRadius = 7;
            this.topMostButton.BorderThickness = 1;
            this.topMostButton.CheckedState.Parent = this.topMostButton;
            this.topMostButton.CustomImages.Parent = this.topMostButton;
            this.topMostButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.topMostButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.topMostButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.topMostButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.topMostButton.DisabledState.Parent = this.topMostButton;
            this.topMostButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.topMostButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.topMostButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.topMostButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.topMostButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.topMostButton.HoverState.Parent = this.topMostButton;
            this.topMostButton.Location = new System.Drawing.Point(50, 47);
            this.topMostButton.Name = "topMostButton";
            this.topMostButton.ShadowDecoration.Parent = this.topMostButton;
            this.topMostButton.Size = new System.Drawing.Size(164, 29);
            this.topMostButton.TabIndex = 10;
            this.topMostButton.Text = "Stay Always on Top";
            this.topMostButton.Click += new System.EventHandler(this.topMostButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(189, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "This is looking kinda empty...\r\n";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(612, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topMostButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button topMostButton;
    }
}