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
    public partial class moneyTransferadmin : Form
    {
        public moneyTransferadmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");
        private void button9_Click(object sender, EventArgs e)
        {
            if (textFName.Text == "" && textFPhone.Text == "" && textAccountNumber.Text == "" && textsentMoney.Text == "" && texttoname.Text == "" && textToPhone.Text == "" && texttoAccountNumber.Text == "" && textreMoney.Text == "") 
            {

                MessageBox.Show("Name,AccountNumber and fields are empty ", "Add MoneyFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                con.Open();

                string register = "INSERT INTO MoneyTransfera (FName,FPhone,AccountNumber,sentMoney,toname,ToPhone,toAccountNumber,reMoney) VALUES ('" + textFName.Text.ToString() + "','" + textFPhone.Text.ToString() + "','" + textAccountNumber.Text.ToString() + "','" + textsentMoney.Text.ToString() + "''" + texttoname.Text.ToString() + "','" + textToPhone.Text.ToString() + "','" + texttoAccountNumber.Text.ToString() + "','" + textreMoney.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textFName.Text = "";
                textFPhone.Text = "";
                textAccountNumber.Text = "";
                textsentMoney.Text = "";
                texttoname.Text = "";
                textToPhone.Text = "";
                texttoAccountNumber.Text = "";
                textreMoney.Text = "";

                MessageBox.Show("Your Information Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
