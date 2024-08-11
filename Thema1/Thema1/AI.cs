using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Thema1
{
    class AI
    {
        public String buttonName = "Nothing";
        private readonly Random rd = new Random();
        //here we keep the selected coordinates
        private readonly List<Tuple<int, int>> coordinatedSelected = new List<Tuple<int, int>>();
        public void SelectPlayerShips(TableLayoutPanel table)
        {
            int row = rd.Next(10);
            int column = rd.Next(10);
            //if the coordinates has not checked yet
            if (coordinatedSelected.Count <= 100)
            {
                if (!coordinatedSelected.Contains(new Tuple<int, int>(row, column)))
                {

                    buttonName = "Nothing";
                    //Console.WriteLine($"AI found something in {column}, {row}");
                    //check if this table cell have a control (Button->Ship) into it
                    if (table.GetControlFromPosition(column, row) != null)
                    {
                        //Console.WriteLine($"I will add new picture in {row}, {column}");
                        //add the counter of the ships
                        buttonName = table.GetControlFromPosition(column, row).Name;
                        //remove the initial control (Button)
                        table.Controls.Remove(table.GetControlFromPosition(column, row));
                        //create and add the new control (PictureBox->X) 
                        PictureBox sankShip = new PictureBox();
                        sankShip.Image = Properties.Resources.sunk;
                        sankShip.SizeMode = PictureBoxSizeMode.StretchImage;
                        table.Controls.Add(sankShip, column, row);
                    }
                    else //if this table cell doesn't have a control 
                    {
                        buttonName = "Nothing";
                        //create and add a control (PictureBox->-)
                        PictureBox missed = new PictureBox();
                        missed.Image = Properties.Resources.missed;
                        missed.SizeMode = PictureBoxSizeMode.StretchImage;
                        table.Controls.Add(missed, column, row);
                    }
                    //Console.WriteLine($"{buttonName} value before exiting the method");
                    //add this selection of row and column into the tuple
                    coordinatedSelected.Add(new Tuple<int, int>(row, column));
                }
                else
                {
                    //repeat the method
                    SelectPlayerShips(table);
                }
            }
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173