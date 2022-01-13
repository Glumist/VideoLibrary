using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary.Properties;

namespace VideoLibrary
{
    public partial class ucRecordEdit : UserControl
    {
        public VideoRecord EditedRecord;
        private List<SeasonDates> _seasonDates;

        public ucRecordEdit()
        {
            InitializeComponent();
            UpdateLanguages();
            SetRecord(new VideoRecord());
        }

        public void SetRecord(VideoRecord record)
        {
            if (record == null)
            {
                SetRecord(new VideoRecord());
                EditedRecord = null;
                nudId.Focus();
                return;
            }
            else
                tbName.Focus();

            EditedRecord = record;

            nudId.Value = record.Id;
            tbUrl.Text = record.Url;
            tbComment.Text = record.Comment;
            tbPath.Text = record.Path;
            tbName.Text = record.Name;
            tbYear.Text = record.Year;
            nudDuration.Value = record.Duration;
            nudScore.Value = (decimal)record.Score;
            tbSynopsis.Text = record.Synopsis;
            chbHdr.Checked = record.IsHdr;
            dtpDateStart.Value = record.DateStart.HasValue ? record.DateStart.Value : DateTime.Today;
            dtpDateStart.Checked = record.DateStart.HasValue;
            dtpDateEnd.Value = record.DateEnd.HasValue ? record.DateEnd.Value : DateTime.Today;
            dtpDateEnd.Checked = record.DateEnd.HasValue;
            nudSeason.Value = record.Season;

            _seasonDates = new List<SeasonDates>();
            record.SeasonDates.ForEach(s => _seasonDates.Add(new SeasonDates() { Season = s.Season, DateStart = s.DateStart, DateEnd = s.DateEnd }));
            dgvSeasonDates.DataSource = new List<SeasonDates>(_seasonDates);

            switch (record.Type)
            {
                case VideoType.Cartoon: cbType.SelectedIndex = 1; break;
                case VideoType.Series: cbType.SelectedIndex = 2; break;
                case VideoType.MiniSeries: cbType.SelectedIndex = 3; break;
                case VideoType.Movie:
                default: cbType.SelectedIndex = 0; break;
            }

            switch (record.Existence)
            {
                case Existence.Have: cbExistence.SelectedIndex = 0; break;
                case Existence.Had: cbExistence.SelectedIndex = 2; break;
                case Existence.Collection: cbExistence.SelectedIndex = 3; break;
                case Existence.WillHave:
                default: cbExistence.SelectedIndex = 1; break;
            }

            switch (record.Resolution)
            {
                case Resolution.SD: rbSd.Checked = true; break;
                case Resolution.HD: rbHd.Checked = true; break;
                case Resolution.FHD: rbFhd.Checked = true; break;
                case Resolution.UHD: rbUhd.Checked = true; break;
                default:
                    rbSd.Checked = false;
                    rbHd.Checked = false;
                    rbFhd.Checked = false;
                    rbUhd.Checked = false;
                    break;
            }

            pbSound.Image = record.SoundLanguagesPic;
            pbSound.Tag = new List<Language>(record.SoundLanguages);

            pbSubs.Image = record.SubLanguagesPic;
            pbSubs.Tag = new List<Language>(record.SubLanguages);

            btGetFromInternet.Image = Resources.IconInternet;
            btGetFromInternetByAddress.Image = Resources.IconDownload;
        }

