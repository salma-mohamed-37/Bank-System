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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "insert into CUSTOMER values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "') ";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Added succuessfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "update customer set cname ='" + textBox2.Text + "', phone = '" + textBox3.Text + "', address = '" + textBox4.Text + "', cpassword = '" + textBox6.Text + "' where ssn ='" + textBox1.Text + "'AND cusername ='" + textBox5.Text + "'";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("updated succuessfully");
        }
    }
}
