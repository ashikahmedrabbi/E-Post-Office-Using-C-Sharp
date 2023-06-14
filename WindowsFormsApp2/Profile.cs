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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void butPHome_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butPProfile_Click(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Hide();
        }

        private void butPMoneytra_Click(object sender, EventArgs e)
        {
            new MoneyTranesfer().Show();
            this.Hide();
        }

        private void butPOurservice_Click(object sender, EventArgs e)
        {
            new OurService().Show();
            this.Hide();
        }

        private void butPContactus_Click(object sender, EventArgs e)
        {
            new contactus().Show();
            this.Hide();
        }

        private void butPLogout_Click(object sender, EventArgs e)
        {
            new logout().Show();
            this.Hide();
        }
    }
}
