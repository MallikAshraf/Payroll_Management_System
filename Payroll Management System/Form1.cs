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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MIKEPC;Initial Catalog=mike;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
               
            
           
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@" select count(*)  from Admin where Name = '" + textBox1.Text + "' and Pass = '" + textBox2.Text + "' ", con);
                SqlCommand cms = new SqlCommand(@" select count(*)  from Account where Name = '" + textBox1.Text + "' and Pass = '" + textBox2.Text + "' ", con);
                int count = (int)cmd.ExecuteScalar();
                int cmm = (int)cms.ExecuteScalar();
                //SqlDataAdapter sda = new SqlDataAdapter(" select count(*)  from Admin where Name = '" + textBox1.Text + "' and Pass = '" + textBox2.Text + "' ",con);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);
                if (count == 1)
                {
                    AdminForm1 adm = new AdminForm1();
                    adm.Show();
                    this.Hide();

                }

                else if(cmm == 1)
                {
                    testing tt = new testing();
                    tt.Show();
                    this.Hide();

                }


                errorProvider1.Clear();

                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(this.textBox1, "Enter Username");
                }
                if (textBox2.Text == "")
                {
                    errorProvider1.SetError(this.textBox2, "Enter Password");
                }
                if (count != 1)
                {
                    errorProvider1.SetError(this.button1, "Enter Correct User Pass");
                }
                con.Close();

            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

           



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
