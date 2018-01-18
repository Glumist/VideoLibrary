namespace VideoLibrary
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvVideo = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTags = new System.Windows.Forms.DataGridViewImageColumn();
            this.colUserScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvVideo = new System.Windows.Forms.ListView();
            this.ssVideo = new System.Windows.Forms.StatusStrip();
            this.msVideo = new System.Windows.Forms.MenuStrip();
            this.tscbSort = new System.Windows.Forms.ToolStripComboBox();
            this.tscbTypeFilter = new System.Windows.Forms.ToolStripComboBox();
            this.tsmiTagsFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbView = new System.Windows.Forms.ToolStripComboBox();
            this.tscbExistence = new System.Windows.Forms.ToolStripComboBox();
            this.videoInfo = new VideoLibrary.VideoInfo();
            this.tsVideoInfo = new System.Windows.Forms.ToolStrip();
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
            this.pClear = new System.Windows.Forms.Panel();
            this.ilVideo = new System.Windows.Forms.ImageList(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWant = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTags = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.msVideo.SuspendLayout();
            this.tsVideoInfo.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVideo
            // 
            this.dgvVideo.AllowUserToAddRows = false;
            this.dgvVideo.AllowUserToDeleteRows = false;
            this.dgvVideo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVideo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVideo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType,
            this.colYear,
            this.colScore,
            this.colDuration,
            this.colTags,
            this.colUserScore,
            this.colSize});
            this.dgvVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVideo.Location = new System.Drawing.Point(0, 27);
            this.dgvVideo.MultiSelect = false;
            this.dgvVideo.Name = "dgvVideo";
            this.dgvVideo.ReadOnly = true;
            this.dgvVideo.RowHeadersVisible = false;
            this.dgvVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideo.Size = new System.Drawing.Size(875, 598);
            this.dgvVideo.TabIndex = 0;
            this.dgvVideo.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Название";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "TypeString";
            this.colType.HeaderText = "Тип";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Width = 50;
            // 
            // colYear
            // 
            this.colYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colYear.DataPropertyName = "Year";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colYear.DefaultCellStyle = dataGridViewCellStyle2;
            this.colYear.HeaderText = "Год";
            this.colYear.Name = "colYear";
            this.colYear.ReadOnly = true;
            this.colYear.Width = 50;
            // 
            // colScore
            // 
            this.colScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colScore.DataPropertyName = "Score";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colScore.DefaultCellStyle = dataGridViewCellStyle3;
            this.colScore.HeaderText = "Оценка";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 70;
            // 
            // colDuration
            // 
            this.colDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colDuration.DataPropertyName = "Duration";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDuration.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDuration.HeaderText = "Хронометраж";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 102;
            // 
            // colTags
            // 
            this.colTags.DataPropertyName = "TagsPic";
            this.colTags.HeaderText = "Тэги";
            this.colTags.Name = "colTags";
            this.colTags.ReadOnly = true;
            // 
            // colUserScore
            // 
            this.colUserScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colUserScore.DataPropertyName = "UserScore";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUserScore.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUserScore.HeaderText = "Приоритет";
            this.colUserScore.Name = "colUserScore";
            this.colUserScore.ReadOnly = true;
            this.colUserScore.Width = 86;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "Size";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSize.HeaderText = "Размер";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 71;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 24);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvVideo);
            this.scMain.Panel1.Controls.Add(this.lvVideo);
            this.scMain.Panel1.Controls.Add(this.ssVideo);
            this.scMain.Panel1.Controls.Add(this.msVideo);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.videoInfo);
            this.scMain.Panel2.Controls.Add(this.tsVideoInfo);
            this.scMain.Panel2.Controls.Add(this.pClear);
            this.scMain.Panel2MinSize = 250;
            this.scMain.Size = new System.Drawing.Size(1138, 647);
            this.scMain.SplitterDistance = 875;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 1;
            // 
            // lvVideo
            // 
            this.lvVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVideo.HideSelection = false;
            this.lvVideo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvVideo.Location = new System.Drawing.Point(0, 27);
            this.lvVideo.MultiSelect = false;
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(875, 598);
            this.lvVideo.TabIndex = 3;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            this.lvVideo.SelectedIndexChanged += new System.EventHandler(this.lvVideo_SelectedIndexChanged);
            // 
            // ssVideo
            // 
            this.ssVideo.Location = new System.Drawing.Point(0, 625);
            this.ssVideo.Name = "ssVideo";
            this.ssVideo.Size = new System.Drawing.Size(875, 22);
            this.ssVideo.SizingGrip = false;
            this.ssVideo.TabIndex = 2;
            this.ssVideo.Text = "ssHave";
            // 
            // msVideo
            // 
            this.msVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSort,
            this.tscbTypeFilter,
            this.tsmiTagsFilter,
            this.tscbView,
            this.tscbExistence});
            this.msVideo.Location = new System.Drawing.Point(0, 0);
            this.msVideo.Name = "msVideo";
            this.msVideo.Size = new System.Drawing.Size(875, 27);
            this.msVideo.TabIndex = 1;
            // 
            // tscbSort
            // 
            this.tscbSort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbSort.Items.AddRange(new object[] {
            "По названию",
            "По рейтингу",
            "По приоритету",
            "По хронометражу",
            "По году выхода",
            "По размеру"});
            this.tscbSort.Name = "tscbSort";
            this.tscbSort.Size = new System.Drawing.Size(130, 23);
            // 
            // tscbTypeFilter
            // 
            this.tscbTypeFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbTypeFilter.Items.AddRange(new object[] {
            "Все",
            "Фильмы",
            "Мульты",
            "Сериалы"});
            this.tscbTypeFilter.Name = "tscbTypeFilter";
            this.tscbTypeFilter.Size = new System.Drawing.Size(121, 23);
            // 
            // tsmiTagsFilter
            // 
            this.tsmiTagsFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTagsFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagsFilter.Image = global::VideoLibrary.Properties.Resources.IconFilter;
            this.tsmiTagsFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTagsFilter.Name = "tsmiTagsFilter";
            this.tsmiTagsFilter.Size = new System.Drawing.Size(28, 23);
            this.tsmiTagsFilter.Text = "Фильтр";
            // 
            // tscbView
            // 
            this.tscbView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbView.Items.AddRange(new object[] {
            "Таблица",
            "Картинки"});
            this.tscbView.MaxDropDownItems = 2;
            this.tscbView.Name = "tscbView";
            this.tscbView.Size = new System.Drawing.Size(121, 23);
            // 
            // tscbExistence
            // 
            this.tscbExistence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbExistence.Items.AddRange(new object[] {
            "В наличии",
            "Скоро",
            "Уже нет",
            "В коллекции"});
            this.tscbExistence.Name = "tscbExistence";
            this.tscbExistence.Size = new System.Drawing.Size(121, 23);
            // 
            // videoInfo
            // 
            this.videoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoInfo.Location = new System.Drawing.Point(0, 25);
            this.videoInfo.Name = "videoInfo";
            this.videoInfo.Size = new System.Drawing.Size(257, 622);
            this.videoInfo.TabIndex = 0;
            // 
            // tsVideoInfo
            // 
            this.tsVideoInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsVideoInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbTags,
            this.tsddbUserScore,
            this.tsbOpenInBrowser,
            this.tsbBrowse,
            this.tsbPlay});
            this.tsVideoInfo.Location = new System.Drawing.Point(0, 0);
            this.tsVideoInfo.Name = "tsVideoInfo";
            this.tsVideoInfo.Size = new System.Drawing.Size(257, 25);
            this.tsVideoInfo.TabIndex = 4;
            this.tsVideoInfo.Text = "toolStrip1";
            // 
            // tsddbTags
            // 
            this.tsddbTags.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddbTags.Image = global::VideoLibrary.Properties.Resources.IconTag;
            this.tsddbTags.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbTags.Name = "tsddbTags";
            this.tsddbTags.Size = new System.Drawing.Size(29, 22);
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
            this.tsddbUserScore.Size = new System.Drawing.Size(26, 22);
            this.tsddbUserScore.Text = "0";
            // 
            // tsmiUserScore0
            // 
            this.tsmiUserScore0.Name = "tsmiUserScore0";
            this.tsmiUserScore0.Size = new System.Drawing.Size(80, 22);
            this.tsmiUserScore0.Text = "0";
            this.tsmiUserScore0.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore1
            // 
            this.tsmiUserScore1.ForeColor = System.Drawing.Color.Red;
            this.tsmiUserScore1.Name = "tsmiUserScore1";
            this.tsmiUserScore1.Size = new System.Drawing.Size(80, 22);
            this.tsmiUserScore1.Text = "1";
            this.tsmiUserScore1.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore2
            // 
            this.tsmiUserScore2.ForeColor = System.Drawing.Color.DarkOrange;
            this.tsmiUserScore2.Name = "tsmiUserScore2";
            this.tsmiUserScore2.Size = new System.Drawing.Size(80, 22);
            this.tsmiUserScore2.Text = "2";
            this.tsmiUserScore2.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore3
            // 
            this.tsmiUserScore3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tsmiUserScore3.Name = "tsmiUserScore3";
            this.tsmiUserScore3.Size = new System.Drawing.Size(80, 22);
            this.tsmiUserScore3.Text = "3";
            this.tsmiUserScore3.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore4
            // 
            this.tsmiUserScore4.ForeColor = System.Drawing.Color.GreenYellow;
            this.tsmiUserScore4.Name = "tsmiUserScore4";
            this.tsmiUserScore4.Size = new System.Drawing.Size(80, 22);
            this.tsmiUserScore4.Text = "4";
            this.tsmiUserScore4.Click += new System.EventHandler(this.btUserScore_Click);
            // 
            // tsmiUserScore5
            // 
            this.tsmiUserScore5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tsmiUserScore5.Name = "tsmiUserScore5";
            this.tsmiUserScore5.Size = new System.Drawing.Size(80, 22);
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
            this.tsbOpenInBrowser.Size = new System.Drawing.Size(23, 22);
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
            this.tsbBrowse.Size = new System.Drawing.Size(23, 22);
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
            this.tsbPlay.Size = new System.Drawing.Size(23, 22);
            this.tsbPlay.Text = "Запуск";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // pClear
            // 
            this.pClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClear.Location = new System.Drawing.Point(0, 0);
            this.pClear.Name = "pClear";
            this.pClear.Size = new System.Drawing.Size(257, 647);
            this.pClear.TabIndex = 1;
            // 
            // ilVideo
            // 
            this.ilVideo.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilVideo.ImageSize = new System.Drawing.Size(200, 256);
            this.ilVideo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiEdit,
            this.tsmiWant,
            this.tsmiTest,
            this.tsmiTags});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1138, 24);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::VideoLibrary.Properties.Resources.add_icon;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(87, 20);
            this.tsmiAdd.Text = "Добавить";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Image = global::VideoLibrary.Properties.Resources.IconEdit;
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(115, 20);
            this.tsmiEdit.Text = "Редактировать";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiWant
            // 
            this.tsmiWant.Name = "tsmiWant";
            this.tsmiWant.Size = new System.Drawing.Size(49, 20);
            this.tsmiWant.Text = "Хотет";
            this.tsmiWant.Click += new System.EventHandler(this.tsmiWant_Click);
            // 
            // tsmiTest
            // 
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(38, 20);
            this.tsmiTest.Text = "test";
            this.tsmiTest.Visible = false;
            this.tsmiTest.Click += new System.EventHandler(this.tsmiTest_Click);
            // 
            // tsmiTags
            // 
            this.tsmiTags.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTags.Name = "tsmiTags";
            this.tsmiTags.Size = new System.Drawing.Size(44, 20);
            this.tsmiTags.Text = "Тэги";
            this.tsmiTags.Click += new System.EventHandler(this.tsmiTags_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 671);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "Фильмотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.msVideo.ResumeLayout(false);
            this.msVideo.PerformLayout();
            this.tsVideoInfo.ResumeLayout(false);
            this.tsVideoInfo.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideo;
        private System.Windows.Forms.SplitContainer scMain;
        private VideoInfo videoInfo;
        private System.Windows.Forms.Panel pClear;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.MenuStrip msVideo;
        private System.Windows.Forms.ToolStripComboBox tscbSort;
        private System.Windows.Forms.ToolStripComboBox tscbTypeFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiTagsFilter;
        private System.Windows.Forms.StatusStrip ssVideo;
        private System.Windows.Forms.ListView lvVideo;
        private System.Windows.Forms.ImageList ilVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiWant;
        private System.Windows.Forms.ToolStripComboBox tscbView;
        private System.Windows.Forms.ToolStripComboBox tscbExistence;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
        private System.Windows.Forms.ToolStripMenuItem tsmiTags;
        private System.Windows.Forms.ToolStrip tsVideoInfo;
        private System.Windows.Forms.ToolStripDropDownButton tsddbTags;
        private System.Windows.Forms.ToolStripDropDownButton tsddbUserScore;
        private System.Windows.Forms.ToolStripButton tsbOpenInBrowser;
        private System.Windows.Forms.ToolStripButton tsbBrowse;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore0;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore2;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore3;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore4;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserScore5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewImageColumn colTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
    }
}

