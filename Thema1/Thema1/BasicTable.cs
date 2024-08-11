using System.Drawing;
using System.Windows.Forms;

namespace Thema1
{
    class BasicTable
    {
        //this is the first table where all the labels of the board are stored.
        public TableLayoutPanel table = new TableLayoutPanel();
        //this is a table (inside the first one) where all the ships of the board are stored.
        public TableLayoutPanel shipsTable = new TableLayoutPanel();

        //set properties for rows and colums labels
        private void SetPropRC(TableLayoutPanel table, string[] list, int count, int row, int colum)
        {
            //create a new label with the proper text.
            Label label = new Label
            {
                Text = list[count - 1],
                AutoSize = true,
                Font = new Font("Comic Sans MS", 20, FontStyle.Regular, GraphicsUnit.Point, (0)),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)
            };
            table.Controls.Add(label, row, colum);
        }

        //create the board table (without the ships)
        public void CreateTable(int xP, int yP)
        {
            //set the first table with the labels
            TableLayoutPanel gameTable = new TableLayoutPanel
            {
                Location = new Point(xP, yP),
                Size = new Size(660, 660),
                BackColor = Color.Transparent,
                //Colums
                ColumnCount = 11
            };
            string[] charInTable = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
            for (int i = 0; i < gameTable.ColumnCount; i++)
            {
                gameTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
                if (i != 0)
                {
                    SetPropRC(gameTable, charInTable, i, 0, i);
                }
            }
            //Rows
            gameTable.RowCount = 11;
            string[] numInTable = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            for (int i = 0; i < gameTable.RowCount; i++)
            {
                gameTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
                if (i != 0)
                {
                    SetPropRC(gameTable, numInTable, i, i, 0);
                }
            }
            //set the nested table where the ships will be stored
            TableLayoutPanel nestedTable = new TableLayoutPanel
            {
                Size = new Size(600, 600),
                BackColor = Color.Blue,
                ColumnCount = 10
            };
            for (int i = 0; i < nestedTable.ColumnCount; i++)
            {
                nestedTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            }
            //Rows
            nestedTable.RowCount = 10;
            for (int i = 0; i < gameTable.RowCount; i++)
            {
                nestedTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            }
            nestedTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble;
            gameTable.Controls.Add(nestedTable, 1, 1);
            gameTable.SetRowSpan(nestedTable, 10);
            gameTable.SetColumnSpan(nestedTable, 10);
            table = gameTable;
            shipsTable = nestedTable;
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173