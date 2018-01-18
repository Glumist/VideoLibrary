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
using VideoLibrary.Properties;

namespace VideoLibrary
{
    public partial class FormTags : Form
    {
        private VideoTagCollection _tags;
        private string _extension;

        public FormTags()
        {
            InitializeComponent();

            VideoTagCollection.Refresh();
            _tags = VideoTagCollection.GetInstance();
            RefreshList();
        }

        private void RefreshList()
        {
            lvTags.BeginUpdate();
            ilTags.Images.Clear();
            lvTags.Clear();

            foreach (VideoTag tag in _tags.Tags)
            {
                if (tag.Image != null)
                    ilTags.Images.Add(tag.Id.ToString(), tag.Image);
                ListViewItem lvi = new ListViewItem(tag.Text, tag.Id.ToString());
                lvi.Tag = tag;
                lvi.Checked = tag.ShowInStat;
                lvTags.Items.Add(lvi);
            }
            lvTags.EndUpdate();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lvTags.SelectedItems.Count == 0)
                _tags.Add(tbText.Text, pbImage.Image, _extension);
            else
            {
                VideoTag tag = lvTags.SelectedItems[0].Tag as VideoTag;
                tag.Text = tbText.Text;
                tag.Image = pbImage.Image;
                tag.Extension = _extension;
            }

            RefreshList();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() != DialogResult.OK)
                return;

            if (!File.Exists(ofdImage.FileName))
                return;

            try
            {
                pbImage.Image = FileHelper.GetTagImage(ofdImage.FileName);
                _extension = Path.GetExtension(ofdImage.FileName);
            }
            catch
            { }
        }

        private void lvTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTags.SelectedItems.Count == 0)
            {
                pbImage.Image = null;
                tbText.Text = "";
                btAdd.Image = Resources.add_icon;
            }
            else
            {
                btAdd.Image = Resources.IconEdit;
                VideoTag tag = lvTags.SelectedItems[0].Tag as VideoTag;
                pbImage.Image = tag.Image;
                _extension = tag.Extension;
                tbText.Text = tag.Text;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            _tags.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lvTags_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            (e.Item.Tag as VideoTag).ShowInStat = e.Item.Checked;
        }
    }
}
