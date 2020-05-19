namespace collectTheTokensGame
{
    partial class Form1
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
            this.lblCollectedCount = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCollectedCount
            // 
            this.lblCollectedCount.AutoSize = true;
            this.lblCollectedCount.Location = new System.Drawing.Point(12, 9);
            this.lblCollectedCount.Name = "lblCollectedCount";
            this.lblCollectedCount.Size = new System.Drawing.Size(120, 13);
            this.lblCollectedCount.TabIndex = 0;
            this.lblCollectedCount.Text = "TOKENS COLLECTED:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(180, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(80, 13);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "TIME LEFT: 00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblCollectedCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCollectedCount;
        private System.Windows.Forms.Label lblTimer;
    }
}

