
namespace Thema1
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.winnerL = new System.Windows.Forms.Label();
            this.playAgainB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.pastGamesL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // winnerL
            // 
            this.winnerL.AutoSize = true;
            this.winnerL.BackColor = System.Drawing.Color.Transparent;
            this.winnerL.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerL.Location = new System.Drawing.Point(113, 49);
            this.winnerL.MinimumSize = new System.Drawing.Size(400, 100);
            this.winnerL.Name = "winnerL";
            this.winnerL.Size = new System.Drawing.Size(458, 100);
            this.winnerL.TabIndex = 0;
            this.winnerL.Text = "Winner is \"Enter Winner Here\"";
            this.winnerL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainB
            // 
            this.playAgainB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.playAgainB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgainB.Location = new System.Drawing.Point(57, 294);
            this.playAgainB.Name = "playAgainB";
            this.playAgainB.Size = new System.Drawing.Size(166, 54);
            this.playAgainB.TabIndex = 1;
            this.playAgainB.Text = "Play Again";
            this.playAgainB.UseVisualStyleBackColor = false;
            this.playAgainB.Click += new System.EventHandler(this.playAgainB_Click);
            // 
            // closeB
            // 
            this.closeB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeB.Location = new System.Drawing.Point(478, 294);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(134, 58);
            this.closeB.TabIndex = 2;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = false;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // pastGamesL
            // 
            this.pastGamesL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pastGamesL.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastGamesL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pastGamesL.Location = new System.Drawing.Point(217, 420);
            this.pastGamesL.Name = "pastGamesL";
            this.pastGamesL.Size = new System.Drawing.Size(238, 54);
            this.pastGamesL.TabIndex = 3;
            this.pastGamesL.Text = "My Past Games Scores";
            this.pastGamesL.UseVisualStyleBackColor = false;
            this.pastGamesL.Click += new System.EventHandler(this.pastGamesL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Do you want to play Again?";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pastGamesL);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.playAgainB);
            this.Controls.Add(this.winnerL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End Screen";
            this.Load += new System.EventHandler(this.EndScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winnerL;
        private System.Windows.Forms.Button playAgainB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Button pastGamesL;
        private System.Windows.Forms.Label label1;
    }
}