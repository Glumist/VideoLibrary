using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary.Properties;

namespace VideoLibrary
{
    public partial class MainForm : Form
    {
        VideoDataCollection _videoCollection = new VideoDataCollection();
        List<VideoTag> _tagFilter = new List<VideoTag>();
        string wantText = "";
        bool picsLoaded = false;
        //public static string log = "";

        BackgroundWorker bgwImagesLoader;

        public MainForm()
        {
            InitializeComponent();

            //MessageBox.Show("");
            dgvVideo.AutoGenerateColumns = false;
            pClear.BringToFront();

            tscbSort.SelectedIndex = 0;
            tscbTypeFilter.SelectedIndex = 0;
            tscbExistence.SelectedIndex = 0;
            tscbView.SelectedIndex = 0;

            tscbSort.SelectedIndexChanged += tscb_SelectedIndexChanged;
            tscbTypeFilter.SelectedIndexChanged += tscb_SelectedIndexChanged;
            tscbExistence.SelectedIndexChanged += tscb_SelectedIndexChanged;
            tscbView.SelectedIndexChanged += tscbView_SelectedIndexChanged;
        }

        private void BgwImagesLoader_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshImages(true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                wantText = File.ReadAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\Want.txt");
            }
            catch { }
            _videoCollection = VideoDataCollection.Load();
            RefreshLists(false);

            bgwImagesLoader = new BackgroundWorker();
            bgwImagesLoader.DoWork += BgwImagesLoader_DoWork;
            bgwImagesLoader.RunWorkerAsync();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> ids = new List<string>();
            _videoCollection.VideoList.FindAll(vl => vl.Existence == Existence.Had).ForEach(dr => ids.Add(dr.Id.ToString()));
            FileHelper.DeleteImages(ids);
        }

        #region Lists

        private void RefreshLists(bool withImages = true)
        {
            RefreshTable();
            if (withImages)
                RefreshImages();
            RefreshListView();
            RefreshStat();
            RefreshTags();
        }

        private List<VideoRecord> GetFilteredSortedList()
        {
            List<VideoRecord> filtered = new List<VideoRecord>(_videoCollection.VideoList);
            if (tscbExistence.SelectedIndex == 0)
                filtered = filtered.FindAll(v => v.Existence == Existence.Have);
            else if (tscbExistence.SelectedIndex == 1)
                filtered = filtered.FindAll(v => v.Existence == Existence.WillHave);
            else if (tscbExistence.SelectedIndex == 2)
                filtered = filtered.FindAll(v => v.Existence == Existence.Had);
            else if (tscbExistence.SelectedIndex == 3)
                filtered = filtered.FindAll(v => v.Existence == Existence.Collection);

            if (tscbTypeFilter.SelectedIndex == 1)
                filtered = filtered.FindAll(v => v.Type == VideoType.Movie);
            else if (tscbTypeFilter.SelectedIndex == 2)
                filtered = filtered.FindAll(v => v.Type == VideoType.Cartoon);
            else if (tscbTypeFilter.SelectedIndex == 3)
                filtered = filtered.FindAll(v => v.Type == VideoType.Series);

            //if (_attitudeFilter != Attitude.Unknown)
            //    filtered = filtered.FindAll(v => v.Attitude == _attitudeFilter);

            if (_tagFilter.Exists(t => t.Id == (new VideoTag()).Id))
            {
                if (_tagFilter.Count == 1)
                    filtered.RemoveAll(v => v.Tags.Count > 0);
                else
                    foreach (VideoTag tag in _tagFilter)
                        if (tag.Id != (new VideoTag()).Id)
                            filtered.RemoveAll(v => !v.Tags.Exists(t => t.Id == tag.Id) && v.Tags.Count > 0);
            }
            else
                foreach (VideoTag tag in _tagFilter)
                    filtered.RemoveAll(v => !v.Tags.Exists(t => t.Id == tag.Id));

            if (tscbSort.SelectedIndex == 1)
                filtered.Sort(VideoRecord.CompareByScore);
            else if (tscbSort.SelectedIndex == 2)
                filtered.Sort(VideoRecord.CompareByUserScore);
            else if (tscbSort.SelectedIndex == 3)
                filtered.Sort(VideoRecord.CompareByDuration);
            else if (tscbSort.SelectedIndex == 4)
                filtered.Sort(VideoRecord.CompareByYear);
            else if (tscbSort.SelectedIndex == 5)
                filtered.Sort(VideoRecord.CompareBySize);

            return filtered;
        }

