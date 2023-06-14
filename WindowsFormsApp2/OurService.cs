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
    public partial class OurService : Form
    {
        public OurService()
        {
            InitializeComponent();
        }

        private void butMProfile_Click(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Hide();
        }

        private void textMMoneypage_TextChanged(object sender, EventArgs e)
        {
            new MoneyTranesfer().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void butMHome_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
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

        private void butMMoneytra_Click(object sender, EventArgs e)
        {
            new MoneyTranesfer().Show();
            this.Hide();
        }
    }
}
