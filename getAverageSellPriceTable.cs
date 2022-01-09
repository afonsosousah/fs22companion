using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Forms;

namespace FS22Companion
{
    public partial class PricesTable
    {
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


            foreach(var cropPriceDict in averageSellPrices[difficulty])
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

    }
}
