using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class userReg : System.Windows.Forms.Form
    {
        public userReg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" && textUsername.Text == "" && textEmailAddress.Text == "" && textAccountNumber.Text == "" && textPhoneNumber.Text == "")
            {

                MessageBox.Show("Name,Username,EmailAddress and fields are empty ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                con.Open();

                string register = "INSERT INTO userreg (Name,Username,EmailAddress,AccountNumber,PhoneNumber) VALUES ('" + textName.Text.ToString() + "','" + textUsername.Text.ToString() + "','" + textEmailAddress.Text.ToString() + "','" + textAccountNumber.Text.ToString() + "','" + textPhoneNumber.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textName.Text = "";
                textUsername.Text = "";
                textEmailAddress.Text = "";
                textAccountNumber.Text = "";
                textPhoneNumber.Text = "";


                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textUsername.Text = "";
            textEmailAddress.Text = "";
            textAccountNumber.Text = "";
            textPhoneNumber.Text = "";


        }

        private void textAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }
    }
}
