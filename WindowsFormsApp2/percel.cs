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
    public partial class percel : Form
    {
        public percel()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");
        private void button9_Click(object sender, EventArgs e)
        {
            if (textFName.Text == "" && textFPhone.Text == "" && textFee.Text == "" && comStatus.Text == "" && comPercelType.Text == "" && texttoname.Text == "" && textToPhone.Text== "" && textAddress.Text == "")
            {

                MessageBox.Show("Name,AccountNumber and fields are empty ", "Add MoneyFailed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            else
            {
                con.Open();

                string register = "INSERT INTO Perceldb (FName,FPhone,Fee,Status,PercelType,toname,ToPhone,Address) VALUES ('" + textFName.Text.ToString() + "','" + textFPhone.Text.ToString() + "','" + textFee.Text.ToString() + "','" + comStatus.Text.ToString() + "','" + comPercelType.Text.ToString() + "','" + texttoname.Text.ToString() + "','" + textToPhone.Text.ToString() + "','" + textAddress.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textFName.Text = "";
                textFPhone.Text = "";
                textFee.Text = "";
                comStatus.Text= "";
                comPercelType.Text= "";
                texttoname.Text = "";
                textToPhone.Text = "";
                textAddress.Text = "";
                MessageBox.Show("Your Percel Information Save", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void percel_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textNameto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textloanaAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNamef_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comPercelType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
