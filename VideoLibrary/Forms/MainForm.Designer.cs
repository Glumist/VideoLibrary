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
            this.colSoundLanguages = new System.Windows.Forms.DataGridViewImageColumn();
            this.colSubLanguages = new System.Windows.Forms.DataGridViewImageColumn();
            this.colUserScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResolution = new System.Windows.Forms.DataGridViewImageColumn();
            this.colHdr = new System.Windows.Forms.DataGridViewImageColumn();
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
            this.recordView = new VideoLibrary.ucRecordView();
            this.pClear = new System.Windows.Forms.Panel();
            this.ucRecordEdit = new VideoLibrary.ucRecordEdit();
            this.ilVideo = new System.Windows.Forms.ImageList(this.components);
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWant = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguages = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.msVideo.SuspendLayout();
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
            this.colSoundLanguages,
            this.colSubLanguages,
            this.colUserScore,
            this.colResolution,
            this.colHdr,
            this.colSize});
            this.dgvVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVideo.Location = new System.Drawing.Point(0, 39);
            this.dgvVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvVideo.MultiSelect = false;
            this.dgvVideo.Name = "dgvVideo";
            this.dgvVideo.ReadOnly = true;
            this.dgvVideo.RowHeadersVisible = false;
            this.dgvVideo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVideo.Size = new System.Drawing.Size(1612, 1179);
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
            this.colYear.Width = 77;
            // 
            // colScore
            // 
            this.colScore.DataPropertyName = "Score";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colScore.DefaultCellStyle = dataGridViewCellStyle3;
            this.colScore.HeaderText = "Оценка";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 40;
            // 
            // colDuration
            // 
            this.colDuration.DataPropertyName = "DurationStr";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDuration.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDuration.HeaderText = "Хронометраж";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            this.colDuration.Width = 40;
            // 
            // colTags
            // 
            this.colTags.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTags.DataPropertyName = "TagsPic";
            this.colTags.HeaderText = "Тэги";
            this.colTags.Name = "colTags";
            this.colTags.ReadOnly = true;
            this.colTags.Width = 53;
            // 
            // colSoundLanguages
            // 
            this.colSoundLanguages.DataPropertyName = "SoundLanguagesPic";
            this.colSoundLanguages.HeaderText = "Озвучка";
            this.colSoundLanguages.Name = "colSoundLanguages";
            this.colSoundLanguages.ReadOnly = true;
            this.colSoundLanguages.Width = 50;
            // 
            // colSubLanguages
            // 
            this.colSubLanguages.DataPropertyName = "SubLanguagesPic";
            this.colSubLanguages.HeaderText = "Субы";
            this.colSubLanguages.Name = "colSubLanguages";
            this.colSubLanguages.ReadOnly = true;
            this.colSubLanguages.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSubLanguages.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSubLanguages.Width = 50;
            // 
            // colUserScore
            // 
            this.colUserScore.DataPropertyName = "UserScore";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colUserScore.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUserScore.HeaderText = "Приоритет";
            this.colUserScore.Name = "colUserScore";
            this.colUserScore.ReadOnly = true;
            this.colUserScore.Width = 40;
            // 
            // colResolution
            // 
            this.colResolution.DataPropertyName = "ResolutionImage";
            this.colResolution.HeaderText = "Разрешение";
            this.colResolution.Name = "colResolution";
            this.colResolution.ReadOnly = true;
            this.colResolution.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colResolution.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colResolution.Width = 50;
            // 
            // colHdr
            // 
            this.colHdr.DataPropertyName = "IsHdrImage";
            this.colHdr.HeaderText = "HDR";
            this.colHdr.Name = "colHdr";
            this.colHdr.ReadOnly = true;
            this.colHdr.Width = 40;
            // 
            // colSize
            // 
            this.colSize.DataPropertyName = "Size";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle6;
            this.colSize.HeaderText = "Размер";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Width = 60;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 35);
            this.scMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.scMain.Panel2.Controls.Add(this.recordView);
            this.scMain.Panel2.Controls.Add(this.pClear);
            this.scMain.Panel2.Controls.Add(this.ucRecordEdit);
            this.scMain.Panel2MinSize = 250;
            this.scMain.Size = new System.Drawing.Size(2129, 1240);
            this.scMain.SplitterDistance = 1612;
            this.scMain.SplitterWidth = 9;
            this.scMain.TabIndex = 1;
            // 
            // lvVideo
            // 
            this.lvVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVideo.HideSelection = false;
            this.lvVideo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvVideo.Location = new System.Drawing.Point(0, 39);
            this.lvVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvVideo.MultiSelect = false;
            this.lvVideo.Name = "lvVideo";
            this.lvVideo.Size = new System.Drawing.Size(1612, 1179);
            this.lvVideo.TabIndex = 3;
            this.lvVideo.UseCompatibleStateImageBehavior = false;
            this.lvVideo.SelectedIndexChanged += new System.EventHandler(this.lvVideo_SelectedIndexChanged);
            // 
            // ssVideo
            // 
            this.ssVideo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ssVideo.Location = new System.Drawing.Point(0, 1218);
            this.ssVideo.Name = "ssVideo";
            this.ssVideo.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ssVideo.Size = new System.Drawing.Size(1612, 22);
            this.ssVideo.SizingGrip = false;
            this.ssVideo.TabIndex = 2;
            this.ssVideo.Text = "ssHave";
            // 
            // msVideo
            // 
            this.msVideo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msVideo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscbSort,
            this.tscbTypeFilter,
            this.tsmiTagsFilter,
            this.tscbView,
            this.tscbExistence});
            this.msVideo.Location = new System.Drawing.Point(0, 0);
            this.msVideo.Name = "msVideo";
            this.msVideo.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msVideo.Size = new System.Drawing.Size(1612, 39);
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
            "По размеру",
            "По качеству"});
            this.tscbSort.Name = "tscbSort";
            this.tscbSort.Size = new System.Drawing.Size(193, 33);
            // 
            // tscbTypeFilter
            // 
            this.tscbTypeFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbTypeFilter.Items.AddRange(new object[] {
            "Все",
            "Фильмы",
            "Мульты",
            "Сериалы",
            "МиниСериалы"});
            this.tscbTypeFilter.Name = "tscbTypeFilter";
            this.tscbTypeFilter.Size = new System.Drawing.Size(180, 33);
            // 
            // tsmiTagsFilter
            // 
            this.tsmiTagsFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTagsFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiTagsFilter.Image = global::VideoLibrary.Properties.Resources.IconFilter;
            this.tsmiTagsFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiTagsFilter.Name = "tsmiTagsFilter";
            this.tsmiTagsFilter.Size = new System.Drawing.Size(28, 33);
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
            this.tscbView.Size = new System.Drawing.Size(180, 33);
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
            this.tscbExistence.Size = new System.Drawing.Size(180, 33);
            // 
            // recordView
            // 
            this.recordView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.recordView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordView.Location = new System.Drawing.Point(0, 0);
            this.recordView.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.recordView.Name = "recordView";
            this.recordView.Size = new System.Drawing.Size(508, 1240);
            this.recordView.TabIndex = 0;
            // 
            // pClear
            // 
            this.pClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pClear.Location = new System.Drawing.Point(0, 0);
            this.pClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pClear.Name = "pClear";
            this.pClear.Size = new System.Drawing.Size(508, 1240);
            this.pClear.TabIndex = 1;
            // 
            // ucRecordEdit
            // 
            this.ucRecordEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRecordEdit.Location = new System.Drawing.Point(0, 0);
            this.ucRecordEdit.Name = "ucRecordEdit";
            this.ucRecordEdit.Size = new System.Drawing.Size(508, 1240);
            this.ucRecordEdit.TabIndex = 4;
            // 
            // ilVideo
            // 
            this.ilVideo.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilVideo.ImageSize = new System.Drawing.Size(250, 256);
            this.ilVideo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiWant,
            this.tsmiTest,
            this.tsmiTags,
            this.tsmiLanguages});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.msMain.Size = new System.Drawing.Size(2129, 35);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::VideoLibrary.Properties.Resources.add_icon;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(126, 29);
            this.tsmiAdd.Text = "Добавить";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiWant
            // 
            this.tsmiWant.Name = "tsmiWant";
            this.tsmiWant.Size = new System.Drawing.Size(69, 29);
            this.tsmiWant.Text = "Хотет";
            this.tsmiWant.Click += new System.EventHandler(this.tsmiWant_Click);
            // 
            // tsmiTest
            // 
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(53, 29);
            this.tsmiTest.Text = "test";
            this.tsmiTest.Visible = false;
            this.tsmiTest.Click += new System.EventHandler(this.tsmiTest_Click);
            // 
            // tsmiTags
            // 
            this.tsmiTags.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiTags.Name = "tsmiTags";
            this.tsmiTags.Size = new System.Drawing.Size(58, 29);
            this.tsmiTags.Text = "Тэги";
            this.tsmiTags.Click += new System.EventHandler(this.tsmiTags_Click);
            // 
            // tsmiLanguages
            // 
            this.tsmiLanguages.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiLanguages.Name = "tsmiLanguages";
            this.tsmiLanguages.Size = new System.Drawing.Size(75, 29);
            this.tsmiLanguages.Text = "Языки";
            this.tsmiLanguages.Click += new System.EventHandler(this.tsmiLanguages_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(2129, 1275);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Фильмотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideo)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.msVideo.ResumeLayout(false);
            this.msVideo.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideo;
        private System.Windows.Forms.SplitContainer scMain;
        private ucRecordView recordView;
        private System.Windows.Forms.Panel pClear;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguages;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewImageColumn colTags;
        private System.Windows.Forms.DataGridViewImageColumn colSoundLanguages;
        private System.Windows.Forms.DataGridViewImageColumn colSubLanguages;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserScore;
        private System.Windows.Forms.DataGridViewImageColumn colResolution;
        private System.Windows.Forms.DataGridViewImageColumn colHdr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private ucRecordEdit ucRecordEdit;
    }
}

