
namespace Thema1
{
    partial class PastGames
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PastGames));
            this.pastScoreTable = new System.Windows.Forms.DataGridView();
            this.pastScoresL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pastScoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pastScoreTable
            // 
            this.pastScoreTable.AllowUserToAddRows = false;
            this.pastScoreTable.AllowUserToDeleteRows = false;
            this.pastScoreTable.AllowUserToResizeRows = false;
            this.pastScoreTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.pastScoreTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.pastScoreTable.BackgroundColor = System.Drawing.Color.Azure;
            this.pastScoreTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pastScoreTable.CausesValidation = false;
            this.pastScoreTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.pastScoreTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.pastScoreTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pastScoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pastScoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastScoreTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pastScoreTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.pastScoreTable.Enabled = false;
            this.pastScoreTable.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.pastScoreTable.Location = new System.Drawing.Point(4, 63);
            this.pastScoreTable.MultiSelect = false;
            this.pastScoreTable.Name = "pastScoreTable";
            this.pastScoreTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pastScoreTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pastScoreTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.pastScoreTable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.pastScoreTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pastScoreTable.ShowCellErrors = false;
            this.pastScoreTable.ShowEditingIcon = false;
            this.pastScoreTable.ShowRowErrors = false;
            this.pastScoreTable.Size = new System.Drawing.Size(596, 352);
            this.pastScoreTable.TabIndex = 1;
            this.pastScoreTable.TabStop = false;
            // 
            // pastScoresL
            // 
            this.pastScoresL.AutoSize = true;
            this.pastScoresL.BackColor = System.Drawing.Color.Transparent;
            this.pastScoresL.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastScoresL.Location = new System.Drawing.Point(173, 22);
            this.pastScoresL.Name = "pastScoresL";
            this.pastScoresL.Size = new System.Drawing.Size(266, 38);
            this.pastScoresL.TabIndex = 2;
            this.pastScoresL.Text = "Your Past Scores: ";
            // 
            // PastGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(602, 426);
            this.Controls.Add(this.pastScoresL);
            this.Controls.Add(this.pastScoreTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PastGames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Past Games";
            this.Load += new System.EventHandler(this.PastGames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pastScoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView pastScoreTable;
        private System.Windows.Forms.Label pastScoresL;
    }
}