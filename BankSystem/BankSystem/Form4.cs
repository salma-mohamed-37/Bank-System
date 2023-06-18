using Menu;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            string cusername, cpassword;
            cusername = textBox1.Text;
            cpassword = textBox2.Text;
            
            string query = "select * from employee where eusername='" + textBox1.Text + "' AND epassword='" + textBox2.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                
                cusername = textBox1.Text;
                cpassword = textBox2.Text;
                if (cusername.Contains("admin"))
                {
                    Form13 form13 = new Form13();
                    form13.Show();
                    this.Hide();
                }
                else
                {
                    Form11 form11 = new Form11();
                    form11.Show();
                    this.Hide();
                }

            }

            else
            {
                MessageBox.Show("invalid sign in");
                textBox1.Clear();
                textBox2.Clear();
            }
            con.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
