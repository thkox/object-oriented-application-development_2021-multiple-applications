using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Thema1
{
    class Sea
    {
        //check if sea box has been selected
        public bool boxSelected = false;
        //it add the rest of the blank cells with blank buttons
        public void CompleteSea(TableLayoutPanel table, List<Tuple<int, int>> coordinatesOfShip)
        {
            //every time we wonna to include a button: check cordinates and add a blank button
            for (int row = 0; row <= 9; row++)
            {
                for (int column = 0; column <= 9; column++)
                {
                    //Console.WriteLine($"This is my row {row} and this is my column {column}");
                    if (!coordinatesOfShip.Contains(new Tuple<int, int>(row, column)))
                    {
                        //create a buttonSea
                        Button seaB = new Button();
                        seaB = CreateButtons(seaB);
                        table.Controls.Add(seaB, column, row);
                        //Console.WriteLine($"Sea button created at: {row}, {column} \n");
                    }
                }
            }
        }
        //the properties of the buttons
        public Button CreateButtons(Button seaB)
        {
            seaB.Name = "Sea";
            seaB.Size = new Size(60, 60);
            //seaB.BackColor = Color.Blue;
            seaB.Text = null;
            seaB.TabStop = false;
            seaB.FlatStyle = FlatStyle.Flat;
            seaB.FlatAppearance.BorderSize = 0;
            seaB.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
            seaB.Click += new EventHandler(Sea_Click);
            return seaB;
        }
        //the event when a player click a see button
        public bool timerEnabled = false;
        public int triesCount = 0;
        public void Sea_Click(object sender, EventArgs e)
        {
            //find which button activate the event
            if (timerEnabled == true)
            {
                triesCount++;
                Button seaB = sender as Button;
                seaB.Image = Properties.Resources.missed;
                Console.WriteLine($"You have just hit {seaB.Name}");
                boxSelected = true;
                seaB.Click -= Sea_Click;
            }
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173