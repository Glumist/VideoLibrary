using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VideoLibrary
{
    public partial class ucRecordView : UserControl
    {
        VideoRecord _record;

        public ucRecordView()
        {
            InitializeComponent();
        }

        public void SetVideoRecord(VideoRecord record)
        {
            _record = record;

            tbName.Text = record.Name;
            tbSynopsis.Text = record.Synopsis;
            tbComment.Text = record.Comment;

            try
            {
                Image image = FileHelper.GetImage(_record.Id, 500);
                if (image != null)
                {
                    pbImage.Image = PicHelper.MakeComplexRecordImage(image, _record, 100);
                    scMain.Panel1Collapsed = false;
                    scMain.SplitterDistance = pbImage.Image.Height;
                }
                else
                    scMain.Panel1Collapsed = true;
            }
            catch
            {
                scMain.Panel1Collapsed = true;
            }

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
        }

        public void UpdateTags()
        {
            VideoTagCollection tags = VideoTagCollection.GetInstance();

            tsddbTags.DropDownItems.Clear();
            foreach (VideoTag tag in tags.Tags)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(tag.Text, tag.Image);
                tsmi.Tag = tag;
                tsmi.Click += TsmiChangeTag_Click;
                tsddbTags.DropDownItems.Add(tsmi);
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            Image image = FileHelper.GetImage(_record.Id);
            if (image != null)
                new FormPic(image).ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            OnVideoRecordEditClicked(_record);
        }

        private void TsmiChangeTag_Click(object sender, EventArgs e)
        {
            VideoTag tag = ((ToolStripMenuItem)sender).Tag as VideoTag;
            if (_record.Tags.Exists(t => t.Id == tag.Id))
                _record.Tags.RemoveAll(t => t.Id == tag.Id);
            else
                _record.Tags.Add(tag);

            OnVideoRecordSaved(_record);
        }

        private void btUserScore_Click(object sender, EventArgs e)
        {
            if (sender == tsmiUserScore0)
                _record.UserScore = 0;
            else if (sender == tsmiUserScore1)
                _record.UserScore = 1;
            else if (sender == tsmiUserScore2)
                _record.UserScore = 2;
            else if (sender == tsmiUserScore3)
                _record.UserScore = 3;
            else if (sender == tsmiUserScore4)
                _record.UserScore = 4;
            else if (sender == tsmiUserScore5)
                _record.UserScore = 5;

            OnVideoRecordSaved(_record);
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            _record.Existence = Existence.Had;
            OnVideoRecordSaved(_record);
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            if (_record.CanPlay)
                Process.Start(_record.Path);
        }

        private void tsbBrowse_Click(object sender, EventArgs e)
        {
            if (_record.CanPlay)
                Process.Start("explorer.exe", "/select, \"" + _record.Path + "\"");
            else if (_record.CanBrowse)
                Process.Start(_record.DirectoryPath);
        }

        private void tsbOpenInBrowser_Click(object sender, EventArgs e)
        {
            string url = _record.Url;
            if (url == "")
                url = "http://www.kinopoisk.ru/film/" + _record.Id;
            Process.Start(url);
        }

        public event EventHandler<VideoRecord> VideoRecordSaved;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnVideoRecordSaved(VideoRecord record)
        {
            if (VideoRecordSaved != null)
                VideoRecordSaved(this, record);
        }

        public event EventHandler<VideoRecord> VideoRecordEditClicked;
        [MethodImpl(MethodImplOptions.Synchronized)]
        protected virtual void OnVideoRecordEditClicked(VideoRecord record)
        {
            if (VideoRecordEditClicked != null)
                VideoRecordEditClicked(this, record);
        }
    }
}