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

namespace Payroll_Management_System
{
    public partial class testing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MIKEPC;Initial Catalog=mike;Integrated Security=True");
        public testing()
        {
            InitializeComponent();
        }

        private void testing_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from Admin_upp";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["id"].ToString());
            }

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin_upp where id= '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                string a = dr["Name"].ToString();
                string b = dr["Email"].ToString();

                string c = dr["Contact"].ToString();
                textBox2.Text = a;
                textBox1.Text = b;
                textBox3.Text = c;
                //textBox2.Text = dr["id"].ToString();
            }

            con.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double amount, ins, tax , total, hr;
            amount = Convert.ToDouble(textBox4.Text);
            
            ins = amount*.15;
            hr = amount * .25;

            if (amount > 100000)
            {
                tax = (amount/100)*5;
                //c = 5;
            }
            else
                tax = 0;
           // c = 0;

            total = amount + hr + ins - tax;

            textBox8.Text = total.ToString("c");


            textBox4.Text = amount.ToString("c");

            textBox5.Text = hr.ToString("25%");
            textBox6.Text = ins.ToString("15%");
            textBox7.Text = tax.ToString("c");

        }

        private void btn1up_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into accounts(name,contact,email,amount,house_rent,insurance,tax,net) values('" + textBox2.Text + "','" + textBox3.Text + "' , '" + textBox1.Text + "' ,  '" + textBox4.Text + "' , '" + textBox5.Text + "' , '" + textBox6.Text + "' , '" + textBox7.Text + "' , '" + textBox8.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Insertion Successful");

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
    }
}
