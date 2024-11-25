using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BinarizeFormApplication
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void base_conversion_btn_Click(object sender, EventArgs e)
        {
            BaseConversion bc = new BaseConversion();
            bc.Show();
        }

        private void fix_rep_btn_Click(object sender, EventArgs e)
        {
            FixDecimal fd = new FixDecimal();
            fd.Show();
        }

        private void flot_rep_btn_Click(object sender, EventArgs e)
        {
            FloatDecimal fd = new FloatDecimal();
            fd.Show();
        }

        private void norm_rep_btn_Click(object sender, EventArgs e)
        {

        }

    }
}
