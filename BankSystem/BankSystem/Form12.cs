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

namespace BankSystem
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "UPDATE LOAN SET  STATUS ='ACCEPTED' WHERE LNUMBER = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("ACCEPTED");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "UPDATE LOAN SET  STATUS ='REJECTED' WHERE LNUMBER = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("REJECTED");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "delete from taken where lnumber = '" + textBox1.Text + "'; delete from loan where lnumber = '" + textBox1.Text + "';";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("paid");
        }
    }
}
