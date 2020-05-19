namespace collectTheTokensGame
{
    partial class loginForm
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
            this.btnInputName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblInputName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInputName
            // 
            this.btnInputName.Location = new System.Drawing.Point(15, 51);
            this.btnInputName.Name = "btnInputName";
            this.btnInputName.Size = new System.Drawing.Size(189, 36);
            this.btnInputName.TabIndex = 0;
            this.btnInputName.Text = "ENTER";
            this.btnInputName.UseVisualStyleBackColor = true;
            this.btnInputName.Click += new System.EventHandler(this.btnInputName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblInputName
            // 
            this.lblInputName.AutoSize = true;
            this.lblInputName.Location = new System.Drawing.Point(12, 9);
            this.lblInputName.Name = "lblInputName";
            this.lblInputName.Size = new System.Drawing.Size(192, 13);
            this.lblInputName.TabIndex = 2;
            this.lblInputName.Text = "Please input your name below to begin!";
            // 
            // loginForm
            // 
            this.AcceptButton = this.btnInputName;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 100);
            this.Controls.Add(this.lblInputName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnInputName);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblInputName;
    }
}