        private void RefreshTable()
        {
            VideoRecord selected = GetSelectedRecordInTable();

            dgvVideo.DataSource = GetFilteredSortedList();
            if (selected != null)
                SelectRecord(dgvVideo, selected);

            //ColorTable(dgvVideo);
            //ColorTable(dgvSoon);
            //ColorTable(dgvArchive);
        }

        private void RefreshListView()
        {
            lvVideo.BeginUpdate();
            VideoRecord selected = GetSelectedRecordInListView();

            lvVideo.Clear();

            List<VideoRecord> filtered = GetFilteredSortedList();

            foreach (VideoRecord record in filtered)
            {
                ListViewItem item = lvVideo.Items.Add(record.ToString(), record.Id.ToString());
                item.Tag = record;
            }

            if (selected != null)
                SelectRecord(lvVideo, selected);
            lvVideo.EndUpdate();
        }

        private void RefreshImages(bool init = false)
        {
            if (!init && !picsLoaded)
                return;

            List<string> currentIds = new List<string>();
            foreach (string id in ilVideo.Images.Keys)
                currentIds.Add(id);

            //log += "start loading pics " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;
            Dictionary<string, Image> pics = FileHelper.GetAllPics(currentIds, ilVideo.ImageSize.Height);
            //log += "end loading pics " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;
            foreach (string id in pics.Keys)
                ilVideo.Images.Add(id, pics[id]);
            //log += "refresh list view " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;

            if (init)
            {
                lvVideo.LargeImageList = ilVideo;
                RefreshListView();
            }
            //log += "list view refreshed " + string.Format("{0:mm:ss.ffff}", DateTime.Now) + Environment.NewLine;

            if (!picsLoaded)
                picsLoaded = true;
        }

        private void RefreshTags()
        {
            VideoTagCollection.Refresh();
            VideoTagCollection tags = VideoTagCollection.GetInstance();

            tsddbTags.DropDownItems.Clear();
            foreach (VideoTag tag in tags.Tags)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(tag.Text, tag.Image);
                tsmi.Tag = tag;
                tsmi.Click += TsmiChangeTag_Click;
                tsddbTags.DropDownItems.Add(tsmi);
            }

            tsmiTagsFilter.DropDownItems.Clear();

            ToolStripMenuItem tsmiWithoutFilter = new ToolStripMenuItem("Без фильтра");
            tsmiWithoutFilter.Click += TsmiFilterTag_Click;
            tsmiTagsFilter.DropDownItems.Add(tsmiWithoutFilter);

            ToolStripMenuItem tsmiWithoutTags = new ToolStripMenuItem("Без тэгов", Resources.IconQuestion);
            tsmiWithoutTags.Click += TsmiFilterTag_Click;
            tsmiWithoutTags.Tag = new VideoTag() { Image = Resources.IconQuestion };
            tsmiTagsFilter.DropDownItems.Add(tsmiWithoutTags);

