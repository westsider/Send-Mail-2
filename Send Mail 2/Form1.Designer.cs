namespace Send_Mail_2
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
            this.sendMailBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendMailBttn
            // 
            this.sendMailBttn.BackColor = System.Drawing.SystemColors.Highlight;
            this.sendMailBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMailBttn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendMailBttn.Location = new System.Drawing.Point(55, 91);
            this.sendMailBttn.Name = "sendMailBttn";
            this.sendMailBttn.Size = new System.Drawing.Size(170, 43);
            this.sendMailBttn.TabIndex = 0;
            this.sendMailBttn.Text = "send e-mail";
            this.sendMailBttn.UseVisualStyleBackColor = false;
            this.sendMailBttn.Click += new System.EventHandler(this.sendMailBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.sendMailBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendMailBttn;
    }
}

