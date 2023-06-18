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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select * from customer";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select distinct type from loan";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select customer.cname , loan.lnumber , Employee.name from customer, loan,takes, employee where CUSTOMER.ssn = takes.ssn AND customer.CUSERNAME = takes.CUSERNAME AND takes.lnumber =loan.lnumber AND employee.eusername = loan.EUSERNAME";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select  distinct BRANCH.branch_no From BRANCH, loan where BRANCH.branch_no != loan.branch_no intersect select  distinct BRANCH.branch_no From BRANCH, account where BRANCH.branch_no != account.branch_no ";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "Select distinct BRANCH.branch_no  From BRANCH, EMPLOYEE except Select distinct BRANCH.branch_no From BRANCH, EMPLOYEE where BRANCH.branch_no = EMPLOYEE.branch_no";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select top 1 L.EUSERNAME,L.BRANCH_NO, count (L.LNUMBER) as NoOfLoans  from LOAN L group by L.EUSERNAME,L.BRANCH_NO order by NoOfLoans  desc";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT distinct TAKES.SSN,CUSTOMER.CNAME, count(takes.SSN) AS number_of_loans FROM TAKES join CUSTOMER on CUSTOMER.SSN = TAKES.SSN GROUP BY TAKES.SSN,CUSTOMER.CNAME";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT distinct CUSTOMER.SSN,CUSTOMER.CNAME FROM TAKES, CUSTOMER WHERE CUSTOMER.SSN<> TAKES.SSN";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N5JN1T1\SQLEXPRESS;Initial Catalog=Bank;Integrated Security=True");
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "SELECT CUSTOMER.SSN,CUSTOMER.CNAME,CUSTOMER.ADDRESS,CUSTOMER.CPASSWORD,CUSTOMER.CUSERNAME,CUSTOMER.PHONE,COUNT(EUSERNAME)AS NUM_OF_EMPLOYEE FROM DEALS_WITH join CUSTOMER on CUSTOMER.SSN = DEALS_WITH.SSN GROUP BY CUSTOMER.CNAME,CUSTOMER.SSN,CUSTOMER.ADDRESS,CUSTOMER.CPASSWORD,CUSTOMER.CUSERNAME,CUSTOMER.PHONE";
            var reader = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
