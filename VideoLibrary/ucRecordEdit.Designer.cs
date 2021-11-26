﻿namespace VideoLibrary
{
    partial class ucRecordEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btGetFromInternet = new System.Windows.Forms.Button();
            this.tbSynopsis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvLanguages = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pbSubs = new System.Windows.Forms.PictureBox();
            this.pbSound = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.chbHdr = new System.Windows.Forms.CheckBox();
            this.rbUhd = new System.Windows.Forms.RadioButton();
            this.rbFhd = new System.Windows.Forms.RadioButton();
            this.rbHd = new System.Windows.Forms.RadioButton();
            this.rbSd = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbExistence = new System.Windows.Forms.ComboBox();
            this.msRecord = new System.Windows.Forms.MenuStrip();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.msRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbComment);
            this.groupBox1.Controls.Add(this.btGetFromInternet);
            this.groupBox1.Controls.Add(this.tbSynopsis);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.tbUrl);
            this.groupBox1.Controls.Add(this.nudId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudScore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudDuration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbYear);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства общие";
            // 
            // tbComment
            // 
            this.tbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComment.Location = new System.Drawing.Point(191, 306);
            this.tbComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(530, 26);
            this.tbComment.TabIndex = 27;
            this.tbComment.TabStop = false;
            // 
            // btGetFromInternet
            // 
            this.btGetFromInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGetFromInternet.Image = global::VideoLibrary.Properties.Resources.IconInternet;
            this.btGetFromInternet.Location = new System.Drawing.Point(685, 27);
            this.btGetFromInternet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetFromInternet.Name = "btGetFromInternet";
            this.btGetFromInternet.Size = new System.Drawing.Size(38, 38);
            this.btGetFromInternet.TabIndex = 15;
            this.btGetFromInternet.UseVisualStyleBackColor = true;
            this.btGetFromInternet.Click += new System.EventHandler(this.btGetFromInternet_Click);
            // 
            // tbSynopsis
            // 
            this.tbSynopsis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSynopsis.Location = new System.Drawing.Point(191, 342);
            this.tbSynopsis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSynopsis.Multiline = true;
            this.tbSynopsis.Name = "tbSynopsis";
            this.tbSynopsis.Size = new System.Drawing.Size(530, 150);
            this.tbSynopsis.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Комментарий";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 345);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Суть";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Фильм",
            "Мульт",
            "Сериал",
            "МиниСериал"});
            this.cbType.Location = new System.Drawing.Point(191, 225);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(530, 28);
            this.cbType.TabIndex = 22;
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(191, 266);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(530, 26);
            this.tbUrl.TabIndex = 25;
            this.tbUrl.TabStop = false;
            // 
            // nudId
            // 
            this.nudId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudId.Location = new System.Drawing.Point(191, 30);
            this.nudId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudId.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(493, 26);
            this.nudId.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "URL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "ID";
            // 
            // nudScore
            // 
            this.nudScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScore.DecimalPlaces = 1;
            this.nudScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScore.Location = new System.Drawing.Point(191, 187);
            this.nudScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(532, 26);
            this.nudScore.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Оценка";
            // 
            // nudDuration
            // 
            this.nudDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudDuration.Location = new System.Drawing.Point(191, 147);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(532, 26);
            this.nudDuration.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Продолжительность";
            // 
            // tbYear
            // 
            this.tbYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbYear.Location = new System.Drawing.Point(191, 108);
            this.tbYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(530, 26);
            this.tbYear.TabIndex = 18;
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(191, 68);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(530, 26);
            this.tbName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Год";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Название";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lvLanguages);
            this.groupBox2.Controls.Add(this.pbSubs);
            this.groupBox2.Controls.Add(this.pbSound);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.chbHdr);
            this.groupBox2.Controls.Add(this.rbUhd);
            this.groupBox2.Controls.Add(this.rbFhd);
            this.groupBox2.Controls.Add(this.rbHd);
            this.groupBox2.Controls.Add(this.rbSd);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btOpenFile);
            this.groupBox2.Controls.Add(this.btBrowse);
            this.groupBox2.Controls.Add(this.tbPath);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbExistence);
            this.groupBox2.Location = new System.Drawing.Point(12, 568);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(728, 583);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Свойства файла";
            // 
            // lvLanguages
            // 
            this.lvLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLanguages.CheckBoxes = true;
            this.lvLanguages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvLanguages.Location = new System.Drawing.Point(19, 277);
            this.lvLanguages.Name = "lvLanguages";
            this.lvLanguages.Size = new System.Drawing.Size(702, 290);
            this.lvLanguages.TabIndex = 35;
            this.lvLanguages.UseCompatibleStateImageBehavior = false;
            this.lvLanguages.View = System.Windows.Forms.View.Details;
            this.lvLanguages.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Язык";
            this.columnHeader1.Width = 200;
            // 
            // pbSubs
            // 
            this.pbSubs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSubs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSubs.Location = new System.Drawing.Point(191, 224);
            this.pbSubs.Name = "pbSubs";
            this.pbSubs.Size = new System.Drawing.Size(530, 29);
            this.pbSubs.TabIndex = 34;
            this.pbSubs.TabStop = false;
            this.pbSubs.Click += new System.EventHandler(this.pbSubs_Click);
            // 
            // pbSound
            // 
            this.pbSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSound.Location = new System.Drawing.Point(191, 176);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(530, 29);
            this.pbSound.TabIndex = 33;
            this.pbSound.TabStop = false;
            this.pbSound.Click += new System.EventHandler(this.pbSound_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 224);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Субтитры";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Озвучка";
            // 
            // chbHdr
            // 
            this.chbHdr.Image = global::VideoLibrary.Properties.Resources.IconHDR;
            this.chbHdr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbHdr.Location = new System.Drawing.Point(597, 132);
            this.chbHdr.Name = "chbHdr";
            this.chbHdr.Size = new System.Drawing.Size(90, 40);
            this.chbHdr.TabIndex = 30;
            this.chbHdr.Text = "             ";
            this.chbHdr.UseVisualStyleBackColor = true;
            // 
            // rbUhd
            // 
            this.rbUhd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbUhd.Image = global::VideoLibrary.Properties.Resources.IconUHD;
            this.rbUhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbUhd.Location = new System.Drawing.Point(477, 132);
            this.rbUhd.Name = "rbUhd";
            this.rbUhd.Size = new System.Drawing.Size(100, 40);
            this.rbUhd.TabIndex = 29;
            this.rbUhd.TabStop = true;
            this.rbUhd.Text = "             ";
            this.rbUhd.UseVisualStyleBackColor = true;
            // 
            // rbFhd
            // 
            this.rbFhd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbFhd.Image = global::VideoLibrary.Properties.Resources.IconFHD;
            this.rbFhd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbFhd.Location = new System.Drawing.Point(373, 132);
            this.rbFhd.Name = "rbFhd";
            this.rbFhd.Size = new System.Drawing.Size(100, 40);
            this.rbFhd.TabIndex = 28;
            this.rbFhd.TabStop = true;
            this.rbFhd.Text = "             ";
            this.rbFhd.UseVisualStyleBackColor = true;
            // 
            // rbHd
            // 
            this.rbHd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rbHd.Image = global::VideoLibrary.Properties.Resources.IconHD;
            this.rbHd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbHd.Location = new System.Drawing.Point(282, 132);
            this.rbHd.Name = "rbHd";
            this.rbHd.Size = new System.Drawing.Size(90, 40);
            this.rbHd.TabIndex = 27;
            this.rbHd.TabStop = true;
            this.rbHd.Text = "             ";
            this.rbHd.UseVisualStyleBackColor = true;
            // 
            // rbSd
            // 
            this.rbSd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rbSd.Image = global::VideoLibrary.Properties.Resources.IconSD;
            this.rbSd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbSd.Location = new System.Drawing.Point(191, 134);
            this.rbSd.Name = "rbSd";
            this.rbSd.Size = new System.Drawing.Size(90, 40);
            this.rbSd.TabIndex = 26;
            this.rbSd.TabStop = true;
            this.rbSd.Text = "             ";
            this.rbSd.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Качество";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpenFile.Image = global::VideoLibrary.Properties.Resources.IconPlay;
            this.btOpenFile.Location = new System.Drawing.Point(683, 87);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(38, 38);
            this.btOpenFile.TabIndex = 24;
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowse.Image = global::VideoLibrary.Properties.Resources.IconBrowse;
            this.btBrowse.Location = new System.Drawing.Point(640, 87);
            this.btBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(38, 38);
            this.btBrowse.TabIndex = 21;
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPath.Location = new System.Drawing.Point(191, 90);
            this.tbPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(446, 26);
            this.tbPath.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Файл";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Хранение";
            // 
            // cbExistence
            // 
            this.cbExistence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbExistence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExistence.FormattingEnabled = true;
            this.cbExistence.Items.AddRange(new object[] {
            "Есть",
            "Будет",
            "Был",
            "В коллекции"});
            this.cbExistence.Location = new System.Drawing.Point(191, 44);
            this.cbExistence.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbExistence.Name = "cbExistence";
            this.cbExistence.Size = new System.Drawing.Size(530, 28);
            this.cbExistence.TabIndex = 19;
            // 
            // msRecord
            // 
            this.msRecord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msRecord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave});
            this.msRecord.Location = new System.Drawing.Point(0, 0);
            this.msRecord.Name = "msRecord";
            this.msRecord.Size = new System.Drawing.Size(762, 33);
            this.msRecord.TabIndex = 2;
            this.msRecord.Text = "Меню";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::VideoLibrary.Properties.Resources.IconSave;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(85, 29);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "file";
            // 
            // ucRecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msRecord);
            this.Name = "ucRecordEdit";
            this.Size = new System.Drawing.Size(762, 1154);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.msRecord.ResumeLayout(false);
            this.msRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btGetFromInternet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbSynopsis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvLanguages;
        private System.Windows.Forms.PictureBox pbSubs;
        private System.Windows.Forms.PictureBox pbSound;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chbHdr;
        private System.Windows.Forms.RadioButton rbUhd;
        private System.Windows.Forms.RadioButton rbFhd;
        private System.Windows.Forms.RadioButton rbHd;
        private System.Windows.Forms.RadioButton rbSd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbExistence;
        private System.Windows.Forms.MenuStrip msRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
