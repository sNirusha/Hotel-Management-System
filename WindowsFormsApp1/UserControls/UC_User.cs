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

namespace WindowsFormsApp1.UserControls
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-7S7QJOB\SQLEXPRESS;Initial Catalog=Hotel_M;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into login_user values (@first_name,@last_name,@user_name,@password)", conn);
            cmd.Parameters.AddWithValue("@first_name", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@last_name", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@user_name", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@password", guna2TextBox4.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("User Created Sucssful");

        }
    }
}
