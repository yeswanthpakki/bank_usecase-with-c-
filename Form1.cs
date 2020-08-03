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

namespace usecase_try4
{
    public partial class Form1 : Form
    {
        string fbal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TS7GU7Q;Initial Catalog=Bank_App;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT balance FROM    details_2 WHERE  balance= (SELECT MIN(balance)  FROM details_2); ", con);
            fbal = (string)cmd1.ExecuteScalar();
            int bal = int.Parse(fbal);
            bal = bal - int.Parse(textBox3.Text);
            string sql = "insert into details_2(acc_id,acc_name,amount,balance) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + bal + "')"; 
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Transferred Successfully....Avl bal: " + bal);
            }
            else
            {
                MessageBox.Show("Error");
            }
            cmd.Dispose();
            con.Close();
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
