namespace VideoLibrary
{
    partial class FormWant
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
            this.tbWant = new System.Windows.Forms.TextBox();
            this.btSaveWant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWant
            // 
            this.tbWant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWant.Location = new System.Drawing.Point(0, 0);
            this.tbWant.Multiline = true;
            this.tbWant.Name = "tbWant";
            this.tbWant.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWant.Size = new System.Drawing.Size(997, 733);
            this.tbWant.TabIndex = 1;
            this.tbWant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWant_KeyDown);
            // 
            // btSaveWant
            // 
            this.btSaveWant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSaveWant.Location = new System.Drawing.Point(460, 739);
            this.btSaveWant.Name = "btSaveWant";
            this.btSaveWant.Size = new System.Drawing.Size(75, 23);
            this.btSaveWant.TabIndex = 2;
            this.btSaveWant.Text = "Сохранить";
            this.btSaveWant.UseVisualStyleBackColor = true;
            this.btSaveWant.Click += new System.EventHandler(this.btSaveWant_Click);
            // 
            // FormWant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 765);
            this.Controls.Add(this.btSaveWant);
            this.Controls.Add(this.tbWant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormWant";
            this.Text = "Хотет";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWant_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWant_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWant;
        private System.Windows.Forms.Button btSaveWant;
    }
}