namespace VideoLibrary
{
    partial class FormCaptcha
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
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.tbCaptcha = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbCaptcha.Location = new System.Drawing.Point(0, 0);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(310, 50);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCaptcha.TabIndex = 0;
            this.pbCaptcha.TabStop = false;
            // 
            // tbCaptcha
            // 
            this.tbCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCaptcha.Location = new System.Drawing.Point(12, 55);
            this.tbCaptcha.Name = "tbCaptcha";
            this.tbCaptcha.Size = new System.Drawing.Size(286, 20);
            this.tbCaptcha.TabIndex = 1;
            this.tbCaptcha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCaptcha_KeyDown);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btOk.Location = new System.Drawing.Point(119, 81);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // FormCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 113);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbCaptcha);
            this.Controls.Add(this.pbCaptcha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCaptcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Капча";
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.TextBox tbCaptcha;
        private System.Windows.Forms.Button btOk;
    }
}