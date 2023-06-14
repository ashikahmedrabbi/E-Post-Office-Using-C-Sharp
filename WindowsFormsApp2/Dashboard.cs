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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void butProfile_Click(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Hide();
        }

        private void butMoneytra_Click(object sender, EventArgs e)
        {
            new MoneyTranesfer().Show();
            this.Hide();
        }

        private void butOurservice_Click(object sender, EventArgs e)
        {
            new OurService().Show();
            this.Hide();
        }

        private void butContactus_Click(object sender, EventArgs e)
        {
            new contactus().Show();
            this.Hide();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            new logout().Show();
            this.Hide();
        }
    }
}
