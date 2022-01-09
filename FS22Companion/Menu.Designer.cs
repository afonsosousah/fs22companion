
namespace FS22Companion
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.removeMoneyButton = new Guna.UI2.WinForms.Guna2Button();
            this.moneyTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.addMoneyButton = new Guna.UI2.WinForms.Guna2Button();
            this.setMoneyButton = new Guna.UI2.WinForms.Guna2Button();
            this.timeScaleTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.currentTimeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.setTimeScaleButton = new Guna.UI2.WinForms.Guna2Button();
            this.setTimeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.moneyTab = new System.Windows.Forms.TabPage();
            this.timeTime = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.seasonComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gpsTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.directionLabel = new System.Windows.Forms.Label();
            this.isInVehicleButton = new Guna.UI2.WinForms.Guna2Button();
            this.deactivateGPSButton = new Guna.UI2.WinForms.Guna2Button();
            this.activateGPSButton = new Guna.UI2.WinForms.Guna2Button();
            this.directionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.gpsTimer = new System.Windows.Forms.Timer(this.components);
            this.isInVehicleTimer = new System.Windows.Forms.Timer(this.components);
            this.gpsActiveButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.moneyTab.SuspendLayout();
            this.timeTime.SuspendLayout();
            this.gpsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            // 
            // removeMoneyButton
            // 
            this.removeMoneyButton.BackColor = System.Drawing.Color.Transparent;
            this.removeMoneyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.removeMoneyButton.BorderRadius = 7;
            this.removeMoneyButton.BorderThickness = 1;
            this.removeMoneyButton.CheckedState.Parent = this.removeMoneyButton;
            this.removeMoneyButton.CustomImages.Parent = this.removeMoneyButton;
            this.removeMoneyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeMoneyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeMoneyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeMoneyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeMoneyButton.DisabledState.Parent = this.removeMoneyButton;
            this.removeMoneyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.removeMoneyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.removeMoneyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.removeMoneyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.removeMoneyButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.removeMoneyButton.HoverState.Parent = this.removeMoneyButton;
            this.removeMoneyButton.Location = new System.Drawing.Point(472, 151);
            this.removeMoneyButton.Name = "removeMoneyButton";
            this.removeMoneyButton.ShadowDecoration.Parent = this.removeMoneyButton;
            this.removeMoneyButton.Size = new System.Drawing.Size(87, 29);
            this.removeMoneyButton.TabIndex = 9;
            this.removeMoneyButton.Text = "Remove";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.moneyTextBox.BorderRadius = 7;
            this.moneyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.moneyTextBox.DefaultText = "";
            this.moneyTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.moneyTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.moneyTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.moneyTextBox.DisabledState.Parent = this.moneyTextBox;
            this.moneyTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.moneyTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.moneyTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.moneyTextBox.FocusedState.Parent = this.moneyTextBox;
            this.moneyTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.moneyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.moneyTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.moneyTextBox.HoverState.Parent = this.moneyTextBox;
            this.moneyTextBox.Location = new System.Drawing.Point(39, 150);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.PasswordChar = '\0';
            this.moneyTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.moneyTextBox.PlaceholderText = "Current money";
            this.moneyTextBox.SelectedText = "";
            this.moneyTextBox.ShadowDecoration.Parent = this.moneyTextBox;
            this.moneyTextBox.Size = new System.Drawing.Size(240, 29);
            this.moneyTextBox.TabIndex = 7;
            // 
            // addMoneyButton
            // 
            this.addMoneyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addMoneyButton.BorderRadius = 7;
            this.addMoneyButton.BorderThickness = 1;
            this.addMoneyButton.CheckedState.Parent = this.addMoneyButton;
            this.addMoneyButton.CustomImages.Parent = this.addMoneyButton;
            this.addMoneyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addMoneyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addMoneyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addMoneyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addMoneyButton.DisabledState.Parent = this.addMoneyButton;
            this.addMoneyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.addMoneyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addMoneyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addMoneyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.addMoneyButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.addMoneyButton.HoverState.Parent = this.addMoneyButton;
            this.addMoneyButton.Location = new System.Drawing.Point(379, 151);
            this.addMoneyButton.Name = "addMoneyButton";
            this.addMoneyButton.ShadowDecoration.Parent = this.addMoneyButton;
            this.addMoneyButton.Size = new System.Drawing.Size(87, 29);
            this.addMoneyButton.TabIndex = 8;
            this.addMoneyButton.Text = "Add";
            // 
            // setMoneyButton
            // 
            this.setMoneyButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setMoneyButton.BorderRadius = 7;
            this.setMoneyButton.BorderThickness = 1;
            this.setMoneyButton.CheckedState.Parent = this.setMoneyButton;
            this.setMoneyButton.CustomImages.Parent = this.setMoneyButton;
            this.setMoneyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setMoneyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setMoneyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setMoneyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setMoneyButton.DisabledState.Parent = this.setMoneyButton;
            this.setMoneyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setMoneyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setMoneyButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setMoneyButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setMoneyButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setMoneyButton.HoverState.Parent = this.setMoneyButton;
            this.setMoneyButton.Location = new System.Drawing.Point(286, 151);
            this.setMoneyButton.Name = "setMoneyButton";
            this.setMoneyButton.ShadowDecoration.Parent = this.setMoneyButton;
            this.setMoneyButton.Size = new System.Drawing.Size(87, 29);
            this.setMoneyButton.TabIndex = 7;
            this.setMoneyButton.Text = "Set";
            // 
            // timeScaleTextBox
            // 
            this.timeScaleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.timeScaleTextBox.BorderRadius = 7;
            this.timeScaleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeScaleTextBox.DefaultText = "";
            this.timeScaleTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timeScaleTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timeScaleTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeScaleTextBox.DisabledState.Parent = this.timeScaleTextBox;
            this.timeScaleTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timeScaleTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.timeScaleTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.timeScaleTextBox.FocusedState.Parent = this.timeScaleTextBox;
            this.timeScaleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.timeScaleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.timeScaleTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.timeScaleTextBox.HoverState.Parent = this.timeScaleTextBox;
            this.timeScaleTextBox.Location = new System.Drawing.Point(152, 176);
            this.timeScaleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeScaleTextBox.Name = "timeScaleTextBox";
            this.timeScaleTextBox.PasswordChar = '\0';
            this.timeScaleTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.timeScaleTextBox.PlaceholderText = "0";
            this.timeScaleTextBox.SelectedText = "";
            this.timeScaleTextBox.ShadowDecoration.Parent = this.timeScaleTextBox;
            this.timeScaleTextBox.Size = new System.Drawing.Size(142, 29);
            this.timeScaleTextBox.TabIndex = 16;
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.currentTimeTextBox.BorderRadius = 7;
            this.currentTimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.currentTimeTextBox.DefaultText = "";
            this.currentTimeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.currentTimeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.currentTimeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentTimeTextBox.DisabledState.Parent = this.currentTimeTextBox;
            this.currentTimeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.currentTimeTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.currentTimeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.currentTimeTextBox.FocusedState.Parent = this.currentTimeTextBox;
            this.currentTimeTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.currentTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.currentTimeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.currentTimeTextBox.HoverState.Parent = this.currentTimeTextBox;
            this.currentTimeTextBox.Location = new System.Drawing.Point(152, 222);
            this.currentTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.PasswordChar = '\0';
            this.currentTimeTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.currentTimeTextBox.PlaceholderText = "00:00";
            this.currentTimeTextBox.SelectedText = "";
            this.currentTimeTextBox.ShadowDecoration.Parent = this.currentTimeTextBox;
            this.currentTimeTextBox.Size = new System.Drawing.Size(142, 29);
            this.currentTimeTextBox.TabIndex = 10;
            // 
            // setTimeScaleButton
            // 
            this.setTimeScaleButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeScaleButton.BorderRadius = 7;
            this.setTimeScaleButton.BorderThickness = 1;
            this.setTimeScaleButton.CheckedState.Parent = this.setTimeScaleButton;
            this.setTimeScaleButton.CustomImages.Parent = this.setTimeScaleButton;
            this.setTimeScaleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setTimeScaleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setTimeScaleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setTimeScaleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setTimeScaleButton.DisabledState.Parent = this.setTimeScaleButton;
            this.setTimeScaleButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setTimeScaleButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setTimeScaleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeScaleButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeScaleButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setTimeScaleButton.HoverState.Parent = this.setTimeScaleButton;
            this.setTimeScaleButton.Location = new System.Drawing.Point(301, 176);
            this.setTimeScaleButton.Name = "setTimeScaleButton";
            this.setTimeScaleButton.ShadowDecoration.Parent = this.setTimeScaleButton;
            this.setTimeScaleButton.Size = new System.Drawing.Size(135, 29);
            this.setTimeScaleButton.TabIndex = 15;
            this.setTimeScaleButton.Text = "Set Time Scale";
            // 
            // setTimeButton
            // 
            this.setTimeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeButton.BorderRadius = 7;
            this.setTimeButton.BorderThickness = 1;
            this.setTimeButton.CheckedState.Parent = this.setTimeButton;
            this.setTimeButton.CustomImages.Parent = this.setTimeButton;
            this.setTimeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setTimeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setTimeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setTimeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setTimeButton.DisabledState.Parent = this.setTimeButton;
            this.setTimeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setTimeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.setTimeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.setTimeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.setTimeButton.HoverState.Parent = this.setTimeButton;
            this.setTimeButton.Location = new System.Drawing.Point(301, 222);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.ShadowDecoration.Parent = this.setTimeButton;
            this.setTimeButton.Size = new System.Drawing.Size(135, 29);
            this.setTimeButton.TabIndex = 14;
            this.setTimeButton.Text = "Set Time";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.moneyTab);
            this.guna2TabControl1.Controls.Add(this.timeTime);
            this.guna2TabControl1.Controls.Add(this.gpsTab);
            this.guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(0, 0);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(612, 390);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.Gray;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(161)))), ((int)(((byte)(213)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Gray;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.guna2TabControl1.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(120, 40);
            this.guna2TabControl1.TabIndex = 16;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // moneyTab
            // 
            this.moneyTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.moneyTab.Controls.Add(this.removeMoneyButton);
            this.moneyTab.Controls.Add(this.moneyTextBox);
            this.moneyTab.Controls.Add(this.addMoneyButton);
            this.moneyTab.Controls.Add(this.setMoneyButton);
            this.moneyTab.Location = new System.Drawing.Point(4, 44);
            this.moneyTab.Name = "moneyTab";
            this.moneyTab.Padding = new System.Windows.Forms.Padding(3);
            this.moneyTab.Size = new System.Drawing.Size(604, 342);
            this.moneyTab.TabIndex = 0;
            this.moneyTab.Text = "Money";
            // 
            // timeTime
            // 
            this.timeTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.timeTime.Controls.Add(this.timeScaleTextBox);
            this.timeTime.Controls.Add(this.label1);
            this.timeTime.Controls.Add(this.currentTimeTextBox);
            this.timeTime.Controls.Add(this.seasonComboBox);
            this.timeTime.Controls.Add(this.setTimeScaleButton);
            this.timeTime.Controls.Add(this.monthLabel);
            this.timeTime.Controls.Add(this.setTimeButton);
            this.timeTime.Controls.Add(this.monthComboBox);
            this.timeTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTime.Location = new System.Drawing.Point(4, 44);
            this.timeTime.Name = "timeTime";
            this.timeTime.Padding = new System.Windows.Forms.Padding(3);
            this.timeTime.Size = new System.Drawing.Size(604, 342);
            this.timeTime.TabIndex = 1;
            this.timeTime.Text = "Time";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label1.Location = new System.Drawing.Point(148, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Season:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seasonComboBox
            // 
            this.seasonComboBox.BackColor = System.Drawing.Color.Transparent;
            this.seasonComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.seasonComboBox.BorderRadius = 7;
            this.seasonComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.seasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seasonComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.seasonComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.seasonComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.seasonComboBox.FocusedState.Parent = this.seasonComboBox;
            this.seasonComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seasonComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.seasonComboBox.HoverState.Parent = this.seasonComboBox;
            this.seasonComboBox.ItemHeight = 23;
            this.seasonComboBox.Items.AddRange(new object[] {
            "Spring",
            "Summer",
            "Autumn",
            "Winter"});
            this.seasonComboBox.ItemsAppearance.Parent = this.seasonComboBox;
            this.seasonComboBox.Location = new System.Drawing.Point(218, 125);
            this.seasonComboBox.Name = "seasonComboBox";
            this.seasonComboBox.ShadowDecoration.Parent = this.seasonComboBox;
            this.seasonComboBox.Size = new System.Drawing.Size(218, 29);
            this.seasonComboBox.TabIndex = 21;
            // 
            // monthLabel
            // 
            this.monthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.monthLabel.Location = new System.Drawing.Point(148, 84);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(64, 29);
            this.monthLabel.TabIndex = 20;
            this.monthLabel.Text = "Month:";
            this.monthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthComboBox
            // 
            this.monthComboBox.BackColor = System.Drawing.Color.Transparent;
            this.monthComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.monthComboBox.BorderRadius = 7;
            this.monthComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.monthComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.monthComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.monthComboBox.FocusedState.Parent = this.monthComboBox;
            this.monthComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.monthComboBox.HoverState.Parent = this.monthComboBox;
            this.monthComboBox.ItemHeight = 23;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.ItemsAppearance.Parent = this.monthComboBox;
            this.monthComboBox.Location = new System.Drawing.Point(218, 84);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.ShadowDecoration.Parent = this.monthComboBox;
            this.monthComboBox.Size = new System.Drawing.Size(218, 29);
            this.monthComboBox.TabIndex = 19;
            // 
            // gpsTab
            // 
            this.gpsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.gpsTab.Controls.Add(this.gpsActiveButton);
            this.gpsTab.Controls.Add(this.label2);
            this.gpsTab.Controls.Add(this.directionLabel);
            this.gpsTab.Controls.Add(this.isInVehicleButton);
            this.gpsTab.Controls.Add(this.deactivateGPSButton);
            this.gpsTab.Controls.Add(this.activateGPSButton);
            this.gpsTab.Controls.Add(this.directionTextBox);
            this.gpsTab.Location = new System.Drawing.Point(4, 44);
            this.gpsTab.Name = "gpsTab";
            this.gpsTab.Padding = new System.Windows.Forms.Padding(3);
            this.gpsTab.Size = new System.Drawing.Size(604, 342);
            this.gpsTab.TabIndex = 2;
            this.gpsTab.Text = "GPS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.label2.Location = new System.Drawing.Point(181, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "GPS Direction:";
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.directionLabel.Location = new System.Drawing.Point(181, 125);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(133, 21);
            this.directionLabel.TabIndex = 14;
            this.directionLabel.Text = "Current Direction:";
            // 
            // isInVehicleButton
            // 
            this.isInVehicleButton.AutoRoundedCorners = true;
            this.isInVehicleButton.BorderRadius = 11;
            this.isInVehicleButton.CheckedState.Parent = this.isInVehicleButton;
            this.isInVehicleButton.CustomImages.Parent = this.isInVehicleButton;
            this.isInVehicleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.isInVehicleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.isInVehicleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.isInVehicleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.isInVehicleButton.DisabledState.Parent = this.isInVehicleButton;
            this.isInVehicleButton.FillColor = System.Drawing.Color.Gainsboro;
            this.isInVehicleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.isInVehicleButton.ForeColor = System.Drawing.Color.Black;
            this.isInVehicleButton.HoverState.Parent = this.isInVehicleButton;
            this.isInVehicleButton.Location = new System.Drawing.Point(185, 83);
            this.isInVehicleButton.Name = "isInVehicleButton";
            this.isInVehicleButton.ShadowDecoration.Parent = this.isInVehicleButton;
            this.isInVehicleButton.Size = new System.Drawing.Size(105, 25);
            this.isInVehicleButton.TabIndex = 12;
            this.isInVehicleButton.Text = "isInVehicle";
            // 
            // deactivateGPSButton
            // 
            this.deactivateGPSButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deactivateGPSButton.BorderRadius = 7;
            this.deactivateGPSButton.BorderThickness = 1;
            this.deactivateGPSButton.CheckedState.Parent = this.deactivateGPSButton;
            this.deactivateGPSButton.CustomImages.Parent = this.deactivateGPSButton;
            this.deactivateGPSButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deactivateGPSButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deactivateGPSButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deactivateGPSButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deactivateGPSButton.DisabledState.Parent = this.deactivateGPSButton;
            this.deactivateGPSButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.deactivateGPSButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deactivateGPSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deactivateGPSButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.deactivateGPSButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.deactivateGPSButton.HoverState.Parent = this.deactivateGPSButton;
            this.deactivateGPSButton.Location = new System.Drawing.Point(303, 218);
            this.deactivateGPSButton.Name = "deactivateGPSButton";
            this.deactivateGPSButton.ShadowDecoration.Parent = this.deactivateGPSButton;
            this.deactivateGPSButton.Size = new System.Drawing.Size(97, 29);
            this.deactivateGPSButton.TabIndex = 10;
            this.deactivateGPSButton.Text = "Dectivate";
            // 
            // activateGPSButton
            // 
            this.activateGPSButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.activateGPSButton.BorderRadius = 7;
            this.activateGPSButton.BorderThickness = 1;
            this.activateGPSButton.CheckedState.Parent = this.activateGPSButton;
            this.activateGPSButton.CustomImages.Parent = this.activateGPSButton;
            this.activateGPSButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.activateGPSButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.activateGPSButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.activateGPSButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.activateGPSButton.DisabledState.Parent = this.activateGPSButton;
            this.activateGPSButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.activateGPSButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activateGPSButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.activateGPSButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.activateGPSButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.activateGPSButton.HoverState.Parent = this.activateGPSButton;
            this.activateGPSButton.Location = new System.Drawing.Point(185, 218);
            this.activateGPSButton.Name = "activateGPSButton";
            this.activateGPSButton.ShadowDecoration.Parent = this.activateGPSButton;
            this.activateGPSButton.Size = new System.Drawing.Size(97, 29);
            this.activateGPSButton.TabIndex = 9;
            this.activateGPSButton.Text = "Activate";
            // 
            // directionTextBox
            // 
            this.directionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.directionTextBox.BorderRadius = 7;
            this.directionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.directionTextBox.DefaultText = "180.0";
            this.directionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.directionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.directionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.directionTextBox.DisabledState.Parent = this.directionTextBox;
            this.directionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.directionTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.directionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.directionTextBox.FocusedState.Parent = this.directionTextBox;
            this.directionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.directionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.directionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.directionTextBox.HoverState.Parent = this.directionTextBox;
            this.directionTextBox.Location = new System.Drawing.Point(303, 174);
            this.directionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.PasswordChar = '\0';
            this.directionTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.directionTextBox.PlaceholderText = "Direction (degrees)";
            this.directionTextBox.SelectedText = "";
            this.directionTextBox.ShadowDecoration.Parent = this.directionTextBox;
            this.directionTextBox.Size = new System.Drawing.Size(99, 29);
            this.directionTextBox.TabIndex = 8;
            // 
            // gpsTimer
            // 
            this.gpsTimer.Enabled = true;
            this.gpsTimer.Interval = 10;
            // 
            // isInVehicleTimer
            // 
            this.isInVehicleTimer.Enabled = true;
            this.isInVehicleTimer.Interval = 500;
            // 
            // gpsActiveButton
            // 
            this.gpsActiveButton.AutoRoundedCorners = true;
            this.gpsActiveButton.BorderRadius = 11;
            this.gpsActiveButton.CheckedState.Parent = this.gpsActiveButton;
            this.gpsActiveButton.CustomImages.Parent = this.gpsActiveButton;
            this.gpsActiveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gpsActiveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gpsActiveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gpsActiveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gpsActiveButton.DisabledState.Parent = this.gpsActiveButton;
            this.gpsActiveButton.FillColor = System.Drawing.Color.Gainsboro;
            this.gpsActiveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpsActiveButton.ForeColor = System.Drawing.Color.Black;
            this.gpsActiveButton.HoverState.Parent = this.gpsActiveButton;
            this.gpsActiveButton.Location = new System.Drawing.Point(295, 83);
            this.gpsActiveButton.Name = "gpsActiveButton";
            this.gpsActiveButton.ShadowDecoration.Parent = this.gpsActiveButton;
            this.gpsActiveButton.Size = new System.Drawing.Size(105, 25);
            this.gpsActiveButton.TabIndex = 16;
            this.gpsActiveButton.Text = "gpsActive";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(612, 390);
            this.Controls.Add(this.guna2TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.guna2TabControl1.ResumeLayout(false);
            this.moneyTab.ResumeLayout(false);
            this.timeTime.ResumeLayout(false);
            this.gpsTab.ResumeLayout(false);
            this.gpsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Button removeMoneyButton;
        private Guna.UI2.WinForms.Guna2TextBox moneyTextBox;
        private Guna.UI2.WinForms.Guna2Button addMoneyButton;
        private Guna.UI2.WinForms.Guna2Button setMoneyButton;
        private Guna.UI2.WinForms.Guna2TextBox timeScaleTextBox;
        private Guna.UI2.WinForms.Guna2TextBox currentTimeTextBox;
        private Guna.UI2.WinForms.Guna2Button setTimeScaleButton;
        private Guna.UI2.WinForms.Guna2Button setTimeButton;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage moneyTab;
        private System.Windows.Forms.TabPage timeTime;
        private System.Windows.Forms.TabPage gpsTab;
        private Guna.UI2.WinForms.Guna2ComboBox monthComboBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox seasonComboBox;
        private System.Windows.Forms.Label monthLabel;
        private Guna.UI2.WinForms.Guna2Button deactivateGPSButton;
        private Guna.UI2.WinForms.Guna2Button activateGPSButton;
        private Guna.UI2.WinForms.Guna2TextBox directionTextBox;
        public Guna.UI2.WinForms.Guna2Button isInVehicleButton;
        private System.Windows.Forms.Timer gpsTimer;
        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer isInVehicleTimer;
        public Guna.UI2.WinForms.Guna2Button gpsActiveButton;
    }
}