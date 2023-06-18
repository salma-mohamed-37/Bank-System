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

namespace Menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True ");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "insert into BRANCH values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "') ";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Added succuessfully");
        }
    }
}
