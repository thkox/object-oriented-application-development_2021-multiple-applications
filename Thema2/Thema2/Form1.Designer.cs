
namespace Thema2
{
    partial class SlotMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotMachine));
            this.spinB = new System.Windows.Forms.Button();
            this.bettingL = new System.Windows.Forms.Label();
            this.coinsL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseSlotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopRollingTimer = new System.Windows.Forms.Timer(this.components);
            this.insertCoinB = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinB
            // 
            this.spinB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spinB.BackColor = System.Drawing.Color.ForestGreen;
            this.spinB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinB.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinB.Location = new System.Drawing.Point(656, 378);
            this.spinB.Name = "spinB";
            this.spinB.Size = new System.Drawing.Size(98, 61);
            this.spinB.TabIndex = 0;
            this.spinB.Text = "SPIN";
            this.spinB.UseVisualStyleBackColor = false;
            this.spinB.Click += new System.EventHandler(this.SpinB_Click);
            // 
            // bettingL
            // 
            this.bettingL.AutoSize = true;
            this.bettingL.BackColor = System.Drawing.Color.Transparent;
            this.bettingL.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bettingL.ForeColor = System.Drawing.Color.Black;
            this.bettingL.Location = new System.Drawing.Point(32, 390);
            this.bettingL.Name = "bettingL";
            this.bettingL.Size = new System.Drawing.Size(117, 40);
            this.bettingL.TabIndex = 2;
            this.bettingL.Text = "Betting:";
            // 
            // coinsL
            // 
            this.coinsL.AutoSize = true;
            this.coinsL.BackColor = System.Drawing.Color.Transparent;
            this.coinsL.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinsL.Location = new System.Drawing.Point(149, 390);
            this.coinsL.Name = "coinsL";
            this.coinsL.Size = new System.Drawing.Size(0, 42);
            this.coinsL.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseSlotsToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseSlotsToolStripMenuItem
            // 
            this.chooseSlotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slotsToolStripMenuItem,
            this.slotsToolStripMenuItem1,
            this.slotsToolStripMenuItem2});
            this.chooseSlotsToolStripMenuItem.Name = "chooseSlotsToolStripMenuItem";
            this.chooseSlotsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.chooseSlotsToolStripMenuItem.Text = "Choose Slots";
            // 
            // slotsToolStripMenuItem
            // 
            this.slotsToolStripMenuItem.Name = "slotsToolStripMenuItem";
            this.slotsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.slotsToolStripMenuItem.Text = "3 Slots";
            this.slotsToolStripMenuItem.Click += new System.EventHandler(this.SlotsToolStripMenuItem_Click);
            // 
            // slotsToolStripMenuItem1
            // 
            this.slotsToolStripMenuItem1.Name = "slotsToolStripMenuItem1";
            this.slotsToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.slotsToolStripMenuItem1.Text = "4 Slots";
            this.slotsToolStripMenuItem1.Click += new System.EventHandler(this.SlotsToolStripMenuItem1_Click);
            // 
            // slotsToolStripMenuItem2
            // 
            this.slotsToolStripMenuItem2.Name = "slotsToolStripMenuItem2";
            this.slotsToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.slotsToolStripMenuItem2.Text = "5 Slots";
            this.slotsToolStripMenuItem2.Click += new System.EventHandler(this.SlotsToolStripMenuItem2_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // stopRollingTimer
            // 
            this.stopRollingTimer.Interval = 3000;
            this.stopRollingTimer.Tick += new System.EventHandler(this.StopRollingTimer_Tick);
            // 
            // insertCoinB
            // 
            this.insertCoinB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.insertCoinB.BackColor = System.Drawing.Color.Transparent;
            this.insertCoinB.BackgroundImage = global::Thema2.Properties.Resources.gold_coin;
            this.insertCoinB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertCoinB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertCoinB.FlatAppearance.BorderSize = 0;
            this.insertCoinB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insertCoinB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertCoinB.Location = new System.Drawing.Point(575, 378);
            this.insertCoinB.Name = "insertCoinB";
            this.insertCoinB.Size = new System.Drawing.Size(60, 60);
            this.insertCoinB.TabIndex = 1;
            this.insertCoinB.UseVisualStyleBackColor = false;
            this.insertCoinB.Click += new System.EventHandler(this.InsertCoinB_Click);
            // 
            // Insert
            // 
            this.Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Insert.AutoSize = true;
            this.Insert.BackColor = System.Drawing.Color.Transparent;
            this.Insert.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(393, 390);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(164, 40);
            this.Insert.TabIndex = 5;
            this.Insert.Text = "Insert Coin:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(36, 442);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 39);
            this.result.TabIndex = 6;
            // 
            // SlotMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.coinsL);
            this.Controls.Add(this.bettingL);
            this.Controls.Add(this.insertCoinB);
            this.Controls.Add(this.spinB);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SlotMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlotMachine_FormClosing);
            this.Load += new System.EventHandler(this.SlotMachine_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button spinB;
        private System.Windows.Forms.Button insertCoinB;
        private System.Windows.Forms.Label bettingL;
        private System.Windows.Forms.Label coinsL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseSlotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem slotsToolStripMenuItem2;
        private System.Windows.Forms.Timer stopRollingTimer;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Insert;
        private System.Windows.Forms.Label result;
    }
}

