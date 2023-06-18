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

namespace RequestLoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = @"INSERT INTO LOAN (LNUMBER,TYPE,AMOUNT,BRANCH_NO,EMP_BRANCH_NO,EUSERNAME) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox4.Text + "','" + textBox5.Text + "');INSERT INTO TAKES (LNUMBER,CUSERNAME,SSN) VALUES ('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            MessageBox.Show("requested successfully");
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}