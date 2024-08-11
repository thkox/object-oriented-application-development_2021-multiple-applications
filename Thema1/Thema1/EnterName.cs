using System;
using System.Windows.Forms;

namespace Thema1
{
    public partial class EnterName : Form
    {
        public string playerName = "Player";
        public bool selectedClose = true;
        public EnterName()
        {
            InitializeComponent();
        }
        private void EnterName_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 10;
        }

        private void okB_Click(object sender, EventArgs e)
        {
            selectedClose = false;
            //save the username and exit the app
            if (textBox1.Text != "")
            {
                playerName = textBox1.Text;
                Hide();
            }
            else
            {
                Hide();
            }
        }

        private void cancelB_Click(object sender, EventArgs e)
        {
            selectedClose = true;
            Close();
        }


    }
}
