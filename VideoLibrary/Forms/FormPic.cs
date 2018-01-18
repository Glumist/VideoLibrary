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
    public partial class FormPic : Form
    {
        public FormPic(Image pic)
        {
            InitializeComponent();
            pbMain.Image = pic;
            this.Height = pic.Height + 38;
            this.Width = pic.Width + 16;
        }

        private void pbMain_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
