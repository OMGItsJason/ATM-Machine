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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int count = 0;
        int ACCB = 10000;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count < 6) 
            {
                SPB.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
        }

        private void AmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void WithdrwalBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AmountTB.Text, out int withdraw))
            {
                if (withdraw > ACCB)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else if (withdraw == ACCB)
                {
                    MessageBox.Show("You Can Not Withdraw All Your Remaining Balance");
                }
                else
                {
                    ACCB -= withdraw;
                    MessageBox.Show("Your Remaining Balance Is: " + ACCB.ToString("N0"));
                }
            }            
        }

        private void DepBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AmountTB.Text, out int deposite))
            {
                ACCB += deposite;
                MessageBox.Show("Your Updated Balance Is: " + ACCB);
            }
            else
            {
                AmountTB.Text = null;
                MessageBox.Show("Please Enter The Amount To Deposite");
            }
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AmountTB.Text, out int trans))
            {
                if (trans > ACCB)
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    ACCB -= trans;
                    MessageBox.Show("Your Remaining Balance Is: " + ACCB);
                }
            }

        }

        private void BalInqBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Current Balance Is: " + ACCB);
        }
    }
}
