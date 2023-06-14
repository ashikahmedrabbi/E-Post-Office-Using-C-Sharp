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
    public partial class contactus : Form
    {
        public contactus()
        {
            InitializeComponent();
        }

        private void textPprofilepage_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPaccountno_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPemailaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textPphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butPHome_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void butPContactus_Click(object sender, EventArgs e)
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

        private void butPContactus_Click_1(object sender, EventArgs e)
        {
            new contactus().Show();
            this.Hide();
        }

        private void butPLogout_Click(object sender, EventArgs e)
        {
            new logout().Show();
            this.Hide();
        }

        private void contactus_Load(object sender, EventArgs e)
        {

        }
    }
    }

