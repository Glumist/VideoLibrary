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

namespace VideoLibrary
{
    public partial class ucRecordEdit : UserControl
    {
        public VideoRecord EditedRecord;

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

            if (isNew)
                OnVideoRecordAdded(EditedRecord);
            else
                OnVideoRecordSaved(EditedRecord);
        }

        private void btGetFromInternet_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;
            if (id <= 0)
                return;

            if (VideoDataCollection.GetInstance().VideoList.Exists(v => v.Id == id))
                if (MessageBox.Show("Запись с указанным Id уже существует. Продолжить?", "Дубликат", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

            HtmlHelper.SaveVideoPicture(id);
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