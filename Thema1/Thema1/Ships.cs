using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Thema1
{
    class Ships
    {
        //set the name of the ships
        public string Name { get; set; }
        public string BelondsTo { get; set; }
        public readonly Random rd = new Random();
        //create a list that has lists with all the buttons of one ship respectively
        public List<List<Button>> shipsBody = new List<List<Button>>();
        //this is the list for the aircraft carrier
        public List<Button> shipAC = new List<Button>();
        //this is the list for the destroyer ship
        public List<Button> shipDS = new List<Button>();
        //this is the list for the military ship
        public List<Button> shipMS = new List<Button>();
        //this is the list for the submarine
        public List<Button> shipS = new List<Button>();
        //set the positions of the ships on the table
        public readonly List<Tuple<int, int>> coordinatesOfShip = new List<Tuple<int, int>>();
        private int sizeOfShip = 5;
        //the dynamics coordinates of each ship
        private int row = 0;
        private int column = 0;
        private int rotateImage = 0;

        //check if one of the 5 ships has been hit
        public bool boxSelected = false;

        //these are counters that counts how many times a ship was targeted
        public int shipACSank = 0;
        public int shipDSSank = 0;
        public int shipMSSank = 0;
        public int shipSSank = 0;

        //these are temprary counters that they will only be used to store their respective values in the database 
        public int tempShipACSank = 0;
        public int tempShipDSSank = 0;
        public int tempShipMSSank = 0;
        public int tempShipSSank = 0;

        //save the last ship that was sanked
        public string shipSanked = "";

        //count any click only when the timer is enabled
        public bool timerEnabled = false;
        public int triesCount = 0;

        //we create a different member for every ship in this class
        public Button ac_1 = new Button();
        public Button ac_2 = new Button();
        public Button ac_3 = new Button();
        public Button ac_4 = new Button();
        public Button ac_5 = new Button();
        public Button ds_1 = new Button();
        public Button ds_2 = new Button();
        public Button ds_3 = new Button();
        public Button ds_4 = new Button();
        public Button ms_1 = new Button();
        public Button ms_2 = new Button();
        public Button ms_3 = new Button();
        public Button s_1 = new Button();
        public Button s_2 = new Button();

        //if we wonna load the images for the player. The Ai ships should be invisible
        public void LoadImages()
        {
            ac_1.Image = Properties.Resources.ac_1;
            ac_2.Image = Properties.Resources.ac_2;
            ac_3.Image = Properties.Resources.ac_3;
            ac_4.Image = Properties.Resources.ac_4;
            ac_5.Image = Properties.Resources.ac_5;
            ds_1.Image = Properties.Resources.ds_1;
            ds_2.Image = Properties.Resources.ds_2;
            ds_3.Image = Properties.Resources.ds_3;
            ds_4.Image = Properties.Resources.ds_4;
            ms_1.Image = Properties.Resources.ms_1;
            ms_2.Image = Properties.Resources.ms_2;
            ms_3.Image = Properties.Resources.ms_3;
            s_1.Image = Properties.Resources.s_1;
            s_2.Image = Properties.Resources.s_2;

            Console.WriteLine("Images for the player table were loaded.");
        }
        //create the 5 ships of the board
        public void CreateShip()
        {
            //load the button to their respective list and set some other properties
            //list for the aircraft carrier
            shipAC.Add(ac_1);
            shipAC.Add(ac_2);
            shipAC.Add(ac_3);
            shipAC.Add(ac_4);
            shipAC.Add(ac_5);
            foreach (Button part in shipAC)
            {
                part.Name = "ac";
            }
            //list for the destroyer ship
            shipDS.Add(ds_1);
            shipDS.Add(ds_2);
            shipDS.Add(ds_3);
            shipDS.Add(ds_4);
            foreach (Button part in shipDS)
            {
                part.Name = "ds";
            }
            //list for the military ship
            shipMS.Add(ms_1);
            shipMS.Add(ms_2);
            shipMS.Add(ms_3);
            foreach (Button part in shipMS)
            {
                part.Name = "ms";
            }
            //list for the submarine
            shipS.Add(s_1);
            shipS.Add(s_2);
            foreach (Button part in shipS)
            {
                part.Name = "s";
            }

            //load the ships/list to a list with all the ships of the table
            shipsBody.Add(shipAC);
            shipsBody.Add(shipDS);
            shipsBody.Add(shipMS);
            shipsBody.Add(shipS);

            //create the 5 ships for one board
            for (int i = 0; i < shipsBody.Count; i++)
            {
                foreach (Button p in shipsBody[i])
                {
                    p.Size = new Size(60, 60);
                    p.BackColor = Color.Blue;
                    p.Text = null;
                    p.TabStop = false;
                    p.FlatStyle = FlatStyle.Flat;
                    p.FlatAppearance.BorderSize = 0;
                    p.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
                }
            }
            Console.WriteLine("\nShips set with right properties.\n");
        }

        //event that activates when a ship button is selected (used by the enemy bot for now)
        public void Ship_Click(object sender, EventArgs e)
        {
            if (timerEnabled == true)
            {
                triesCount++;
                Button ship = sender as Button;
                AddSankAIShips(ship);
                ship.Image = Properties.Resources.sunk;
                //ship.ForeColor = Color.Red;
                //ship.Enabled = false;
                Console.WriteLine($"You have just hit one part of the ship {ship.Name}");
                //raise the handler of the hit box
                boxSelected = true;
                ship.Click -= Ship_Click;
            }
        }
        //for the ships of the enemy, activate the click event
        public void AIShipsEvents()
        {
            for (int i = 0; i < shipsBody.Count; i++)
            {
                foreach (Button p in shipsBody[i])
                {
                    p.Click += new EventHandler(Ship_Click);
                }
            }
        }

        //check what ships was targeted (by the enemy) and make the counter go up by one
        public void AddSankAIShips(Button ship)
        {
            if (shipAC.Contains(ship) && shipACSank < 5)
            {
                shipACSank++;
                tempShipACSank = shipACSank;
            }
            else if (shipDS.Contains(ship) && shipDSSank < 4)
            {
                shipDSSank++;
                tempShipDSSank = shipDSSank;
            }
            else if (shipMS.Contains(ship) && shipMSSank < 3)
            {
                shipMSSank++;
                tempShipMSSank = shipMSSank;
            }
            else if (shipS.Contains(ship) && shipSSank < 2)
            {
                shipSSank++;
                tempShipSSank = shipSSank;
            }
            CheckShipSank();
            if (Name == "Enemy")
            {
                Console.WriteLine($"\nYou have sank HIS AC: {tempShipACSank}, DS: {tempShipDSSank}, MS: {tempShipMSSank}, S: {tempShipSSank}\n");
            }
            else
            {
                Console.WriteLine($"\nEnemy have sank YOUR AC: {tempShipACSank}, DS: {tempShipDSSank}, MS: {tempShipMSSank}, S: {tempShipSSank}\n");
            }
        }

        //check if the player has hit a part of the enemy ships
        public void AddSankPlayerShips(string ship)
        {

            if (ship == "ac" && shipACSank < 5)
            {
                shipACSank++;
                tempShipACSank = shipACSank;
            }
            else if (ship == "ds" && shipDSSank < 4)
            {
                shipDSSank++;
                tempShipDSSank = shipDSSank;
            }
            else if (ship == "ms" && shipMSSank < 3)
            {
                shipMSSank++;
                tempShipMSSank = shipMSSank;
            }
            else if (ship == "s" && shipSSank < 2)
            {
                shipSSank++;
                tempShipSSank = shipSSank;
            }
            CheckShipSank();
            if (Name == "Enemy")
            {
                Console.WriteLine($"\nYou have sank HIS AC: {tempShipACSank}, DS: {tempShipDSSank}, MS: {tempShipMSSank}, S: {tempShipSSank}\n");
            }
            else
            {
                Console.WriteLine($"\nEnemy have sank YOUR AC: {tempShipACSank}, DS: {tempShipDSSank}, MS: {tempShipMSSank}, S: {tempShipSSank}\n");
            }
        }

        //used both by enemy and player controls
        public int countGameOver = 0;
        public void CheckShipSank()
        {
            if (shipACSank == 5)
            {
                Console.WriteLine($"{BelondsTo} airecraft carrier was sank!");
                shipSanked = $"{BelondsTo} airecraft carrier was sank!";
                shipACSank = 0;
                countGameOver++;
            }
            else if (shipDSSank == 4)
            {
                Console.WriteLine($"{BelondsTo} destroyer ship was sank!");
                shipSanked = $"{BelondsTo} destroyer ship was sank!";
                shipDSSank = 0;
                countGameOver++;
            }
            else if (shipMSSank == 3)
            {
                Console.WriteLine($"{BelondsTo} military ship was sank!");
                shipSanked = $"{BelondsTo} military ship was sank!";
                shipMSSank = 0;
                countGameOver++;
            }
            else if (shipSSank == 2)
            {
                Console.WriteLine($"{BelondsTo} submarine was sank!");
                shipSanked = $"{BelondsTo} submarine was sank!";
                shipSSank = 0;
                countGameOver++;
            }

            if (Name == "Enemy")
            {
                Console.WriteLine($"\nYou have sunk: {countGameOver} ships\n");
            }
            else
            {
                Console.WriteLine($"\nEnemy have sunk: {countGameOver} ships\n");
            }
        }
        //set the coordinates of the ship
        //on the given tables, set their positions
        //TO BE MOVED TO THE SHIP CLASS
        public void ShipsSetPosition(TableLayoutPanel table, List<List<Button>> shipsList)
        {
            //for every ship/list on the list
            foreach (List<Button> f in shipsList)
            {
                Console.WriteLine($"This is the {f} ship\n");
                //rotate the image rand
                rotateImage = rd.Next(2); //return 0 or 1
                ShipCoordinate(table, f);
                sizeOfShip--;
            }
        }
        private void ShipCoordinate(TableLayoutPanel table, List<Button> f)
        {
            //based on the rotation set the coordinates of the ship
            Console.WriteLine($"This is my size {sizeOfShip}: and this is my rotation: {rotateImage}");
            //we set the values of random here 
            int changeNumber1 = rd.Next(10);
            int changeNumber2 = rd.Next(10 - sizeOfShip);
            Console.WriteLine($"\nThis is the changeNumber1: {changeNumber1} and this is the changeNumber2: {changeNumber2}\n");
            //we choose a random cell
            switch (rotateImage)
            {
                case 0:
                    row = changeNumber1;
                    column = changeNumber2;
                    break;
                case 1:
                    foreach (Button p in f)
                    {
                        if (p.Image != null)
                        {
                            p.Image.RotateFlip(RotateFlipType.Rotate90FlipNone); //90 degrees clockwise - no flip
                        }
                    }
                    row = changeNumber2;
                    column = changeNumber1;
                    break;
            }
            //Console.WriteLine($"These are my coordinates: {row}, {column}");
            //-------------exlude list coordinates-------------------------//
            //check everytime if a coordinate is free or not to be occupied by a part of a ship
            bool checkCoordinates = true;
            switch (rotateImage)
            {
                //if the ship is orizontal
                case 0:
                    for (int i = 0; i < sizeOfShip; i++)
                    {
                        //check if the coordinates belong in a ship
                        if (coordinatesOfShip.Contains(new Tuple<int, int>(row, column + i)))
                        {
                            Console.WriteLine($"These coordinates: {row}, {column + i} are not available");
                            checkCoordinates = false;
                        }
                    }
                    break;
                //if the ship is vertical
                case 1:
                    for (int i = 0; i < sizeOfShip; i++)
                    {

                        if (coordinatesOfShip.Contains(new Tuple<int, int>(row + i, column)))
                        {
                            Console.WriteLine($"These coordinates: {row + i}, {column} are not available");
                            checkCoordinates = false;
                        }
                    }
                    break;
            }
            //what happens after the check
            if (checkCoordinates == false)
            {
                Console.WriteLine($"These coordinates: {row}, {column} are not available");
                //undo the rotate
                if (rotateImage == 1)
                {
                    foreach (Button p in f)
                    {
                        if (p.Image != null)
                        {
                            p.Image.RotateFlip(RotateFlipType.Rotate270FlipNone); //270 degrees clockwise - no flip
                        }
                    }
                }
                //recall method to pick another coordinates
                ShipCoordinate(table, f);
            }
            else
            {
                //based on what rotation the ship has
                switch (rotateImage)
                {
                    case 0:
                        //exclude the proper rows and columns from the list
                        int i = 0;
                        foreach (Button p in f)
                        {
                            table.Controls.Add(p, column + i, row);
                            coordinatesOfShip.Add(new Tuple<int, int>(row, column + i));
                            Console.WriteLine($"\nI occuping these coordinates: {row}, {column + i}");
                            if (i < sizeOfShip)
                            {
                                i++;
                            }
                        }
                        break;
                    case 1:
                        //exclude the proper rows and columns from the list
                        int j = 0;
                        foreach (Button p in f)
                        {
                            table.Controls.Add(p, column, row + j);
                            coordinatesOfShip.Add(new Tuple<int, int>(row + j, column));
                            Console.WriteLine($"\nI occuping these coordinates: {row + j}, {column}");
                            if (j < sizeOfShip)
                            {
                                j++;
                            }
                        }
                        break;
                }
                Console.WriteLine("Let's move to our next ship placement on the sea\n\n\n");
            }
            //---------------end of checking of coordinates of the ship in the table-------------------//

        }
    }
}