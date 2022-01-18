using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FS22Companion
{
    public partial class CustomMessageBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public CustomMessageBox(string message)
        {
            InitializeComponent();

            SizeF sizeOfString;

            using (System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(new Bitmap(1, 1)))
            {
               sizeOfString  = graphics.MeasureString(message, new Font("Segoe UI", (float)11.25, FontStyle.Regular, GraphicsUnit.Point));
            }

            if((int)sizeOfString.Width > 400)
            {
                this.Width = (int)sizeOfString.Width/2 + 80;
                label1.Width = this.Width;

                var oldLabelHeight = label1.Height;
                label1.Height = ((int)sizeOfString.Height*2 * oldLabelHeight)/(int)sizeOfString.Height; // Regra de 3 simples
                this.Height = this.Height + label1.Height - oldLabelHeight;
            }
            else
            {
                this.Width = (int)sizeOfString.Width + 50;
                label1.Width = this.Width;
            }

            label1.Text = message;
            this.Text = message;

            label1.MouseMove += dragabbleElement_MouseMove;
            this.MouseMove += dragabbleElement_MouseMove;
            flowLayoutPanel1.MouseMove += dragabbleElement_MouseMove;
        }

        private void dragabbleElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static DialogResult Show(string message, MessageBoxButtons buttons)
        {
            if(buttons == MessageBoxButtons.OK)
            {
                var form = new CustomMessageBox(message);
                var OkButton = new Guna2Button();
                OkButton.Text = "OK";
                OkButton.Location = new Point(167, 110);
                OkButton.Size = new Size(65, 30);
                OkButton.BorderColor = Color.FromArgb(57, 187,223);
                OkButton.BorderRadius = 7;
                OkButton.BorderThickness = 1;
                OkButton.DisabledState.BorderColor = Color.DarkGray;
                OkButton.DisabledState.CustomBorderColor = Color.DarkGray;
                OkButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                OkButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                OkButton.FillColor = Color.FromArgb(30, 47, 55);
                OkButton.Font = new Font("Segoe UI", 12F);
                OkButton.ForeColor = Color.FromArgb(57, 187, 223);
                OkButton.HoverState.FillColor = Color.FromArgb(57, 187, 223);
                OkButton.HoverState.ForeColor = Color.FromArgb(30, 47, 55);
                form.flowLayoutPanel1.Controls.Add(OkButton);
                OkButton.Click += (sender, e) =>
                {
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };
                var result = form.ShowDialog();
                form.Dispose();
                return result;
            }
            else if(buttons == MessageBoxButtons.YesNo)
            {
                var form = new CustomMessageBox(message);
                var YesButton = new Guna2Button();
                var NoButton = new Guna2Button();
                
                YesButton.Text = "Yes";
                //YesButton.Location = new Point(10, 110);

                NoButton.Text = "No";
                //NoButton.Location = new Point(75, 110);

                NoButton.Size = YesButton.Size = new Size(60, 30);
                NoButton.BorderColor = YesButton.BorderColor = Color.FromArgb(57, 187, 223);
                NoButton.BorderRadius = YesButton.BorderRadius = 7;
                NoButton.BorderThickness = YesButton.BorderThickness = 1;
                NoButton.FillColor = YesButton.FillColor = Color.FromArgb(30, 47, 55);
                NoButton.Font = YesButton.Font = new Font("Segoe UI", 12F);
                NoButton.ForeColor = YesButton.ForeColor = Color.FromArgb(57, 187, 223);
                NoButton.HoverState.FillColor = YesButton.HoverState.FillColor = Color.FromArgb(57, 187, 223);
                NoButton.HoverState.ForeColor = YesButton.HoverState.ForeColor = Color.FromArgb(30, 47, 55);
                form.flowLayoutPanel1.Controls.Add(NoButton);
                form.flowLayoutPanel1.Controls.Add(YesButton);

                YesButton.Click += (sender, e) =>
                {
                    form.DialogResult = DialogResult.Yes;
                    form.Close();
                };

                NoButton.Click += (sender, e) =>
                {
                    form.DialogResult = DialogResult.No;
                    form.Close();
                };

                var result = form.ShowDialog();
                form.Dispose();
                return result;
            }
            else
            {
                return DialogResult.None;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
