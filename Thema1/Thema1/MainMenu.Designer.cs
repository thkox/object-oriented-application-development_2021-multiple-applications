
namespace Thema1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rulesB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.leaderBoardB = new System.Windows.Forms.Button();
            this.pastScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start.Location = new System.Drawing.Point(268, 145);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(210, 70);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "BATTLESHIPS";
            // 
            // rulesB
            // 
            this.rulesB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rulesB.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rulesB.Location = new System.Drawing.Point(268, 221);
            this.rulesB.Name = "rulesB";
            this.rulesB.Size = new System.Drawing.Size(210, 70);
            this.rulesB.TabIndex = 5;
            this.rulesB.Text = "Rules";
            this.rulesB.UseVisualStyleBackColor = false;
            this.rulesB.Click += new System.EventHandler(this.rulesB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitB.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitB.Location = new System.Drawing.Point(669, 508);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(103, 41);
            this.exitB.TabIndex = 6;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = false;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // leaderBoardB
            // 
            this.leaderBoardB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leaderBoardB.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderBoardB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leaderBoardB.Location = new System.Drawing.Point(268, 297);
            this.leaderBoardB.Name = "leaderBoardB";
            this.leaderBoardB.Size = new System.Drawing.Size(210, 70);
            this.leaderBoardB.TabIndex = 7;
            this.leaderBoardB.Text = "Leaderboard";
            this.leaderBoardB.UseVisualStyleBackColor = false;
            this.leaderBoardB.Click += new System.EventHandler(this.leaderBoardB_Click);
            // 
            // pastScores
            // 
            this.pastScores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pastScores.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pastScores.Location = new System.Drawing.Point(12, 508);
            this.pastScores.Name = "pastScores";
            this.pastScores.Size = new System.Drawing.Size(116, 41);
            this.pastScores.TabIndex = 8;
            this.pastScores.Text = "Past Scores";
            this.pastScores.UseVisualStyleBackColor = false;
            this.pastScores.Click += new System.EventHandler(this.pastScores_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pastScores);
            this.Controls.Add(this.leaderBoardB);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.rulesB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seafight";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rulesB;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button leaderBoardB;
        private System.Windows.Forms.Button pastScores;
    }
}

