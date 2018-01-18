namespace VideoLibrary
{
    partial class FormAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSynopsis = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbExistence = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btGetFromInternet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(420, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Год";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(129, 58);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(420, 20);
            this.tbYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Продолжительность";
            // 
            // nudDuration
            // 
            this.nudDuration.Location = new System.Drawing.Point(129, 83);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(420, 20);
            this.nudDuration.TabIndex = 3;
            this.nudDuration.Enter += new System.EventHandler(this.nudDuration_Enter);
            // 
            // nudScore
            // 
            this.nudScore.DecimalPlaces = 1;
            this.nudScore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudScore.Location = new System.Drawing.Point(129, 109);
            this.nudScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(420, 20);
            this.nudScore.TabIndex = 4;
            this.nudScore.Enter += new System.EventHandler(this.nudScore_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оценка";
            // 
            // tbSynopsis
            // 
            this.tbSynopsis.Location = new System.Drawing.Point(129, 265);
            this.tbSynopsis.Multiline = true;
            this.tbSynopsis.Name = "tbSynopsis";
            this.tbSynopsis.Size = new System.Drawing.Size(420, 192);
            this.tbSynopsis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Суть";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(129, 7);
            this.nudId.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(394, 20);
            this.nudId.TabIndex = 0;
            this.nudId.Enter += new System.EventHandler(this.nudId_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Фильм",
            "Мульт",
            "Сериал"});
            this.cbType.Location = new System.Drawing.Point(129, 134);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(420, 21);
            this.cbType.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип";
            // 
            // cbExistence
            // 
            this.cbExistence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExistence.FormattingEnabled = true;
            this.cbExistence.Items.AddRange(new object[] {
            "Есть",
            "Будет",
            "Был",
            "В коллекции"});
            this.cbExistence.Location = new System.Drawing.Point(129, 162);
            this.cbExistence.Name = "cbExistence";
            this.cbExistence.Size = new System.Drawing.Size(420, 21);
            this.cbExistence.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Хранение";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(237, 481);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 12;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(129, 189);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(420, 20);
            this.tbUrl.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "URL";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(129, 215);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(420, 20);
            this.tbComment.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 219);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Комментарий";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(129, 239);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(394, 20);
            this.tbPath.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Файл";
            // 
            // btBrowse
            // 
            this.btBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrowse.Image = global::VideoLibrary.Properties.Resources.IconBrowse;
            this.btBrowse.Location = new System.Drawing.Point(524, 237);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(25, 25);
            this.btBrowse.TabIndex = 10;
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.FileName = "file";
            // 
            // btGetFromInternet
            // 
            this.btGetFromInternet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGetFromInternet.Image = global::VideoLibrary.Properties.Resources.IconInternet;
            this.btGetFromInternet.Location = new System.Drawing.Point(524, 5);
            this.btGetFromInternet.Name = "btGetFromInternet";
            this.btGetFromInternet.Size = new System.Drawing.Size(25, 25);
            this.btGetFromInternet.TabIndex = 20;
            this.btGetFromInternet.Text = "Получить из интернета";
            this.btGetFromInternet.UseVisualStyleBackColor = true;
            this.btGetFromInternet.Click += new System.EventHandler(this.btGetFromInternet_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 516);
            this.Controls.Add(this.btGetFromInternet);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbExistence);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSynopsis);
            this.Controls.Add(this.nudScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление видео";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSynopsis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbExistence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btGetFromInternet;
    }
}