using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class loginuser : System.Windows.Forms .Form
    {
        public loginuser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");

        private void label6_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string login = "SELECT * FROM  Registration_table WHERE username='" + textUsername.Text + "' and password='" + textpassword.Text + "' ";
            SqlCommand cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new Dashboard().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invaild Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsername.Text = "";
                textpassword.Text = "";
                textUsername.Focus();
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
