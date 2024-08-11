using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Thema2
{
    public partial class SlotMachine : Form
    {
        string connectionString = "Data source=SlotMachineDB.db;Version=3";
        public int betting;
        public int earnings = 0;

        public int totalBetting = 0;
        public int totalEarnings = 0;

        //number of slots that will be created
        public int numOfSlots = 3;
        //the screen (panel) of the game
        private SlotScreen panel = new SlotScreen();
        //this list is were all the slots are stored. It is very important, thank you
        private readonly List<Slot> slotsL = new List<Slot>();
        private readonly List<string> luckyLymbols = new List<string>();
        public SlotMachine()
        {
            InitializeComponent();
        }
        private void SlotMachine_Load(object sender, EventArgs e)
        {
            //save the properties of the game screen in the panel of the form
            panel = CreateScreen();
            Controls.Add(panel.outerScreen);
            //set the defaults slots.
            ChangeSlots(numOfSlots, 800);
        }
        //lock the respective option in the "choose slot" menu
        private void SlotMenu()
        {
            switch (numOfSlots)
            {
                case 3:
                    ActivateSlotMenu(false, true, true);
                    break;
                case 4:
                    ActivateSlotMenu(true, false, true);
                    break;
                case 5:
                    ActivateSlotMenu(true, true, false);
                    break;
            }
        }
        //it create the screen of the slots (two panels, one inside of the other in order to make the invisible effect for the pictureboxes that exists in the slots)
        private SlotScreen CreateScreen()
        {
            SlotScreen gameScreen = new SlotScreen();
            gameScreen.CreateSlotScreen(numOfSlots);
            gameScreen.outerScreen.Location = new Point(34, 38);
            return gameScreen;
        }
        //it creates one slot of the game
        private void CreateSlot(int xL, SlotScreen gameScreen)
        {
            Slot slot = new Slot();
            slot.LoadImages();
            //pass the numOfSlots to the object slot in order to make dynamic timers later in the game
            slot.numOfSlots = numOfSlots;
            slot.CreateSlotPictures();
            //2 pictureboxes under the same slot with different images
            //set dynamically the position of the slots inside the screen
            int yL = 0;
            for (int i = 0; i < 2; i++)
            {
                slot.slotPictureL[i].Location = new Point(xL, yL);
                gameScreen.baseScreen.Controls.Add(slot.slotPictureL[i]);
                yL += 300;
            }
            //set the timer
            slot.SetTimer();
            //and add the slot to the list
            slotsL.Add(slot);
        }
        //activate/disable the proper 'select slot' 
        private void ActivateSlotMenu(bool slot3, bool slot4, bool slot5)
        {
            slotsToolStripMenuItem.Enabled = slot3;
            slotsToolStripMenuItem1.Enabled = slot4;
            slotsToolStripMenuItem2.Enabled = slot5;
        }

        //coins to bet
        int countCoin = 0;

        //incert coin button insert
        private void InsertCoinB_Click(object sender, EventArgs e)
        {
            countCoin++;
            coinsL.Text = $"{countCoin} Coins";
        }


        //spin button commands
        private void SpinB_Click(object sender, EventArgs e)
        {
            //check if player has bet at least one coin
            if (countCoin == 0)
            {
                MessageBox.Show("Please insert one coin at least to start the slot machine game");
            }
            else
            {
                betting = countCoin;
                result.Text = "";
                //disable the buttons
                spinB.Enabled = false;
                insertCoinB.Enabled = false;
                chooseSlotsToolStripMenuItem.Enabled = false;
                //set the slots
                ChangeSlots(numOfSlots, Size.Width);
                //and activate the timers
                ActivateTimers();
            }
        }

        //what happens when we activate the timers
        private void ActivateTimers()
        {
            foreach (Slot slot in slotsL)
            {
                slot.timer.Enabled = true;
            }
            //per 3 seconds stop the timer of a slot
            stopRollingTimer.Enabled = true;
        }
        //primary counter to stop the timer when all the slots has stopped
        int slotToStop = 0;
        private void StopRollingTimer_Tick(object sender, EventArgs e)
        {
            if (slotToStop < slotsL.Count)
            {
                Console.WriteLine($"This the Slot that is gonna stop RIGHT NOW: {slotToStop}");
                //stop the timer of the slot
                slotsL[slotToStop].timer.Enabled = false;
                for (int i = 0; i < 2; i++)
                {
                    //take the picturebox that it was just respawned 
                    if (slotsL[slotToStop].slotPictureL[i].Top < 0)
                    {
                        slotsL[slotToStop].slotPictureL[i].Top = 0;
                        //slotsL[slotToStop].slotPictureL[i].Name = $"This slot has the {1} symbol";
                        luckyLymbols.Add(slotsL[slotToStop].slotPictureL[i].Name);
                    }
                    else
                    {
                        slotsL[slotToStop].slotPictureL[i].Visible = false;
                    }
                }
                slotToStop++;
            }
            else
            {
                //when slot's timers pause, the global timer pauses.
                stopRollingTimer.Enabled = false;
                int sameSymbol = 0;
                foreach (string fruit2 in luckyLymbols)
                {
                    Console.WriteLine($"This the name of the FIRST picture: {luckyLymbols[0]}");
                    Console.WriteLine($"This the name of the SECOND picture: {fruit2}");
                    Console.WriteLine($"This the name of the picture: {luckyLymbols[0] == fruit2}");
                    if (luckyLymbols[0] == fruit2)
                    {
                        sameSymbol++;
                    }
                }
                //if all the symbols are the same
                if (sameSymbol == numOfSlots)
                {
                    earnings = countCoin * Convert.ToInt32(Math.Pow(2, numOfSlots));
                    result.Text = $"{earnings} Coins";
                    //----------------->this is where we are going to connect our database.<-------------------------------//                   
                    ServerConnection serverConnection = new ServerConnection();
                    serverConnection.Insertion(connectionString, betting, earnings);
                    //reset countCoin
                    countCoin = 0;
                }
                else
                {
                    //----------------->this is where we are going to connect our database.<-------------------------------//
                    ServerConnection serverConnection = new ServerConnection();
                    serverConnection.Insertion(connectionString, betting, earnings);
                    //reset countCoin
                    countCoin = 0;
                    result.Text = "Better Luck Next Time";
                }
                slotToStop = 0;
                //reactivate the buttons of the game
                spinB.Enabled = true;
                insertCoinB.Enabled = true;
                chooseSlotsToolStripMenuItem.Enabled = true;
                //and clear the list of the selected symbols
                luckyLymbols.Clear();
            }

        }
        //set the new slots every time we set more or less slots or when we want, as a player, to spin again.
        private void ChangeSlots(int num, int xSize)
        {
            //number of slots
            numOfSlots = num;
            BackgroundImage = Properties.Resources.money_background;
            Size = new Size(xSize, 550);
            //make the game align in center
            //each time we remove the slots and we create new ones in order to run the program again.
            stopRollingTimer.Enabled = false;
            slotsL.Clear();
            panel.baseScreen.Controls.Clear();
            //the proper size of the screen
            panel.CreateSlotScreen(numOfSlots);

            //the paramateres of the screen
            int xL = 0;
            //create the number of slots we want
            for (int j = 0; j < numOfSlots; j++)
            {
                CreateSlot(xL, panel);
                xL += 235;
            }

            SlotMenu();
        }
        //----------------->Slots on Menustrip<-------------------------------//
        private void SlotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeSlots(3, 800);
            Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
        }
        private void SlotsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChangeSlots(4, 1035);
            Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
        }
        private void SlotsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ChangeSlots(5, 1275);
            Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (Size.Height / 2));
        }
        //----------------->Statistics on Menustrip<-------------------------------//
        private void statisticsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ServerConnection serverConnection = new ServerConnection();
            MessageBox.Show(serverConnection.Selection(connectionString, totalBetting, totalEarnings));
        }
        //----------------->Help->About on Menustrip<-------------------------------//
        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please insert at least one coin to start the slot machine game!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SlotMachine_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173