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
    
    public partial class Form3 : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=MIKEPC;Initial Catalog=mike;Integrated Security=True");
        public Form3()
        {
          



            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

            cc();
            

        }

        public void cc()
        {


            comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID from Admin_upp";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["ID"].ToString());
            }

            con.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // comboBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Admin_upp where ID= '" + comboBox1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                string a = dr["Name"].ToString();
                string b = dr["Email"].ToString();
                textBox1.Text = a;
                textBox2.Text = b;
                //textBox2.Text = dr["id"].ToString();







            }

            con.Close();


        }

        private void btn1up_Click(object sender, EventArgs e)
        {
           
        }
    }
}
