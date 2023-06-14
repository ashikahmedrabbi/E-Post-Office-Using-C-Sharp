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
    public partial class CUSTOMER : Form
    {
        public CUSTOMER()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-4IDUNQN\\SQLEXPRESS;Initial Catalog=postoffice;Integrated Security=True");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textSEARCH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            String search = "SELECT*From userreg where AccountNumber Like CONCAT('%','" + textSEARCH.Text + "','%')";
            SqlCommand cmd = new SqlCommand(search, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            con.Open();
            String show = "SELECT*From userreg where AccountNumber ";
            SqlCommand cmd = new SqlCommand(show, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new admindsb().Show();
            this.Hide();
        }
    }
}
