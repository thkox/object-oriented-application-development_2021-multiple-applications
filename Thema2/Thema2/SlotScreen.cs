using System;
using System.Drawing;
using System.Windows.Forms;


namespace Thema2
{
    class SlotScreen
    {
        //the two basic panel of the screen of the game
        public Panel outerScreen = new Panel();
        public Panel baseScreen = new Panel();

        //set the proper size of the screen based on how many slots we have
        public void CreateSlotScreen(int numOfSlots)
        {
            Console.WriteLine($"NumOfslots in slotScreen = {numOfSlots}\n");
            switch (numOfSlots)
            {
                case 3:
                    SizeOfScreen(720, 320, 700, 300);
                    break;
                case 4:
                    SizeOfScreen(955, 320, 935, 300);
                    break;
                case 5:
                    SizeOfScreen(1190, 320, 1170, 300);
                    break;
                default:
                    SizeOfScreen(720, 320, 700, 300);
                    break;
            }

        }
        //self explanatory
        private void SizeOfScreen(int xSizeOut, int ySizeOut, int xSizeIn, int ySizeIn)
        {
            //create the first layer of the screen
            outerScreen.Size = new Size(xSizeOut, ySizeOut);
            outerScreen.BackColor = Color.LightSlateGray;
            //create the second layer of the screen
            baseScreen.Size = new Size(xSizeIn, ySizeIn);
            baseScreen.BackColor = Color.BlanchedAlmond;
            //add the second layer to the first one
            outerScreen.Controls.Add(baseScreen);
            baseScreen.Location = new Point(10, 10);
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173