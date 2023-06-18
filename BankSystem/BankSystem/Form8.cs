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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string cusername , cpassword ;
            cusername = textBox1.Text;
            cpassword = textBox2.Text;

            string query = "select * from customer where cusername='" + textBox1.Text + "' AND cpassword='" + textBox2.Text +"'";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
           
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            if(dtable.Rows.Count > 0)
            {
                cusername = textBox1.Text;
                cpassword = textBox2.Text;
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("invalid sign in");
                textBox1.Clear();
                textBox2.Clear();
            }
            con.Close();
            
        }
    }
}
