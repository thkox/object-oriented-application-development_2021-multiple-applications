
namespace Thema1
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.opponentLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerL = new System.Windows.Forms.Label();
            this.startB = new System.Windows.Forms.Button();
            this.timerAI = new System.Windows.Forms.Timer(this.components);
            this.triesL = new System.Windows.Forms.Label();
            this.winnerL = new System.Windows.Forms.Label();
            this.playerShipsL = new System.Windows.Forms.Label();
            this.enemyShipsL = new System.Windows.Forms.Label();
            this.randomB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(734, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "BATTLESHIPS";
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLabel.Location = new System.Drawing.Point(303, 150);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(314, 37);
            this.playerLabel.TabIndex = 4;
            this.playerLabel.Text = "Player\'s Battleships";
            // 
            // opponentLabel
            // 
            this.opponentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.opponentLabel.AutoSize = true;
            this.opponentLabel.BackColor = System.Drawing.Color.Transparent;
            this.opponentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentLabel.Location = new System.Drawing.Point(1216, 150);
            this.opponentLabel.Name = "opponentLabel";
            this.opponentLabel.Size = new System.Drawing.Size(368, 37);
            this.opponentLabel.TabIndex = 5;
            this.opponentLabel.Text = "Opponent\'s Battleships";
            this.opponentLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerL
            // 
            this.timerL.AutoSize = true;
            this.timerL.BackColor = System.Drawing.Color.Transparent;
            this.timerL.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerL.Location = new System.Drawing.Point(780, 616);
            this.timerL.Name = "timerL";
            this.timerL.Size = new System.Drawing.Size(232, 49);
            this.timerL.TabIndex = 7;
            this.timerL.Text = "Time: 00:00";
            // 
            // startB
            // 
            this.startB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startB.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startB.Location = new System.Drawing.Point(789, 487);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(223, 83);
            this.startB.TabIndex = 8;
            this.startB.Text = "Start";
            this.startB.UseVisualStyleBackColor = false;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // timerAI
            // 
            this.timerAI.Interval = 1;
            this.timerAI.Tick += new System.EventHandler(this.timerAI_Tick);
            // 
            // triesL
            // 
            this.triesL.AutoSize = true;
            this.triesL.BackColor = System.Drawing.Color.Transparent;
            this.triesL.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triesL.Location = new System.Drawing.Point(803, 676);
            this.triesL.Name = "triesL";
            this.triesL.Size = new System.Drawing.Size(140, 49);
            this.triesL.TabIndex = 9;
            this.triesL.Text = "Tries: ";
            // 
            // winnerL
            // 
            this.winnerL.AutoSize = true;
            this.winnerL.BackColor = System.Drawing.Color.Transparent;
            this.winnerL.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerL.Location = new System.Drawing.Point(780, 256);
            this.winnerL.Name = "winnerL";
            this.winnerL.Size = new System.Drawing.Size(0, 51);
            this.winnerL.TabIndex = 10;
            // 
            // playerShipsL
            // 
            this.playerShipsL.AutoSize = true;
            this.playerShipsL.BackColor = System.Drawing.Color.Transparent;
            this.playerShipsL.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerShipsL.Location = new System.Drawing.Point(157, 863);
            this.playerShipsL.Name = "playerShipsL";
            this.playerShipsL.Size = new System.Drawing.Size(0, 41);
            this.playerShipsL.TabIndex = 11;
            // 
            // enemyShipsL
            // 
            this.enemyShipsL.AutoSize = true;
            this.enemyShipsL.BackColor = System.Drawing.Color.Transparent;
            this.enemyShipsL.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyShipsL.Location = new System.Drawing.Point(1098, 863);
            this.enemyShipsL.Name = "enemyShipsL";
            this.enemyShipsL.Size = new System.Drawing.Size(0, 41);
            this.enemyShipsL.TabIndex = 12;
            // 
            // randomB
            // 
            this.randomB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.randomB.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.randomB.Location = new System.Drawing.Point(789, 749);
            this.randomB.Name = "randomB";
            this.randomB.Size = new System.Drawing.Size(223, 83);
            this.randomB.TabIndex = 13;
            this.randomB.Text = "Change Ships Position";
            this.randomB.UseVisualStyleBackColor = false;
            this.randomB.Click += new System.EventHandler(this.RandomB_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.randomB);
            this.Controls.Add(this.enemyShipsL);
            this.Controls.Add(this.playerShipsL);
            this.Controls.Add(this.winnerL);
            this.Controls.Add(this.triesL);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.timerL);
            this.Controls.Add(this.opponentLabel);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seafight";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label opponentLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerL;
        private System.Windows.Forms.Button startB;
        private System.Windows.Forms.Timer timerAI;
        private System.Windows.Forms.Label triesL;
        private System.Windows.Forms.Label winnerL;
        private System.Windows.Forms.Label playerShipsL;
        private System.Windows.Forms.Label enemyShipsL;
        private System.Windows.Forms.Button randomB;
    }
}