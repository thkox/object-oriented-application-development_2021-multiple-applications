using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Thema2
{
    class Slot
    {
        //for the rand
        private readonly Random rd = new Random();
        //set the default number of slots
        public int numOfSlots;
        //set a different timer for each slot
        public Timer timer = new Timer();
        //each slot has three different images
        public PictureBox pictureS1 = new PictureBox();
        public PictureBox pictureS2 = new PictureBox();

        public List<Image> symbolsList = new List<Image>();
        public List<PictureBox> slotPictureL = new List<PictureBox>();

        //execute it only once per instance
        public void LoadImages()
        {
            symbolsList.Add(Properties.Resources.seven);
            symbolsList.Add(Properties.Resources.bar);
            symbolsList.Add(Properties.Resources.bell);
            symbolsList.Add(Properties.Resources.cherry);
            symbolsList.Add(Properties.Resources.diamond);
            symbolsList.Add(Properties.Resources.lemon);
        }
        //create the two pictureboxes for the slot
        public void CreateSlotPictures()
        {
            slotPictureL.Add(pictureS1);
            slotPictureL.Add(pictureS2);

            for (int i = 0; i < 2; i++)
            {
                slotPictureL[i].Size = new Size(220, 300);
                slotPictureL[i].SizeMode = PictureBoxSizeMode.StretchImage;

                slotPictureL[i].Visible = true;
                slotPictureL[i].Image = symbolsList[rd.Next(numOfSlots + 1)]; //number of slots + 1 = max pictures that we can use
            }
        }

        //create a different timer for every slot
        public void SetTimer()
        {
            Timer setTimer = new Timer();
            setTimer.Tick += new EventHandler(SetTimer_Tick);
            setTimer.Interval = 1;
            setTimer.Enabled = false;
            timer = setTimer;
        }
        //set the movement of the picturebox
        private void SetTimer_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox j in slotPictureL)
            {
                if (j.Top < 300)
                {
                    j.Top += 10;
                }
                else
                {
                    //respawn
                    j.Top = -300;
                    int temp = rd.Next(numOfSlots + 1);
                    Console.WriteLine($"This slot {j.Name} has the {temp} symbol");
                    j.Image = symbolsList[temp];
                    j.Name = $"SLOT WITH {temp} SYMBOL";
                }
            }
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173