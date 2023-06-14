using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class admindsb : Form
    {
        public admindsb()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new logout().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new userReg().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new CUSTOMER().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AddMoney().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new SeavingMoney().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new loans().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new moneyTransferadmin().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new percel().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new INSIRANCE().Show();
            this.Hide();
        }
    }
    }

