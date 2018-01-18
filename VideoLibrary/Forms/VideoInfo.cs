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

namespace VideoLibrary
{
    public partial class VideoInfo : UserControl
    {
        VideoRecord _record;

        public VideoInfo()
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
                Image image = FileHelper.GetImage(_record.Id, 300);
                if (image != null)
                {
                    pbImage.Image = image;
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
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            Image image = FileHelper.GetImage(_record.Id);
            if (image != null)
                new FormPic(image).ShowDialog();
        }
    }
}
