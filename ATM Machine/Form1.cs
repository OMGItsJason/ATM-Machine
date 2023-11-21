using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {

        }

        private void EnterBtn_Click_1(object sender, EventArgs e)
        {
            if (AccNumTB.Text == "2822" & PINTB.Text == "123")
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check Your Account Number & PIN", "Invalid");
            }
        }


        private void AccNumTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PINTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AccNumTB.Clear();
            PINTB.Clear();
        }
    }
}
