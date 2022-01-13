namespace VideoLibrary
{
    partial class ucRecordView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRecordView));
            this.tbName = new System.Windows.Forms.TextBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tbSynopsis = new System.Windows.Forms.TextBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tsVideoInfo = new System.Windows.Forms.ToolStrip();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsddbTags = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsddbUserScore = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiUserScore0 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserScore1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserScore2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserScore3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserScore4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserScore5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbOpenInBrowser = new System.Windows.Forms.ToolStripButton();
            this.tsbBrowse = new System.Windows.Forms.ToolStripButton();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbRemove = new System.Windows.Forms.ToolStripButton();
            this.tsbNextSeason = new System.Windows.Forms.ToolStripButton();
            this.tssSeason = new System.Windows.Forms.ToolStripSeparator();
            this.tsbStartSeason = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tsVideoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(4, 39);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(1408, 34);
            this.tbName.TabIndex = 2;
            this.tbName.TabStop = false;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scMain
            // 
            this.scMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scMain.Location = new System.Drawing.Point(4, 114);
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.pbImage);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tbSynopsis);
            this.scMain.Size = new System.Drawing.Size(1408, 1107);
            this.scMain.SplitterDistance = 370;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 22;
            // 
            // tbSynopsis
            // 
            this.tbSynopsis.BackColor = System.Drawing.SystemColors.Control;
            this.tbSynopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSynopsis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSynopsis.Location = new System.Drawing.Point(0, 0);
            this.tbSynopsis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSynopsis.Multiline = true;
            this.tbSynopsis.Name = "tbSynopsis";
            this.tbSynopsis.ReadOnly = true;
            this.tbSynopsis.Size = new System.Drawing.Size(1408, 731);
            this.tbSynopsis.TabIndex = 16;
            this.tbSynopsis.TabStop = false;
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbComment.Location = new System.Drawing.Point(4, 85);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbComment.Name = "tbComment";
            this.tbComment.ReadOnly = true;
            this.tbComment.Size = new System.Drawing.Size(1408, 19);
            this.tbComment.TabIndex = 23;
            this.tbComment.TabStop = false;
            // 
            // tsVideoInfo
            // 
            this.tsVideoInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsVideoInfo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsVideoInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEdit,
            this.tsddbTags,
            this.tsddbUserScore,
            this.tsbOpenInBrowser,
            this.tsbBrowse,
            this.tsbPlay,
            this.tsbRemove,
            this.tssSeason,
            this.tsbStartSeason,
            this.tsbNextSeason});
            this.tsVideoInfo.Location = new System.Drawing.Point(0, 0);
            this.tsVideoInfo.Name = "tsVideoInfo";
            this.tsVideoInfo.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsVideoInfo.Size = new System.Drawing.Size(1418, 32);
            this.tsVideoInfo.TabIndex = 24;
            this.tsVideoInfo.Text = "toolStrip1";
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1408, 370);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::VideoLibrary.Properties.Resources.IconEdit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(28, 29);
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsddbTags
            // 
            this.tsddbTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbTags.Image = global::VideoLibrary.Properties.Resources.IconTag;
            this.tsddbTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbTags.Name = "tsddbTags";
            this.tsddbTags.Size = new System.Drawing.Size(42, 29);
            this.tsddbTags.Text = "Тэги";
            // 
            // tsddbUserScore
            // 
            this.tsddbUserScore.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbUserScore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserScore0,
            this.tsmiUserScore1,
            this.tsmiUserScore2,
            this.tsmiUserScore3,
            this.tsmiUserScore4,
            this.tsmiUserScore5});
            this.tsddbUserScore.Image = ((System.Drawing.Image)(resources.GetObject("tsddbUserScore.Image")));
            this.tsddbUserScore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbUserScore.Name = "tsddbUserScore";
            this.tsddbUserScore.Size = new System.Drawing.Size(40, 29);
            this.tsddbUserScore.Text = "0";
            // 
            // tsmiUserScore0
            // 
            this.tsmiUserScore0.Name = "tsmiUserScore0";
            this.tsmiUserScore0.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore0.Text = "0";
            this.tsmiUserScore0.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore1
            // 
            this.tsmiUserScore1.ForeColor = System.Drawing.Color.Red;
            this.tsmiUserScore1.Name = "tsmiUserScore1";
            this.tsmiUserScore1.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore1.Text = "1";
            this.tsmiUserScore1.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore2
            // 
            this.tsmiUserScore2.ForeColor = System.Drawing.Color.DarkOrange;
            this.tsmiUserScore2.Name = "tsmiUserScore2";
            this.tsmiUserScore2.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore2.Text = "2";
            this.tsmiUserScore2.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore3
            // 
            this.tsmiUserScore3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsmiUserScore3.Name = "tsmiUserScore3";
            this.tsmiUserScore3.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore3.Text = "3";
            this.tsmiUserScore3.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore4
            // 
            this.tsmiUserScore4.ForeColor = System.Drawing.Color.GreenYellow;
            this.tsmiUserScore4.Name = "tsmiUserScore4";
            this.tsmiUserScore4.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore4.Text = "4";
            this.tsmiUserScore4.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore5
            // 
            this.tsmiUserScore5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tsmiUserScore5.Name = "tsmiUserScore5";
            this.tsmiUserScore5.Size = new System.Drawing.Size(106, 30);
            this.tsmiUserScore5.Text = "5";
            this.tsmiUserScore5.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsbOpenInBrowser
            // 
            this.tsbOpenInBrowser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbOpenInBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenInBrowser.Image = global::VideoLibrary.Properties.Resources.IconInternet;
            this.tsbOpenInBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenInBrowser.Name = "tsbOpenInBrowser";
            this.tsbOpenInBrowser.Size = new System.Drawing.Size(28, 29);
            this.tsbOpenInBrowser.Text = "Кинопоиск";
            this.tsbOpenInBrowser.Click += new System.EventHandler(this.tsbOpenInBrowser_Click);
            // 
            // tsbBrowse
            // 
            this.tsbBrowse.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrowse.Image = global::VideoLibrary.Properties.Resources.IconBrowse;
            this.tsbBrowse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrowse.Name = "tsbBrowse";
            this.tsbBrowse.Size = new System.Drawing.Size(28, 29);
            this.tsbBrowse.Text = "Открыть";
            this.tsbBrowse.Click += new System.EventHandler(this.tsbBrowse_Click);
            // 
            // tsbPlay
            // 
            this.tsbPlay.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::VideoLibrary.Properties.Resources.IconPlay;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(28, 29);
            this.tsbPlay.Text = "Запуск";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbRemove
            // 
            this.tsbRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemove.Image = global::VideoLibrary.Properties.Resources.IconTrash;
            this.tsbRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemove.Name = "tsbRemove";
            this.tsbRemove.Size = new System.Drawing.Size(28, 29);
            this.tsbRemove.Click += new System.EventHandler(this.tsbRemove_Click);
            // 
            // tsbNextSeason
            // 
            this.tsbNextSeason.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNextSeason.Image = global::VideoLibrary.Properties.Resources.IconUpload;
            this.tsbNextSeason.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNextSeason.Name = "tsbNextSeason";
            this.tsbNextSeason.Size = new System.Drawing.Size(28, 29);
            this.tsbNextSeason.Click += new System.EventHandler(this.tsbNextSeason_Click);
            // 
            // tssSeason
            // 
            this.tssSeason.Name = "tssSeason";
            this.tssSeason.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbStartSeason
            // 
            this.tsbStartSeason.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStartSeason.Image = global::VideoLibrary.Properties.Resources.IconPlay;
            this.tsbStartSeason.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStartSeason.Name = "tsbStartSeason";
            this.tsbStartSeason.Size = new System.Drawing.Size(28, 29);
            this.tsbStartSeason.Click += new System.EventHandler(this.tsbStartSeason_Click);
            // 
            // ucRecordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tsVideoInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucRecordView";
            this.Size = new System.Drawing.Size(1418, 1226);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tsVideoInfo.ResumeLayout(false);
            this.tsVideoInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox tbSynopsis;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.ToolStrip tsVideoInfo;
        private System.Windows.Forms.ToolStripDropDownButton tsddbTags;
        private System.Windows.Forms.ToolStripDropDownButton tsddbUserScore;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore0;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore3;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore4;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore5;
        private System.Windows.Forms.ToolStripButton tsbOpenInBrowser;
        private System.Windows.Forms.ToolStripButton tsbBrowse;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbRemove;
        private System.Windows.Forms.ToolStripButton tsbNextSeason;
        private System.Windows.Forms.ToolStripSeparator tssSeason;
        private System.Windows.Forms.ToolStripButton tsbStartSeason;
    }
}