            foreach (VideoTag tag in tags.Tags)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(tag.Text, tag.Image);
                tsmi.Tag = tag;
                tsmi.Click += TsmiFilterTag_Click;
                tsmiTagsFilter.DropDownItems.Add(tsmi);
            }
        }

        private void RefreshStat()
        {
            List<VideoRecord> filtered = GetFilteredSortedList();
            VideoTagCollection tags = VideoTagCollection.GetInstance();

            ssVideo.Items.Clear();

            ssVideo.Items.Add("Фильмы:");
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Movie).Count.ToString());
            foreach (VideoTag tag in tags.Tags)
                if (tag.ShowInStat && tag.Image != null)
                {
                    ToolStripStatusLabel tssl = new ToolStripStatusLabel(tag.Image);
                    ssVideo.Items.Add(tssl);
                    ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Movie && v.Tags.Exists(t => t.Id == tag.Id)).Count.ToString());
                }
            ssVideo.Items.Add(Resources.IconQuestion);
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Movie && v.Tags.Count == 0).Count.ToString());

            ssVideo.Items.Add("Мульты:");
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Cartoon).Count.ToString());
            foreach (VideoTag tag in tags.Tags)
                if (tag.ShowInStat && tag.Image != null)
                {
                    ssVideo.Items.Add(tag.Image);
                    ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Tags.Exists(t => t.Id == tag.Id)).Count.ToString());
                }
            ssVideo.Items.Add(Resources.IconQuestion);
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Tags.Count == 0).Count.ToString());

            ssVideo.Items.Add("Сериалы:");
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Series).Count.ToString());
            foreach (VideoTag tag in tags.Tags)
                if (tag.ShowInStat && tag.Image != null)
                {
                    ssVideo.Items.Add(tag.Image);
                    ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Series && v.Tags.Exists(t => t.Id == tag.Id)).Count.ToString());
                }
            ssVideo.Items.Add(Resources.IconQuestion);
            ssVideo.Items.Add(filtered.FindAll(v => v.Type == VideoType.Series && v.Tags.Count == 0).Count.ToString());

            /*tsslMovieCount.Text = filtered.FindAll(v => v.Type == VideoType.Movie).Count.ToString();
            tsslMovieBothCount.Text = filtered.FindAll(v => v.Type == VideoType.Movie && v.Attitude == Attitude.Both).Count.ToString();
            tsslMovieOneCount.Text = filtered.FindAll(v => v.Type == VideoType.Movie && v.Attitude == Attitude.One).Count.ToString();
            tsslMovieNoneCount.Text = filtered.FindAll(v => v.Type == VideoType.Movie && v.Attitude == Attitude.None).Count.ToString();
            tsslMovieNanCount.Text = filtered.FindAll(v => v.Type == VideoType.Movie && v.Attitude == Attitude.Unknown).Count.ToString();
            tsslCartoonCount.Text = filtered.FindAll(v => v.Type == VideoType.Cartoon).Count.ToString();
            tsslCartoonBothCount.Text = filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Attitude == Attitude.Both).Count.ToString();
            tsslCartoonOneCount.Text = filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Attitude == Attitude.One).Count.ToString();
            tsslCartoonNoneCount.Text = filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Attitude == Attitude.None).Count.ToString();
            tsslCartoonNanCount.Text = filtered.FindAll(v => v.Type == VideoType.Cartoon && v.Attitude == Attitude.Unknown).Count.ToString();
            tsslSeriesCount.Text = filtered.FindAll(v => v.Type == VideoType.Series).Count.ToString();
            tsslSeriesBothCount.Text = filtered.FindAll(v => v.Type == VideoType.Series && v.Attitude == Attitude.Both).Count.ToString();
            tsslSeriesOneCount.Text = filtered.FindAll(v => v.Type == VideoType.Series && v.Attitude == Attitude.One).Count.ToString();
            tsslSeriesNoneCount.Text = filtered.FindAll(v => v.Type == VideoType.Series && v.Attitude == Attitude.None).Count.ToString();
            tsslSeriesNanCount.Text = filtered.FindAll(v => v.Type == VideoType.Series && v.Attitude == Attitude.Unknown).Count.ToString();*/
        }

        private void ColorTable(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                VideoRecord record = null;
                if (row.DataBoundItem is VideoRecord)
                    record = row.DataBoundItem as VideoRecord;
                if (record == null)
                    continue;
                switch (record.UserScore)
                {
                    case 1: ColorRow(row, tsmiUserScore1.ForeColor); break;
                    case 2: ColorRow(row, tsmiUserScore2.ForeColor); break;
                    case 3: ColorRow(row, tsmiUserScore3.ForeColor); break;
                    case 4: ColorRow(row, tsmiUserScore4.ForeColor); break;
                    case 5: ColorRow(row, tsmiUserScore5.ForeColor); break;
                }
            }
        }

        private void ColorRow(DataGridViewRow row, Color color)
        {
            foreach (DataGridViewCell cell in row.Cells)
                cell.Style.BackColor = color;
        }

        private void RefreshInfo()
        {
            VideoRecord record = GetSelectedRecord();
            if (record != null)
            {
                videoInfo.SetVideoRecord(record);

                tsddbUserScore.Text = record.UserScore.ToString();
                switch (record.UserScore)
                {
                    case 0: tsddbUserScore.ForeColor = tsmiUserScore0.ForeColor; break;
                    case 1: tsddbUserScore.ForeColor = tsmiUserScore1.ForeColor; break;
                    case 2: tsddbUserScore.ForeColor = tsmiUserScore2.ForeColor; break;
                    case 3: tsddbUserScore.ForeColor = tsmiUserScore3.ForeColor; break;
                    case 4: tsddbUserScore.ForeColor = tsmiUserScore4.ForeColor; break;
                    case 5: tsddbUserScore.ForeColor = tsmiUserScore5.ForeColor; break;
                }

                tsbPlay.Enabled = record.CanPlay;
                tsbBrowse.Enabled = record.CanBrowse;

                pClear.SendToBack();
            }
            else
                pClear.BringToFront();
        }

        private VideoRecord GetSelectedRecord()
        {
            if (tscbView.SelectedIndex == 0)
                return GetSelectedRecordInTable();
            else if (tscbView.SelectedIndex == 1)
                return GetSelectedRecordInListView();

            return null;
        }

        private VideoRecord GetSelectedRecordInTable()
        {
            if (dgvVideo.SelectedRows.Count > 0 && dgvVideo.SelectedRows[0].Index > -1)
            {
                VideoRecord record = null;
                if (dgvVideo.SelectedRows[0].DataBoundItem is VideoRecord)
                    record = dgvVideo.SelectedRows[0].DataBoundItem as VideoRecord;
                if (record != null)
                    return record;
            }

            return null;
        }

        private VideoRecord GetSelectedRecordInListView()
        {
            if (lvVideo.SelectedItems.Count > 0 && lvVideo.SelectedItems[0].Index > -1)
            {
                VideoRecord record = null;
                if (lvVideo.SelectedItems[0].Tag is VideoRecord)
                    record = lvVideo.SelectedItems[0].Tag as VideoRecord;
                if (record != null)
                    return record;
            }

            return null;
        }

        private void SelectRecord(DataGridView dgv, VideoRecord record)
        {
            dgv.ClearSelection();
            foreach (DataGridViewRow row in dgv.Rows)
                if ((row.DataBoundItem as VideoRecord).Id == record.Id)
                {
                    row.Selected = true;
                    dgv.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
        }

        private void SelectRecord(ListView lv, VideoRecord record)
        {
            foreach (ListViewItem item in lv.Items)
                if ((item.Tag as VideoRecord).Id == record.Id)
                {
                    item.Selected = true;
                    lv.EnsureVisible(item.Index);
                    break;
                }
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void lvVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInfo();
        }

        #endregion

        #region Menu

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (_videoCollection.VideoList.Exists(v => v.Id == form.Record.Id))
                    if (MessageBox.Show("Запись с указанным Id уже существует. Продолжить?", "Дубликат", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;
                _videoCollection.Add(form.Record);
                _videoCollection.Save();
                RefreshLists();
            }
        }

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            if (record == null)
                return;
            if (new FormAdd(record).ShowDialog() == DialogResult.OK)
            {
                record.ResetSizeNum();
                _videoCollection.Save();
                RefreshLists();
            }
        }

        private void tsmiWant_Click(object sender, EventArgs e)
        {
            FormWant form = new FormWant(wantText);
            if (form.ShowDialog() == DialogResult.OK)
            {
                wantText = form.WantText;
                File.WriteAllText(Path.GetDirectoryName(Application.ExecutablePath) + "\\Want.txt", wantText);
            }
        }

        private void tsmiTest_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(log);
        }

        private void tsmiTags_Click(object sender, EventArgs e)
        {
            FormTags form = new FormTags();
            if (form.ShowDialog() == DialogResult.OK)
                RefreshLists();
        }

        private void TsmiChangeTag_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            if (record == null)
                return;

            VideoTag tag = ((ToolStripMenuItem)sender).Tag as VideoTag;
            if (record.Tags.Exists(t => t.Id == tag.Id))
                record.Tags.RemoveAll(t => t.Id == tag.Id);
            else
                record.Tags.Add(tag);

            _videoCollection.Save();
            RefreshLists();
        }

        private void TsmiFilterTag_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
            if (tsmi.Tag == null)
                _tagFilter.Clear();
            else
            {
                VideoTag tag = tsmi.Tag as VideoTag;
                if (_tagFilter.Exists(t => t.Id == tag.Id))
                    _tagFilter.RemoveAll(t => t.Id == tag.Id);
                else
                    _tagFilter.Add(tag);
            }

            if (_tagFilter.Count == 0)
            {
                tsmiTagsFilter.Image = Resources.IconFilter;
                tsmiTagsFilter.AutoSize = true;
            }
            else
            {
                tsmiTagsFilter.Image = VideoTag.GetTagsPic(_tagFilter);
                tsmiTagsFilter.AutoSize = false;
                tsmiTagsFilter.Size = new Size(tsmiTagsFilter.Image.Width + 12, tsmiTagsFilter.Height);
            }

            RefreshLists();
        }

        private void btUserScore_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            if (record == null)
                return;

            if (sender == tsmiUserScore0)
                record.UserScore = 0;
            else if (sender == tsmiUserScore1)
                record.UserScore = 1;
            else if (sender == tsmiUserScore2)
                record.UserScore = 2;
            else if (sender == tsmiUserScore3)
                record.UserScore = 3;
            else if (sender == tsmiUserScore4)
                record.UserScore = 4;
            else if (sender == tsmiUserScore5)
                record.UserScore = 5;
            _videoCollection.Save();
            RefreshLists();
        }

        /*private void tsmiAttitudeFilter_Click(object sender, EventArgs e)
        {
            if (sender == tsmiAttitudeBoth)
                _attitudeFilter = Attitude.Both;
            else if (sender == tsmiAttitudeOne)
                _attitudeFilter = Attitude.One;
            else if (sender == tsmiAttitudeNone)
                _attitudeFilter = Attitude.None;
            else
                _attitudeFilter = Attitude.Unknown;

            RefreshLists();
        }*/

        private void tscb_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshLists();
        }

        private void tscbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscbView.SelectedIndex == 0)
                dgvVideo.BringToFront();
            else if (tscbView.SelectedIndex == 1)
                lvVideo.BringToFront();

            RefreshInfo();
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            if (record != null && record.CanPlay)
                Process.Start(record.Path);
        }

        private void tsbBrowse_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            if (record == null)
                return;

            if (record.CanPlay)
                Process.Start("explorer.exe", "/select, \"" + record.Path + "\"");
            else if (record.CanBrowse)
                Process.Start(record.DirectoryPath);
        }

        private void tsbOpenInBrowser_Click(object sender, EventArgs e)
        {
            VideoRecord record = GetSelectedRecord();
            
            string url = record.Url;
            if (url == "")
                url = "http://www.kinopoisk.ru/film/" + record.Id;
            System.Diagnostics.Process.Start(url);
        }

        #endregion
    }
}