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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/TrHtNygusw");
        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/afonsosousah/fs22companion");
        }
    }
}
