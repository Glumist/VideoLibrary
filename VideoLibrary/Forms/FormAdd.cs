using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class FormAdd : Form
    {
        public VideoRecord Record = null;
        private List<VideoRecord> _records;

        public FormAdd(List<VideoRecord> records)
        {
            InitializeComponent();
            _records = records;
        }

        public FormAdd(VideoRecord record)
        {
            InitializeComponent();

            Record = record;
            SetOfficialInfo(record);

            nudId.Value = record.Id;
            tbUrl.Text = record.Url;
            tbComment.Text = record.Comment;
            tbPath.Text = record.Path;

            switch (record.Existence)
            {
                case Existence.Have: cbExistence.SelectedIndex = 0; break;
                case Existence.WillHave: cbExistence.SelectedIndex = 1; break;
                case Existence.Had: cbExistence.SelectedIndex = 2; break;
                case Existence.Collection: cbExistence.SelectedIndex = 3; break;
            }
        }

        private void SetOfficialInfo(VideoRecord record)
        {
            tbName.Text = record.Name;
            tbYear.Text = record.Year;
            nudDuration.Value = record.Duration;
            nudScore.Value = (decimal)record.Score;
            tbSynopsis.Text = record.Synopsis;

            switch (record.Type)
            {
                case VideoType.Movie: cbType.SelectedIndex = 0; break;
                case VideoType.Cartoon: cbType.SelectedIndex = 1; break;
                case VideoType.Series: cbType.SelectedIndex = 2; break;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            VideoType type;
            Existence existence;

            switch (cbType.SelectedIndex)
            {
                case 0: type = VideoType.Movie; break;
                case 1: type = VideoType.Cartoon; break;
                case 2: type = VideoType.Series; break;
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

            if (Record == null)
                Record = new VideoRecord();
            Record.Id = (int)nudId.Value;
            Record.Name = tbName.Text;
            Record.Year = tbYear.Text;
            Record.Duration = (int)nudDuration.Value;
            Record.Score = (double)nudScore.Value;
            Record.Synopsis = tbSynopsis.Text;
            Record.Type = type;
            Record.Existence = existence;
            Record.Url = tbUrl.Text;
            Record.Comment = tbComment.Text;
            Record.Path = tbPath.Text;

            DialogResult = DialogResult.OK;
        }

        private void FormAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void nudId_Enter(object sender, EventArgs e)
        {
            nudId.Select(0, nudId.Text.Length);
        }

        private void nudDuration_Enter(object sender, EventArgs e)
        {
            nudDuration.Select(0, nudDuration.Text.Length);
        }

        private void nudScore_Enter(object sender, EventArgs e)
        {
            nudScore.Select(0, nudScore.Text.Length);
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tbPath.Text = File.Exists(openFileDialog1.FileName) ? openFileDialog1.FileName : Path.GetDirectoryName(openFileDialog1.FileName);
        }

        private void btGetFromInternet_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;
            if (id <= 0)
                return;

            if (_records != null)
                if (_records.Exists(v => v.Id == id))
                    if (MessageBox.Show("Запись с указанным Id уже существует. Продолжить?", "Дубликат", MessageBoxButtons.YesNo) != DialogResult.Yes)
                        return;

            //bool success = false;
            //bool first = true;

            //while (!success)
            HtmlHelper.SaveVideoPicture(id);
            try
                {
                    //if (!first)
                    //    if (MessageBox.Show("Попробовать ещё раз?", "Повторная попытка", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    //        return;
                    //first = false;
                    SetOfficialInfo(HtmlHelper.GetVideoRecord(id));
                    //success = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось :(" + Environment.NewLine + ex.Message);
                    //new FormBrowser(ex.Message).ShowDialog();
                }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}