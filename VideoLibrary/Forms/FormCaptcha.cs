﻿using System;
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
    public partial class FormCaptcha : Form
    {
        public string EnteredText;

        public FormCaptcha(string imageAddress)
        {
            InitializeComponent();

            pbCaptcha.Load(imageAddress);
            Width = pbCaptcha.Image.Width + 20;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EnteredText = tbCaptcha.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void tbCaptcha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btOk_Click(sender, e);
        }
    }
}
