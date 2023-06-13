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
    public partial class MainForm : Form
    {
        CorvetteConfiguration myConfiguration = new CorvetteConfiguration();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Color LongBeachRedMetalic = System.Drawing.Color.FromArgb(157, 38, 50);
            label11.BackColor = LongBeachRedMetalic;
            label12.BackColor = LongBeachRedMetalic;
            rad1LT.Focus();
            UpdateGUI();
        }

        private void ButTopUp_Click(object sender, EventArgs e)
        {
            myConfiguration.ConvertibleMode = "TopUp";
            UpdateGUI();
        }

        private void ButTopDown_Click(object sender, EventArgs e)
        {
            myConfiguration.ConvertibleMode = "TopDown";
            UpdateGUI();
        }

        private void ChkLiftKit_CheckedChanged(object sender, EventArgs e)
        {
            if(chkLiftKit.Checked == true)
            {
                myConfiguration.Liftkit = true;
            }
            else
            {
                myConfiguration.Liftkit = false;
            }
            UpdateGUI();
        }

        private void ChkDoorPlates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoorPlates.Checked == true)
            {
                myConfiguration.SillPlates = true;
            }
            else
            {
                myConfiguration.SillPlates = false;
            }
            UpdateGUI();
        }

        private void ChkFloorMats_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFloorMats.Checked == true)
            {
                myConfiguration.FloorMats = true;
            }
            else
            {
                myConfiguration.FloorMats = false;
            }
            UpdateGUI();
        }

        private void LblTrimDetails_Click(object sender, EventArgs e)
        {
            TrimLevelForm TLF = new TrimLevelForm(this);
            TLF.StartPosition = FormStartPosition.CenterScreen;
            TLF.Show(this);
        }
        
        private void TrimLevelChanged(object sender, EventArgs e)
        {
            if (rad1LT.Checked == true)
            {
                myConfiguration.TrimLevel = "1LT";
                myConfiguration.Liftkit = false;
                chkLiftKit.Checked = false;
                chkLiftKit.Enabled = false;
            }
            else
            {
                myConfiguration.TrimLevel = "2LT";
                chkLiftKit.Enabled = true;
            }
            UpdateGUI();
        }
        
        private void ColorChanged(object sender, EventArgs e)
        {
            if (radColorWhite.Checked == true)
            {
                myConfiguration.Color = "White";
            }
            else
            {
                myConfiguration.Color = "Red";
            }
            UpdateGUI();
        }

        private void WingChanged(object sender, EventArgs e)
        {
            if (radHighWing.Checked == true)
            {
                myConfiguration.HighWing = true;
            }
            else
            {
                myConfiguration.HighWing = false;
            }
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            pictureBox1.ImageLocation = myConfiguration.getPictureURL();
            lblBasePrice.Text = myConfiguration.getBasePrice().ToString("C0");
            lblOptionsPrice.Text = myConfiguration.getOptionsPrice().ToString("N0");
            lblTotalPrice.Text = myConfiguration.getTotalPrice().ToString("C0");
        }

    }
}
