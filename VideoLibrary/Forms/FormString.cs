using System;
using System.Windows.Forms;

namespace VideoLibrary
{
    public partial class FormString : Form
    {
        public string EditedText;

        public FormString(string caption)
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedText = tbText.Text;

            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}