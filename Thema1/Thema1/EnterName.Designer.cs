
namespace Thema1
{
    partial class EnterName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterName));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterNameL = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.cancelB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(331, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 35);
            this.textBox1.TabIndex = 0;
            // 
            // enterNameL
            // 
            this.enterNameL.AutoSize = true;
            this.enterNameL.BackColor = System.Drawing.Color.Transparent;
            this.enterNameL.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNameL.ForeColor = System.Drawing.Color.Black;
            this.enterNameL.Location = new System.Drawing.Point(29, 38);
            this.enterNameL.Name = "enterNameL";
            this.enterNameL.Size = new System.Drawing.Size(296, 35);
            this.enterNameL.TabIndex = 1;
            this.enterNameL.Text = "Please enter your name:";
            // 
            // okB
            // 
            this.okB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.okB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.okB.Location = new System.Drawing.Point(104, 99);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(111, 57);
            this.okB.TabIndex = 2;
            this.okB.Text = "Ok";
            this.okB.UseVisualStyleBackColor = false;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // cancelB
            // 
            this.cancelB.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancelB.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelB.Location = new System.Drawing.Point(374, 99);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(111, 57);
            this.cancelB.TabIndex = 3;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = false;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Thema1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(584, 186);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.okB);
            this.Controls.Add(this.enterNameL);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnterName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Name";
            this.Load += new System.EventHandler(this.EnterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label enterNameL;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.Button cancelB;
    }
}