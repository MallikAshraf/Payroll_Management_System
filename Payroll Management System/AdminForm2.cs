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
    public partial class AdminForm2 : Form
    {
        SqlConnection scn = new SqlConnection(@"Data Source=MIKEPC;Initial Catalog=mike;Integrated Security=True");
        public AdminForm2()
        {
            InitializeComponent();
        }

        private void btn1up_Click(object sender, EventArgs e)
        {
            try
            {

                scn.Open();
                SqlCommand cmd = scn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Admin_upp(Name,ID,Email,Contact,Address,ZIP) values('" + txtl1.Text + "','" + txtl2.Text + "' , '" + txtl3.Text + "' ,  '" + txtl4.Text + "' , '" + txtl5.Text + "' , '" + txtl6.Text + "')";
                cmd.ExecuteNonQuery();
                scn.Close();
                MessageBox.Show("Insertion Successful");

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm1 a1 = new AdminForm1();
            a1.Show();
            this.Hide();
        }
    }
}
