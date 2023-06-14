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
    public partial class loans : Form
    {
        public loans()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");

        private void button9_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" && textAccountNumber.Text == "" && textPhone.Text == "" && textloanaAmount.Text == "")
            {

                MessageBox.Show("Name,AccountNumber and fields are empty ", "Add MoneyFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                con.Open();

                string register = "INSERT INTO loans (Name,AccountNumber,Phone,loanaAmount,Date,Year) VALUES ('" + textName.Text.ToString() + "','" + textAccountNumber.Text.ToString() + "','" + textPhone.Text.ToString() + "','" + textloanaAmount.Text.ToString() + "','" + textDate.Text.ToString() + "','" + textYear.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textName.Text = "";
                textAccountNumber.Text = "";
                textPhone.Text = "";
                textloanaAmount.Text = "";
                textDate.Text = "";
                textYear.Text = "";





                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textName.Text = "";
            textAccountNumber.Text = "";
            textPhone.Text = "";
            textloanaAmount.Text = "";
            textDate.Text = "";
            textYear.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
