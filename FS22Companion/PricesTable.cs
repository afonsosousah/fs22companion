using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace FS22Companion
{
    public partial class PricesTable : Form
    {
        Dictionary<string, Dictionary<string, int[]>> averageSellPrices = new Dictionary<string, Dictionary<string, int[]>>();

        Dictionary<string, int> basePrices = new Dictionary<string, int>()
        {
            { "Wheat ",  337 },
            { "Barley ",  313 },
            { "Oat ",  532 },
            { "Canola ",  603 },
            { "Sorghum ",  430 },
            { "Grapes ",  603 },
            { "Olives ",  603 },
            { "Sunflowers ",  673 },
            { "Soybeans ",  778 },
            { "Corn ",  380 },
            { "Potatoes ",  172 },
            { "SugarBeet ",  122 },
            { "SugarBeetCut ",  172 },
            { "Cotton ",  1252 },
            { "Sugarcane ",  119 },
            { "Eggs ",  1120 },
            { "Wool ",  940 },
            { "Milk ",  700 },
            { "Chaff ",  42 },
            { "Woodchips ",  80 },
            { "Silage ",  171 },
            { "Wood ",  1000 },
            { "Grass ",  45 },
            { "Hay ",  56 },
            { "Straw ",  41 },
            { "Manure ",  33 },
            { "Slurry ",  33 },
            { "Digestate ",  33 },
            { "Stones ",  50 },
            { "Flour ",  570 },
            { "Bread ",  1520 },
            { "Cake ",  3300 },
            { "Butter ",  900 },
            { "Cheese ",  1800 },
            { "Fabric ",  3000 },
            { "Clothes ",  8000 },
            { "Sugar ",  500 },
            { "Honey ",  1000 },
            { "Cereal ",  2350 },
            { "SunflowerOil ",  1780 },
            { "CanolaOil ",  1640 },
            { "OliveOil ",  2440 },
            { "Raisins ",  1400 },
            { "GrapeJuice ",  1600 },
            { "Lettuce ",  990 },
            { "Tomato ",  500 },
            { "Strawberry ",  250 },
            { "Chocolate ",  2000 },
            { "Boards ",  1300 },
            { "Furniture ",  2000 }
        };

        public PricesTable()
        {
            InitializeComponent();
        }

        private DataTable getAverageSellPricesTable(string difficulty, Dictionary<string, Dictionary<string, int[]>> averageSellPrices)
        {

            DataTable averageSellPricesTable = new DataTable("AverageSellPrices");
            DataColumn dtColumn;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Products";
            dtColumn.Caption = "";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;
            averageSellPricesTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Average";
            dtColumn.Caption = "";
            dtColumn.AutoIncrement = false;
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            averageSellPricesTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Good";
            dtColumn.Caption = "";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            averageSellPricesTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "Best";
            dtColumn.Caption = "";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            averageSellPricesTable.Columns.Add(dtColumn);


            foreach (var cropPriceDict in averageSellPrices[difficulty])
            {
                var cropName = cropPriceDict.Key;
                var cropPriceArray = cropPriceDict.Value;

                var row = averageSellPricesTable.NewRow();
                row["Products"] = cropName;
                row["Average"] = cropPriceArray[0];
                row["Good"] = cropPriceArray[1];
                row["Best"] = cropPriceArray[2];
                averageSellPricesTable.Rows.Add(row);
            }

            return averageSellPricesTable;
        }

        private void PricesTable_Load(object sender, EventArgs e)
        {
            // Easy prices
            var easyPrices = new Dictionary<string, int[]>();
            foreach (var pair in basePrices)
            {
                var name = pair.Key;
                var price = pair.Value;
                easyPrices.Add(name, new int[] { 3 * price, (int)(3 * price * 1.21 * 1.25 * 0.95), (int)(3 * price * 1.21 * 1.25) });
            }

            // Medium prices
            var mediumPrices = new Dictionary<string, int[]>();
            foreach (var pair in basePrices)
            {
                var name = pair.Key;
                var price = pair.Value;
                mediumPrices.Add(name, new int[] { (int)(1.8 * price), (int)(1.8 * price * 1.21 * 1.25 * 0.95), (int)(1.8 * price * 1.21 * 1.25) });
            }

            // Hard prices
            var hardPrices = new Dictionary<string, int[]>();
            foreach (var pair in basePrices)
            {
                var name = pair.Key;
                var price = pair.Value;
                hardPrices.Add(name, new int[] { price, (int)(price * 1.21 * 1.25 * 0.95), (int)(price * 1.21 * 1.25) });
            }

            averageSellPrices.Add("Easy", easyPrices);
            averageSellPrices.Add("Medium", mediumPrices);
            averageSellPrices.Add("Hard", hardPrices);

            dataGridView1.DataSource = getAverageSellPricesTable("Easy", averageSellPrices);

            dataGridView1.Columns["Products"].DefaultCellStyle.BackColor = SystemColors.Control;
            dataGridView1.Columns["Average"].DefaultCellStyle.BackColor = Color.CornflowerBlue;
            dataGridView1.Columns["Good"].DefaultCellStyle.BackColor = Color.LightGreen;
            dataGridView1.Columns["Best"].DefaultCellStyle.BackColor = Color.LimeGreen;

            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.SelectionBackColor = column.DefaultCellStyle.BackColor;
                column.DefaultCellStyle.SelectionForeColor = Color.Black;
                column.DefaultCellStyle.ForeColor = Color.Black;
            }

            dataGridView1.MouseWheel += (sender2, e2) => 
            {
                var newValue = (int) Math.Round((decimal)(dataGridView1.FirstDisplayedScrollingRowIndex / 2), MidpointRounding.ToEven) * 2 - e2.Delta / 60;
                if (newValue >= 0)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = newValue;
                    tableScrollBar.Value = newValue;
                }
            };

            //this.Controls["label1"].Font = MemoryFonts.GetFont(0, (float)12.5);
            //this.Controls["panel1"].Controls["difficultyLabel"].Font = MemoryFonts.GetFont(0, (float)12.5);
            //this.Controls["label2"].Font = MemoryFonts.GetFont(0, (float)9);

            /*foreach (Control control in this.Controls)
            {
                if(control.HasChildren)
                {
                    foreach(Control control1 in control.Controls)
                    {
                        if(control1.GetType() == typeof(Label))
                            control1.Font = MemoryFonts.GetFont(0, (float)12.5);
                    }
                }
                if (control.GetType() == typeof(Label))
                    control.Font = MemoryFonts.GetFont(0, (float)12.5);
            }*/

            //difficultyButtonLeft.BackgroundImage = IconChar.AngleLeft.ToBitmap(IconFont.Solid, 100, Color.FromArgb(69, 186, 213));
            //difficultyButtonRight.BackgroundImage = IconChar.AngleRight.ToBitmap(IconFont.Solid, 100, Color.FromArgb(69, 186, 213));
        }

        private void dataGridView1_SelectionChanged(Object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void difficultyButtonLeft_Click(object sender, EventArgs e)
        {
            if (difficultyLabel.Text == "Easy")
            {
                difficultyLabel.Text = "Hard";
                dataGridView1.DataSource = getAverageSellPricesTable("Hard", averageSellPrices);
            }
            else if (difficultyLabel.Text == "Hard")
            {
                difficultyLabel.Text = "Medium";
                dataGridView1.DataSource = getAverageSellPricesTable("Medium", averageSellPrices);
            }
            else if (difficultyLabel.Text == "Medium")
            {
                difficultyLabel.Text = "Easy";
                dataGridView1.DataSource = getAverageSellPricesTable("Easy", averageSellPrices);
            }
        }

        private void difficultyButtonRight_Click(object sender, EventArgs e)
        {
            if (difficultyLabel.Text == "Easy")
            {
                difficultyLabel.Text = "Medium";
                dataGridView1.DataSource = getAverageSellPricesTable("Medium", averageSellPrices);
            }
            else if (difficultyLabel.Text == "Medium")
            {
                difficultyLabel.Text = "Hard";
                dataGridView1.DataSource = getAverageSellPricesTable("Hard", averageSellPrices);
            }
            else if (difficultyLabel.Text == "Hard")
            {
                difficultyLabel.Text = "Easy";
                dataGridView1.DataSource = getAverageSellPricesTable("Easy", averageSellPrices);
            }
        }

        private void tableScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            dataGridView1.FirstDisplayedScrollingRowIndex = e.NewValue;
        }
    }
}
