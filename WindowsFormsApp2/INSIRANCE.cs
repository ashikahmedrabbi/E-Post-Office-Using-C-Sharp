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
    public partial class INSIRANCE : Form
    {
        public INSIRANCE()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");
        private void button9_Click(object sender, EventArgs e)
        {
            if (textName.Text == "" && textAccountNumber.Text == "" && textPhone.Text == "" && textAmount.Text == "")
            {

                MessageBox.Show("Name,AccountNumber and fields are empty ", "Add MoneyFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                con.Open();

                string register = "INSERT INTO INSIRANCE (Name,AccountNumber,Phone,Amount) VALUES ('" + textName.Text.ToString() + "','" + textAccountNumber.Text.ToString() + "','" + textPhone.Text.ToString() + "','" + textAmount.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textName.Text = "";
                textAccountNumber.Text = "";
                textPhone.Text = "";
                textAmount.Text = "";



                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }
    }
}
