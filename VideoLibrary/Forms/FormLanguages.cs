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
    public partial class FormLanguages : Form
    {
        private LanguageCollection _languages;
        private string _extension;

        public FormLanguages()
        {
            InitializeComponent();

            LanguageCollection.Refresh();
            _languages = LanguageCollection.GetInstance();
            RefreshList();
        }

        private void RefreshList()
        {
            lvLanguages.BeginUpdate();
            ilLanguages.Images.Clear();
            lvLanguages.Clear();

            foreach (Language language in _languages.Languages)
            {
                if (language.Image != null)
                    ilLanguages.Images.Add(language.Id.ToString(), language.Image);
                ListViewItem lvi = new ListViewItem(language.Text, language.Id.ToString());
                lvi.Tag = language;
                lvi.Checked = language.ShowInStat;
                lvLanguages.Items.Add(lvi);
            }
            lvLanguages.EndUpdate();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (lvLanguages.SelectedItems.Count == 0)
                _languages.Add(tbText.Text, pbImage.Image, _extension);
            else
            {
                Language language = lvLanguages.SelectedItems[0].Tag as Language;
                language.Text = tbText.Text;
                language.Image = pbImage.Image;
                language.Extension = _extension;
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

        private void lvLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLanguages.SelectedItems.Count == 0)
            {
                pbImage.Image = null;
                tbText.Text = "";
                btAdd.Image = Resources.add_icon;
            }
            else
            {
                btAdd.Image = Resources.IconEdit;
                Language language = lvLanguages.SelectedItems[0].Tag as Language;
                pbImage.Image = language.Image;
                _extension = language.Extension;
                tbText.Text = language.Text;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            _languages.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lvLanguages_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            (e.Item.Tag as Language).ShowInStat = e.Item.Checked;
        }
    }
}