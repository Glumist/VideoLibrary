using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class FormWant : Form
    {
        public string WantText;
        bool textChanged;

        public FormWant(string wantText)
        {
            InitializeComponent();

            tbWant.Text = wantText;

            tbWant.TextChanged += TbWant_TextChanged;
        }

        private void TbWant_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void btSaveWant_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void Save()
        {
            WantText = tbWant.Text;
            DialogResult = DialogResult.OK;
        }

        private void FormWant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textChanged)
                if (MessageBox.Show("Текст был изменен. Сохранить?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Save();
        }

        private void FormWant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
