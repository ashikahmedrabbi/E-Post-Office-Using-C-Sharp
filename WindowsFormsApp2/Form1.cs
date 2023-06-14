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
    public partial class frmRegister : System.Windows.Forms.Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked)
            {
                textPassword.PasswordChar ='\0';
                textComfirmPassword.PasswordChar = '\0';

            }
            else
            {
                textPassword.PasswordChar = ('•');
                textComfirmPassword.PasswordChar = '•';
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textName.Text == "" && textUsername.Text == "" && textEmailAddress.Text == "" && textPassword.Text == "")
            {
            
                MessageBox.Show("Name,Username,EmailAddress and Password fields are empty ","Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);


            }

            else if(textPassword.Text ==textComfirmPassword.Text)
            {
                con.Open();

                string register = "INSERT INTO Registration_table(Name,Username,EmailAddress,Password) VALUES ('" + textName.Text.ToString() + "','" + textUsername.Text.ToString() + "','" + textEmailAddress.Text.ToString() + "','" + textPassword.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textName.Text = "";
                textUsername.Text = "";
                textEmailAddress.Text = "";
                textPassword.Text = "";
                textComfirmPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created","Registration Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Password dose not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";
                textComfirmPassword.Text = "";
                textPassword.Focus();
            }

        }


        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textUsername.Text = "";
            textEmailAddress.Text = "";
            textPassword.Text = "";
            textComfirmPassword.Text = "";
            textName.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            new loginuser().Show();
            this.Hide();

        }
    }
}
