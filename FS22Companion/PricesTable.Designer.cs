
namespace FS22Companion
{
    partial class PricesTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PricesTable));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.difficultyButtonRight = new FontAwesome.Sharp.IconButton();
            this.difficultyButtonLeft = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tableScrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.Location = new System.Drawing.Point(21, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(367, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.difficultyLabel);
            this.panel1.Controls.Add(this.difficultyButtonRight);
            this.panel1.Controls.Add(this.difficultyButtonLeft);
            this.panel1.Location = new System.Drawing.Point(421, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 35);
            this.panel1.TabIndex = 1;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.difficultyLabel.ForeColor = System.Drawing.Color.White;
            this.difficultyLabel.Location = new System.Drawing.Point(32, 0);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(106, 35);
            this.difficultyLabel.TabIndex = 2;
            this.difficultyLabel.Text = "Easy";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difficultyButtonRight
            // 
            this.difficultyButtonRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(143)))));
            this.difficultyButtonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.difficultyButtonRight.FlatAppearance.BorderSize = 0;
            this.difficultyButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyButtonRight.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.difficultyButtonRight.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.difficultyButtonRight.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(186)))), ((int)(((byte)(213)))));
            this.difficultyButtonRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.difficultyButtonRight.IconSize = 35;
            this.difficultyButtonRight.Location = new System.Drawing.Point(137, 0);
            this.difficultyButtonRight.Name = "difficultyButtonRight";
            this.difficultyButtonRight.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.difficultyButtonRight.Size = new System.Drawing.Size(34, 35);
            this.difficultyButtonRight.TabIndex = 1;
            this.difficultyButtonRight.UseVisualStyleBackColor = false;
            this.difficultyButtonRight.Click += new System.EventHandler(this.difficultyButtonRight_Click);
            // 
            // difficultyButtonLeft
            // 
            this.difficultyButtonLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(117)))), ((int)(((byte)(143)))));
            this.difficultyButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.difficultyButtonLeft.FlatAppearance.BorderSize = 0;
            this.difficultyButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyButtonLeft.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.difficultyButtonLeft.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(186)))), ((int)(((byte)(213)))));
            this.difficultyButtonLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.difficultyButtonLeft.IconSize = 35;
            this.difficultyButtonLeft.Location = new System.Drawing.Point(0, 0);
            this.difficultyButtonLeft.Name = "difficultyButtonLeft";
            this.difficultyButtonLeft.Padding = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.difficultyButtonLeft.Size = new System.Drawing.Size(34, 35);
            this.difficultyButtonLeft.TabIndex = 0;
            this.difficultyButtonLeft.UseVisualStyleBackColor = false;
            this.difficultyButtonLeft.Click += new System.EventHandler(this.difficultyButtonLeft_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(421, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Economic Difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableScrollBar
            // 
            this.tableScrollBar.AutoRoundedCorners = true;
            this.tableScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.tableScrollBar.BorderRadius = 4;
            this.tableScrollBar.FillColor = System.Drawing.Color.Transparent;
            this.tableScrollBar.HoverState.Parent = null;
            this.tableScrollBar.InUpdate = false;
            this.tableScrollBar.LargeChange = 10;
            this.tableScrollBar.Location = new System.Drawing.Point(394, 21);
            this.tableScrollBar.Maximum = 48;
            this.tableScrollBar.Name = "tableScrollBar";
            this.tableScrollBar.PressedState.Parent = this.tableScrollBar;
            this.tableScrollBar.ScrollbarSize = 10;
            this.tableScrollBar.Size = new System.Drawing.Size(10, 425);
            this.tableScrollBar.TabIndex = 4;
            this.tableScrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(187)))), ((int)(((byte)(223)))));
            this.tableScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.tableScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.tableScrollBar_Scroll);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(421, 413);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(171, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credits to u/Edigorin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // PricesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(612, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableScrollBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PricesTable";
            this.Text = "PricesTable";
            this.Load += new System.EventHandler(this.PricesTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton difficultyButtonRight;
        private FontAwesome.Sharp.IconButton difficultyButtonLeft;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VScrollBar tableScrollBar;
        private System.Windows.Forms.Label label2;
    }
}