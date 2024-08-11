using System.Drawing;
using System.Windows.Forms;

namespace Thema1
{
    class SetSpace
    {
        public Panel panelGamer = new Panel();
        public Panel panelAI = new Panel();
        public void CreateSpaceForTable(Panel space, int xL, int yL)
        {
            space.Size = new Size(660, 660);
            space.Location = new Point(xL, yL);
            space.BackColor = Color.Cyan;
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173