        public void UpdateLanguages()
        {
            lvLanguages.Items.Clear();
            LanguageCollection languages = LanguageCollection.GetInstance();

            ImageList imgList = new ImageList();
            lvLanguages.SmallImageList = imgList;
            foreach (Language language in languages.Languages)
            {
                imgList.Images.Add("" + language.Id, language.Image);
                ListViewItem lvi = new ListViewItem(language.Text, "" + language.Id);
                lvi.Tag = language;
                lvLanguages.Items.Add(lvi);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            VideoType type;
            Existence existence;

            switch (cbType.SelectedIndex)
            {
                case 0: type = VideoType.Movie; break;
                case 1: type = VideoType.Cartoon; break;
                case 2: type = VideoType.Series; break;
                case 3: type = VideoType.MiniSeries; break;
                default: MessageBox.Show("Не выбран тип"); return;
            }

            switch (cbExistence.SelectedIndex)
            {
                case 0: existence = Existence.Have; break;
                case 1: existence = Existence.WillHave; break;
                case 2: existence = Existence.Had; break;
                case 3: existence = Existence.Collection; break;
                default: MessageBox.Show("Не выбрано хранение"); return;
            }

            bool isNew = false;
            if (EditedRecord == null)
            {
                EditedRecord = new VideoRecord();
                isNew = true;
            }
            EditedRecord.Id = (int)nudId.Value;
            EditedRecord.Name = tbName.Text;
            EditedRecord.Year = tbYear.Text;
            EditedRecord.Duration = (int)nudDuration.Value;
            EditedRecord.Score = (double)nudScore.Value;
            EditedRecord.Synopsis = tbSynopsis.Text;
            EditedRecord.Type = type;
            EditedRecord.Existence = existence;
            EditedRecord.Url = tbUrl.Text;
            EditedRecord.Comment = tbComment.Text;
            EditedRecord.Path = tbPath.Text;
            EditedRecord.IsHdr = chbHdr.Checked;
            EditedRecord.DateStart = dtpDateStart.Checked ? (DateTime?)dtpDateStart.Value.Date : null;
            EditedRecord.DateEnd = dtpDateEnd.Checked ? (DateTime?)dtpDateEnd.Value.Date : null;
            EditedRecord.Season = (int)nudSeason.Value;

            if (rbSd.Checked)
                EditedRecord.Resolution = Resolution.SD;
            else if (rbHd.Checked)
                EditedRecord.Resolution = Resolution.HD;
            else if (rbFhd.Checked)
                EditedRecord.Resolution = Resolution.FHD;
            else if (rbUhd.Checked)
                EditedRecord.Resolution = Resolution.UHD;

            EditedRecord.SoundLanguages = (List<Language>)pbSound.Tag;
            EditedRecord.SubLanguages = (List<Language>)pbSubs.Tag;

            EditedRecord.SeasonDates = new List<SeasonDates>();
            _seasonDates.ForEach(s => EditedRecord.SeasonDates.Add(new SeasonDates()
            {
                Season = s.Season,
                DateStart = s.DateStart,
                DateEnd = s.DateEnd
            }));

            if (isNew)
                OnVideoRecordAdded(EditedRecord);
            else
                OnVideoRecordSaved(EditedRecord);
        }

        private void nudId_Enter(object sender, EventArgs e)
        {
            nudId.Select(0, nudId.Value.ToString().Length);
        }

        private void btGetFromInternet_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;
            if (id <= 0)
                return;

            if (EditedRecord == null && VideoDataCollection.GetInstance().VideoList.Exists(v => v.Id == id))
                if (MessageBox.Show("Запись с указанным Id уже существует. Продолжить?", "Дубликат", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

            try
            {
                HtmlHelper.SaveVideoPicture(id);
                btGetFromInternet.Image = Resources.IconApply;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btGetFromInternetByAddress_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;
            if (id <= 0)
                return;

            FormString form = new FormString("Введите URL картинки");
            if (form.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrWhiteSpace(form.EditedText))
                return;

            try
            {
                HtmlHelper.SaveVideoPicture(id, form.EditedText);
                btGetFromInternetByAddress.Image = Resources.IconApply;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = !(cbType.SelectedIndex == 2 || cbType.SelectedIndex == 3);
        }

        private void btAddSeason_Click(object sender, EventArgs e)
        {
            SeasonDates found = _seasonDates.Find(sd => sd.Season == (int)nudSeason.Value);
            if (found != null)
            {
                found.DateStart = dtpDateStart.Checked ? (DateTime?)dtpDateStart.Value.Date : null;
                found.DateEnd = dtpDateEnd.Checked ? (DateTime?)dtpDateEnd.Value.Date : null;
            }
            else
            {
                VideoRecord.AddSeasonDates(_seasonDates, new SeasonDates()
                {
                    Season = (int)nudSeason.Value,
                    DateStart = dtpDateStart.Checked ? (DateTime?)dtpDateStart.Value.Date : null,
                    DateEnd = dtpDateEnd.Checked ? (DateTime?)dtpDateEnd.Value.Date : null
                });
                dgvSeasonDates.DataSource = new List<SeasonDates>(_seasonDates);
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbPath.Text = File.Exists(openFileDialog1.FileName) ? openFileDialog1.FileName : Path.GetDirectoryName(openFileDialog1.FileName);
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPath.Text))
                return;

            if (VideoRecord.CanPlayFile(tbPath.Text))
                Process.Start(tbPath.Text);
            else if (Directory.Exists(tbPath.Text))
                Process.Start(tbPath.Text);
        }

        private void pbSound_Click(object sender, EventArgs e)
        {
            if (lvLanguages.Visible)
                GetLanguages(pbSound);
            else
                SetLanguages((List<Language>)pbSound.Tag);
        }

        private void pbSubs_Click(object sender, EventArgs e)
        {
            if (lvLanguages.Visible)
                GetLanguages(pbSubs);
            else
                SetLanguages((List<Language>)pbSubs.Tag);
        }

        private void SetLanguages(List<Language> languages)
        {
            foreach (ListViewItem lvi in lvLanguages.Items)
                lvi.Checked = languages.Exists(l => "" + l.Id == lvi.ImageKey);

            lvLanguages.Visible = true;
        }

        private void GetLanguages(PictureBox box)
        {
            List<Language> result = new List<Language>();

            foreach (ListViewItem lvi in lvLanguages.Items)
                if (lvi.Checked)
                    result.Add((Language)lvi.Tag);

            box.Tag = result;
            box.Image = Language.GetLanguagesPic(result);

            lvLanguages.Visible = false;
        }

        public event EventHandler<VideoRecord> VideoRecordSaved;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnVideoRecordSaved(VideoRecord record)
        {
            if (VideoRecordSaved != null)
                VideoRecordSaved(this, record);
        }

        public event EventHandler<VideoRecord> VideoRecordAdded;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnVideoRecordAdded(VideoRecord record)
        {
            if (VideoRecordAdded != null)
                VideoRecordAdded(this, record);
        }
    }
}