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

namespace Employee_sign_update
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEE SET NAME='" + textBox2.Text + "', EMAIL ='" + textBox3.Text+ "', EPASSWORD ='" + textBox5.Text + "'WHERE BRANCH_NO = '" + textBox1.Text + "' AND EUSERNAME ='" + textBox4.Text + "'",con);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Updated succuessfully");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "insert into EMPLOYEE values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
            cmd.ExecuteNonQuery();
           
            con.Close();
            MessageBox.Show("Added succuessfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
