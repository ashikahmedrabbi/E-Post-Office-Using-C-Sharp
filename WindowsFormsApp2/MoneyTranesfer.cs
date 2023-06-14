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
    public partial class MoneyTranesfer : Form
    {
        public MoneyTranesfer()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoneyTranesfer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butMHome_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void butMProfile_Click(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Hide();
        }

        private void butMOurservice_Click(object sender, EventArgs e)
        {
            new OurService().Show();
            this.Hide();
        }

        private void butMContactus_Click(object sender, EventArgs e)
        {
            new contactus().Show();
            this.Hide();
        }

        private void butMLogout_Click(object sender, EventArgs e)
        {
            new logout().Show();
            this.Hide();
        }
    }
}
