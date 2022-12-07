using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmmettButton_Click(object sender, EventArgs e)
        {
            MCAnswer2.Text = "Emmett is superior";
        }

        private void SalehButton_Click(object sender, EventArgs e)
        {
            MCAnswer2.Text = "Saleh is superior";
        }

        private void HussienButton_Click(object sender, EventArgs e)
        {
            MCAnswer2.Text = "Hussien is superior";
        }

        private void TypePls_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ReadOnly_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            ReadOnly.Text = TypePls.Text;
            TypePls.ReadOnly = true;
        }

        private void MCAnswer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Copy_Click(object sender, EventArgs e)
        {
            TypePls.ReadOnly = false;
            ReadOnly.Text = " ";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to exit the Unit Conversion Utility ? ", "Confirm", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); 
            }
        }
    }
}
