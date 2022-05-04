using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Point location = panelSm.Location;
            panelSm.Location = panelInch.Location;
            panelInch.Location = location;
            if (numericUpDown6.Enabled)
            {
                numericUpDown6.Enabled = false;
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown6.Enabled = true;
                numericUpDown1.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Point location = panelCel.Location;
            panelCel.Location = panelFar.Location;
            panelFar.Location = location;
            if (numericUpDown5.Enabled)
            {
                numericUpDown5.Enabled = false;
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown5.Enabled = true;
                numericUpDown2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Point location = panelPound.Location;
            panelPound.Location = panelKil.Location;
            panelKil.Location = location;
            if (numericUpDown4.Enabled)
            {
                numericUpDown4.Enabled = false;
                numericUpDown3.Enabled = true;
            }
            else
            {
                numericUpDown4.Enabled = true;
                numericUpDown3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!numericUpDown1.Enabled)
            {
                numericUpDown1.Value = numericUpDown6.Value * 2.54m;
            }
            else
            {
                numericUpDown6.Value = numericUpDown1.Value / 2.54m;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!numericUpDown2.Enabled)
            {
                numericUpDown2.Value = (numericUpDown5.Value - 32) * (5m / 9m);
            }
            else
            {
                numericUpDown5.Value = (9m / 5m) * numericUpDown2.Value +32;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!numericUpDown3.Enabled)
            {
                numericUpDown3.Value = numericUpDown4.Value / 0.457m;
            }
            else
            {
                numericUpDown4.Value = numericUpDown3.Value * 0.457m; 
            }
        }
    }
}
