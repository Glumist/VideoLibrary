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
    public partial class FormDates : Form
    {
        public DateTime? DateStart = null;
        public DateTime? DateEnd = null;
        public Existence Existence;

        public FormDates(DateTime? dateStart, DateTime? dateEnd, bool showRadio)
        {
            InitializeComponent();
            
            dtpDateStart.Checked = dateStart.HasValue;
            dtpDateStart.Value = dateStart.HasValue ? dateStart.Value : DateTime.Today;
            dtpDateEnd.Checked = dateEnd.HasValue;
            dtpDateEnd.Value = dateEnd.HasValue ? dateEnd.Value : DateTime.Today;

            if (!showRadio)
            {
                rbHave.Visible = false;
                rbWillHave.Visible = false;
                Height = 150;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (dtpDateStart.Checked)
                DateStart = dtpDateStart.Value.Date;
            else
                DateStart = null;
            if (dtpDateEnd.Checked)
                DateEnd = dtpDateEnd.Value.Date;
            else
                DateEnd = null;

            Existence = rbHave.Checked ? Existence.Have : Existence.WillHave;

            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}