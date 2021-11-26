namespace VideoLibrary
{
    partial class FormTags
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
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.lvTags = new System.Windows.Forms.ListView();
            this.ilTags = new System.Windows.Forms.ImageList(this.components);
            this.tbText = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lvTags
            // 
            this.lvTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTags.CheckBoxes = true;
            this.lvTags.Location = new System.Drawing.Point(18, 58);
            this.lvTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTags.Name = "lvTags";
            this.lvTags.Size = new System.Drawing.Size(566, 704);
            this.lvTags.SmallImageList = this.ilTags;
            this.lvTags.TabIndex = 0;
            this.lvTags.UseCompatibleStateImageBehavior = false;
            this.lvTags.View = System.Windows.Forms.View.List;
            this.lvTags.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTags_ItemChecked);
            this.lvTags.SelectedIndexChanged += new System.EventHandler(this.lvTags_SelectedIndexChanged);
            // 
            // ilTags
            // 
            this.ilTags.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilTags.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTags.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(57, 18);
            this.tbText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(476, 26);
            this.tbText.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Image = global::VideoLibrary.Properties.Resources.add_icon;
            this.btAdd.Location = new System.Drawing.Point(544, 14);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(42, 38);
            this.btAdd.TabIndex = 3;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btOk.Location = new System.Drawing.Point(244, 774);
            this.btOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(112, 35);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(18, 18);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(29, 28);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // FormTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 828);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lvTags);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTags";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Тэги";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ListView lvTags;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ImageList ilTags;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btOk;
    }
}