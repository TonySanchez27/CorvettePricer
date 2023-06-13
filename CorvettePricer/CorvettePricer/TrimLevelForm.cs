using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorvettePricer
{
    public partial class TrimLevelForm : Form
    {
        MainForm MainFormRef = new MainForm();

        public TrimLevelForm(MainForm MF)
        {
            InitializeComponent();
            MainFormRef = MF;
        }

        private void TrimLevelForm_Load(object sender, EventArgs e)
        {
            if (MainFormRef.rad1LT.Checked == true)
            {
                this.rad1LT.Checked = true;
            }
            else
            {
                this.rad2LT.Checked = true;
            }
        }

        private void Rad1LT_CheckedChanged(object sender, EventArgs e)
        {
            updateparentform();
        }

        private void Rad2LT_CheckedChanged(object sender, EventArgs e)
        {
            updateparentform();
        }

        private void updateparentform()
        {
            if (this.rad1LT.Checked == true)
            {
                MainFormRef.rad1LT.Checked = true;
            }
            else
            {
                MainFormRef.rad2LT.Checked = true;
            }
        }



    }
}
