using System;
using System.Drawing;
using System.Windows.Forms;

namespace Thema1
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        //player Name
        public string playerName;
        //manage both player and enemy tables
        private SetSpace spaces = new SetSpace();
        //manage the player table
        private BasicTable gamerTable = new BasicTable();
        //manage the pc table
        private BasicTable aITable = new BasicTable();
        //manage the movements of the pc player
        private AI playerAI = new AI();
        //manage the ships of the player
        private Ships shipsPl = new Ships();
        //manage the ships of the ai player
        private Ships shipsAI = new Ships();
        //sea of the ai player
        private Sea seaAI = new Sea();

        private void Game_Load(object sender, EventArgs e)
        {
            loadGame();
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void loadGame()
        {
            RefreshGame();
            StartTheGame();
        }

        //refresh the game if the player want to
        private void RefreshGame()
        {
            startB.Text = startText;
            playerShipsL.Text = "";
            enemyShipsL.Text = "";
            winnerL.Text = "";
            m = 0;
            s = 0;
            shipsAI.timerEnabled = false;
            seaAI.timerEnabled = false;
            timerAI.Enabled = false;
            timer.Enabled = false;
            timerL.Text = "Time: 00:00";
            triesL.Text = "Tries: ";
            hitPlayerBlock = false;
            Controls.Remove(spaces.panelGamer);
            Controls.Remove(spaces.panelAI);
            //manage both player and enemy tables
            spaces = new SetSpace();
            //manage the player table
            gamerTable = new BasicTable();
            //manage the pc table
            aITable = new BasicTable();
            //manage the movements of the pc player
            playerAI = new AI();
            //manage the ships of the player
            shipsPl = new Ships();
            //manage the ships of the ai player
            shipsAI = new Ships();
            //sea of the ai player
            seaAI = new Sea();
        }

        //this method is gonna start the game every time the player choose to.
        private void StartTheGame()
        {
            randomB.Enabled = true;

            //create two panel where the tables are gonna be
            spaces.CreateSpaceForTable(spaces.panelGamer, 100, 200);

            //set the properties for the gamerTable
            gamerTable.CreateTable(0, 0);
            //add the panel with the player table on the game
            spaces.panelGamer.Controls.Add(gamerTable.table);
            Controls.Add(spaces.panelGamer);

            //for the second panel
            spaces.CreateSpaceForTable(spaces.panelAI, 1040, 200);

            //set the properties for the AItable
            aITable.CreateTable(0, 0);
            //add the panel with the pc table on the game
            spaces.panelAI.Controls.Add(aITable.table);
            Controls.Add(spaces.panelAI);

            //-------We have created the panels with all their properties in the game.-----//
            //Create the player ships
            shipsPl.BelondsTo = $"{playerName}'s";
            playerLabel.Text = $"{playerName}'s Battleships";
            shipsPl.Name = playerName;
            shipsPl.LoadImages();
            shipsPl.CreateShip();


            //Create the enemy ships
            shipsAI.BelondsTo = "Enemy's";
            shipsAI.Name = "Enemy";
            shipsAI.CreateShip();
            //allow enemy ships to be clicked
            shipsAI.AIShipsEvents();


            //for the player Table
            gamerTable.shipsTable.Visible = false;
            shipsPl.ShipsSetPosition(gamerTable.shipsTable, shipsPl.shipsBody);
            gamerTable.shipsTable.Visible = true;

            //for the enemy
            aITable.shipsTable.Visible = false;
            shipsAI.ShipsSetPosition(aITable.shipsTable, shipsAI.shipsBody);
            seaAI.CompleteSea(aITable.shipsTable, shipsAI.coordinatesOfShip);
            aITable.shipsTable.Visible = true;
        }
        //Koxanoglou Theodoros P20094
        //Kourpas Danas Aimilios P20100
        //Siampanis Apostolis P20173

        private string gameOver = "Game Over";
        private string startText = "Start";
        private string continueText = "Continue";
        private string pauseText = "Pause";
        private int m, s;
        private void startB_Click(object sender, EventArgs e)
        {
            randomB.Enabled = false;
            if (timer.Enabled == false && startB.Text == startText)
            {
                //start the timer for the first time
                timer.Enabled = true;
                //set the AI brain on to hit the player when proper
                timerAI.Enabled = true;
                //change the button text
                startB.Text = pauseText;
                //set the table of enemy on, in order to allow the player to play first
                shipsAI.timerEnabled = true;
                seaAI.timerEnabled = true;
                m = 0;
                s = 0;
            }
            else if (timer.Enabled == true && startB.Text == pauseText)
            {
                //pause all timers
                timer.Enabled = false;
                timerAI.Enabled = false;
                //change button text
                startB.Text = continueText;
                //do not allow player to hit another AI box
                shipsAI.timerEnabled = false;
                seaAI.timerEnabled = false;
            }
            else if (timer.Enabled == false && startB.Text == continueText)
            {
                //continue the timer
                timer.Enabled = true;
                timerAI.Enabled = true;
                //change button text
                startB.Text = pauseText;
                //allow player to hit another AI box
                shipsAI.timerEnabled = true;
                seaAI.timerEnabled = true;
            }
        }
        //every time the player hits an enemy block
        bool hitPlayerBlock = false;
        private void timerAI_Tick(object sender, EventArgs e)
        {
            //Upadate the labels
            triesL.Text = $"Tries: {shipsAI.triesCount + seaAI.triesCount}";
            playerShipsL.Text = shipsPl.shipSanked;
            enemyShipsL.Text = shipsAI.shipSanked;
            //What happen the game is over
            if (shipsPl.countGameOver == 4)
            {

                shipsAI.timerEnabled = false;
                seaAI.timerEnabled = false;
                timerAI.Enabled = false;
                timer.Enabled = false;
                startB.Text = gameOver;
                winnerL.TextAlign = ContentAlignment.MiddleCenter;
                winnerL.Text = "The enemy\nhas taken\nyour sea!";
                Console.WriteLine("Enemy is the Winner");
                endGame("Enemy is the Winner");
            }
            else if (shipsAI.countGameOver == 4)
            {
                shipsAI.timerEnabled = false;
                seaAI.timerEnabled = false;
                timerAI.Enabled = false;
                timer.Enabled = false;
                startB.Text = gameOver;
                winnerL.Text = "The winner is\nYou!";
                winnerL.TextAlign = ContentAlignment.MiddleCenter;
                Console.WriteLine("You are the Winner");
                endGame("You are the Winner");
            }
            else
            {
                //if an AI box has been hit
                if (hitPlayerBlock == false && (shipsAI.boxSelected == true || seaAI.boxSelected == true))
                {

                    //do not allow the player to hit another box before the ai hits one first
                    shipsAI.timerEnabled = false;
                    seaAI.timerEnabled = false;
                    //hit a player box
                    playerAI.SelectPlayerShips(gamerTable.shipsTable);
                    shipsPl.AddSankPlayerShips(playerAI.buttonName);
                    //enemy just hit one player box
                    hitPlayerBlock = true;
                }
                //allow the player to hit another AI box
                else if (hitPlayerBlock == true)
                {
                    //allow the player to hit the AI once again
                    shipsAI.timerEnabled = true;
                    seaAI.timerEnabled = true;
                    //disable any handler
                    shipsAI.boxSelected = false;
                    seaAI.boxSelected = false;
                    hitPlayerBlock = false;
                }
            }
        }
        //changeCountTimerLabel
        private void timer_Tick(object sender, EventArgs e)
        {
            s += 1;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m == 60)
            {
                m = 0;
                MessageBox.Show("Game Over");
            }
            timerL.Text = $"Time: {m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}";
        }
        //end or repeat the game
        private void endGame(string winner = "Winner Here")
        {
            EndScreen endOfGame = new EndScreen();
            endOfGame.winnerText = winner;
            endOfGame.playerName = playerName;
            //save the player data in the db
            ServerConnection saveData = new ServerConnection();
            saveData.InsertPlayerData(playerName, winner, shipsAI.triesCount + seaAI.triesCount, $"{m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}", shipsPl.countGameOver, shipsAI.countGameOver);
            Hide();
            endOfGame.ShowDialog();
            if (endOfGame.playAgain == true)
            {
                loadGame();
                Show();
            }
            else
            {
                Show();
            }
        }
        //change the position of the ships
        private void RandomB_Click(object sender, EventArgs e)
        {
            loadGame();
        }
    }
}
//Koxanoglou Theodoros P20094
//Kourpas Danas Aimilios P20100
//Siampanis Apostolis P20173